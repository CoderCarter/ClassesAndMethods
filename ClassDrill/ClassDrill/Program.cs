using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Number x = new Number();
            x = Addition(x);
            Console.WriteLine("Your number added to istelf is... " + x.Value + "! Press enter for the next step!");
            Console.ReadLine();
            x = Multiply(x);
            Console.WriteLine("Your number multiplied by  istelf is... " + x.Value +"! Press enter for the next step!");
            Console.ReadLine();
            x = divide(x);
            Console.WriteLine("Your number divided in half is... " + x.Value + "! Thanks for playing!");
            Console.ReadLine();

        }
        public static Number Addition(Number x)
        {
            Console.WriteLine("Please enter a number.");
            int y = Convert.ToInt32(Console.ReadLine());

            x.Value = y + y;
            return x;
        }
        public static Number Multiply(Number x)
        {
            Console.WriteLine("Please enter a number.");
            int y = Convert.ToInt32(Console.ReadLine());

            x.Value = y * y;
            return x;
        }
        public static Number divide(Number x)
        {
            Console.WriteLine("Please enter a number.");
            int y = Convert.ToInt32(Console.ReadLine());

            x.Value = y / 2;
            return x;
        }

    }
    

}
