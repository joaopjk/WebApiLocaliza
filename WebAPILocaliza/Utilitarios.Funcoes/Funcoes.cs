using System;
using System.Collections.Generic;
using System.Linq;

namespace Utilitarios
{    /// <summary>
     /// Classe funçoes usadas na API.
     /// </summary>
    public class Funcoes
    {
        public static void DecomporNumero(long numero, List<long> divisores, List<long> divisoresPrimos)
        {

            Funcoes.ObterListaNumerosPrimos(numero, divisoresPrimos);
            List<long> numerosDivisores = Funcoes.FatorarComNumerosPrimos(divisoresPrimos, numero);
            Funcoes.ObterListaDivisores(numerosDivisores, divisores);

        }
        /// <summary>
        /// Verifiar se o número passado por parâmetro é Primo utilizando o Crivo de Erastóstenes.
        /// </summary>
        public static void ObterListaNumerosPrimos(long numero, List<long> listaNumerosPrimos)
        {
            double raiz;
            long[] vetor = new long[numero + 1];
            raiz = Math.Round(Math.Sqrt(numero), MidpointRounding.AwayFromZero);

            for (int i = 2; i <= numero; i++)
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
            if(listaNumerosPrimos.Count == 0)
            {
                listaNumerosPrimos.Add(numero);
            }
        }
        /// <summary>
        /// Obter a lista de todos os divisores no número passado por parâmentro 
        /// utilizando a lista de números primos obtidos no passo anterior.
        /// Fatoração por Números Primos
        /// </summary>
        public static List<long> FatorarComNumerosPrimos(List<long> listaNumerosPrimos, long numero)
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
        public static void ObterListaDivisores(List<long> numerosDivisores, List<long> divisores)
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
                    }
                }
            }
            divisores.Sort();
        }
    }

}
