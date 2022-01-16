using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoQuinze.AtividadeGenerics
{
    class PrintService
    {
        private int[] _values = new int[10];
        private int _count = 0;

        public void AddValue(int externalValue)
        {
            if(_count == 10)
            {
                throw new InvalidOperationException("PrintService is full!");
            }
            _values[_count] = externalValue;
            _count++;
        }
        public int First()
        {
            if(_count == 0)
            {
                throw new InvalidOperationException("Printservice is empty");
            }
            return _values[0];
        }
        public void Print()
        {
            Console.Write("[");
            for(int cont = 0; cont < _count -1; cont++)
            {
                Console.Write(_values[cont] + ", ");
            }
            if(_count > 0)
            {
                Console.Write(_values[_count - 1]);
            }
            Console.WriteLine("]");
        }
    }
}