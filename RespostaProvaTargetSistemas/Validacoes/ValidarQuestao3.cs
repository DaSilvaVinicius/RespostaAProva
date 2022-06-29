using RespostaProvaTargetSistemas.Extensoes;
using static RespostaProvaTargetSistemas.Servicos.CalcularQuestao3;

namespace RespostaProvaTargetSistemas.Validação
{
    public static class ValidarQuestao3
    {
        public static bool Conta(int[] SequenciaDosNum, int posicaoTeste, LogicaDelegate logica)
        {
            int numSeguinte = SequenciaDosNum[posicaoTeste + 1];
            int numAnterior = SequenciaDosNum[posicaoTeste];

            bool logicaCerta = numAnterior + logica(SequenciaDosNum, posicaoTeste) == numSeguinte;

            return logicaCerta;
        }

        public static bool ContaItemF(int[] sequenciaDeNum, string[] sequenciaCompletaDeNums)
        {
            int quantNumForaDaLista = 0;
            int quantNumAMaisNaLista = 0;
            bool logicaCerta;

            foreach (var num in sequenciaDeNum)
            {
                if (!sequenciaCompletaDeNums.Contains(Transformar.EmNumeroPorExtenso(num)))
                {
                    quantNumForaDaLista++;
                }
            }

            for (int i = 1; i < sequenciaDeNum.LastOrDefault(); i++)
            {
                if (sequenciaCompletaDeNums.Contains(Transformar.EmNumeroPorExtenso(i)) && !sequenciaDeNum.Contains(i))
                {
                    quantNumAMaisNaLista++;
                }
            }

            if (quantNumForaDaLista > 0 || quantNumAMaisNaLista > 0)
                logicaCerta = false;
            else
                logicaCerta = true;

            return logicaCerta;
        }

        public static string Item(bool contaEstaCorreta1, bool contaEstaCorreta2, int resposta)
        {
            if (contaEstaCorreta1 && contaEstaCorreta2)
                return resposta.ToString();

            return "Houve um equívoco na lógica, tente novamente!";
        }

        public static string Item(bool contaEstaCorreta, int resposta)
        {
            if (contaEstaCorreta)
                return resposta.ToString();

            return "Houve um equívoco na lógica, tente novamente!";
        }
    }
}
