using System;
using System.Collections.Generic;
using System.Text;

namespace StringAndStringBuilder
{
    //  This program demo hoe to use StringBuilder class.
    class StringBuilderDemo
    {
        static void Main()
        {
            StringBuilder stringBuilder = new StringBuilder("This is test string");
            Console.WriteLine($"Max Capacity of this string is:{stringBuilder.MaxCapacity}");
            Console.WriteLine($"Length is: {stringBuilder.Length}");

            stringBuilder.Append(" this is appended string");
            Console.WriteLine($"After appending string new string is: {stringBuilder}");

            stringBuilder.Insert(10, " this is inserted");
            Console.WriteLine($"After inserting string new string is: {stringBuilder}");

            StringBuilder stringBuilder1 = stringBuilder.Replace("test", "demo");

            Console.WriteLine($"After replacing test with demo:{stringBuilder1}");
            Console.ReadLine();
        }
    }
}
