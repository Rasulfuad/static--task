using Examples.Models;
using System;

namespace Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Console.WriteLine($"Id {p1.Id} Count {Person.Count}");
            Person p2 = new Person();
            Console.WriteLine($"Id {p2.Id} Count {Person.Count}");
            Person p3 = new Person();
            Console.WriteLine($"Id {p3.Id} Count {Person.Count}");
            Person.Count = 10;
            p1.Info();
            Console.WriteLine(Person.Count);

            Getinfo();

            Console.WriteLine(Test.Id);
        }

        static public void Getinfo()
        {

        }
        
    }
}
