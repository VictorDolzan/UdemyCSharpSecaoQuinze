using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoQuinze.AtividadeGenerics
{
    class AtividadeGenerics
    {
        public static void ExecutarAtividadeGenerics()
        {
            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values: ");
            int nValues = int.Parse(Console.ReadLine());

            for(int cont = 0; cont < nValues; cont++)
            {
                int externalValue = int.Parse(Console.ReadLine());
                printService.AddValue(externalValue);
            }
            
            printService.Print();
            Console.Write("First: " + printService.First());
        }
    }
}