using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace RegexExceptionHandling
{
    public class UserRegistration
    {
        public string data;

        public UserRegistration(string data) 
        {
            this.data = data;
        }

        public string ValidFirstName()
        {
            try
            {
                string namePattern = "^[A-Z]{1}[A-Za-z]{3,}$";
                Regex regexObj = new Regex(namePattern);

                if (regexObj.IsMatch(data))
                {
                    Console.WriteLine("\nEntered input is correct!");
                    return this.data;
                }
                else
                {
                    Console.WriteLine("\nEntered input is incorrect!");
                    return "Invalid";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
