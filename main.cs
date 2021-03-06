using System;
using System.Threading.Tasks;
using System.Threading;
class Calc {
  static void Main() {
    Console.WriteLine("Hi! Welcome to my C# Calculator! (v.1.2)");
    System.Threading.Thread.Sleep(500);
    Console.WriteLine("ChangeLog: Added divide and multiply, Python version \"Coming Soon\"");
    System.Threading.Thread.Sleep(500);
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
            Console.WriteLine("Press any key to close app...");
            Console.Read();
            break;
        case "s":
            result = num1 - num2;
            Console.WriteLine("Your result is: " + result + "!");
            Console.WriteLine("Press any key to close app...");
            Console.Read();
            break;
        case "d":
            result = num1 / num2;
            Console.WriteLine("Your result is: " + result + "!");
            Console.WriteLine("Press any key to close app...");
            Console.Read();
            break;
        case "m":
            result = num1 * num2;
            Console.WriteLine("Your result is: " + result + "!");
            Console.WriteLine("Press any key to close app...");
            Console.Read();
            break;
        default:
            Console.WriteLine("You wrote wrong symbol! Please try again!");
            Console.WriteLine("Press any key to close app...");
            Console.Read();
            break;
        }
    }
}
