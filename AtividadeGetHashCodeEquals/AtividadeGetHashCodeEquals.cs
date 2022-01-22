using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoQuinze.AtividadeGetHashCodeEquals.Entities;

namespace CSharpSecaoQuinze.AtividadeGetHashCodeEquals
{
    class AtividadeGetHashCodeEquals
    {
        public static void ExecutarAtividadeGetHashCodeEquals()
        {
            Client a = new Client(
                "Maria", 
                "Maria@email.com"
            );

            Client b = new Client{
                Name = "Alex",
                Email = "alex@email.com"
            };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine("GetHashCode: ");
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());




            // string a = "Victor";
            // string b = "Jasmin";
            
            // Console.WriteLine(a.Equals(b));
            // Console.WriteLine();
            // Console.WriteLine("GetHashCode: ");
            // Console.WriteLine(a.GetHashCode());
            // Console.WriteLine(b.GetHashCode());

        }
    }
}