using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoQuinze.AtividadeRestricoesGenerics.Services;
using CSharpSecaoQuinze.AtividadeRestricoesGenerics.Entities;

namespace CSharpSecaoQuinze.AtividadeRestricoesGenerics
{
    class AtividadeRestricoesGenerics
    {
        public static void ExecutarAtividadeRestricoesGenerics()
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for(int cont = 0; cont < n; cont++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);                
                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);

            Console.WriteLine("Max: ");
            Console.WriteLine(max);
        }
    }
}