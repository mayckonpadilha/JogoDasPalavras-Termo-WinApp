using JogoDasPalavras_Termo_WinApp.ModuloJogoDasPalavras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace JogoDasPalavras_Termo_WinApp
{
    public partial class TelaFinal : Form
    {
        public TelaFinal()
        {
            InitializeComponent();
        }


        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
