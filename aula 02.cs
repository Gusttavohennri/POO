using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[5];
            int[] B = new int[5];
            int[] R = new int[5];

            int Pos = 0;
            bool Existe;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Elemento {0} do Vetor A: ", i + 1);
                A[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Elemento {0} do Vetor B: ", i + 1);
                B[i] = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();

            for(int i = 0; i<5;i++)
            {
                Existe = false;

                for (int j = 0; j < 5; j++)
                {
                    if (A[i] == B[j])
                        Existe = true;
                    
                }

                if (!Existe)
                    R[Pos++] = A[i];
                //Pos++;
            }
       
            Console.Write("\n\nElementos de A que nao existem em B: \n");

            for (int i = 0; i < Pos; i++)
            {
                Console.WriteLine("{0}", R[i]);
            }
            Console.ReadKey();
        }
        
    }
}

