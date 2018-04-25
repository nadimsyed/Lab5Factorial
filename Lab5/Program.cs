using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Factorial Factory(Calculator)!!");

            while (true)
            {
                Console.Write("Enter an integer that's greater than 0 but less than 20:  ");

                string input = Console.ReadLine();

                bool converted = long.TryParse(input, out long num);

                if (converted)
                {
                    long factorial = 0;
                    long total = 0;
                    for (long i = 1; i <= num; i++)
                    {
                        factorial = num;
                        for (long j = (num -1); j > 0; j--)
                        {
                            factorial *= --num;
                        }
                    }
                    total += factorial;
                    Console.WriteLine($"The factorial of {input} is {total}" );
                }
                else
                {
                    Console.WriteLine("User input is incorrect, Please try again.");
                }

                Console.Write("Continue? (y/n): ");
                var yep = Console.ReadLine();
                bool quitter = char.TryParse(yep, out char quitter2);
                if (quitter2 == 'N' || quitter2 == 'n')
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            
        }
    }
}
