using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;


namespace ghrs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados MeusDados = new ghrs.Dados();
            //Menu
            int Op;

            do
            {
                Console.Clear();

                Console.Write("MEnu de Opções: \n");
                Console.Write("1 - Incluir time Profissional \n");
                Console.Write("2 - Incluir time de varzea \n");
                Console.Write("3 - Listar Times \n");
                Console.Write("4 - Sair \n");

                Console.WriteLine("Digite uma opção: ");
                Op = int.Parse(Console.ReadLine());

                switch (Op)
                {
                    case 1:
                        Profissional P = new Profissional();
                        MeusDados.InsereProfissional(P);
                        break;
                    case 2:
                        Varzea Z = new Varzea();
                        MeusDados.InsereVarzea(Z);
                        break;
                    case 3:
                        MeusDados.Lista();
                        break;
                    case 4:
                        Console.Write("\nSaida do sistema");
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                        break;

                    default:

                        Console.WriteLine("\nOpcao Invalida!");
                        Thread.Sleep(2000);
                        break;
                }
                
            }



            while (Op != 4) ;

                 }
        }
    }

    

