using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC5_Password_8_ch
{
    public class RegexValidation
    {
        public void Regex1()
        {
            //writing the expression as we are needed
            string Pattern = "[a-z]{8,}";
            Console.WriteLine("Enter the Password");
            string Pass1 = Console.ReadLine();

            Func<string, bool> result = (pass0) => Regex.IsMatch(Pass1, Pattern); //The word matches the regex
            if (result(Pass1))
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
            RegexValidation ch = new RegexValidation();
            ch.Regex1();
            Console.ReadLine();
        }
    }
}

