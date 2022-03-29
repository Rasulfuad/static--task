using System;
using static_task.Models;

namespace static_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Say daxil edin");
            int  = Convert.ToInt32(Console.ReadLine());
            User num1 = new User();
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("password daxil et");
                string password = Console.ReadLine();

                Console.WriteLine("maili daxil edin");
                string email = Console.ReadLine();

                Console.WriteLine("Adi daxil edin");
                string fullame = Console.ReadLine();

                Console.WriteLine("Id daxil edin");
                int id = Convert.ToInt32(Console.ReadLine());


                num1.ShowInfo();

                Console.WriteLine(num1.PasswordChecker(password));

            }
        }

    }
     interface IAccount
    {
        string PasswordChecker(string password);
        void ShowInfo();
    }
}
