using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RespostaProvaTargetSistemas.Modelos
{
    public class Itinerario
    {
        public Itinerario(int velocidadeMedia, int distanciaPercursoEmKM, int quantidadePedagios, int tempoGastoPorPedagio)
        {
            VelocidadeMedia = velocidadeMedia;
            DistanciaPercurso = distanciaPercursoEmKM;
            QuantidadePedagios = quantidadePedagios;
            TempoGastoPorPedagio = tempoGastoPorPedagio;
        }

        public int VelocidadeMedia { get; set; }
        public int DistanciaPercurso { get; private set; }
        public int TempoDeViagemEmMin { get => Convert.ToInt32((double)DistanciaPercurso / VelocidadeMedia * 60 + QuantidadePedagios * TempoGastoPorPedagio); }
        public int QuantidadePedagios { get; private set; }
        public int TempoGastoPorPedagio { get; private set; }
        public int[] PosicaoDosPedagios
        {
            get
            {
                int distanciaPedagio = DistanciaPercurso / (QuantidadePedagios + 1);
                var distanciaDosPedagios = new List<int>();

                for (int i = 1; i <= QuantidadePedagios; i++)
                {
                    distanciaDosPedagios.Add(distanciaPedagio * (i));
                }

                return distanciaDosPedagios.ToArray();
            }
        }
        public int DistanciaNaoPercorridaPorCausaDoPedagio
        {
            get => VelocidadeMedia * TempoGastoPorPedagio / 60;
        }

        public int DistanciaPercorridaPeloVeiculo(int tempoTranscorridoEmMin)
        {
            double distanciaPercorrida = (double)VelocidadeMedia * tempoTranscorridoEmMin / 60;

            for (int i = 0; i < QuantidadePedagios; i++)
            {
                if (distanciaPercorrida >= PosicaoDosPedagios[i])
                {
                    distanciaPercorrida -= DistanciaNaoPercorridaPorCausaDoPedagio;
                }
            }

            int dis = Convert.ToInt32(distanciaPercorrida);
            return dis;
        }


        public int DistanciaAPercorrerPeloVeiculo(int tempoTranscorrido)
        {
            int distanciaAPercorrer = DistanciaPercurso - DistanciaPercorridaPeloVeiculo(tempoTranscorrido);

            return distanciaAPercorrer;
        }
    }
}
