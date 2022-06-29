namespace RespostaProvaTargetSistemas.Extensoes
{
    public class Fibonacci
    {
        public Fibonacci()
        {
            List<int> numFibo = new List<int>() { 0, 1};

            for (int numBemAnterior = 0, numAnterior = 1, num = 1; num <= 2000000000;)
            {
                num = numAnterior + numBemAnterior;

                numFibo.Add(num);

                numBemAnterior = numAnterior;
                numAnterior = num;
            }

            Numeros = numFibo;
        }

        public List<int> Numeros { get; private set; }

        public string PertenceASequencia(int n)
        {
            if (Numeros.Contains(n))
                return "Que incrível! Este número pertence à sequência de Fibonacci!";

            else
                return "Que pena! Este número não pertence à sequência de Fibonacci!";
        }
    }
}


