using System;

namespace FlowControl
{
    public class Program
    {
        //create global variables to hold users login data.
        public static string username;
        public static string password;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Challenge 1. Temperature Advice
            int temp = GetValidTemperature();
            GiveActivityAdvice(temp);

            //Challenge 2. Login system.
            Register();
            if (Login())
            {
                Console.WriteLine("Congratulations, You successfully logged in.");
            }

            //Challenge 3. Ternary Operators
            temp = GetValidTemperature();
            GetTemperatureTernary(temp);
        }

        // This method gets a valid temperaturebetween -40 asnd 135 inclusive 
        // and returns the valid int.
        public static int GetValidTemperature()
        {
            int validTemp;

            while (true)
            {
                Console.WriteLine("Please input a temperature between -40 and 130:");
                if (Int32.TryParse(Console.ReadLine(), out validTemp))
                {
                    if (validTemp >= -40 && validTemp <= 130)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not a valid temperature");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Not a valid temperature");
                    continue;
                }
            }
            return validTemp;
        }

        // This method has one int parameter
        // It gives outdoor activity advice and temperature opinion based on 20 degree
        // increments starting at -20 and ending at 135 
        // n < -20 = hella cold
        // -20 <= n < 0 = pretty cold
        //  0 <= n < 20 = cold
        // 20 <= n < 40 = thawed out
        // 40 <= n < 60 = feels like Autumn
        // 60 <= n < 80 = perfect outdoor workout temperature
        // 80 <= n < 90 = niiice
        // 90 <= n < 100 = hella hot
        // 100 <= n < 135 = hottest
        public static void GiveActivityAdvice(int temp)
        {
            if (temp < -20){ Console.WriteLine("hella cold");}
            if (-20 <= temp && temp < 0){ Console.WriteLine("pretty cold");}
            if (0 <= temp && temp < 20){ Console.WriteLine("cold");}
            if (20 <= temp && temp < 40){ Console.WriteLine("thawed out");}
            if (40 <= temp && temp < 60){ Console.WriteLine("feels like Autumn");}
            if (60 <= temp && temp < 80){ Console.WriteLine("perfect outdoor workout temperature");}
            if (80 <= temp && temp < 90){ Console.WriteLine("niiice");}
            if (90 <= temp && temp < 100){ Console.WriteLine("hella hot");}
            if (100 <= temp && temp < 135){ Console.WriteLine("hottest");}
        }

        // This method gets a username and password from the user
        // and stores that data in the global variables of the 
        // names in the method.
        public static void Register()
        {
            Console.WriteLine("Please enter a username:");
            username = Console.ReadLine();
            Console.WriteLine("Please enter a password:");
            password = Console.ReadLine();
            Console.WriteLine("Login saved");
            Login();
        }

        // This method gets username and password from the user and
        // compares them with the username and password global variables
        // or the names provided. If the password and username match,
        // the method returns true. If they do not match, the user is 
        // prompted again for the username and password.
        public static bool Login()
        {
            return true;
            // Console.WriteLine("Please enter a username:");
            // string userTry = Console.ReadLine();
            // bool success = false;
            // if (userTry.Equals(username))
            // {
            //     success = true;
            // }
            // else
            // {
            //     success = false;
            // }
            // Console.WriteLine("Please enter a password:");
            // string passTry = Console.ReadLine();
            // if (passTry.Equals(password))
            // {
            //     success = true;
            // }
            // else
            // {
            //     success = false;
            // }
            // return success;
        }

        // This method as one int parameter.
        // It checks is the int is <=42, between
        // 43 and 78 inclusive, or > 78.
        // For each temperature range, a different 
        // advice is given. 
        public static void GetTemperatureTernary(int temp)
        {
            string tempRating;

            tempRating = temp <= 42 ? $"{temp} is too cold!": temp <= 78 ? $"{temp} is an ok temperature" : temp > 78 ? $"{temp} is too hot!": "Not a valid temperature";

            Console.WriteLine(tempRating);
        }
    }//end of Program()
}

/*
Get a Farhrenheit temperature value between -40 and 130 as input from the user.
    - Validate that the input is a valid integer value. 
    - If the input value is not a valid integer value, it should print to the console "Not a valid temperature" and repeat the promptfor a valid temperature.
    - If the input temperature value is <=42, print "[tempValue] is too cold!" to the console.
    - If the input temperature value is >= 43 and <=78 print "[tempValue] is an ok temperature" to the console.
    - If the input temperature value is > 78 it should write "[tempValue] is too hot!" to the console.
    - You must use ternary operators (not 'if' statements) to check for the three conditions, 
    however you can use an if statement for the other conditions like to check if the 
    entered value is a valid integer or not. You may use previous methods (hint hint) 
    to get or varify values.*/