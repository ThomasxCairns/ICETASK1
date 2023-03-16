using System;
namespace Program
{
    class Class1
    {
        static void Main(string[] args)
        {
            string s1 = "Happy";
            Console.WriteLine(s1.Length);
            Console.WriteLine(s1.Contains("a"));
            Console.WriteLine(s1.Insert(3, "a"));
            Console.WriteLine(s1.ToUpper());
            Console.WriteLine(s1.ToLower());
        }
    }
}