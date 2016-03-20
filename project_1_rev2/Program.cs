using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1_rev2
{
    class Program
    {
        static void Main(string[] args)


        {
            //INTRO
            Console.WriteLine("Welcome to Madame Bougainvillea's Fortune Teller. \n *****Your future looks amazing!***** \n\n");

            // Putting variables in parent
            int retire;
            string city;
            // int isMatch;
            string bank;
            string transport = "Citroen, the default car of people who don't enter a color";
            string redo = "yes";
            bool redoYES;
            do
            {

                //USER INPUT BLOCK          
                Console.WriteLine("Please enter your first name:");
                string firstName = Console.ReadLine();
                string firstNameLow = firstName.ToLower();

                Console.WriteLine("Now enter your last name:");
                string lastName = Console.ReadLine();
                string lastNameLow = lastName.ToLower();
                Console.WriteLine("Next, enter your age in years");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("And your birth month:");
                string month = Console.ReadLine();
                string monthLow = month.ToLower();

                Console.WriteLine("Tell me your favorite ROYGBIV color or enter \"HELP\":");
                string favColor = Console.ReadLine();
                string favColorLower = favColor.ToLower();
                //string color = Console.ReadLine();
                //string colorLow = color.ToLower();

                Console.WriteLine("How many brothers and sisters do you have?");
                int siblings = int.Parse(Console.ReadLine());

               
                /*
                bool strEq2;
                if (strEq2 = colorLow.Equals("help"))
                    {
                    Console.WriteLine("R = RED");
                    Console.WriteLine("O = ORANGE");
                    Console.WriteLine("Y = YELLOW");
                    Console.WriteLine("G = GREEN");
                    Console.WriteLine("B = BLUE");
                    Console.WriteLine("I = INDIGO");
                    Console.WriteLine("V = VIOLET");
                    Console.WriteLine("");
                    Console.WriteLine("Please enter a selection");
                    color = Console.ReadLine();
                    colorLow = color.ToLower();

                    }

                //Mode of Transportation assignment
                if (strEq2 = (colorLow.Equals("red") || (colorLow.Equals("r")
                //    vehicle =    */

                //LEXUS' color switch
                switch (favColorLower)
                {
                    case "red":
                        transport = "tricycle";
                        break;
                    case "orange":
                        transport = "skateboard";
                        break;
                    case "yellow":
                        transport = "VW bus";
                        break;
                    case "green":
                        transport = "unicorn";
                        break;
                    case "blue":
                        transport = "Lexus";
                        break;
                    case "indigo":
                        transport = "sedan";
                        break;
                    case "violet":
                        transport = "mechanical bull";
                        break;
                    case "help":
                        string help = "ROYGBIV colors: \n R is red \n O is orange \n Y is yellow \n G is green \n B is blue \n I is indigo \n V is violet";
                        Console.WriteLine(help);
                        break;
                    default:
                        Console.WriteLine("did you enter a color? ");
                        break;
                }
                //    Console.WriteLine(transport);

                //DESTINATION SWiTCh CASE (siblings)

                switch (siblings)
                {
                    case 0:
                        city = "Marrakesh, Morocco";
                        break;

                    case 1:
                        city = "Sarasota, FL";
                        break;
                    case 2:
                        city = "Vancouver, BC";
                        break;
                    case 3:
                        city = "Boise, ID";
                        break;
                    default:
                        city = "Basel, Switzerland";
                        break;
                }


                //AGE test
                if (age % 2 == 0)
                {
                    retire = 20;
                }
                else
                {
                    retire = 25;
                }


                //Insane troll logic for determining net worth -- MONEY MONEY MONEY
                //This is intended to test the conditions and will stop when the condition is met
                // it will not add amounts or substitute one for another. 

                if (firstNameLow.IndexOf(monthLow[0]) != -1 || lastNameLow.IndexOf(monthLow[0]) != -1)
                {
                    bank = "$2.5 million";
                }
                else if
                    (firstNameLow.IndexOf(monthLow[1]) != -1 || lastNameLow.IndexOf(monthLow[1]) != -1)
                {
                    bank = "$3 million";
                }
                else if
                    (firstNameLow.IndexOf(monthLow[2]) != -1 || lastNameLow.IndexOf(monthLow[2]) != -1)
                {
                    bank = "$5 million";
                }
                else
                {
                    bank = "$100 million";
                }

                //writing the results
                Console.WriteLine();
                Console.WriteLine();
                Console.Write(firstName + " " + lastName + " will retire in " + retire + " years" + " with " + bank);
                Console.WriteLine(",\na vacation home in " + city + ", and a " + transport + ".");
                Console.WriteLine();
                Console.WriteLine("*** There now, wasn't that nice?***\nWould you like to play again? Enter YES or NO.*** ");
                string redoIt = Console.ReadLine();
                string redoItLower = redoIt.ToLower();
                redoYES = redo.Equals(redoItLower, StringComparison.CurrentCultureIgnoreCase);
                
            } while (redoYES == true);

        }
    }
}
