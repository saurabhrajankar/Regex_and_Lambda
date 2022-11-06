using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC3_Enter_Email
{
    public class RegexValidation
    {
        public void Regex1()
        {
            //writing the expression as we are needed
            string Pattern = "^[a-z]{3}([.][a-z]{3})?@[a-z]{2}[.][a-z]{2}([.][a-z]{2})?";
            Console.WriteLine("Enter the Email");
            string email = Console.ReadLine();

            Func<string, bool> result = (email1) => Regex.IsMatch(email, Pattern); //The word matches the regex
            if (result(email))
            {
                Console.WriteLine("Email is valid");

            }
            else
            {
                Console.WriteLine("Email is invalid");

            }
        }
    }
    class main
    {
        static void Main(string[] args)
        {
            RegexValidation FirstTime = new RegexValidation();
            FirstTime.Regex1();
            Console.ReadLine();
        }
    }
}

