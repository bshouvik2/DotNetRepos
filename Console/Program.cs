using System;


namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("enter your name:");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("my name is" + name);
            Console.WriteLine("enter frst no");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second no");
            double b = Convert.ToDouble(Console.ReadLine());
            int sum = Convert.ToInt32(a + b);
            Console.WriteLine("sum of name + a + b is " + sum);
            Console.ReadLine();

        }
    }
}
