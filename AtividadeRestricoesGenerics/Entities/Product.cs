using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoQuinze.AtividadeRestricoesGenerics.Services;

namespace CSharpSecaoQuinze.AtividadeRestricoesGenerics.Entities
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string externalName, double externalPrice)
        {
            Name = externalName;
            Price = externalPrice;
        }
        public override string ToString()
        {
            return Name
            + ", "
            + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object? obj)
        {
            if(!(obj is Product))
            {
                throw new ArgumentException("Comparing error: arguments is not a product!");
            }
            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }
    }
}