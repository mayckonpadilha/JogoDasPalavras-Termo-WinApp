namespace JogoDasPalavras_Termo_WinApp
{
    partial class TelaInicial
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
            lblTituloPrincipal = new Label();
            btnComecar = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // lblTituloPrincipal
            // 
            lblTituloPrincipal.AutoSize = true;
            lblTituloPrincipal.BorderStyle = BorderStyle.Fixed3D;
            lblTituloPrincipal.Font = new Font("Verdana", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloPrincipal.ForeColor = Color.WhiteSmoke;
            lblTituloPrincipal.Location = new Point(190, 29);
            lblTituloPrincipal.Name = "lblTituloPrincipal";
            lblTituloPrincipal.Size = new Size(288, 80);
            lblTituloPrincipal.TabIndex = 0;
            lblTituloPrincipal.Text = "TERMO!";
            // 
            // btnComecar
            // 
            btnComecar.BackColor = Color.FromArgb(76, 67, 71);
            btnComecar.Font = new Font("Sitka Text", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            btnComecar.ForeColor = SystemColors.Menu;
            btnComecar.Location = new Point(283, 158);
            btnComecar.Margin = new Padding(4, 3, 4, 3);
            btnComecar.Name = "btnComecar";
            btnComecar.Size = new Size(106, 61);
            btnComecar.TabIndex = 42;
            btnComecar.Text = "INICIAR";
            btnComecar.UseVisualStyleBackColor = false;
            btnComecar.Click += btnComecar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(76, 67, 71);
            btnSair.Font = new Font("Sitka Text", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.ForeColor = SystemColors.Menu;
            btnSair.Location = new Point(283, 248);
            btnSair.Margin = new Padding(4, 3, 4, 3);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(106, 61);
            btnSair.TabIndex = 43;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(97, 84, 88);
            ClientSize = new Size(711, 386);
            Controls.Add(btnSair);
            Controls.Add(btnComecar);
            Controls.Add(lblTituloPrincipal);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "TelaInicial";
            Text = "TelaInicial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloPrincipal;
        private Button btnComecar;
        private Button btnSair;
    }
}