using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassesAndMethods8523
{
    class Program
    {
        static void Main(string[] args)
        {
            Config.ConnectionTimeout = 5;
            Console.WriteLine(Config.ConnectionString + ", " + Config.ConnectionTimeout);

            Console.Write("Enter name: ");
            string input = Console.ReadLine();

            if(Utilities.Validate(input))
                Console.WriteLine("valid");
            else
                Console.WriteLine("not valid");

            Manager.Manager_static();
            Manager manager = new Manager();
            manager.Manage();

            Console.WriteLine(Database.name);

            Console.ReadLine();
        }
    }
    static class Config 
    {
        public static string ConnectionString => "SQL Server Connection String";
        public static int ConnectionTimeout { get; set; }
    }
    static class Utilities
    {
        public static bool Validate(string input) 
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;
            return true;
        }
    }
    class Manager 
    { 
        public static void Manager_static() 
        {
            Console.WriteLine("Manage static");
        }
        public void Manage() 
        {
            Console.WriteLine("Manage");
        }
    }
    static class Database
    {
        public static readonly string name;

        static Database()
        {
            name = "SQL Server";
        }
    }
}
