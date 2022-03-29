using System;
using examples_Extention.Helper;
namespace examples_Extention
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "lorem";
            //  Console.WriteLine(Extention.Reverse(word));
            Console.WriteLine(word.Reverse());
            int num = 10;
            num.Pow(3);
        }
    }
}
