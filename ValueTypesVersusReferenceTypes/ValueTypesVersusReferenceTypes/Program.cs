using System;

namespace ValueTypesVersusReferenceTypes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // because this is a value type, it creates a copy of the value
            var a = 1;
            var b = a;
            b++;

            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            // because this is a reference type, it points to the same location in the heap
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;

            array2[0] = 13;

            Console.WriteLine(string.Format("array1: {0}, array2: {1}", array1[0], array2[0]));
        
        }
    }
}
