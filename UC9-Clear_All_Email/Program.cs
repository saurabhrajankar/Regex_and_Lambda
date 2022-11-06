using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC9_Clear_All_Email
{
    public class RegexValidation
    {
        public void Regex1()
        {
            //writing the expression as we are needed
            string Pattern = "^[a-z A-Z 0-9_]+[@][a-z]+.[a-z]{2,3}";
            Console.WriteLine("Enter the Password");
            string email2 = Console.ReadLine();

            Func<string, bool> result = (email1) => Regex.IsMatch(email2, Pattern); //The word matches the regex
            if (result(email2))
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
            RegexValidation email = new RegexValidation();
            email.Regex1();
            Console.ReadLine();
        }
    }
}


