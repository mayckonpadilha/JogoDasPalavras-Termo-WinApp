using JogoDasPalavras_Termo_WinApp.ModuloJogoDasPalavras;
using JogoDasPalavras_Termo_WinApp.Properties;
using System.Globalization;

namespace JogoDasPalavras_Termo_WinApp
{
    public partial class TelaFormJogoDasPalavras : Form
    {
        JogoDasPalavras jogo;
        Panel painelAtual;



        public TelaFormJogoDasPalavras()
        {
            InitializeComponent();
            ConfigurarClickDosBotoes();
            jogo = new JogoDasPalavras();
        }





        private void ConfiguraOsBotoesDoPainelDepoisDeCadaRodada()
        {
            foreach (Button botao in tableLayoutPanel1.Controls)
            {
                VerificaSeOBotaoExisteNaPalavra(botao);
            }
        }




        private void VerificaSeOBotaoExisteNaPalavra(Button botao)
        {
            foreach (TextBox textBox in painelAtual.Controls)
            {
                if (textBox.Text == botao.Text)
                {
                    if (jogo.verificaSeAletraExiste(botao) == false)
                    {
                        botao.Enabled = false;
                        botao.BackColor = Color.DarkGray;
                    }
                }
            }
        }

        private void ConfigurarClickDosBotoes()
        {
            foreach (Button botao in tableLayoutPanel1.Controls)
            {
                botao.Click += AtribuirLetra;
            }
        }





        private void AtribuirLetra(object? sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            painelAtual = EscolhaPainelDoJogo();
            foreach (TextBox textBox in painelAtual.Controls)
            {
                if (textBox.Text == "")
                {
                    textBox.Text = botaoClicado.Text;
                    return;
                }

            }
        }


        private void btnChutar_Click(object sender, EventArgs e)
        {

            try
            {
                string novaPalavra = PegaNovaPalavra();
                MessageBox.Show(novaPalavra);
                RodaOJogo();
                ConfiguraOsBotoesDoPainelDepoisDeCadaRodada();
            }
            catch (FormatException)
            {
                MessageBox.Show("Letras Vazias...");
            }

        }




        private string PegaNovaPalavra()
        {
            string novaPalavra = new string(jogo.PopularLetrasEncontradas(EscolhaPainelDoJogo()).ToArray());
            return novaPalavra;
        }





        public Panel EscolhaPainelDoJogo()
        {
            if (jogo.Erros == 0)
            {
                return (Panel)pnlPrincipalDoJogo.Controls[0];
            }
            if (jogo.Erros == 1)
            {

                return (Panel)pnlPrincipalDoJogo.Controls[1];
            }
            if (jogo.Erros == 2)
            {
                return (Panel)pnlPrincipalDoJogo.Controls[2];
            }
            if (jogo.Erros == 3)
            {
                return (Panel)pnlPrincipalDoJogo.Controls[3];
            }
            if (jogo.Erros == 4)
            {
                return (Panel)pnlPrincipalDoJogo.Controls[4];
            }

            return null;
        }


        private void RodaOJogo()
        {
            if (jogo.JogadorAcertou() || jogo.JogadorPerdeu())
            {
                TelaFinal telaFinal = new();
                telaFinal.lblMensagemFinal.Text = jogo.mensagemFinal;
                if (jogo.JogadorAcertou())
                {
                    telaFinal.picBoxEmogiFinal.Image = Resources.diwali_sparkles_stars;
                }
                telaFinal.ShowDialog();
                Close();

            }
            PintaTodasAsCaixas();
        }




        private void PintaTodasAsCaixas()
        {
            int i = 0;
            foreach (TextBox textBox in painelAtual.Controls)
            {
                textBox.BackColor = jogo.corDaCaixa.ToArray()[i];
                i++;
            }
        }




        private void btnApagar_Click(object sender, EventArgs e)
        {
            jogo.ApagaRegistros(EscolhaPainelDoJogo());
        }




        private void btnChutar_MouseHover(object sender, EventArgs e)
        {
            MudaCoreDoBotao(btnChutar, Color.Black, Color.White);
        }




        private void btnChutar_MouseLeave(object sender, EventArgs e)
        {
            MudaCoreDoBotao(btnChutar, Color.White, Color.Black);
        }


        private void MudaCoreDoBotao(Button botao, Color corLetra, Color corFundo)
        {
            botao.BackColor = corFundo;
            botao.ForeColor = corLetra;
        }

    }
}