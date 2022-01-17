using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoQuinze.AtividadeRestricoesGenerics.Entities;

namespace CSharpSecaoQuinze.AtividadeRestricoesGenerics.Services
{
    class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable
        {
            if(list.Count == 0)
            {
                throw new ArgumentException("The list can not be empty!");
            }
            
            T max = list[0];
            for(int cont = 1; cont < list.Count; cont++)
            {
                if(list[cont].CompareTo(max) > 0)
                {
                    max = list[cont];
                }
            }
            return max;
        }  
    }
}