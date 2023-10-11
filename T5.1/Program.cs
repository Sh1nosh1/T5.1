using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Task 1.
                //Determine whether or not the current year is a leap year?
                //Enter the year from the keyboard (A year is a leap year if it is a multiple of 4).

                /*WriteLine("Enter the year: ");                         //Ask the user to enter the year
                int year = Convert.ToInt32(Console.ReadLine());

                if (year % 4 == 0)                                    //Full if/else
                {
                    WriteLine($"{year} is a leap year") ;
                }
                else
                {
                    WriteLine($"{year} is not a leap year");
                }*/


                //Task 2.
                //Determine whether the price of the selected laptop is within the range of 20000 to 30000 rubles.

                /*Write("Enter the price of the laptop: ");     //Ask the user for the price of the laptop
                int price = Convert.ToInt32(ReadLine());

                string compare = price > 20000 && price < 30000 ? 
                    "The price of the laptop is not in the affordable range" : "The price of the laptop falls within the affordable range";   //Ternary operator
                WriteLine(compare);*/


                //Task 3.
                //Write a program that, depending on a given score, determines the student’s grade according to the table.

                /*Write("Enter score: ");
                 int point = Convert.ToInt32(ReadLine());

                 if(point <= 59 && point >= 0)
                 {
                     WriteLine("Unsatisfactory grade");
                 }
                 else if (point <= 74 && point >= 60)
                 {
                     WriteLine("Satisfactory grade");
                 }
                 else if(point <= 75 && point >= 89)
                 {
                     WriteLine("The grade is good");
                 }
                 else if (point <= 90 && point >= 100)
                 {
                     WriteLine("The grade is excellent");
                 }*/


                //Task 4.
                //The traffic light is coded in three states: 1 – red, 2 – yellow, 3 – green.
                //Depending on the state, determine the color of the traffic light.

                /*Random random = new Random();                 //Determining a random number
                int color = random.Next(1, 3);

                Write("The traffic light is ");
                switch (color)                          //Compare using the switch/case
                {
                    case 1:
                        WriteLine("red");
                        break;
                    case 2:
                        WriteLine("yellow");
                        break;
                    case 3:
                        WriteLine("green");
                        break;
                }*/


                //Task 5.
                //Checking the sign of a random number and its parity.

                /*Random random = new Random();             //Determining a random number
                int count = random.Next(-100, 100);

                Write($"The number {count} is ");
                if (count % 2 == 0 & count > 0)             //Compare using the inserted if/else
                {
                    WriteLine("even and positive");
                }
                else if (count % 2 == 0 & count < 0)
                {
                    WriteLine("even and negative");
                }
                else if (count % 2 != 0 & count > 0)
                {
                    WriteLine("odd and positive");
                }
                else if (count % 2 != 0 & count < 0)
                {
                    WriteLine("odd and negative");
                }*/


                //Task 6.
                //Select day of week.

                /*Write("Enter the number from 1 to 7: ");              //Ask the user for a number
                 int day = Convert.ToInt32(ReadLine());

                 switch (day)                       //Compare using the switch/case
                 {
                     case 1:
                         WriteLine("Monday");
                         break;
                     case 2:
                         WriteLine("Thusday");
                         break;
                     case 3:
                         WriteLine("Wednesday");
                         break;
                     case 4:
                         WriteLine("Thursday");
                         break;
                     case 5:
                         WriteLine("Friday");
                         break;
                     case 6:
                         WriteLine("Saturday");
                         break;
                     case 7:
                         WriteLine("Sunday");
                         break;
                     default:
                         WriteLine("The number doesn't fit");
                         break;
                 }*/


                //Task 7.
                //Checking username and password entered from the keyboard.

                /*string username = "sh1nda";                        //Assigning a value 
                string password = "27042005";

                Write("Enter your username, please: \nUsername: ");             //Ask the user for username and password
                string username_1 = ReadLine();
                Write("\nNow enter your password, please: \nPassword: ");
                string password_1 = ReadLine();

                string compare = username == username_1 && password == password_1 ? 
                    "You have successfully logged in!" : "This username or password does not exist.";  //Compare using the ternary operator
                WriteLine($"\n{compare}");*/


                //Task 8.
                //The simplest 4-step calculator.

                /*Write("Enter a = ");                      //Ask the user for values ​​and type of operation
                double a = Convert.ToDouble(ReadLine());
                Write("b = ");
                double b = Convert.ToDouble(ReadLine());
                Write("Enter the operation: ");
                string oper = ReadLine();

                switch (oper)                                   //Compare using the switch/case
                {
                    case "+":
                        WriteLine($"{a} + {b} = {a + b}");
                        break;
                    case "-":
                        WriteLine($"{a} - {b} = {a - b}");
                        break;
                    case "*":
                        WriteLine($"{a} * {b} = {a * b}");
                        break;
                    case "/":
                        WriteLine($"{a} / {b} = {a / b}");
                        break;
                    default:
                        WriteLine("This operation doesn't exist.");
                        break;
                }*/


                //Task 9.
                //The age of the person is entered and the age group to which the person belongs is displayed in the console window.

                /*Write("Enter the person's age from 18 to 90 \nAge: ");     //Ask the user enter the person's age
                int age = Convert.ToInt32(ReadLine());

                if (age >= 18 & age <= 44)                  //Compare using the inserted if/else
                {
                    WriteLine("The person is young.");
                }
                else if (age >= 45 & age <= 60)
                {
                    WriteLine("The person has an average age.");
                }
                else if (age >= 61 & age <= 75)
                {
                    WriteLine("It's an elderly person.");
                }
                else if (age >= 76 & age <= 90)
                {
                    WriteLine("This person of old age.");
                }
                else
                {
                    WriteLine($"\nYou are out of the range of possible values.");;
                }*/


            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
