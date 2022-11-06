using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC6_Password_UC
{
    public class RegexValidation
    {
        public void Regex1()
        {
            //writing the expression as we are needed
            string Pattern = "[A-Z]{1}[a-z]{8,}";
            Console.WriteLine("Enter the Password");
            string Pass2 = Console.ReadLine();

            Func<string, bool> result = (email1) => Regex.IsMatch(Pass2, Pattern); //The word matches the regex
            if (result(Pass2))
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
            RegexValidation email = new RegexValidation();
            email.Regex1();
            Console.ReadLine();
        }
    }
}


