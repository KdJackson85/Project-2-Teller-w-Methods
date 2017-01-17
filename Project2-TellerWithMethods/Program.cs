using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_TellerWithMethods
{
    class Program
    {
        // private static string myString;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! I am Shaq Fu, and I will read you your fortune!");
            Console.WriteLine("Please type \"quit\" at anytime to quit.\n Or \"restart\" to restart!");

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            exitMethod(firstName);

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            exitMethod(lastName);

            userGreeting(firstName, lastName);

            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            

            int x = numberOfYears(age);

            Console.WriteLine("How many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine());

            string y = SibVacation(siblings);

            Console.WriteLine("You will retire in " + x + " years to a beautiful house in " + y);


            Console.WriteLine("What is your favorite ROYGBIV color. Not sure what that means? Just respond with the word \"help\"");
            string favColor = Console.ReadLine();
            exitMethod(favColor);






            Console.ReadKey();


        }
        // Greeting method
        static void userGreeting(string firstName, string lastName)

        {
          
                Console.WriteLine("Greetings " + firstName + " " + lastName + ", I will tell you your fortune!");
        
        }
        //Retirement Method
        static int numberOfYears(int age)
        {
        
            int retire;
            if (age % 2 == 0)
            {

                return (30);

            }
            else
            {
                return (5);
            }

        }


        //Vacation Home Method
        static string SibVacation(int siblings)
        {
            
            string vacation;


            if (siblings == 0)
            {
                vacation = "Maui!";

            }

            else if (siblings == 1)
            {
                vacation = "Paris, France!";
            }
            else if (siblings == 2)
            {

                vacation = ("Auckland, New Zealand!");
            }
            else if (siblings == 3)
            {

                vacation = ("Tokyo, Japan!");
            }
            else if (siblings >= 4)
            {
                return
                vacation = ("Your ex's parents backyard!");
            }
            else
            {
                return
                vacation = ("Montreal, Canada!");
            }
            return vacation;
        }

        //ROYGBIV Method


        static string RetireVehicle(string favColor)
        {

            string myString = "";

            if (favColor == "help")
            {
                Console.WriteLine("\"ROYGBIV\" stands for Red, Orange, Yellow,\n Green, Blue, Indigo, and Violet.");
                favColor = Console.ReadLine();
            }

            switch (favColor.ToUpper())
            {
                case "RED":
                    myString = ("Porche");
                    break;
                case "ORANGE":
                    myString = ("Harley Davidson");
                    break;
                case "YELLOW":
                    myString = ("Leer Jet");
                    break;
                case "GREEN":
                    myString = ("Recumbent bike");
                    break;
                case "BLUE":
                    myString = ("Jetpack");
                    break;
                case "INDIGO":
                    myString = ("18 wheeler");
                    break;
                case "VIOLET":
                    myString = ("Tesla");
                    break;
            }

            return myString;
        }
           //Money_in_bank Method 
            static double userMoney(int birthMonth)
            {
                
                float bank;

                if (birthMonth >= 1 && birthMonth <= 4)
                {
                    bank = 4.20f;
                }
                else if (birthMonth >= 5 && birthMonth <= 8)
                {
                    bank = 1.01f;
                }
                else if (birthMonth >= 9 && birthMonth <= 12)
                {
                    bank = 409.22f;
                }
                else
                {
                    bank = 0.0f;
                }

                return bank;

            }
            //Fortune Comment Method
            static void fortuneJudge()
            {

            Console.WriteLine("What a fantastic future you have on the horizon!");

            }
            //Exit Method
            static void exitMethod(string exitQuit)
            {
            string myVar = exitQuit.ToLower();
            if (myVar == "quit")
            {
                Console.WriteLine("Sorry to see you go. Please try again soon!");
                Environment.Exit(0);
            }
            else if (myVar == "restart")
            {
                
                string[] args = { };
                Console.Clear();
                Main(args);
                Environment.Exit(0);
            }
        }
    }
            

    }
}




