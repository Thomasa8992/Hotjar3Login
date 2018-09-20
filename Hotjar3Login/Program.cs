using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotjar3Login
{
    class Program
    {
        static void Main(string[] args)
        {
            GetLogin();
        }
        static void GetLogin()
        {
            int tries = 3;
            int counter = 0;
            bool success = false;
            string userName;
            string password;
            while (counter < 4)
            {
                if (counter == 3 && success != true)
                {
                    counter = 0;
                    Console.WriteLine("Rejected");
                    Console.WriteLine("Press any key to try again.");
                    Console.ReadKey();
                }
                else if (success == true)
                {
                    success = false;
                    Console.WriteLine("Success");
                    Console.WriteLine("Press any key to login again.");
                    Console.ReadKey();
                }
                else
                {
                    Console.Write("Username: ");
                    userName = Console.ReadLine();
                    if(String.IsNullOrEmpty(userName))
                    {
                        Console.WriteLine("Please enter a user name");
                        Console.Write("Username: ");
                        userName = Console.ReadLine();
                    }
                    Console.Write("Password: ");
                    password = Console.ReadLine();
                    if (String.IsNullOrEmpty(password))
                    {
                        Console.WriteLine("Please enter a password");
                        Console.Write("Password: ");
                        password = Console.ReadLine();
                    }

                    if (userName != "adrian" && password != "password")
                    {
                        counter++;
                        Console.WriteLine("User Name or Password is not correct");
                        Console.WriteLine(counter != 3 ? "You have " + (tries - counter) + " remaining attempts" : "You are out of attempts");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                    }
                    else
                    {
                        success = true;
                    }
                    
                }
            }
        }
        //static void CheckNullOrEmpty(string value)
        //{
        //    if (value == "" || value == "null")
        //    {
        //        true;
        //    }
        //}
    }
}
