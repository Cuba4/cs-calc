using System;
class Calc {
  static void Main() {
    Console.WriteLine("Hi! Welcome to my C# Calculator! (v.1.2 Beta)");
    Console.WriteLine("ChangeLog: Added divide and multiply, soon i will create compiled .exe and Python version!");
    Console.WriteLine("So, let's get started! Write first number.");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ok, now, second number!");
    double num2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Choose option:");
    Console.WriteLine("a - Add.");
    Console.WriteLine("s - Subtract.");
    Console.WriteLine("d - Divide.");
    Console.WriteLine("m - Multiply.");
    string option = Console.ReadLine();
    switch (option)
    {
        case "a":
            double result = num1 + num2;
            Console.WriteLine("Your result is: " + result + "!");
            break;
        case "s":
            result = num1 - num2;
            Console.WriteLine("Your result is: " + result + "!");
            break;
        case "d":
            result = num1 / num2;
            Console.WriteLine("Your result is: " + result + "!");
            break;
        case "m":
            result = num1 * num2;
            Console.WriteLine("Your result is: " + result + "!");
            break;
        default:
            Console.WriteLine("You write wrong symbol! Please try again!");
            break;
        }
    }
  }