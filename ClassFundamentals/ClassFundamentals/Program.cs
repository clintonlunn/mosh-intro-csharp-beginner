using System;
using ClassFundamentals.Math;

namespace ClassFundamentals
{
    class Program
    {
        public static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            var calc = new Calculator();
            var result = calc.Add(1, 2);

            Console.WriteLine(result);
        }
    }
}
