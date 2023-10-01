using PolitechFalkovskiyD.BLL;
using PolitechFalkovskiyD.DAL;
using PolitechFalkovskiyD.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Runtime.InteropServices;

namespace PolitechFalkovskiyD.Online.View
{
    internal class Program
    {
        static string path = ConfigurationManager.
            ConnectionStrings["DefaultConnection"].
            ConnectionString;
        static void Main(string[] args)
        {
            FirstMenu();
        }
        public static void FirstMenu()
        {
            Console.Clear();
            Console.WriteLine("Выберите вариант: ");
            Console.WriteLine("1) Авторизация");
            Console.WriteLine("2) Регистрация");
            Console.WriteLine("3) Выход");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Authoriztion();
                    break;
                case 2:
                    Registration();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }
            
        }
        public static void Authoriztion()
        {
            Client client = new Client();
            Console.Write("Введите логин:" );
            client.Email = Console.ReadLine();
            Console.Write("Введите пароль: ");
            client.Password = Console.ReadLine();

            ServiceClient serviceClient = new ServiceClient(path);
            Client client = serviceClient.AuthorizationClient(client);
            if(client != null)
            {
                Console.WriteLine("Приветствую тебя, " + client.FullName);
            }
            else
            {
                Console.WriteLine("ТАкой пользователь не зарегестрирован");
                Thread.Sleep(2000);
                FirstMenu();
            }
        }
        public static void Registration() 
        {
            Client client = new Client();
            Console.Write("Введите логин:" );
            client.Email = Console.ReadLine();

            Console.Write("Введите пароль: ");
            client.Password = Console.ReadLine();

            Console.Write("Введите Имя: ");
            client.FName = Console.ReadLine();

            Console.Write("Введите Фамилию: ");
            client.FName = Console.ReadLine();

            Console.Write("Введите Отчество: ");
            client.FName = Console.ReadLine();

            ServiceClient serviceClient = new ServiceClient(path);
            var result = serviceClient.RegisterClient(client);
            if(result.isError)
            {
                Console.WriteLine(result.message);
            }
            else
            {
                Console.WriteLine("Все прошло успешно");
                Thread.Sleep(2000);
                FirstMenu();
            }
        }
    }
}
