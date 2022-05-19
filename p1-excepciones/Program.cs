using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1_excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
                Console.ReadKey();

            }
            catch (DivideByZeroException e)
            {
                Console.Write(e.Message);
                Console.ReadKey();
            }
            catch (FormatException e)
            {
                Console.Write(e.Message);
                Console.ReadKey();
            }
        }
    }
}
