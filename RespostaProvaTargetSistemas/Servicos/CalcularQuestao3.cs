using RespostaProvaTargetSistemas.Extensoes;

namespace RespostaProvaTargetSistemas.Servicos
{
    public static class CalcularQuestao3
    {
        public delegate int LogicaDelegate(int[] vetor, int posicaoTeste);

        public static int ProximoNumero(int[] vetor, LogicaDelegate logica)
        {
            int ultimoNumero = vetor.LastOrDefault();
            int ultimaPosicao = vetor.Count() - 1;

            int proximoNumero = ultimoNumero + logica(vetor, ultimaPosicao);

            return proximoNumero;
        }

        public static int ProximoNumeroItemF(int[] sequenciaDeNum, string[] sequenciaCompletaDeNums)
        {
            int ultimoNumero = sequenciaDeNum.LastOrDefault();           

            int posicao = Array.IndexOf(sequenciaCompletaDeNums, Transformar.EmNumeroPorExtenso(ultimoNumero));

            int proximoNumero = Transformar.PorExtensoEmNumero(sequenciaCompletaDeNums[posicao + 1]);

            return proximoNumero;
        }

        public static int LogicaItemA(int[] vetor, int posicaoTeste)
        {
            return 2;
        }

        public static int LogicaItemB(int[] vetor, int posicaoTeste)
        {
            return vetor[posicaoTeste];
        }

        public static int LogicaItemC(int[] vetor, int posicaoTeste)
        {
            return posicaoTeste + posicaoTeste + 1;
        }

        public static int LogicaItemD(int[] vetor, int posicaoTeste)
        {
            return Convert.ToInt32(Math.Sqrt(vetor[posicaoTeste]) * 4 + 4);
        }

        public static int LogicaItemE(int[] vetor, int posicaoTeste)
        {
            return vetor[posicaoTeste - 1];
        }
    }
}
