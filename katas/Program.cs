using System;
using System.Linq;
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

        public static string AlphabetPosition(string text)
        {
            var ans = string.Join(" ", text.Where(x => char.IsLetter(x))
                                  .Select(x => char.ToUpper(x) - 64));

            return ans.Trim();
        }

        public static int[,] MultiplicationTable(int size)
        {
            var ans = new int[size, size];

            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    ans[i - 1, j - 1] = i * j;
                }
            }

            return ans;
        }

        public static string BreakCamelCase(string str)
        {
            // complete the function
            StringBuilder sb = new StringBuilder();

            foreach (char c in str)
            {
                if (char.IsUpper(c))
                    sb.Append(' ');

                sb.Append(c);
            }

            return sb.ToString();
        }

        public static bool lovefunc(int flower1, int flower2)
        {
            //Moment of truth...
            if ((flower1 % 2 == 0 && flower2 % 2 != 0) || (flower1 % 2 != 0 && flower2 % 2 == 0))
                return true;

            return false;
        }

        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;

            vowelCount += str.Count(f => f == 'a');
            vowelCount += str.Count(f => f == 'e');
            vowelCount += str.Count(f => f == 'i');
            vowelCount += str.Count(f => f == 'o');
            vowelCount += str.Count(f => f == 'u');

            return vowelCount;
        }

        public static string AreYouPlayingBanjo(string name)
        {
            if (char.ToLower(name[0]).Equals('r'))
                return name + " plays banjo";
            else
                return name + " does not play banjo";
        }

        public static bool IsLeapYear(int year)
        {
            if (year % 4 == 0 && (year % 100 > 0 || year % 400 == 0))
                return true;
            return false;
        }

        public static int century(int number)
        {
            double cent = number / 100.00;

            if (number % 100 == 0)
                return (int)cent;
            else
                return (int)cent + 1;
        }

        public static int basicMath(String op, int v1, int v2)
        {
            switch (op)
            {
                case "+":
                    return v1 + v2;
                case "-":
                    return v1 - v2;
                case "*":
                    return v1 * v2;
                case "/":
                    return v1 / v2;
            }
            return 0;
        }

        public static String even_or_odd(int number)
        {
            //check if there is no remainder
            if (number % 2 == 0)
                return "Even";
            else
                return "Odd";
        }

    }
}

