using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ghrs
{
    class Varzea: Time
    {
        public string Bairro { get; set; }

        new public void LeDados()
        {
            base.LeDados();
            Console.Write("Bairro: ");
            Bairro = Console.ReadLine();
        }
    }
}
