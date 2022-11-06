using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC2_Last_Name
{
    public class RegexValidation
    {
        public void Regex1()
        {
            //writing the expression as we are needed
            string Pattern = "^[A-Z]{1}[A-Za-z]{2,}$";
            Console.WriteLine("Enter the LastName");
            string lastname = Console.ReadLine();

            Func<string, bool> result = (LastName1) => Regex.IsMatch(lastname, Pattern); //The word matches the regex
            if (result(lastname))
            {
                Console.WriteLine("LastName is valid");

            }
            else
            {
                Console.WriteLine("LastName is invalid");

            }
        }
    }
    class main
    {
        static void Main(string[] args)
        {
            RegexValidation LastName = new RegexValidation();
            LastName.Regex1();
            Console.ReadLine();
        }
    }
}
