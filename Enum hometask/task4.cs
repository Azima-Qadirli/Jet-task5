//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Threading.Channels;
//using System.Threading.Tasks;
////4)Bonus: Write a method which checks a number is Palindrome or not.
//namespace Enum_hometask
//{
//    public class task4
//    {

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter your number:");
//            int number=Convert.ToInt32(Console.ReadLine());
//            if (IsPalindrome(number))
//            {
//                Console.WriteLine("Your entered number is palindrome:");
//            }
//            else
//            {
//                Console.WriteLine("Unfortunately, your number is not palindrome:");
//            }

//        }
//        public static bool IsPalindrome(int number)
//        {
//            int temp = number;
//            int palindrome = 0;
//            int remainder ;
//            while (number > 0)
//            {
//                remainder = number % 10;
//                palindrome=(palindrome*10)+remainder;
//                number = number / 10;
//            }
//            return temp == palindrome;
//        }
//    }
//}
