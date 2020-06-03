using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaPratica
{
    public class Montes
    {
        public int monteInicial;
        public int monteFinal;
        public int custo;
        public List<PosicoesPesos> ListaPosicoesPesos;

        public Montes()
        {
            monteInicial = 0;
            monteFinal = 0;
            custo = 0;
            ListaPosicoesPesos = new List<PosicoesPesos>();
        }
    }
}
