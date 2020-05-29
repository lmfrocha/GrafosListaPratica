using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace listaPratica
{
    class Program
    {
        static String caminhoArquivo = @"C:\var\grafo.txt";
        public static void lerArquivo()
        {

            using (StreamReader sr = new StreamReader(caminhoArquivo))
            {
                Boolean hasNext = false;
                String [] linha = sr.ReadLine().Split(' ');

                List<Linha> listaMontes = new List<Linha>();

                int qtdLinhasToRead = int.Parse(linha[0]);
                int qtdMontesToFormar = int.Parse(linha[1]);

                /*
                 * For que le a quantidade de linhas estipuladas e cria os montes
                 */
                for(int i = 0; i<qtdLinhasToRead; i++)
                {
                    Linha ln = new Linha();

                    string [] proximaLinha = sr.ReadLine().Split(' ');

                    ln.Y0 = int.Parse(proximaLinha[0]);
                    ln.M = int.Parse(proximaLinha[1]);
                    hasNext = qtdLinhasToRead == i;

                    listaMontes.Add(ln);

                    Console.WriteLine("Linha ponto x: " + ln.Y0 + " Linha ponto y: "+ ln.M);
                   
                }

                Console.ReadKey();
            }

        }

        static void Main(string[] args)
        {

            lerArquivo();
                     
        }
    }
}
