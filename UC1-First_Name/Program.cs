using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC1_First_Name
{
    public class RegexValidation
    {
        public void Regex1()
        {
            //writing the expression as we are needed
            string Pattern = "^[A-Z]{1}[A-Za-z]{2,}$";
            Console.WriteLine("Enter the FirstName");
            string firstname = Console.ReadLine();

            Func<string, bool> result = (firstname1) => Regex.IsMatch(firstname, Pattern);
            if (result(firstname))
            {
                Console.WriteLine("FirstNmae is valid");

            }
            else
            {
                Console.WriteLine("FirstNmae is invalid");

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
