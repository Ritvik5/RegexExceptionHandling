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

        public string ValidLastName()
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

        public string ValidEmail()
        {
            try
            {
                string emailPattern = "^[A-Za-z0-9]+([-_.+][A-Za-z0-9]+)?[@][A-Za-z]+[.][A-Za-z]{2,3}([.][a-z]{2})?$";
                Regex regexObj = new Regex(emailPattern);
                if (regexObj.IsMatch(this.data))
                {
                    Console.WriteLine("\nEntered input is correct!");
                    return this.data;
                }
                else
                {
                    Console.WriteLine("\nEntered Input is incorrect!");
                    return "Invalid";
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public string ValidMobileNumber()
        {
            try
            {
                string numberPattern = "^91[ ][6-9][0-9]{9}$";
                Regex regexObj = new Regex(numberPattern);
                if (regexObj.IsMatch(this.data))
                {
                    Console.WriteLine("\nEntered input is correct!");
                    return this.data;
                }
                else
                {
                    Console.WriteLine("\nEntered Input is incorrect!");
                    return "Invalid";
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public string ValidPassword()
        {
            try
            {
                string passPattern = "^(?=.*[A-Z])(?=.*[0-9])(?!.*[!@#$_].*[!@#$_])[A-Za-z0-9!@#$%_]{8,}$";
                Regex regexObj = new Regex(passPattern);
                if (regexObj.IsMatch(this.data))
                {
                    Console.WriteLine("\nEntered input is correct!");
                    return this.data;
                }
                else
                {
                    Console.WriteLine("\nEntered Input is incorrect!");
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
