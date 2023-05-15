using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDasPalavras_Termo_WinApp.ModuloJogoDasPalavras
{
    internal class JogoDasPalavras
    {
        public string PalavraParcial
        {
            get { return new string(letras.ToArray());}
        }

        public int Erros
        {
            get { return erros; }
        }

        public string mensagemFinal;
        public List<Color> corDaCaixa;


        private string palavraSecreta;
        public List<char> letras;

        private int erros;

        public JogoDasPalavras()
        {
            mensagemFinal = "";
            palavraSecreta = ObterPalavraSecreta();
        }



        public bool verificaSeAletraExiste(Button botao)
        {
            foreach(var letra in palavraSecreta)
            {
                if (letra == Convert.ToChar(botao.Text.ToLower()))
                {
                    return true;
                }
            }                
            return false;

        }






        public bool JogadorAcertou()
        {
            bool acertou = false;
            char[] novasLetras = letras.ToArray();
            palavraSecreta = RemoverAcentos(palavraSecreta);
            char[] letrasDapalavraSecreta = palavraSecreta.ToArray();
            corDaCaixa = new();           

            if (palavraSecreta == PalavraParcial)
            {
                acertou = true;
            }
            

            for (int i = 0; i < novasLetras.Length; i++)           
            {

                if (palavraSecreta.Contains(novasLetras[i]) && letrasDapalavraSecreta[i] == novasLetras[i])
                {
                    corDaCaixa.Add(Color.LightGreen);
                }
                else if (palavraSecreta.Contains(novasLetras[i]) && letrasDapalavraSecreta[i] != novasLetras[i])
                {
                    corDaCaixa.Add(Color.LightGoldenrodYellow);
                }
                else
                {
                    corDaCaixa.Add(Color.DarkGray);
                }
            }

            if (acertou == false)
                erros++;

            if (acertou)
                mensagemFinal = $"Você acertou a palavra {palavraSecreta}\n     parabéns!";

            else if (JogadorPerdeu())
                mensagemFinal = $"Você perdeu! A Palavra era {palavraSecreta}\n     Tente novamente...";

            return acertou;
        }

        public bool JogadorPerdeu()
        {
            return erros == 5;
        }




        public void ApagaRegistros(Panel panel)
        {
            foreach (TextBox textBox in panel.Controls)
            {
                if (textBox.Text != "")
                {
                    textBox.Text = "";
                    return;
                }
            }
        }





        private string ObterPalavraSecreta()
        {
            string[] palavras = new string[]
            {
                "ácido", "adiar", "ímpar", "algar", "amado", "amigo", "anexo", "anuir", "aonde", "apelo",
                "aquém", "argil", "arroz", "assar", "atrás", "ávido", "azeri", "babar", "bagre", "banho",
                "barco", "bicho", "bolor", "brasa", "brava", "brisa", "bruto", "bulir", "caixa", "cansa",
                "chato", "chave", "chefe", "choro", "chulo", "claro", "cobre", "corte", "curar", "deixo",
                "dizer", "dogma", "dores", "duque", "enfim", "estou", "exame", "falar", "fardo", "farto",
                "fatal", "feliz", "ficar", "fogue", "força", "forno", "fraco", "fugir", "fundo", "fúria",
                "gaita", "gasto", "geada", "gelar", "gosto", "grito", "gueto", "honra", "humor", "idade",
                "ideia", "ídolo", "igual", "imune", "índio", "íngua", "irado", "isola", "janta", "jovem",
                "juizo", "largo", "laser", "leite", "lento", "lerdo", "levar", "lidar", "lindo", "lírio",
                "longe", "luzes", "magro", "maior", "malte", "mamar", "manto", "marca", "matar", "meigo",
                "meios", "melão", "mesmo", "metro", "mimos", "moeda", "moita", "molho", "morno", "morro",
                "motim", "muito", "mural", "naipe", "nasci", "natal", "naval", "ninar", "nível", "nobre",
                "noite", "norte", "nuvem", "oeste", "ombro", "ordem", "órgão", "ósseo", "ossos", "outro",
                "ouvir", "palma", "pardo", "passe", "pátio", "peito", "pêlos", "perdo", "períl", "perto",
                "pezar", "piano", "picar", "pilar", "pingo", "pione", "pista", "poder", "porém", "prado",
                "prato", "prazo", "preço", "prima", "primo", "pular", "quero", "quota", "raiva", "rampa",
                "rango", "reais", "reino", "rezar", "risco", "roçar", "rosto", "roubo", "russo", "saber",
                "sacar", "salto", "samba", "santo", "selar", "selos", "senso", "serão", "serra", "servo",
                "sexta", "sinal", "sobra", "sobre", "sócio", "sorte", "subir", "sujei", "sujos", "talão",
                "talha", "tanga", "tarde", "tempo", "tenho", "terço", "terra", "tesão", "tocar", "lacre",
                "laico", "lamba", "lambo", "largo", "larva", "lasca", "laser", "laura", "lavra", "leigo",
                "leite", "leito", "leiva", "lenho", "lento", "leque", "lerdo", "lesão", "lesma", "levar",
                "libra", "limbo", "lindo", "líneo", "lírio", "lisar", "lista", "livro", "logar", "lombo",
                "lotes", "louca", "louco", "louro", "lugar", "luzes", "macio", "maçom", "maior", "malha",
                "malte", "mamar", "mamãe", "manto", "março", "maria", "marra", "marta", "matar", "medir",
                "meigo", "meios", "melão", "menta", "menti", "mesmo", "metro", "miado", "mídia", "mielo",
                "mielo", "milho", "mimos", "minar", "minha", "miolo", "mirar", "missa", "mitos", "moeda",
                "moído", "moita", "molde", "molho", "monar", "monja", "moral", "morar", "morda", "morfo",
                "morte", "mosca", "mosco", "motim", "motor", "mudar", "muito", "mular", "mulas", "múmia",
                "mural", "extra", "falar", "falta", "fardo", "farol", "farto", "fatal", "feixe", "festa",
                "feudo", "fezes", "fiapo", "fibra", "ficha", "fidel", "filão", "filho", "firma", "fisco",
                "fisga", "fluir", "força", "forma", "forte", "fraco", "frade", "friso", "frito", "fugaz",
                "fugir", "fundo", "furor", "furto", "fuzil", "gabar", "gaita", "galho", "ganho", "garoa",
                "garra", "garro", "garvo", "gasto", "gaupe", "gazua", "geada", "gemer", "germe", "gigas",
                "girar", "gizar", "globo", "gosto", "grãos", "graça", "grava", "grito", "grude", "haver",
                "haver", "hiato", "hidra", "hífen", "hímel", "horas", "hotel", "humor", "ideal", "ídolo",
                "igual", "ileso", "imune", "irado", "isola", "jarra", "jaula", "jegue", "jeito", "jogar",
                "jovem", "juíza", "juizo", "julho", "junho", "jurar", "justa"
            };

            int indiceAleatorio = new Random().Next(palavras.Length);

            return palavras[indiceAleatorio];
        }

        public List<char> PopularLetrasEncontradas(Panel panel)
        {
            letras = new List<char>();

            foreach (TextBox textBox in panel.Controls)
            {                
              letras.Add(Convert.ToChar(textBox.Text.ToLower()));                                  
            }
            return letras;
        }
        private string RemoverAcentos(string texto)
        {
            string comAcentos = "äáâàãéêëèíîïìöóôòõüúûùç";
            string semAcentos = "aaaaaeeeeiiiiooooouuuuc";

            for (int i = 0; i < comAcentos.Length; i++)
            {
                texto = texto.Replace(comAcentos[i].ToString(), semAcentos[i].ToString());
            }
            return texto;
        }

    }
}
