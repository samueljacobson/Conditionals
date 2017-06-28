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
            //Console.WriteLine("How many people are in your party?");
            //int numberPeople = int.Parse(Console.ReadLine());

            //Console.WriteLine("How much was dinner per person?");
            //double costPerPerson = Convert.ToDouble(Console.ReadLine());

            //double totalCost = numberPeople * costPerPerson;
            //Console.WriteLine("Your total cost is: $" + totalCost);

            //if (totalCost >= 50)
            //{
            //    Console.WriteLine("You will receive a 10% discount");
            //    double newTotal = Math.Round(totalCost * .9, 2);
            //    Console.WriteLine("Your new total is: $" +newTotal);
            //}
            //else
            //{ Console.WriteLine("You will receive a 5% discount");
            //    double newTotal5 = Math.Round(totalCost * .95, 2);
            //    Console.WriteLine("Your new total is: $" + newTotal5);
            //}
            //    Console.WriteLine("What is your age?");
            //    int age = int.Parse(Console.ReadLine());
            //        if (age >= 0 && age <= 2)
            //        {
            //            Console.WriteLine("Still in Mama's Arms");
            //        }
            //        else if (age >= 3 && age <= 5)
            //        {
            //            Console.WriteLine("Preschool Maniac");
            //        }
            //        else if (age >= 5 && age <= 11) 
            //        {
            //            Console.WriteLine("Elementary School");
            //        }
            //        else if (age >= 12 && age <= 14)
            //        {
            //            Console.Write("Middle School");
            //        }
            //        else if (age >= 15 && age <= 18)
            //        {
            //            Console.Write("High School");
            //        }
            //        else if (age >= 19 && age <= 22)
            //        { Console.WriteLine("College");
            //        }


            //}
            //}
            Console.WriteLine("Enter a number from zero to ten as a word.");

            string digit = Console.ReadLine();
            switch (digit)
            {
                case "zero":
                    Console.WriteLine("0");
                    break;

                case "one":
                    Console.WriteLine("1");
                    break;

                case "two":
                    Console.WriteLine("2");
                    break;

                case "three":
                    Console.WriteLine("3");
                    break;

                case "four":
                    Console.WriteLine("4");
                    break;

                case "five":
                    Console.WriteLine("5");
                    break;

                case "six":
                    Console.WriteLine("6");
                    break;

                case "seven":
                    Console.WriteLine("7");
                    break;

                case "eight":
                    Console.WriteLine("8");
                    break;

                case "nine":
                    Console.WriteLine("9");
                    break;

                case "ten":
                    Console.WriteLine("10");
                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
