using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            // Setter
            user.Age = 15;

            // Getter
            Console.WriteLine(user.Age);

            Console.ReadKey();
        }

        static void Method()
        {
            var x = 1;
            int y = 2;
            // 2
        }
    }
}
