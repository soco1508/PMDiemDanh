using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position() { X = -1; Y = -1; }
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
