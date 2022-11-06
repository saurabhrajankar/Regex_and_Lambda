using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC8_Password_Rule4
{
    public class RegexValidation
    {
        public void Regex1()
        {
            //writing the expression as we are needed
            string Pattern = "(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*]).{8}";
            Console.WriteLine("Enter the Password");
            string Pass4 = Console.ReadLine();

            Func<string, bool> result = (Pass0) => Regex.IsMatch(Pass4, Pattern); //The word matches the regex
            if (result(Pass4))
            {
                Console.WriteLine("Password is valid");

            }
            else
            {
                Console.WriteLine("Password is invalid");

            }
        }
    }
    class main
    {
        static void Main(string[] args)
        {
            RegexValidation pass = new RegexValidation();
            pass.Regex1();
            Console.ReadLine();
        }
    }
}




