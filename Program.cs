/*
 * Author: Isaac Cruz
 * Course: COMP003A
 * Purpose: looping statements
 */
namespace COMP003A.Assignment4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("for loop selection");
            Console.WriteLine("Output a right triangle based on user input");
            Console.WriteLine("".PadRight(50, '*'));

            Console.WriteLine("Enter a positive whole number: ");

            int limit = Convert.ToInt32(Console.ReadLine());
            
            string output = "#";

            for (int i = 0; i < limit; i ++)
            {
                Console.WriteLine(output);
                output += "#";
            }

            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("foreach selection");
            Console.WriteLine("Output all of the friends in an array");
            Console.WriteLine("".PadRight(50, '*'));

            string[] friends = new string[] { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe" };

            foreach (string friend in friends)
            {
                Console.WriteLine(friend);
            }


            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("do-while Section");
            Console.WriteLine("Output 0-50 by 5s");
            Console.WriteLine("".PadRight(50, '*'));

            int counter = 0;

            do
            {
                Console.WriteLine(counter += 5);
            }
            while (counter < 50);

            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("while Section");
            Console.WriteLine("Output 1-20 ");
            Console.WriteLine("If the number is divisible by 2, output Foo ");
            Console.WriteLine("If the number is divisible by 5, ouput Bar");
            Console.WriteLine("If the number is divisible by 2 & 5, output FooBar");
            Console.WriteLine("".PadRight(50, '*'));

            int counter2 = 1;
            while (counter2 <= 20)
            {
                if (counter2 == 2)
                    Console.WriteLine("Foo");

                else if (counter2 == 5)
                    Console.WriteLine("Bar");

                else if (counter2 == 2 && counter2 == 5)
                    Console.WriteLine("FooBar");

                else
                    Console.WriteLine(counter2);

                counter2 += 1;
            }

        }
    }
}
