using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoQuinze.AtividadeCompararHash.Entities
{
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int extrnalX, int externalY) : this()
        {
            X = extrnalX;
            Y = externalY;
        }
    }
}