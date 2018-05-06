using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class FrmSize
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public FrmSize() { Width = -1; Height = -1; }
        public FrmSize(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
