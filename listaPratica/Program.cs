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

                
                Floresta floresta = null;
                int countFlorestaNome = 0;

                do
                {   
                    floresta = new Floresta();
                    floresta.Nome = (countFlorestaNome + 1).ToString();
                    List<Monte> listaMontes = new List<Monte>();
                    String[] linha = sr.ReadLine().Split(' ');
                    int qtdLinhasToRead = int.Parse(linha[0]);
                    int qtdMontesToFormar = int.Parse(linha[1]);

                    Console.WriteLine("Linhas a ler: " + qtdLinhasToRead + " Montes: " + qtdMontesToFormar);

                    for (int i = 0; i < qtdLinhasToRead; i++)
                    {
                        Monte monte = new Monte();

                        string[] proximaLinha = sr.ReadLine().Split(' ');

                        monte.Y0 = int.Parse(proximaLinha[0]);
                        monte.M = int.Parse(proximaLinha[1]);

                        hasNext = qtdLinhasToRead == i;

                        listaMontes.Add(monte);

                        Console.WriteLine("Linha ponto x: " + monte.Y0 + " Linha ponto y: " + monte.M);

                    }
                    floresta.Montes = listaMontes;
                }
                while (!sr.EndOfStream);
                Console.WriteLine("Totalmente preenchido.");
            }

        }

        static void Main(string[] args)
        {
            lerArquivo();
            Console.WriteLine("fim");
            Console.ReadKey();
        }
    }
}
