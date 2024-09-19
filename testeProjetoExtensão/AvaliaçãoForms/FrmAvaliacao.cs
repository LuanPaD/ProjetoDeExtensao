using Npgsql;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using testeProjetoExtensão.resources.classes;

namespace testeProjetoExtensão.AvaliaçãoForms
{
    public partial class FrmAvaliacao : Form
    {
        private int perguntaAtual = 0;
        private List<string> perguntas;
        private List<List<string>> opcoes;
        private string? respostaSelecionada;
        clsConexao conexao = new clsConexao();

        public FrmAvaliacao()
        {
            InitializeComponent();

            perguntas = getPerguntas();
            opcoes = getOpcoes();

            MostrarPergunta(perguntaAtual);
        }

        #region Funções
        private void MostrarPergunta(int index)
        {
            if (index < perguntas.Count)
            {
                lblPergunta.Text = perguntas[index];
                pnlOpcoes.Controls.Clear();

                int posY = 10;
                const int spacing = 10;

                foreach (var opcao in opcoes[index])
                {
                    var btnOpcao = new RoundedButton
                    {
                        Text = opcao,
                        Width = 300,
                        Height = 80,
                        Tag = opcao,
                        Location = new Point(10, posY),
                        BackColor = Color.LightCoral,
                        ForeColor = Color.Black,
                        FlatStyle = FlatStyle.Flat
                    };
                    btnOpcao.Click += BtnOpcao_Click;
                    pnlOpcoes.Controls.Add(btnOpcao);

                    posY += btnOpcao.Height + spacing;
                }
            }
            else
            {
                FrmAgradecimento agradecimento = new FrmAgradecimento();
                agradecimento.Show();

                this.Close();
            }
        }

        private List<string> getPerguntas()
        {
            return new List<string>
            {
                "Como você avalia o atendimento?",
                "Como você avalia o ambiente?"
            };
        }

        private List<List<string>> getOpcoes()
        {
            //if (!clsConexao.ConexaoAtiva()) {
                return new List<List<string>>
                {
                    new List<string> { "Ótimo", "Bom", "Ruim", "Péssimo" },
                    new List<string> { "Ótimo", "Bom", "Ruim", "Péssimo" }
                };
            //}

            var opcoes = new List<List<string>>();
            StringBuilder sql = new StringBuilder();
            sql.Clear()
               .Append("SELECT * ")
               .Append("FROM ")
               .Append("    tb_opcoes");


            NpgsqlCommand cmd = new NpgsqlCommand(sql.ToString(), clsConexao.Conexao);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var row = new List<string>();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row.Add(reader.GetString(i));
                }

                opcoes.Add(row);
            }

            cmd.Dispose();

            return opcoes;
        }
        #endregion

        #region Eventos
        private void BtnOpcao_Click(object sender, EventArgs e)
        {
            if (sender is RoundedButton btnSelecionado)
            {
                foreach (RoundedButton btn in pnlOpcoes.Controls.OfType<RoundedButton>())
                {
                    btn.BackColor = Color.LightCoral;
                }

                btnSelecionado.BackColor = Color.Tomato;
                respostaSelecionada = btnSelecionado.Tag?.ToString();
            }
        }

        private void btnAvancarPergunta_Click(object sender, EventArgs e)
        {
            if (respostaSelecionada == null)
            {
                MessageBox.Show("Por favor, selecione uma resposta antes de avançar.");
                return;
            }

            perguntaAtual++;
            MostrarPergunta(perguntaAtual);
            respostaSelecionada = null;
        }
    }
    #endregion

    #region Classe para o botao arredondado

    public class RoundedButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            var path = new GraphicsPath();
            const int radius = 20;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            Region = new Region(path);

            base.OnPaint(pevent);
        }
    }

    #endregion
}
