using System;
namespace Examples.Models
{
    internal class Person
    {
        public string Name { get; set; }
        public int Surname { get; set; }
        public static int Count;
        public int Id;
        static Person()
        {
            Console.WriteLine("static cons 1 defe ishledi ");
            Count++;
        }
        public Person()
        {
            Count++;
            Id++;
        }

        public void Info()
        {
            Count = 10;
        }
    }
    static class Test
    {

        public static int Id { get; set; }

        static Test()
        {
            
            Console.WriteLine("Static constructor ishledi");
        }
        public static void Info()
        {

        }
    }
}
