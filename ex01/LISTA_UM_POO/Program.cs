using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LISTA_UM_POO
{
    class Program
    {
        class Dados_Alunos
        {
            public string Nome;
            public string Mail;
            public string DataNascimento;
            public string Telefone;
        }
        static void Main(string[] args)
        {
            ArrayList Cadastro = new ArrayList();
            int reg = 0;
            do
            {
                Dados_Alunos novoAluno = new Dados_Alunos();

                Console.Write("\nQual o nome do aluno: ");
                novoAluno.Nome = Console.ReadLine();

                Console.Write("\nQual o email do aluno: ");
                novoAluno.Mail = Console.ReadLine();

                Console.Write("\nQual Data de nascimento do aluno: ");
                novoAluno.DataNascimento = Console.ReadLine();

                Console.Write("\nQual o telefone do aluno: ");
                novoAluno.Telefone = Console.ReadLine();

                Cadastro.Add(novoAluno);
                reg++;

                if (reg < 100)
                {
                    Console.WriteLine("Pressione qualquer tecla para cadastrar um novo aluno ... Pressione Esc para sair");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    break;
                }
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            {
                Console.Clear();
                for (int i = 0; i < reg; i++)
                {
                    foreach (Dados_Alunos x in Cadastro)
                    {
                        Console.WriteLine("\n\nAluno: {0}\nTelefone:{1}\nEmail: {2}\nData de Nascimento: {3}",
                            x.Nome,
                            x.Telefone,
                            x.Mail,
                            x.DataNascimento);
                    }


                }

                Console.ReadKey();

            }
        }
    }
}
