using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ghrs
{
    class Time
    {
        public string NomeTime { get; set; }
        public string NomeTecnico { get; set; }
        public string DataFundacao { get; set; }

        public void LeDados()
        {
            Console.Clear();

            Console.Write("Nome do time: ");
            NomeTime = Console.ReadLine();
            Console.Write("Nome do Tecnico: ");
            NomeTecnico= Console.ReadLine();
            Console.Write("Data da fundação: ");
            DataFundacao = Console.ReadLine();
        }
    }
}
