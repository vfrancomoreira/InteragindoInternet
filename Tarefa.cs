using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto04_InteragindoInternet_HTTP
{
    public class Tarefa
    {
        public int userId;
        public int id;
        public string title;
        public bool completed;

        public void Exibir()
        {
            Console.WriteLine("Objeto tarefa.");
            Console.WriteLine($"User id: {userId}");
            Console.WriteLine($"Id: {id}");            
            Console.WriteLine($"Title: {title}");            
            Console.WriteLine($"Completed: {completed}");
            Console.WriteLine("");
            Console.WriteLine("================");
        }
    }
}