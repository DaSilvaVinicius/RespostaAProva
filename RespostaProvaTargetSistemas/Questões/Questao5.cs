using RespostaProvaTargetSistemas.Extensoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RespostaProvaTargetSistemas.Questões
{
    public static class Questao5
    {
        /*5) Escreva um programa que inverta os caracteres de um string.


        IMPORTANTE:

        a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;

        b) Evite usar funções prontas, como, por exemplo, reverse;*/

        public static void Resposta()
        {
            Console.WriteLine("Questâo 5:");

            Console.WriteLine();
            Console.WriteLine("Que frase você gostaria de inverter a ordem dos seus caracteres?");
            string frase = Console.ReadLine();

            string fraseInvertida = Inverter.Frase(frase);

            Console.WriteLine("Sua frase invertida está pronta:");
            Console.WriteLine(fraseInvertida);
        }
    }
}
