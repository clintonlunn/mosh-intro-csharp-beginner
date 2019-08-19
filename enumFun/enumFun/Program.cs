using System;

namespace enumFun
{
    enum ShippingMethod
    {

        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = (ShippingMethod)method;
            Console.WriteLine(methodId);


            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(methodName);
        }
    }
}
