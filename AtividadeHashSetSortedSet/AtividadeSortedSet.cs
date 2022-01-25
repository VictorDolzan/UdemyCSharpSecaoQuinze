using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoQuinze.AtividadeHashSetSortedSet
{
    public class AtividadeSortedSet
    {
        public static void ExecutarAtividadeSortedSet()
        {
            SortedSet<int> aSet = new SortedSet<int>(){ 0, 2, 4, 5, 6, 8, 10 };

            SortedSet<int> bsSet = new SortedSet<int>(){ 5, 6, 7, 8, 9, 10 };

            //union

            SortedSet<int> cSet = new SortedSet<int>(aSet);
            cSet.UnionWith(bsSet);
            PrintCollection(cSet);

            //intersection
            SortedSet<int> dSet = new SortedSet<int>(aSet);
            dSet.IntersectWith(bsSet);
            PrintCollection(dSet);

            //difference
            SortedSet<int> eSet = new SortedSet<int>(aSet);
            eSet.ExceptWith(bsSet);
            PrintCollection(eSet);

            static void PrintCollection<T>(IEnumerable<T> collection)
            {
                foreach(T obj in collection)
                {
                    Console.Write(obj + " ");
                }
                Console.WriteLine();
            }
        }
    }
}