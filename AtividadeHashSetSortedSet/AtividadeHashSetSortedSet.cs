using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoQuinze.AtividadeHashSetSortedSet
{
    class AtividadeHashSetSortedSet
    {
        public static void ExecutarAtividadeHashSetSortedSet()
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine("Notebook está contido no conjunto? " + set.Contains("Notebook"));
            Console.WriteLine("Computer está contindo no conjunto? " + set.Contains("Computer"));

            foreach(string p in set)
            {
                Console.WriteLine(p);
            }
        }
    }
}