using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RespostaProvaTargetSistemas.Extensoes
{
    public class Inverter
    {
        public static string Frase(string frase)
        {
            string[] palavras = frase.Split();
            string[] palavrasInvertidas = new string[palavras.Length];
            string fraseInvertida = string.Empty;

            for (int i = 0; i < palavras.Length; i++)
            {
                palavrasInvertidas[i] = Inverter.Palavra(palavras[i]) + " ";  
            }                         

            for (int i = 0; i < palavras.Length; i++)
                fraseInvertida += palavrasInvertidas[palavras.Length - 1 - i];

                return fraseInvertida;
        }

        public static string Palavra(string palavra)
        {
            string[] letrasInvertidas = new string[palavra.Length];
            string palavraInvertida = string.Empty;

            for (int i = 0; i < palavra.Length; i++)
                letrasInvertidas[i] = palavra.Substring(palavra.Length -1 - i, 1);

            for (int i = 0; i < palavra.Length; i++)
                palavraInvertida += letrasInvertidas[i];

            return palavraInvertida;
        }
    }
}
