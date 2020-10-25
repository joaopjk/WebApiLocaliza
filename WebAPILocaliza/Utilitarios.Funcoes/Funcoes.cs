using System;
using System.Collections.Generic;
using System.Linq;

namespace Utilitarios
{    /// <summary>
     /// Classe funçoes usadas na API.
     /// </summary>
    public class Funcoes
    {
        public static void DecomporNumero(long numero,List<long> divisores, List<long> divisoresPrimos)
        {

            if (Funcoes.VerificarNumeroPrimo(numero))
            {
                divisores.Add(1);
                divisores.Add(numero);
                divisoresPrimos.Add(numero);

            }
            else
            {
                List<long> numerosPrimos = Funcoes.ObterListaNumerosPrimos(numero);
                List<long> numerosDivisores = Funcoes.ObterListaDivisores(numerosPrimos, numero);
                Funcoes.ObterDivisores(numerosDivisores, divisores, divisoresPrimos);

            }
        }
        /// <summary>
        /// Verifiar se o número passado por parâmetro é Primo utilizando o Crivo de Erastóstenes.
        /// </summary>
        public static bool VerificarNumeroPrimo(long numero)
        {
            double raiz;
            long[] vetor = new long[numero + 1];

            raiz = Math.Round(Math.Sqrt(numero), MidpointRounding.AwayFromZero);

            if(numero == 1)
            {
                return false;
            }
            for (int i = 0; i <= numero; i++)
            {
                vetor[i] = i;
            }
            for (int j = 2; j <= raiz; j++)
            {
                if (vetor[j] == j)
                {
                    if (numero % j == 0)
                    {
                        return false;
                    }
                    for (int k = j + j; k <= numero; k += j)
                    {
                        vetor[k] = 0;
                    }
                }
            }

            return true;
        }
        /// <summary>
        /// Obter lista de número primos de 2 até o número passada por parâmetro.
        /// </summary>
        public static List<long> ObterListaNumerosPrimos(long numero)
        {
            double raiz;
            long[] vetor = new long[numero + 1];
            List<long> listaNumerosPrimos = new List<long>();
            raiz = Math.Round(Math.Sqrt(numero), MidpointRounding.AwayFromZero);

            for (int i = 0; i <= numero; i++)
            {
                vetor[i] = i;
            }
            for (int j = 2; j <= raiz; j++)
            {
                if (vetor[j] == j)
                {
                    if (numero % j == 0)
                    {
                        listaNumerosPrimos.Add(j);
                    }
                    for (int k = j + j; k <= numero; k += j)
                    {
                        vetor[k] = 0;
                    }
                }
            }
            return listaNumerosPrimos;
        }
        /// <summary>
        /// Obter a lista de todos os divisores no número passado por parâmentro 
        /// utilizando a lista de números primos obtidos no passo anterior.
        /// </summary>
        public static List<long> ObterListaDivisores(List<long> listaNumerosPrimos, long numero)
        {
            bool parar = true;
            List<long> listaDivisores = new List<long>();

            for (int i = 0; i < listaNumerosPrimos.Count; i++)
            {
                if (numero != 1)
                {
                    parar = true;
                    do
                    {
                        if (numero % listaNumerosPrimos[i] == 0)
                        {
                            listaDivisores.Add(listaNumerosPrimos[i]);
                            numero /= listaNumerosPrimos[i];
                        }
                        else
                        {
                            parar = false;
                        }
                    } while (parar);
                }
                else
                {
                    break;
                }
            }
            return listaDivisores;
        }
        /// <summary>
        /// Obter todos os divisores de um número utilizando a lista de numeros decompostos. 
        /// </summary>
        public static void ObterDivisores(List<long> numerosDivisores,List<long> divisores, List<long> divisoresPrimos)
        {

            divisores.Add(1);
            long resultado = 0;

            for (int i = 0; i < numerosDivisores.Count; i++)
            {
                int quantidadeDivisores = divisores.Count();
                for (int j = 0; j < quantidadeDivisores; j++)
                {
                    resultado = numerosDivisores[i] * divisores[j];
                    if (!divisores.Contains(resultado))
                    {
                        divisores.Add(resultado);
                        if (VerificarNumeroPrimo(resultado))
                        {
                            if (!divisoresPrimos.Contains(resultado))
                                divisoresPrimos.Add(resultado);
                        }
                    }
                }
            }

            divisores.Sort();
            divisoresPrimos.Sort();
        }
    }

}
