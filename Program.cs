using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
             
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the password to be validated");
            string password = Console.ReadLine();
            
            if(ValidatePassword(password))
            {
                Console.WriteLine("Password is Valid");
            }
            else
            {
                Console.WriteLine("Password is invalid");
            }
        }

        private static bool ValidatePassword(string password)
        {
            bool hasNum = false;
            bool hasCap = false;
            bool hasSmall = false;
            bool hasSpe=false;
            bool hasSpace = false;
            char cc;

            if (password.Length < 8)
                return false;
            for (int i=0;i<password.Length;i++)
            {
                cc = password[i];
                if (char.IsDigit(cc))
                    hasNum = true;
                else if (char.IsLower(cc))
                    hasSmall = true;
                else if (char.IsUpper(cc))
                    hasCap = true;
                else if (!char.IsLetterOrDigit(cc))
                    hasSpe = true;
                else if (!char.IsWhiteSpace(cc))
                    hasSpace = true;
                if (hasNum && hasSmall && hasCap && hasSpe && hasSpace)
                    return true;
            }
            return false;

        }
    }
}
