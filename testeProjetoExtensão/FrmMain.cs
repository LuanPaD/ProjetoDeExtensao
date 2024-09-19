using testeProjetoExtensão.AvaliaçãoForms;
using testeProjetoExtensão.resources.classes;

namespace testeProjetoExtensão
{
    public partial class FrmMain : Form
    {
        private clsConexao conexao = new clsConexao();
        public FrmMain()
        {
            InitializeComponent();

            abreConexao();

        }

        #region Funções

        private async void abreConexao()
        {
            await conexao.getConexao();

            if (!clsConexao.ConexaoAtiva())
            {
                MessageBox.Show("Não há conexão com o banco de dados.", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Conectado com o banco de dados.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion  


        #region Eventos
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            await conexao.closeConnection();
        }

        private async void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            await conexao.closeConnection();
        }
        

        private void btnAvaliar_Click(object sender, EventArgs e)
        {
            FrmAvaliacao avaliacoes = new FrmAvaliacao();
            avaliacoes.Show();
        }

        #endregion
    }
}
