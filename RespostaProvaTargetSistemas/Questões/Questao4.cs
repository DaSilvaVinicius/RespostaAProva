using RespostaProvaTargetSistemas.Modelos;
using RespostaProvaTargetSistemas.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RespostaProvaTargetSistemas.Questões
{
    /*4 - Dois veículos (um carro e um caminhão) saem respectivamente de cidades opostas pela mesma rodovia.O carro de Ribeirão Preto em direção a Franca, 
     a uma velocidade constante de 110 km/h e o caminhão de Franca em direção a Ribeirão Preto a uma velocidade constante de 80 km/h.Quando eles se 
     cruzarem na rodovia, qual estará mais próximo a cidade de Ribeirão Preto?


    IMPORTANTE:

    a) Considerar a distância de 100km entre a cidade de Ribeirão Preto <-> Franca.

    b) Considerar 2 pedágios como obstáculo e que o caminhão leva 5 minutos a mais para passar em cada um deles e o carro possui tag de pedágio (Sem Parar).

    c) Explique como chegou no resultado.*/

    public static class Questao4
    {
        public static void Resposta()
        {

            var iti1 = new Itinerario(110, 100, 2, 0);
            var iti2 = new Itinerario(80, 100, 2, 5);

            int pertoDaSaidaDoItinerario = CalcularQuestao4.SeEncontramPertoDaSaidaDoItinerario(iti1, iti2);

            Console.WriteLine("Questâo 4:");

            Console.WriteLine();
            if (pertoDaSaidaDoItinerario == 0)
                Console.WriteLine("Os dois veículos estarão à mesma distancia de Ribeirão Preto pois nesse momento estarão se cruzando, logo estarão um ao lado do outro." +
                    "Dito isso, quando os veículos se cruzarem estarão bem no meio do caminho.");
            else if (pertoDaSaidaDoItinerario == 1)
                Console.WriteLine("Os dois veículos estarão à mesma distancia de Ribeirão Preto pois nesse momento estarão se cruzando, logo estarão um ao lado do outro. " +
                    "Dito isso, Ribeirão Preto é a cidade mais perto.");
            else if (pertoDaSaidaDoItinerario == 2)
                Console.WriteLine("Os dois veículos estarão à mesma distancia de Ribeirão Preto pois nesse momento estarão se cruzando, logo estarão um ao lado do outro. " +
                    "Dito isso, Franca é a cidade mais perto.");
            else
                Console.WriteLine("Os veículos não se encontrarão.");
        }
    }
}
