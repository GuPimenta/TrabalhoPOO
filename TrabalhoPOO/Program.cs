using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using CLass;
using Factory;
using Microsoft.Data.Sqlite;

namespace TrabalhoPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            string database = "sqlite.db";
            string conection = $"DataSource={database};Version=3;";
            menu.Iniciar(-1, conection);
           
        }
    }
}
