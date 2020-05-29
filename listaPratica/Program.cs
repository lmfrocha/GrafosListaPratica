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
            using (StreamReader sr = File.OpenText(caminhoArquivo))
            {
                String[] documento = File.ReadAllLines(caminhoArquivo);

                foreach (string linha in documento)
                {
                    string[] dados = linha.Split(' ');
                    Console.WriteLine(dados[0] +" " + dados[1]);
                }

                    
            }

        }

        static void Main(string[] args)
        {

            lerArquivo();
          
            Console.ReadKey();
        }
    }
}
