using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoQuinze.AtividadeCompararHash.Entities;

namespace CSharpSecaoQuinze.AtividadeCompararHash
{
    class AtividadeCompararHash
    {
        public static void ExecutarAtividadeCompararHash()
        {
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.0);

            Console.WriteLine(a.Contains(prod));

            Point p = new Point(5, 10);
            Console.WriteLine(b.Contains(p));
            // HashSet<string> set = new HashSet<string>();

            // set.Add("Maria");
            // set.Add("Alex");

            // Console.WriteLine(set.Contains("Maria"));            

        }
    }
}