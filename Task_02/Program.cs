using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Реализуйте шаблон NVI в собственной иерархии наследования
             */
            Console.WriteLine("DBConnection:");
            Connection connectionDB = new DBConnection();
            connectionDB.Check();

            Console.WriteLine("\nFTPConnection:");

            Connection connectionFTP = new FTPConnection();
            connectionFTP.Check();

            Console.ReadKey();
        }
    }

    class Connection
    {
        public void Check()
        {
            CheckInternet();
            CheckVPN();
            CheckConnection();
            Ping();
        }
        protected virtual void Ping()
        {
        }
        protected virtual void CheckConnection()
        {
        }
        protected virtual void CheckInternet()
        {
            Console.WriteLine("Проверка наличие интернета");
        }
        protected virtual void CheckVPN()
        {
            Console.WriteLine("Проверка подключения к VPN");
        }
    }

    class DBConnection : Connection
    {
        protected override void CheckConnection()
        {
            Console.WriteLine("Подключение к Database");
        }
    }
    class FTPConnection : Connection
    {
        protected override void CheckConnection()
        {
            Console.WriteLine("Подключение к FTP");
        }
        protected override void Ping()
        {
            Console.WriteLine("Проверить пинг на сервере");
        }

    }
}

