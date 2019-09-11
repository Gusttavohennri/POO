using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ghrs
{
    class Profissional: Time
    {
        public string Patrocinador { get; set; }

        new void LeDados()
        {
            base.LeDados();

            Console.Write("Patrocinador: ");
            Patrocinador = Console.ReadLine();

        }
    }
}
