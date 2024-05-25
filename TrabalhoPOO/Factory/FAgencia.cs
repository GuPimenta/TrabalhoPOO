using CLass;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class FAgencia
    {
        public int MenuAgencia(int loop, string connection)
        {
            while (loop != 0)
            {
                Console.Clear();
                Console.WriteLine("Menu da agência");
                Console.WriteLine("1- Cadastrar agência");
                Console.WriteLine("2- Editar agência");
                Console.WriteLine("3- Remover agência");
                Console.WriteLine("4- Vizualisar agências");
                Console.WriteLine("0- Retornar");
                Console.Write("Opção: ");
                loop = int.Parse(Console.ReadLine());

                switch (loop)
                {
                    case 0:
                        break;

                    case 1:
                        Cadastrar(loop, connection);
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

        public int Cadastrar(int loop, string connection)
        {
            Agencia agencia = new Agencia();
            Console.WriteLine("Cadastro de agência");
            Console.Write("ID da agéncia: ");
            agencia.Agencia_id = int.Parse(Console.ReadLine());
            Console.Write("Nome da agência: ");
            agencia.Agencia_nome = Console.ReadLine();
            Console.Write("Numero da agência: ");
            agencia.Agencia_num = int.Parse(Console.ReadLine());

            using (var cntx = new SqliteConnection(connection))
            {
                cntx.Open();
                string query = "INSERT INTO agencia VALUES(@id,@nome,@num)";
                using (var cmd = new SqliteCommand(query, cntx))
                {
                    cmd.Parameters.AddWithValue("@nome", agencia.Agencia_id);
                    cmd.Parameters.AddWithValue("@cpf", agencia.Agencia_nome);
                    cmd.Parameters.AddWithValue("@cpf", agencia.Agencia_num);
                    cmd.ExecuteNonQuery();

                }

            }


            return loop;
        }

        public int Editar(int loop)
        {
            Agencia agencia = new Agencia();
            Console.WriteLine("Editar agência");
            Console.Write("ID da agéncia a ser alterada: ");
            agencia.Agencia_id = int.Parse(Console.ReadLine());
            Console.Write("Novo nome da agência: ");
            agencia.Agencia_nome = Console.ReadLine();
            Console.Write("Novo numero da agência: ");
            agencia.Agencia_num = int.Parse(Console.ReadLine());
            return loop;
        }

        public int Remover(int loop)
        {
            Agencia agencia = new Agencia();
            Console.WriteLine("Remover agência");
            Console.Write("ID da agência a ser removida: ");
            agencia.Agencia_id = int.Parse(Console.ReadLine());
            return loop;
        }

    }
}
