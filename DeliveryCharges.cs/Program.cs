using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeliveryCharges.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] validValues = { 101, 108, 201, 213, 266304, 311, 409, 411, 412 };
            double[] prices = { 0.89, 1.23, 3.50, 0.69, 5.79, 3.19, 0.99, 0.89, 1.26, 8.00 };
            int itemOrdered;
            bool isValidItem = false;
            Console.Write("Please enter an item");
            itemOrdered = Convert.ToInt32(Console.ReadLine());
            for (int x = 0; x < validValues.Length; ++x)
            {
                if (itemOrdered == validValues[x])
                {
                    isValidItem = true;
                    itemPrice = prices[x];
                }
            }
            if (isValidItem)
                Console.WriteLine("Price is {0}", itemPrice);
            else
                Console.WriteLine("Sorry - item not found");
        }
    }
}
