using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many people are in your party?");
            int numberPeople = int.Parse(Console.ReadLine());

            Console.WriteLine("How much was dinner per person?");
            double costPerPerson = Convert.ToDouble(Console.ReadLine());
            
            double totalCost = numberPeople * costPerPerson;
            Console.WriteLine("Your total cost is: $" + totalCost);

            if (totalCost >= 50)
            {
                Console.WriteLine("You will receive a 10% discount");
                double newTotal = Math.Round(totalCost * .9, 2);
                Console.WriteLine("Your new total is: $" +newTotal);
            }
            else
            { Console.WriteLine("You will receive a 5% discount");
                double newTotal5 = Math.Round(totalCost * .95, 2);
                Console.WriteLine("Your new total is: $" + newTotal5);
            }
        }
    }
}
