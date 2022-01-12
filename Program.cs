using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net; // Para fazer requisições web.
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json; // Para converter JSON em C#

namespace Projeto04_InteragindoInternet_HTTP
{
    class Program
    {
        static void Main(string[] args)
        {
            // ReqList();
            ReqUnica();
            Console.ReadLine();
        }

        static void ReqList()
        {
            var requisicao = WebRequest.Create("https://jsonplaceholder.typicode.com/todos/");
            requisicao.Method = "GET"; // Cadastra a requisição
            
            var resposta = requisicao.GetResponse();

            using (resposta) // Executa a requisição / Manda a requisição para a internet
            {
                var stream = resposta.GetResponseStream(); // Pegando a stream
                StreamReader leitor = new StreamReader (stream); // Decodifica a stream
                object dados = leitor.ReadToEnd(); // Lendo e passando o resultado pra dados

                List<Tarefa> tarefas = JsonConvert.DeserializeObject<List<Tarefa>>(dados.ToString());

                foreach(Tarefa tarefa in tarefas)
                {
                    tarefa.Exibir();
                }

                stream.Close();
                resposta.Close();
            }
        }
        static void ReqUnica()
        {
            var requisicao = WebRequest.Create("https://jsonplaceholder.typicode.com/todos/5");
            requisicao.Method = "GET";
            
            var resposta = requisicao.GetResponse();

            using (resposta)
            {
                var stream = resposta.GetResponseStream();
                StreamReader leitor = new StreamReader (stream);
                object dados = leitor.ReadToEnd();

                Tarefa tarefa = JsonConvert.DeserializeObject<Tarefa>(dados.ToString());

                tarefa.Exibir();

                stream.Close();
                resposta.Close();
            }
        }
    }
}
/*
1 - Básicamente este arquivo pega os dados da internet, e transforma os dados em string(c#).
2 - Instalando biblioteca/pacote Newtonsoft.Json para converter dados de texto para objetos c#.
3 - Converter JSON para objeto C#.
Desenvolvimento de aplicativos móveis
*/