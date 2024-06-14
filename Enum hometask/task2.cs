//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Reflection.Metadata;
//using System.Text;
//using System.Threading.Tasks;
////task2; Define an enum named TrafficLight.
////Write a method to parse a string and return the corresponding enum value.
////Handle invalid input gracefully.
//namespace Enum_hometask
//{
//    public enum TrafficLight
//    {
//        Red,
//        Yellow,
//        Green
//    }
//    public class TrafficLight2
//    {
//        public string GetName(string input)
//        {
//            if (Enum.TryParse(input, true, out TrafficLight light))
//            {
//                return Enum.GetName(typeof(TrafficLight), light);
//            }
//            else
//            {
//                return "It is not correct:";
//            }
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            TrafficLight2 obj = new TrafficLight2();
//            Console.WriteLine("Enter your input:");
//            string input=Console.ReadLine();
//            Console.WriteLine(obj.GetName(input));
//        }
//    }

//}
