using System;
using System.Text.RegularExpressions;

namespace StringAndStringBuilder
{
    class RegexDemo
    {
        static void Main()
        {
            Console.WriteLine("Please Enter your Email Id:");
            string email = Console.ReadLine();

            string regexPattern = @"(^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$)";

            Regex emailRegex = new Regex(regexPattern);
            Console.WriteLine(emailRegex.IsMatch(email) ? "This is valid email" : "This is not valid email");
            Console.ReadLine();
        }
    }
}
