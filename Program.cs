using System;

namespace ArithmaticOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number");
            int numbe1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            int number2 = int.Parse(Console.ReadLine());
            int Add = numbe1 + number2;
            int sub = numbe1 - number2;
            int mul = numbe1 * number2;
            float div = (float)numbe1 / number2;
            int mod = numbe1 % number2;
            Console.WriteLine("Sum of two number is :{0}",Add);
            Console.WriteLine("Subtraction of two number is :{0}",sub);
            Console.WriteLine("multiple of two number is :{0}",mul);
            Console.WriteLine("Division of two number is :{0}",div);
            Console.WriteLine("Mod of two number is :{0}",mod);
            Console.ReadKey();
        }
    }
}
