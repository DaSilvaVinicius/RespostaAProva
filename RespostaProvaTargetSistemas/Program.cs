using System;
using RespostaProvaTargetSistemas.Extensoes;
using RespostaProvaTargetSistemas.Modelos;
using RespostaProvaTargetSistemas.Questões;
using RespostaProvaTargetSistemas.Servicos;

namespace RespostaProvaTargetSistemas.Extensôes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Questao1.Resposta();

            Console.ReadKey();
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine();

            Questao2.Resposta();

            Console.ReadKey();
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine();

            Questao3.Resposta();

            Console.ReadKey();
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine();

            Questao4.Resposta();

            Console.ReadKey();
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine();

            Questao5.Resposta();

            Console.ReadKey();
        }
    }
}

