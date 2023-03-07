using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Marcos", "Victor", "Gabriela", "Gabriel", "Julia", "Pedro" };
            names.Add("Ataliba");
            Console.WriteLine(names[4]);
            /*foreach (var name in names)
            {
                Console.WriteLine($"Lista de Nomes da TI32: {name.ToUpper()}!");
            }*/
            var r = new Random();
            for (int i = 0; i < names.Count; i++)
            {
                r.Next(6);
                Console.WriteLine(r);
                Console.WriteLine($"Lista de Nomes da TI32: {names[i].ToLower()}!");
            }

            Console.ReadKey();
        }
        
    }
}
