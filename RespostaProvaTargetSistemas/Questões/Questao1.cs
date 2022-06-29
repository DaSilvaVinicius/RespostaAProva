namespace RespostaProvaTargetSistemas.Questões
{
    public static class Questao1
    {
        /*1) Observe o trecho de código abaixo:

        int INDICE = 13, SOMA = 0, K = 0;

        enquanto K < INDICE faça

        {

        K = K + 1;

        SOMA = SOMA + K;

        }

        imprimir(SOMA);


        Ao final do processamento, qual será o valor da variável SOMA?*/

        private static int _soma = 0;
        private static int _indice = 13;

        public static void Resposta()
        {
            Console.WriteLine("Questâo 1:");

            Console.WriteLine();
            for (int K = 0; K < _indice; K++)
            {
                _soma += K;

                Console.WriteLine(_soma);
            }

            Console.WriteLine("Valor final da soma: " + _soma);
        }
    }
}
