using System;
using System.Text;

namespace kata
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

        public int DigitalRoot(long n)
        {
            if (n < 10)
                return Convert.ToInt32(n);

            long sum = 0;

            while (n > 0)
            {
                long dsum = n % 10;
                n = n / 10;

                sum += dsum;
            }

            return DigitalRoot((long)sum);
        }

        public static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;
            if (n == 2)
                return true;

            var limit = Math.Ceiling(Math.Sqrt(n));

            for (int i = 2; i <= limit; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }


        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            string number = "";

            foreach (int num in BinaryArray)
            {
                number = number + num.ToString();
            }
            return Convert.ToInt32(number, 2);
        }

        // return masked string
        public static string Maskify(string cc)
        {
            StringBuilder sb = new StringBuilder(cc);

            for (int i = 0; i < cc.Length - 4; i++)
                sb[i] = '#';

            return sb.ToString();
        }

        public static bool ValidatePin(string pin)
        {
            int i = 0;
            return (pin.Replace(" ", "").Length == 4 || pin.Replace(" ", "").Length == 6) && Int32.TryParse(pin, out i);
        }

        public static string LongestConsec(string[] strarr, int k)
        {
            if (strarr.Length == 0 || k > strarr.Length || k <= 0)
                return "";

            string longest = "";


            for (int i = 0; i <= strarr.Length - k; i++)
            {
                string testString = "";

                for (int j = i; j < i + k; j++)
                {
                    testString = testString + strarr[j];
                }

                if (longest.Length < testString.Length)
                    longest = testString;
            }

            return longest;
        }
    }
}

