using System;
using System.Text.RegularExpressions;

namespace ValidParentheses
{
    class Program
    {
        public static bool IsValid(string s)
        {
            var regex = new Regex(@"\((?:[^)(]+|\((?:[^)(]+|\([^)(]*\))*\))*\)");
            var match = regex.Match(s);

            if (match.Success)
                return true;
            else
                return false;
        }


        static void Main(string[] args)
        {
            var boolean = IsValid("{[]}");

            Console.WriteLine(boolean);
        }
    }
}
