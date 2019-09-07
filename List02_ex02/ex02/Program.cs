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
        public class Dados_Alunos: DataNascimento
        {
            
            public string Nome;
            public string Mail;
            public string Telefone;
            
        }
        public class DataNascimento 
        {
            public string Dia;
            public string Mes;
            public string Ano;
        }

        static void Main(string[] args)
        {
            ArrayList Cadastro = new ArrayList();
            ArrayList Datas = new ArrayList();
            int reg = 0;
            do
            {
                Dados_Alunos novoAluno = new Dados_Alunos();
              

                Console.Write("\nQual o nome do aluno: ");
                novoAluno.Nome = Console.ReadLine();

                Console.Write("\nQual o email do aluno: ");
                novoAluno.Mail = Console.ReadLine();

                Console.Write("\nQual Dia de nascimento do aluno: ");
                novoAluno.Dia = Console.ReadLine();
                Console.Write("\nQual Mes de nascimento do aluno: ");
                novoAluno.Mes = Console.ReadLine();
                Console.Write("\nQual Ano de nascimento do aluno: ");
                novoAluno.Ano= Console.ReadLine();

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
                       

                        Console.WriteLine("\n\nAluno: {0}\nTelefone:{1}\nEmail: {2} \nNascimento: {3}/{4}/{5}",
                        x.Nome,
                        x.Telefone,
                        x.Mail,
                        x.Dia,
                        x.Mes,
                        x.Ano);
                    }
                    Console.ReadKey();
                }
            }
        }
    }
}
