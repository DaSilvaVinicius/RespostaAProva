using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RespostaProvaTargetSistemas.Extensoes
{
    public class Transformar
    {
        public static string EmNumeroPorExtenso(int num)
        {
            string numero = num.ToString();
            string milhar = string.Empty;
            string centena = string.Empty;
            string dezena = string.Empty;
            string unidade = string.Empty;
            string extenso = string.Empty;

            numero = numero.PadLeft(4, '0');

            string zero = "0000";
            if (numero == zero)
            {
                Console.Write("Zero");
            }

            if (numero[0] != '0')
            {
                switch (numero[0])
                {
                    case '1': milhar = "Mil "; break;
                    case '2': milhar = "Dois Mil "; break;
                    case '3': milhar = "Três Mil "; break;
                    case '4': milhar = "Quatro Mil "; break;
                    case '5': milhar = "Cinco Mil "; break;
                    case '6': milhar = "Seis Mil "; break;
                    case '7': milhar = "Sete Mil "; break;
                    case '8': milhar = "Oito Mil "; break;
                    case '9': milhar = "Nove Mil "; break;

                }
            }

            if (numero[1] != '0')
            {

                switch (numero[1])
                {
                    case '1': centena = "Cento "; break;
                    case '2': centena = "Duzentos "; break;
                    case '3': centena = "Trezentos "; break;
                    case '4': centena = "Quatrocentos "; break;
                    case '5': centena = "Quinhentos "; break;
                    case '6': centena = "Seiscentos "; break;
                    case '7': centena = "Setecentos "; break;
                    case '8': centena = "Oitocentos "; break;
                    case '9': centena = "Novecentos "; break;

                }
                if (numero[0] == '0' && numero[1] == '1' && numero[2] == '0' && numero[3] == '0')
                {
                    centena = "Cem";
                }
                else if (numero[0] != '0' && numero[1] == '1' && numero[2] == '0' && numero[3] == '0')
                {
                    centena = "e Cem";
                }
                else if (numero[0] != '0' && numero[1] == '2' && numero[2] == '0' && numero[3] == '0')
                {
                    centena = "e Duzentos";
                }
                else if (numero[0] != '0' && numero[1] == '3' && numero[2] == '0' && numero[3] == '0')
                {
                    centena = "e Trezentos";
                }
                else if (numero[0] != '0' && numero[1] == '4' && numero[2] == '0' && numero[3] == '0')
                {
                    centena = "e Quatrocentos";
                }
                else if (numero[0] != '0' && numero[1] == '5' && numero[2] == '0' && numero[3] == '0')
                {
                    centena = "e Quinhentos";
                }
                else if (numero[0] != '0' && numero[1] == '6' && numero[2] == '0' && numero[3] == '0')
                {
                    centena = "e Seicentos";
                }
                else if (numero[0] != '0' && numero[1] == '7' && numero[2] == '0' && numero[3] == '0')
                {
                    centena = "e Setecentos";
                }
                else if (numero[0] != '0' && numero[1] == '8' && numero[2] == '0' && numero[3] == '0')
                {
                    centena = "e Oitocentos";
                }
                else if (numero[0] != '0' && numero[1] == '9' && numero[2] == '0' && numero[3] == '0')
                {
                    centena = "e Novecentos";
                }
            }

            if (numero[2] == '1')
            {
                switch (numero.Substring(2))
                {
                    case "10": dezena = "e Dez"; break;
                    case "11": dezena = "e Onze"; break;
                    case "12": dezena = "e Doze"; break;
                    case "13": dezena = "e Treze"; break;
                    case "14": dezena = "e Quatorze"; break;
                    case "15": dezena = "e Quinze"; break;
                    case "16": dezena = "e Dezesseis"; break;
                    case "17": dezena = "e Dezessete"; break;
                    case "18": dezena = "e Dezoito"; break;
                    case "19": dezena = "e Dezenove"; break;
                }
            }
            else if (numero[2] != '0')
            {
                switch (numero[2])
                {
                    case '2': dezena = "e Vinte "; break;
                    case '3': dezena = "e Trinta "; break;
                    case '4': dezena = "e Quarenta "; break;
                    case '5': dezena = "e Cinquenta "; break;
                    case '6': dezena = "e Secenta "; break;
                    case '7': dezena = "e Setenta "; break;
                    case '8': dezena = "e Oitenta "; break;
                    case '9': dezena = "e Noventa "; break;
                }
            }

            if (numero[3] != '0' && numero[2] != '1')
            {
                switch (numero[3])
                {
                    case '1': unidade = "e Um"; break;
                    case '2': unidade = "e Dois"; break;
                    case '3': unidade = "e Três"; break;
                    case '4': unidade = "e Quatro"; break;
                    case '5': unidade = "e Cinco"; break;
                    case '6': unidade = "e Seis"; break;
                    case '7': unidade = "e Sete"; break;
                    case '8': unidade = "e Oito"; break;
                    case '9': unidade = "e Nove"; break;
                }
            }


            extenso = milhar + centena + dezena + unidade;

            if (extenso[0] == 'e')
            {
                extenso = extenso.Substring(2);
            }

            return extenso;
        }

        public static int PorExtensoEmNumero(string extenso)
        {
            Dictionary<string, int> NumDict = new();
            Dictionary<string, int> MilharDict = new();

            NumDict.Add("Zero", 0);
            NumDict.Add("Um", 1);
            NumDict.Add("Dois", 2);
            NumDict.Add("Três", 3);
            NumDict.Add("Quatro", 4);
            NumDict.Add("Cinco", 5);
            NumDict.Add("Seis", 6);
            NumDict.Add("Sete", 7);
            NumDict.Add("Oito", 8);
            NumDict.Add("Nove", 9);

            NumDict.Add("Dez", 10);
            NumDict.Add("Onze", 11);
            NumDict.Add("Doze", 12);
            NumDict.Add("Treze", 13);
            NumDict.Add("Quatorze", 14);
            NumDict.Add("Quinze", 15);
            NumDict.Add("Dezesseis", 16);
            NumDict.Add("Dezessete", 17);
            NumDict.Add("Dezoito", 18);
            NumDict.Add("Dezenove", 19);

            NumDict.Add("Vinte", 20);
            NumDict.Add("Trinta", 30);
            NumDict.Add("Quarenta", 40);
            NumDict.Add("Cinquenta", 50);
            NumDict.Add("Sessenta", 60);
            NumDict.Add("Setenta", 70);
            NumDict.Add("Oitenta", 80);
            NumDict.Add("Noventa", 90);

            NumDict.Add("Cem", 100);
            NumDict.Add("Cento", 100);
            NumDict.Add("Duzentos", 200);
            NumDict.Add("Trezentos", 300);
            NumDict.Add("Quatrocentos", 400);
            NumDict.Add("Quinhentos", 500);
            NumDict.Add("Seiscentos", 600);
            NumDict.Add("Setecentos", 700);
            NumDict.Add("Oitocentos", 800);
            NumDict.Add("Novecentos", 900);

            MilharDict.Add("Mil", 1000);
            MilharDict.Add("Milhão", 1000000);
            MilharDict.Add("Milhões", 1000000);
            MilharDict.Add("Bilhão", 1000000000);
            MilharDict.Add("Bilhões", 1000000000);

            int resultado = 0;
            int grupoCorrente = 0;

            foreach (var word in extenso.Split(' '))
            {
                if (NumDict.ContainsKey(word))
                {
                    grupoCorrente += NumDict[word];
                }
                else if (MilharDict.ContainsKey(word))
                {
                    resultado += (grupoCorrente == 0 ? 1 : grupoCorrente) * MilharDict[word];
                    grupoCorrente = 0;
                }
            }

            resultado += grupoCorrente;

            return resultado;
        }
    }
}
