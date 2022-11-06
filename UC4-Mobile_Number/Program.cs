using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC4_Mobile_Number
{
    public class RegexValidation
    {
        public void Regex1()
        {
            //writing the expression as we are needed
            string Pattern = "^[0-9]{2}\\s[0-9]{10}$";
            Console.WriteLine("Enter the MobileNumber");
            string Mobile = Console.ReadLine();

            Func<string, bool> result = (MN0) => Regex.IsMatch(Mobile, Pattern); //The word matches the regex
            if (result(Mobile))
            {
                Console.WriteLine("MobileNumber is valid");

            }
            else
            {
                Console.WriteLine("MobileNumber is invalid");

            }
        }
    }
    class main
    {
        static void Main(string[] args)
        {
            RegexValidation MN = new RegexValidation();
            MN.Regex1();
            Console.ReadLine();
        }
    }
}
