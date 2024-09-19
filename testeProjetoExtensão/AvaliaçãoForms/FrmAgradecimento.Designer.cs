namespace testeProjetoExtensão.AvaliaçãoForms
{
    partial class FrmAgradecimento
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
            label1 = new Label();
            pbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(206, 220);
            label1.Name = "label1";
            label1.Size = new Size(201, 25);
            label1.TabIndex = 0;
            label1.Text = "Obrigado pela avaliação";
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.unisagradoLogo;
            pbLogo.Location = new Point(169, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(269, 114);
            pbLogo.TabIndex = 6;
            pbLogo.TabStop = false;
            // 
            // FrmAgradecimento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 450);
            Controls.Add(pbLogo);
            Controls.Add(label1);
            Name = "FrmAgradecimento";
            Text = "FrmAgradecimento";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pbLogo;
    }
}