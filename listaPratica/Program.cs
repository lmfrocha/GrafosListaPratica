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
        //Método para leitura do arquivo
        public static void lerArquivo(ref List<Montes> ListaMontes)
        {
            //Classe que realiza a leitura
            using (StreamReader leitor = new StreamReader(caminhoArquivo))
            {
                //Preenchendo montes iniciais e finais
                do
                {
                    Montes objMonte = new Montes();

                    //Vetor utilizado para ler as linhas de montes inicial e final
                    String[] linha = leitor.ReadLine().Split(' ');

                    //Guardando os montes iniciais e finais na lista do objeto Monte
                    objMonte.monteInicial = int.Parse(linha[0]);
                    objMonte.monteFinal = int.Parse(linha[1]);

                    //Preenchendo posições e pesos
                    for (int i = 0; i < objMonte.monteInicial; i++) //Faz enquanto o i for menor que o monte inicial
                    {
                        PosicoesPesos objPosicoesPesos = new PosicoesPesos();

                        //Vetor utilizado para ler as linhas de posições e pesos
                        string[] proximaLinha = leitor.ReadLine().Split(' ');

                        //Guardando as posições e pesos nas listas do objeto Monte
                        objPosicoesPesos.posicoes = int.Parse(proximaLinha[0]);
                        objPosicoesPesos.pesos = int.Parse(proximaLinha[1]);

                        //Inserir o objeto preenchido na lista de Posições e Pesos
                        objMonte.ListaPosicoesPesos.Add(objPosicoesPesos);
                    }
                    //Inserindo o objeto preenchido na lista
                    ListaMontes.Add(objMonte);
                }
                while (!leitor.EndOfStream); //Faz enquanto não termina a leitura de todo o arquivo
            }

        }

        static void Main(string[] args)
        {
            /*
              Lista de montes para guardar os dados do arquivo lido, sendo:
              Dois inteiros contendo monte inicial e final
              Duas listas de inteiro contendo posições e pesos
            */

            //Lista de Montes para guardar os dados do arquivo lido.
            List<Montes> ListaMontes = new List<Montes>();

            //Método de leitura que recebe por parâmetro uma lista de montes que será preenchida durante a leitura.
            lerArquivo(ref ListaMontes);

            //Imprimindo em tela só pra testar se os valores foram guardados corretamente
            foreach (Montes IMPmontes in ListaMontes)
            {
                Console.WriteLine(IMPmontes.monteInicial + " " + IMPmontes.monteFinal);

                foreach (PosicoesPesos IMPposicoesPesos in IMPmontes.ListaPosicoesPesos)
                {
                    Console.WriteLine(IMPposicoesPesos.posicoes + " " + IMPposicoesPesos.pesos);
                }
            }

            /* Let us create the example graph discussed above */
            int[,] graph = new int[,] { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                                      { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                                      { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                                      { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                                      { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                                      { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                                      { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                                      { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                                      { 0, 0, 2, 0, 0, 0, 6, 7, 0 } };

            Grafos.Implementacao(graph, 0, 9);
                        
            Console.ReadKey();
        }
    }
}
