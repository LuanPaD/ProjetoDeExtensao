namespace testeProjetoExtensão
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            btnFechar = new Button();
            btnAvaliar = new Button();
            pbLogo = new PictureBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFechar.BackColor = Color.FromArgb(255, 128, 128);
            btnFechar.BackgroundImage = (Image)resources.GetObject("btnFechar.BackgroundImage");
            btnFechar.BackgroundImageLayout = ImageLayout.Stretch;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Location = new Point(900, 9);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(67, 59);
            btnFechar.TabIndex = 1;
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnAvaliar
            // 
            btnAvaliar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            btnAvaliar.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAvaliar.Location = new Point(659, 241);
            btnAvaliar.Name = "btnAvaliar";
            btnAvaliar.Size = new Size(270, 78);
            btnAvaliar.TabIndex = 1;
            btnAvaliar.Text = "Avaliar";
            btnAvaliar.UseVisualStyleBackColor = true;
            btnAvaliar.Click += btnAvaliar_Click;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.unisagradoLogo;
            pbLogo.Location = new Point(322, 9);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(269, 114);
            pbLogo.TabIndex = 2;
            pbLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.gra_abertura;
            pictureBox1.Location = new Point(0, 209);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(469, 457);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            button1.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(659, 334);
            button1.Name = "button1";
            button1.Size = new Size(270, 78);
            button1.TabIndex = 4;
            button1.Text = "Cadastrar Pergunta";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            button2.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(659, 431);
            button2.Name = "button2";
            button2.Size = new Size(270, 78);
            button2.TabIndex = 5;
            button2.Text = "Relatorio";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            button3.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(659, 528);
            button3.Name = "button3";
            button3.Size = new Size(270, 78);
            button3.TabIndex = 6;
            button3.Text = "Gráficos";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 186);
            label1.Name = "label1";
            label1.Size = new Size(179, 20);
            label1.TabIndex = 7;
            label1.Text = "AVALIAÇÕES SECRETÁRIA";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(979, 664);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(pbLogo);
            Controls.Add(btnFechar);
            Controls.Add(btnAvaliar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += FrmMain_FormClosing;
            FormClosed += FrmMain_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnFechar;
        private Button btnAvaliar;
        private PictureBox pbLogo;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
    }
}
