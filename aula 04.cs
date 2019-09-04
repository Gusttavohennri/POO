using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Funcionario
    {
        public string  Nome { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }

        public void LeDados()
        {
            Console.Write("\nNome do funcionario: ");
            Nome = Console.ReadLine();

            Console.Write("\nCargo................: ");
            Cargo = Console.ReadLine();

            Console.Write("\nSalario..............: ");
            Salario = double.Parse(Console.ReadLine());
        }
    }
}
