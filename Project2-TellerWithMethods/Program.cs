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
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

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






            Console.ReadKey();





            //Console.WriteLine("What month were you born? (\"1-12\")");
            //int birthMonth = int.Parse(Console.ReadLine());
            //float bank;

            //if (birthMonth >= 1 && birthMonth <= 4)
            //{
            //    bank = 4.20f;
            //}
            //else if (birthMonth >= 5 && birthMonth <= 8)
            //{
            //    bank = 1.01f;
            //}
            //else if (birthMonth >= 9 && birthMonth <= 12)
            //{
            //    bank = 409.22f;
            //}
            //else
            //{
            //    bank = 0.0f;
            //}


            ////final statement

            //Console.WriteLine(firstName + " " + lastName + "," + " your fortune is..." + retire + " With $" + bank + " million dollars in the bank," + "\n" + "a vacation home in " + vacation + ", and " + newColor + ".");

            //Console.WriteLine("Thank you for playing!");

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
        static string FavoriteColor(string favColor);
        //favColorCaps = favColor.ToUpper();

            switch (favColorCaps)

                case "RED":
                    newColor = ("you'll man a raft");
                    break;
                case "ORANGE":
                    newColor = ("you'll drive a Ferrari");
                    break;
                case "YELLOW":
                    newColor = ("you'll drive a Jeep");
                    break;
                case "GREEN":
                    newColor = ("you'll drive a new Tesla");
                    break;
                case "BLUE":
                    newColor = ("you'll fly in a Private Jet");
                    break;
                case "INDIGO":
                    newColor = ("you'll water whip on a hot jet ski dog");
                    break;
                case "VIOLET":
                    newColor = ("you'll ride a recumbent bike");
                    break;

    }

}




