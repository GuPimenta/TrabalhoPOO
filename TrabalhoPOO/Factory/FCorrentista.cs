using CLass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOO.Factory
{
    internal class FCorrentista
    {
        public int MenuCorrentista(int loop) 
        {
            while (loop != 0)
            {
                Console.Clear();
                Console.WriteLine("Menu de correntista");
                Console.WriteLine("1- Cadastrar correntista");
                Console.WriteLine("2- Editar correntista");
                Console.WriteLine("3- Remover correntista");
                Console.WriteLine("4- Vizualisar correntistas");
                Console.WriteLine("0- Retornar");
                Console.Write("Opção: ");
                loop = int.Parse(Console.ReadLine());

                switch (loop)
                {
                    case 0:
                        break;

                    case 1:
                        Cadastrar(loop);
                        break;

                    case 2:
                        Editar(loop);
                        break;

                    case 3:
                        Remover(loop);
                        break;
                }
            }
            return loop;
        }

        public int Cadastrar(int loop)
        {
            Correntista correntista = new Correntista();
            Console.WriteLine("Cadastro de correntista");
            Console.Write("ID: ");
            correntista.Correntista_id = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            correntista.Correntista_nome = Console.ReadLine();
            Console.Write("CPF: ");
            correntista.Correntista_cpf = Console.ReadLine();


            return loop;
        }

        public int Editar(int loop)
        {
            Correntista correntista = new Correntista();
            Console.WriteLine("Editar correntista");
            Console.Write("ID do correntista a ser alterado: ");
            correntista.Correntista_id = int.Parse(Console.ReadLine());
            Console.Write("Novo nome: ");
            correntista.Correntista_nome = Console.ReadLine();
            Console.Write("Novo CPF: ");
            correntista.Correntista_cpf = Console.ReadLine();
            return loop;
        }

        public int Remover(int loop)
        {
            Correntista correntista = new Correntista();
            Console.WriteLine("Remover correntista");
            Console.Write("ID do correntista a ser removido: ");
            correntista.Correntista_id = int.Parse(Console.ReadLine());
            return loop;
        }
    }
}
