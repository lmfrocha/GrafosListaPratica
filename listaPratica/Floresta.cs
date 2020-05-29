using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaPratica
{
    class Floresta
    {
        private List<Monte> montes;
        private int custo = 0;
        private String nome;

        internal List<Monte> Montes { get => montes; set => montes = value; }
        public int Custo { get => custo; set => custo = value; }
        public string Nome { get => nome; set => nome = value; }

        public Floresta(List<Monte> montes, int custo)
        {
            this.Montes = montes;
            this.Custo = custo;
        }
        public Floresta()
        {
            this.custo = 0;
        }
               
    }
}
