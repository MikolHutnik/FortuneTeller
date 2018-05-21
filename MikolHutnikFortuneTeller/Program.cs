using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikolHutnikFortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable list.
            string resultMonth;
            string resultVacay;
            string result;
            string retirementAge;
            int ageResponse;
            int birthMonth;
            int siblings;

            //Asking for user input of First Name.
            Console.WriteLine("What's your first name?");

            string firstNameResponse = Console.ReadLine().ToUpper();

            //Asking user input of Last Name
            Console.WriteLine("What's your last name?");
            string lastNameResponse = Console.ReadLine().ToUpper();

            //Asking user input of Age/ calculating retirement

            Console.WriteLine("What's your age?");
            ageResponse = int.Parse(Console.ReadLine());
            if ((ageResponse % 2) == 0)
            {
                retirementAge = "45";
            }

            else
            {
                retirementAge = "70";
            }

            //Asking user input of Birth Month
            Console.WriteLine("What's your birth month? Please enter in number format.");
            // string inputBirthMonth;
            //string birthMonthResponse = Console.ReadLine();

            birthMonth = int.Parse(Console.ReadLine());

            //Switch statement for amount of money based on birth month.
            switch (birthMonth)
            {

                case 1:
                    resultMonth = "$100.00";
                    break;
                case 2:
                    resultMonth = "$100.00";
                    break;
                case 3:
                    resultMonth = "$100.00";
                    break;
                case 4:
                    resultMonth = "$100.00";
                    break;

                case 5:
                    resultMonth = "$500.00";
                    break;
                case 6:
                    resultMonth = "$500.00";
                    break;
                case 7:
                    resultMonth = "$500.00";
                    break;
                case 8:
                    resultMonth = "$500.00";
                    break;

                case 9:
                    resultMonth = "$1000.00";
                    break;
                case 10:
                    resultMonth = "$1000.00";
                    break;
                case 11:
                    resultMonth = "$1000.00";
                    break;
                case 12:
                    resultMonth = "$1000.00";
                    break;

                default:
                    resultMonth = "$0.00";
                    break;

            }

            //Asking for user input of favorite color 
            //and implimenting HELP menue.
            Console.WriteLine("Please choose a color from ROYGBIV. Please type help for assistance.");
            string rOYGBIVResponse = Console.ReadLine().ToLower();

            switch (rOYGBIVResponse)
            {

                case "red":
                    result = "Ford Mustang";
                    break;
                case "orange":
                    result = "Dodge Charger";
                    break;
                case "yellow":
                    result = "Lamborghini Diablo";
                    break;
                case "green":
                    result = "Astin Martin Vanquish";
                    break;
                case "blue":
                    result = "Koenigsegg Agera R";
                    break;
                case "indigo":
                    result = "Bugatti Veyron";
                    break;
                case "violet":
                    result = "Ferrari F-430";
                    break;
                case "help":
                    result = "Please choose a color from Red, Orange, Yellow, Green, Blue, Indigo, Violet";
                    Console.WriteLine(result);
                    rOYGBIVResponse = Console.ReadLine().ToLower();

                    switch (rOYGBIVResponse)
                    {
                        case "red":
                            result = "Ford Mustang";
                            break;
                        case "orange":
                            result = "Dodge Charger";
                            break;
                        case "yellow":
                            result = "Lamborghini Diablo";
                            break;
                        case "green":
                            result = "Astin Martin Vanquish";
                            break;
                        case "blue":
                            result = "Koenigsegg Agera R";
                            break;
                        case "indigo":
                            result = "Bugatti Veyron";
                            break;
                        case "violet":
                            result = "Ferrari F-430";
                            break;
                        default:
                            result = "Nissan GTR";
                            break;

                    }

                    break;
                default:
                    result = "Type Help";
                    break;

            }

            //Asking for user input on number of siblings/ choosing vacation home.
            Console.WriteLine("How many siblings do you have?");
            siblings = int.Parse(Console.ReadLine());

            if (siblings <= 0)
            {
                resultVacay = "Arctic Circle";
            }
            else if (siblings == 1)
            {
                resultVacay = "Country";
            }

            else if (siblings == 2)
            {
                resultVacay = "Ireland";
            }

            else if (siblings == 3)
            {
                resultVacay = "New Zealand";
            }

            else
            {
                resultVacay = "Mountains";
            }//End if else if

            //Display end result to console.
            Console.WriteLine("{0} {1} will retire in {2} years with {3} in the bank, a vacation home in {4}, and a {5}.", firstNameResponse, lastNameResponse, retirementAge, resultMonth, resultVacay, result);

        }
    }
}
