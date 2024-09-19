namespace testeProjetoExtensão.AvaliaçãoForms
{
    partial class FrmAvaliacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblContador = new Label();
            lblPergunta = new Label();
            pbLogo = new PictureBox();
            btnAvancarPergunta = new Button();
            label2 = new Label();
            pnlOpcoes = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // lblContador
            // 
            lblContador.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContador.Location = new Point(293, 129);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(218, 50);
            lblContador.TabIndex = 3;
            lblContador.Text = "Pergunta n/n";
            // 
            // lblPergunta
            // 
            lblPergunta.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPergunta.Location = new Point(50, 179);
            lblPergunta.Name = "lblPergunta";
            lblPergunta.Size = new Size(780, 50);
            lblPergunta.TabIndex = 4;
            lblPergunta.Text = "BLABLABLABLABLABLA";
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.unisagradoLogo;
            pbLogo.Location = new Point(267, -2);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(269, 114);
            pbLogo.TabIndex = 5;
            pbLogo.TabStop = false;
            // 
            // btnAvancarPergunta
            // 
            btnAvancarPergunta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAvancarPergunta.Location = new Point(240, 653);
            btnAvancarPergunta.Name = "btnAvancarPergunta";
            btnAvancarPergunta.Size = new Size(325, 74);
            btnAvancarPergunta.TabIndex = 8;
            btnAvancarPergunta.Text = "Próxima Pegunta";
            btnAvancarPergunta.UseVisualStyleBackColor = true;
            btnAvancarPergunta.Click += btnAvancarPergunta_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(21, 39);
            label2.Name = "label2";
            label2.Size = new Size(150, 50);
            label2.TabIndex = 10;
            label2.Text = "Voltar";
            // 
            // pnlOpcoes
            // 
            pnlOpcoes.Location = new Point(168, 257);
            pnlOpcoes.Name = "pnlOpcoes";
            pnlOpcoes.Size = new Size(592, 390);
            pnlOpcoes.TabIndex = 11;
            // 
            // FrmAvaliacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 723);
            Controls.Add(pnlOpcoes);
            Controls.Add(label2);
            Controls.Add(btnAvancarPergunta);
            Controls.Add(pbLogo);
            Controls.Add(lblPergunta);
            Controls.Add(lblContador);
            Name = "FrmAvaliacao";
            Text = "FrmAvaliacao";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblContador;
        private Label lblPergunta;
        private PictureBox pbLogo;
        private Button btnAvancarPergunta;
        private Label label2;
        private Panel pnlOpcoes;
    }
}