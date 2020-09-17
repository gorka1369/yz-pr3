using System;
using System.Text.RegularExpressions;

namespace yz_pr3
{
    class Program
    {
        static bool IsPhone(string s)
        {
            return Regex.IsMatch(s, @" ^\+7[\s\(]?{ 3}[\s\)]? [\s\-]?d{3}[\-\s]?\d{2}[\-\s]?\d{2}$");
        }
        static bool IsZip(string s)
        {
            return Regex.IsMatch(s, @" ^\d{5}(\-\d{4})?$");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsPhone("+7(926)269-25-11"));
            

        }
    }
}
