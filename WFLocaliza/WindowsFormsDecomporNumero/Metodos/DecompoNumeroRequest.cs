using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using WindowsFormsDecomporNumero.Model;

namespace WindowsFormsDecomporNumero.Metodos
{
    public class DecompoNumeroRequest
    {
        public static void DecomporNumero(long numero,ref string divisores, ref string divisoresPrimos)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json", true, true).Build();
            string Url = (config["URLAPI"] == null || config["URLAPI"] == "") ? "https://localhost:44324/API/v1/DecomporNumero/" : config["URLAPI"].Trim();
            DecomporNumeroResponse retorno = new DecomporNumeroResponse();
            using (HttpClient client = new HttpClient() { BaseAddress = new Uri(Url) })
            {
                HttpResponseMessage result = client.GetAsync($"{numero}").Result;

                result.EnsureSuccessStatusCode();

                if(result.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    throw new Exception($"StatusCode: {result.StatusCode} | RequestMessage: {result.RequestMessage}");
                }

                string resultRequest = result.Content.ReadAsStringAsync().Result;

                retorno = JsonConvert.DeserializeObject<DecomporNumeroResponse>(resultRequest);
            }

            foreach (var item in retorno.divisores)
            {
                divisores += item.ToString() + ";";
            }
            foreach (var item in retorno.divisoresPrimos)
            {
                divisoresPrimos += item.ToString() + ";";
            }
        }
    }
}
