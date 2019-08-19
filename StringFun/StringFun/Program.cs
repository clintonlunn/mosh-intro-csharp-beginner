using System;

namespace StringFun
{
    class Program
    {
        public static void Main(string[] args)
        {
            var firstName = "Clinton";
            var lastName = "Lunn";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "Clinton", "Rebecca", "Pepper" };
            var formattedNames = string.Join(", ", names);

            Console.WriteLine(formattedNames);
        }
    }
}
