using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("How many people are dining?");
            //int peopleDine = int.Parse(Console.ReadLine());

            //Console.WriteLine("How much did each person pay each?");
            //int payEach = int.Parse(Console.ReadLine());
            /////must calculate how many people are dining and how much each person is paying each.

            //double totalBill = peopleDine * payEach;

            //Console.WriteLine("The total of your bill is $" + totalBill);
            /////find out how much the bill is and see is its over or under $50 for the discount.
            /////+ totalBill will add a dollar sign in front of bill total.

            //int total = 50;
            //if(total >= 50)
            //{
            //    double discountTen = totalBill * .10d;

            //    Console.WriteLine("You will recieve a 10% discount of $" + discountTen);
            //    ///add dicsounts to subtotal of bill
            //}

            //else
            //{
            //    double discountFive = totalBill * .05d;

            //    Console.WriteLine("You will recieve a 5% discount of $" + discountFive);
            //    ////add discounts to subtotal of the bill
            //}
            //{
            //    double discount = totalBill * .10d;


            //    double grandTotal = totalBill - discount;
            //    Console.WriteLine("Your grandtotal with discount is $" + grandTotal);
            //    ///add + grandTotal to same statement to have $ in front of grandTotal.

          //  int age = int.Parse(Console.ReadLine());
          //  if (age <= 2) ;
          //  {
          //      Console.WriteLine("Still in Mamas arms");
          //  }
          //else if (3 <= 4) ;
          //  {
          //      Console.WriteLine("Preschool Maniac");
          //  }
          //else if ()
          //  {
          //      Console.WriteLine("Elementary School");
          //  }
          //else if ()
          //  { 
          //      Console.WriteLine("Middle School");
          //  }
          //else if ()
          //  {
          //      Console.WriteLine("High School");
          // }






            Console.WriteLine("Please enter a number");
            string userNumber = Console.ReadLine();
          switch(userNumber)
            {
                case "zero":
                    Console.WriteLine(0);
                    break;

                case "one":
                    Console.WriteLine(1);
                    break;

                case "two":
                    Console.WriteLine(2);
                    break;

                case "three":
                    Console.WriteLine(3);
                    break;

                case "four":
                    Console.WriteLine(4);
                    break;

                case "five":
                    Console.WriteLine(5);
                    break;

                case "six":
                    Console.WriteLine(6);
                    break;

                case "seven":
                    Console.WriteLine(7);
                    break;

                case "eight":
                    Console.WriteLine(8);
                    break;

                case "nine":
                    Console.WriteLine(9);
                    break;

                case "ten":
                    Console.WriteLine(10);
                    break;

                default:
                    Console.WriteLine("invalid");
                    break;
            }


































        }
    }
}