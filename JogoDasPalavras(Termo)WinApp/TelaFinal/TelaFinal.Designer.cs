namespace JogoDasPalavras_Termo_WinApp
{
    partial class TelaFinal
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
            lblMensagemFinal = new Label();
            btnReiniciar = new Button();
            picBoxEmogiFinal = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBoxEmogiFinal).BeginInit();
            SuspendLayout();
            // 
            // lblMensagemFinal
            // 
            lblMensagemFinal.AutoSize = true;
            lblMensagemFinal.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensagemFinal.ForeColor = Color.WhiteSmoke;
            lblMensagemFinal.Location = new Point(43, 33);
            lblMensagemFinal.Name = "lblMensagemFinal";
            lblMensagemFinal.Size = new Size(299, 38);
            lblMensagemFinal.TabIndex = 0;
            lblMensagemFinal.Text = "MENSAGEMFINAL";
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.FromArgb(76, 67, 71);
            btnReiniciar.Font = new Font("Sitka Text", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            btnReiniciar.ForeColor = SystemColors.Menu;
            btnReiniciar.Location = new Point(107, 275);
            btnReiniciar.Margin = new Padding(4, 3, 4, 3);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(106, 61);
            btnReiniciar.TabIndex = 41;
            btnReiniciar.Text = "VOLTAR";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // picBoxEmogiFinal
            // 
            picBoxEmogiFinal.Image = Properties.Resources.loudly_crying_face_joypixels;
            picBoxEmogiFinal.Location = new Point(309, 178);
            picBoxEmogiFinal.Name = "picBoxEmogiFinal";
            picBoxEmogiFinal.Size = new Size(163, 158);
            picBoxEmogiFinal.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxEmogiFinal.TabIndex = 42;
            picBoxEmogiFinal.TabStop = false;
            // 
            // TelaFinal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(97, 84, 88);
            ClientSize = new Size(609, 376);
            Controls.Add(picBoxEmogiFinal);
            Controls.Add(btnReiniciar);
            Controls.Add(lblMensagemFinal);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "TelaFinal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaFinal";
            ((System.ComponentModel.ISupportInitialize)picBoxEmogiFinal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblMensagemFinal;
        private Button btnReiniciar;
        public PictureBox picBoxEmogiFinal;
    }
}