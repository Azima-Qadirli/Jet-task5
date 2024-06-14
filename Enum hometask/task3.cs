using Enum_hometask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Enum_hometask
{
// 3)Coffee Size Enum:
//Defines an enum CoffeeSize with values representing different sizes of coffee.(example:Small,Medium)

//CoffeeShop Class:
//Contains static methods GetPrice(CoffeeSize size) to retrieve the price of a given coffee size(you can use switch case >> case CoffeeSize.Small ), and CalculateTotalCost(CoffeeSize size, int quantity) to calculate the total cost based on size and quantity.

//Main Program:
//Demonstrates usage by selecting a medium-sized coffee and calculating the total cost for ordering two coffees.
//    public  enum CoffeeSize
//    {
//        Small=1,
//        Medium,
//        Large
//    }
//    //switch case yazildigina gore;
//    public class CoffeeShop
//    {
//        public static int GetPrice(CoffeeSize size)
//        {
//           switch(size)
//            {
//                case CoffeeSize.Small:
//                    return 1;
//                    //break;
//                case CoffeeSize.Medium:
//                    return 2;
//                    //break;
//                case CoffeeSize.Large:
//                    return 3;
//                    default:
//                    return 0;

//            }
//        }
//        public static string CalculateTotalCost(CoffeeSize size, int quantity)
//        {
//            return $"The total cost based on size and quantity will be {size}*{quantity}" ;
//        }

//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine(CoffeeShop.CalculateTotalCost(CoffeeSize.Medium,2));
//    }
}