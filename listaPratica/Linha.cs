using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaPratica
{
    class Linha
    {
        int y0;
        int m;

        public Linha()
        {
        }

        public int Y0 { get => y0; set => y0 = value; }
        public int M { get => m; set => m = value; }
    }
}
