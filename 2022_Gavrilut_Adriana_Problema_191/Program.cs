using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2022_Gavrilut_Adriana_Problema_191
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader load = new StreamReader(@"..\..\maxmat.in");
            StreamWriter afisare = new StreamWriter(@"..\..\maxmat.out");
            string line = load.ReadLine();
            char[] sep = { ' ', '\n', '\t', ',', ';' };
            int n, m;
            string[] tokens = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            n = int.Parse(tokens[0]);
            m = int.Parse(tokens[1]);
            int[,] matrice = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                line = load.ReadLine();
                tokens = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < m; j++)
                {
                    matrice[i, j] = int.Parse(tokens[j]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                int max = matrice[i, 0];
                int indice = 0;
                for (int j = 1; j < m; j++)
                {
                    if (matrice[i, j] > max)
                    {
                        max = matrice[i, j];
                        indice = j;
                    }
                }
                afisare.WriteLine(max + " " + (indice + 1));
            }
            afisare.Close();
        }
    }
}
