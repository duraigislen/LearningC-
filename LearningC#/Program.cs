/* Use variables inside double quotes*/
//string name = "Durai";
//Console.WriteLine($"Hello {name}");

/* Use Trim method on string */
//string greeting = "      Hello World!       ";
//Console.WriteLine($"[{greeting}]");

//string trimmedGreeting = greeting.TrimStart();
//Console.WriteLine($"[{trimmedGreeting}]");

//trimmedGreeting = greeting.TrimEnd();
//Console.WriteLine($"[{trimmedGreeting}]");

//trimmedGreeting = greeting.Trim();
//Console.WriteLine($"[{trimmedGreeting}]");

/* Use Replace method on string */
//string sayHello = "Hello World!";
//Console.WriteLine(sayHello);
//sayHello = sayHello.Replace("Hello", "Greetings");
//Console.WriteLine(sayHello);

/* Calculator */

//using System;

//namespace AdvanceCalci
//{
//    class Calci
//    {
//        public static void Main (string[] args)
//        {
//            Console.WriteLine("Welcome to the Advanced Calculator !");
//            Console.WriteLine("Do your operations on this Calculator");
//            String userChoice;
//            do
//            {
//                Console.WriteLine("Enter two numbers");
//            int a = Convert.ToInt32(Console.ReadLine());
//            int b = Convert.ToInt32(Console.ReadLine());

//                Console.WriteLine("Enter the option number:");
//                Console.WriteLine("\n1.Addition \n 2.Subtraction \n 3.Multiplication \n 4.Division.");
//                int choice = Convert.ToInt32(Console.ReadLine());
//                int result;
//                switch (choice)
//                {
//                    case 1:
//                        {
//                            result = a + b;
//                            Console.WriteLine($"Result is {result}");
//                            break;
//                        }
//                    case 2:
//                        {
//                            result = a - b;
//                            Console.WriteLine($"Result is {result}");
//                            break;
//                        }
//                    case 3:
//                        {
//                            result = a * b;
//                            Console.WriteLine($"Result is {result}");
//                            break;
//                        }
//                    case 4:
//                        {
//                            result = a / b;
//                            Console.WriteLine($"Result is {result}");
//                            break;
//                        }
//                    default:
//                        {
//                            Console.WriteLine("Wrong input");
//                            break;
//                        }
//                }
//                Console.WriteLine("Do you want to continue ? (Y/N)");
//                userChoice = Console.ReadLine();
//            } while (userChoice == "Y" || userChoice == "y");



//        }
//    }
//}


using System;

namespace AdvanceCalci
{
    class Assignment
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("*         WELCOME TO THE CALCULATOR      *");
            Console.WriteLine("--------------------------------------------");

            List<double> numbers = new List<double>();
            List<string> operators = new List<string>();

            while (true)
            {

                Console.WriteLine("Enter Number :");
                try
                {
                    double num = Convert.ToInt64(Console.ReadLine());
                    numbers.Add(Convert.ToDouble(num));
                }
                catch
                {
                    Console.WriteLine("Enter number only");

                }


                Console.WriteLine("Enter Symbol : [+,-,*,/,^,%,=]");
                string opr = Console.ReadLine();
                if (opr == "=")
                    break;
                else if (opr == "+" || opr == "-" || opr == "*" || opr == "/" || opr == "%" || opr == "^")
                {
                    operators.Add(opr);
                }
                else
                    Console.WriteLine("Enter valid Symbol !");

            }

            for (int i = 0; i < operators.Count; i++)
            {
                string stropr = operators[i];

                if (stropr == "^" || stropr == "%" || stropr == "*" || stropr == "/")
                {
                    double result = 0;
                    if (stropr == "^")
                    {
                        result = Math.Pow(numbers[i], numbers[i + 1]);
                    }
                    else if (stropr == "%")
                    {
                        result = numbers[i] % numbers[i + 1];
                    }
                    else if (stropr == "*")
                    {
                        result = numbers[i] * numbers[i + 1];
                    }
                    else
                    {
                        if (numbers[i + 1] == 0)
                        {
                            Console.WriteLine("Divisible by Zero error");
                        }
                        else
                        {
                            result = numbers[i] / numbers[i + 1];
                        }
                    }

                    numbers[i] = result;
                    numbers.RemoveAt(i + 1);
                    operators.RemoveAt(i);
                    i--;
                }
            }

            double ogresult = numbers[0];
            for (int i = 0; i < operators.Count; i++)
            {
                string stropr = (operators[i]);
                if (stropr == "+" || stropr == "-")
                {
                    if (stropr == "+")
                    {
                        ogresult = ogresult + numbers[i + 1];
                    }
                    else
                    {
                        ogresult = ogresult - numbers[i + 1];
                    }
                }
            }

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"             RESULT : {ogresult}            ");
            Console.WriteLine("---------------------------------------------");


        }
    }
}
