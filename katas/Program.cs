using System;

namespace katas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GroupByCommas(2333333));
        }

        public static string GroupByCommas(int n)
        {
            return n.ToString("n0");
        }

        public static string Likes(string[] name)
        {
            if (name.Length == 0)
                return "no one likes this";
            else if (name.Length == 1)
                return name[0] + " likes this";
            else if (name.Length == 2)
                return name[0] + " and " + name[1] + " like this";
            else if (name.Length == 3)
                return name[0] + ", " + name[1] + " and " + name[2] + " like this";

            return name[0] + ", " + name[1] + " and " + (name.Length - 2).ToString() + " others like this";
        }
    }
}
