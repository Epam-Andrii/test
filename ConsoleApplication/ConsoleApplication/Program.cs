using ConsoleApplication.Services;
using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var formater = new Formater();
            var name = Console.ReadLine();
            Console.WriteLine(formater.SayHello(name));
            Console.ReadLine();
        }
    }
}
