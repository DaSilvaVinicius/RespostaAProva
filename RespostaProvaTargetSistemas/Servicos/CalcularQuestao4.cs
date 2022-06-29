using RespostaProvaTargetSistemas.Extensoes;
using RespostaProvaTargetSistemas.Modelos;

namespace RespostaProvaTargetSistemas.Servicos
{
    public static class CalcularQuestao4
    {
        public static int SeEncontramPertoDaSaidaDoItinerario(Itinerario iti1, Itinerario iti2)
        {
            int tempoMaximoParaSeEncontrarem;

            if (iti1.TempoDeViagemEmMin <= iti2.TempoDeViagemEmMin)
                tempoMaximoParaSeEncontrarem = iti1.TempoDeViagemEmMin;
            else
                tempoMaximoParaSeEncontrarem = iti2.TempoDeViagemEmMin;

            for (int i = 1; i < tempoMaximoParaSeEncontrarem; i++)
            {
                if (iti1.DistanciaPercorridaPeloVeiculo(i) > iti2.DistanciaAPercorrerPeloVeiculo(i))
                {
                    if (iti1.DistanciaPercorridaPeloVeiculo(i) < iti1.DistanciaAPercorrerPeloVeiculo(i))
                        return 1;
                    else if (iti1.DistanciaPercorridaPeloVeiculo(i) > iti1.DistanciaAPercorrerPeloVeiculo(i))
                        return 2;
                    else
                        return 0;
                }
            }

            return 3;
        }
    }
}
