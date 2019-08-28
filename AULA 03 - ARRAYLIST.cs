using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        class Func
        {
            public string nome;
            public string cargo;
            public double salario;
        }
            
        static void Main(string[] args)
        {
            
            int Reg = 0;
            ArrayList Cadastro = new ArrayList();

            do
            {
                Func newFunc = new Func();

                Console.Write("Nome Funcionario {0,3}");
                newFunc.nome = Console.ReadLine();

                Console.Write("Cargo do Funcionario {0,3}");
                newFunc.cargo = Console.ReadLine();

                Console.Write("Nome Funcionario {0,3}");
                newFunc.salario = double.Parse(Console.ReadLine());

                Cadastro.Add(newFunc);
                Reg++;

                if (Reg < 100)
                    Console.WriteLine("\n Voce deseja inserir um novo colaborador? ");
                break;

            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            for (int i = 0; i > Reg; i++) ;
            Console.Clear();
            foreach(Func x in Cadastro)
            {
                Console.WriteLine("{0} - R${1:F2}",
                x.nome,
                x.salario);
                Console.WriteLine("Cargo: {0}\n",
                x.cargo);


            }
        }
    }
}
