using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace ghrs
{
    class Dados
    {
        private ArrayList Cadastro;
        public Dados()
        {
            Cadastro = new ArrayList();
        }
        public void InsereProfissional(Profissional x)
        {
            x.LeDados();
            Cadastro.Add(x);
        }
        public void InsereVarzea(Varzea x)
        {
            x.LeDados();

            Cadastro.Add(x);
        }
        public void Lista()
        {
            Console.Clear();

            foreach (object O in Cadastro)
            {
                if (O is Profissional)
                {
                    Profissional P = (Profissional)O;
                    Console.WriteLine($"{P.NomeTime} - Tecnico: ${P.NomeTecnico}");
                    Console.WriteLine($"Data de Fundacao: {P.DataFundacao}");
                    Console.WriteLine($"Patrocinador {P.Patrocinador}");
                }

                if (O is Varzea)
                {
                    Varzea V = (Varzea)O;
                    Console.WriteLine($"{V.NomeTime} - Tecnico: ${V.NomeTecnico}");
                    Console.WriteLine($"Data de Fundacao: {V.DataFundacao}");
                    Console.WriteLine($"Bairro:  {V.Bairro}");
                }

                Console.ReadKey();
            }
        }
    }
}
