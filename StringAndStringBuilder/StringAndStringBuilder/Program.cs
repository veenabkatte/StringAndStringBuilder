using System;

namespace StringAndStringBuilder
{
    class Program
    {
        //  This program demo. how to use String API.
        static void Main(string[] args)
        {
            
           
                //  String is immutable.
                string myString = "This is a test string";
                myString = myString.ToLowerInvariant();
                //myString += "How are you";
                //  Access string with indexer
                Console.WriteLine($"char at index 1 is:{ myString[1]}");
                //  To get count of char. using Length prop.
                Console.WriteLine($"Length is :{myString.Length}");

                Console.WriteLine(myString.Contains(("test")) ? "test is present" : "test is not present");

                Console.WriteLine(myString.StartsWith("this") ? "it starts with This" : "it not starts with This");

                Console.WriteLine(myString.EndsWith("string") ? "it starts with string" : "it not starts with string");

                string substring = myString.Substring(0, 4);
                Console.WriteLine($"New string: {substring}");

                string myString1 = "This is a test string";
                myString1 = myString1.ToLowerInvariant();
                int result = String.Compare(myString1, myString);
                Console.WriteLine(result);
                Console.ReadLine();
            }
        }
    }

