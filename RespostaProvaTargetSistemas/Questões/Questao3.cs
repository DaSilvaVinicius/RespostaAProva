using RespostaProvaTargetSistemas.Extensoes;
using RespostaProvaTargetSistemas.Servicos;
using RespostaProvaTargetSistemas.Validação;
using static RespostaProvaTargetSistemas.Servicos.CalcularQuestao3;

namespace RespostaProvaTargetSistemas.Questões
{
    public static class Questao3
    {
        /*3) Descubra a lógica e complete o próximo elemento:


        a) 1, 3, 5, 7, ___

        b) 2, 4, 8, 16, 32, 64, ____

        c) 0, 1, 4, 9, 16, 25, 36, ____

        d) 4, 16, 36, 64, ____

        e) 1, 1, 2, 3, 5, 8, ____

        f) 2,10, 12, 16, 17, 18, 19, ____*/

        private static int[] _a = new int[]
        {
            1, 3, 5, 7
        };

        private static int[] _b = new int[]
        {
            2, 4, 8, 16, 32, 64,
        };

        private static int[] _c = new int[]
        {
            0, 1, 4, 9, 16, 25, 36,
        };

        private static int[] _d = new int[]
        {
            4, 16, 36, 64,
        };

        private static int[] _e = new int[]
        {
            1, 1, 2, 3, 5, 8,
        };

        private static int[] _f = new int[]
        {
            2,10, 12, 16, 17, 18, 19,
        };

        public static void Resposta()
        {
            Console.WriteLine("Questâo 3:");

            Console.WriteLine();
            Console.Write("a) ");
            Console.WriteLine(ItemAResposta());

            Console.WriteLine();
            Console.Write("b) ");
            Console.WriteLine(ItemBResposta());

            Console.WriteLine();
            Console.Write("c) ");
            Console.WriteLine(ItemCResposta());

            Console.WriteLine();
            Console.Write("d) ");
            Console.WriteLine(ItemDResposta());

            Console.WriteLine();
            Console.Write("e) ");
            Console.WriteLine(ItemEResposta());

            Console.WriteLine();
            Console.Write("f) ");
            Console.WriteLine(ItemFResposta());
        }

        private static string ItemAResposta()
        {
            int posicaoTeste1 = 0;
            int posicaoTeste2 = 2;

            LogicaDelegate logica = CalcularQuestao3.LogicaItemA;

            bool contaEstaCorreta1 = ValidarQuestao3.Conta(_a, posicaoTeste1, logica);
            bool contaEstaCorreta2 = ValidarQuestao3.Conta(_a, posicaoTeste2, logica);

            int resposta = CalcularQuestao3.ProximoNumero(_a, logica);

            return ValidarQuestao3.Item(contaEstaCorreta1, contaEstaCorreta2, resposta);
        }

        private static string ItemBResposta()
        {
            int posicaoTeste1 = 0;
            int posicaoTeste2 = 2;

            LogicaDelegate logica = CalcularQuestao3.LogicaItemB;

            bool contaEstaCorreta1 = ValidarQuestao3.Conta(_b, posicaoTeste1, logica);
            bool contaEstaCorreta2 = ValidarQuestao3.Conta(_b, posicaoTeste2, logica);

            int resposta = CalcularQuestao3.ProximoNumero(_b, logica);

            return ValidarQuestao3.Item(contaEstaCorreta1, contaEstaCorreta2, resposta);
        }

        private static string ItemCResposta()
        {
            int posicaoTeste1 = 1;
            int posicaoTeste2 = 4;

            LogicaDelegate logica = CalcularQuestao3.LogicaItemC;

            bool contaEstaCorreta1 = ValidarQuestao3.Conta(_c, posicaoTeste1, logica);
            bool contaEstaCorreta2 = ValidarQuestao3.Conta(_c, posicaoTeste2, logica);
            
            int resposta = CalcularQuestao3.ProximoNumero(_c, logica);

            return ValidarQuestao3.Item(contaEstaCorreta1, contaEstaCorreta2, resposta);
        }

        private static string ItemDResposta()
        {
            int posicaoTeste = 1;
            int posicaoTeste2 = 2;

            LogicaDelegate logica = CalcularQuestao3.LogicaItemD;

            bool contaEstaCorreta1 = ValidarQuestao3.Conta(_d, posicaoTeste, logica);
            bool contaEstaCorreta2 = ValidarQuestao3.Conta(_d, posicaoTeste2, logica);

            int resposta = CalcularQuestao3.ProximoNumero(_d, logica);

            return ValidarQuestao3.Item(contaEstaCorreta1, contaEstaCorreta2, resposta);
        }

        private static string ItemEResposta()
        {
            int posicaoTeste = 2;
            int posicaoTeste2 = 4;

            LogicaDelegate logica = CalcularQuestao3.LogicaItemE;
            
            bool contaEstaCorreta1 = ValidarQuestao3.Conta(_e, posicaoTeste, logica);
            bool contaEstaCorreta2 = ValidarQuestao3.Conta(_e, posicaoTeste2, logica);

            int resposta = CalcularQuestao3.ProximoNumero(_e, logica);

            return ValidarQuestao3.Item(contaEstaCorreta1, contaEstaCorreta2, resposta);
        }

        private static string ItemFResposta()
        {
            string[] numerosPorExtenso = new string[9999];

            for (int i = 1; i < 10000; i++)
            {
                numerosPorExtenso[i - 1] = Transformar.EmNumeroPorExtenso(i);
            }

            string[] sequenciaCompletaDeNums = Array.FindAll(numerosPorExtenso, n => n.StartsWith("D"));

            bool contaEstaCorreta = ValidarQuestao3.ContaItemF(_f, sequenciaCompletaDeNums);

            int resposta = CalcularQuestao3.ProximoNumeroItemF(_f, sequenciaCompletaDeNums);

            return ValidarQuestao3.Item(contaEstaCorreta, resposta);
        }
    }
}
