using RespostaProvaTargetSistemas.Extensoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RespostaProvaTargetSistemas.Questões
{
    public static class Questao2
    {
        /*2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores 
        (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, 
        ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.


        IMPORTANTE:
        Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;*/

        public static void Resposta()
        {
            Console.WriteLine("Questâo 2:");

            Console.WriteLine();
            Console.Write("Entre com um valor = ");
            int valor = int.Parse(Console.ReadLine());

            var fibonacci = new Fibonacci();
            Console.WriteLine(fibonacci.PertenceASequencia(valor));
        }
    }
}
