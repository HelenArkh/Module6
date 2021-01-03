using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Greetings();

            human = new Human("Дмитрий");
            human.Greetings();

            human = new Human("Дмитрий", 23);
            human.Greetings();

            Human human2 = new Human { name = "Дмитрий", age = 23 };
            human2.Greetings();

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
