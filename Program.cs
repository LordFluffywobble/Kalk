namespace Kalk;

using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{


    static void Main(string[] args)
    {

        mathPicker();

    }

    // public static void addArray()
    // {
    //     Console.Write("Enter the list of numbers you wish to add together: ");
    //     double []inputArray = Console.ReadLine()
    //                         .Split(' ')
    //                         .Select(double.Parse)
    //                         .ToArray();

    //     double total = 0;
    //     for (int i = 0; i < inputArray.Length; i++)
    //     {
    //         total += inputArray[i];
    //     } 
    //     Console.WriteLine($" The sum of the numbers is: {total}");
    // }

    // public static void minusArray()
    // {

    // }

    // public static void timesArray()
    // {

    // }

    // public static void divideArray()
    // {

    // }

    public static void mathPicker()
    {
        Console.WriteLine("Which operation do you wish to do? Pick between +, *, -, / or Area ");
        String op = Console.ReadLine() ?? "";
        Console.Write("Enter the list of numbers: ");

        double[] inputArray = Console.ReadLine()
                            .Split(' ')
                            .Select(double.Parse)
                            .ToArray();

        if (inputArray.Length == 0) return;
        //double total = (op == "*" || op == "/") ? 1 : 0;
        double total = inputArray[0];

        Geometry geo = new Geometry();
        if (op == "Area")
        {
         total = geo.GetArea(inputArray[0], inputArray[1]);
         total = inputArray[0] * inputArray[1];
         Console.WriteLine($"The area is: {total}");
        }
        else
        {   
            for (int i = 1; i < inputArray.Length; i++)
            {
                total = op switch
                {
                    "/" when inputArray[i] == 0 => total,
                    "+" => total + inputArray[i],
                    "-" => total - inputArray[i],
                    "*" => total * inputArray[i],
                    "/" => total / inputArray[i],
                    _ => total
                };
            }
            Console.WriteLine($"The result is: {total}");   
        }
    }

    public class Geometry
    {
        public double GetArea(double width, double height)                          => width * height;
        public double GetArea(double radius)                                        => Math.PI * radius * radius;
        public double GetArea(double baseLength, double height, bool isTriangle)    => 0.5 * baseLength * height;
    }


    // static (int, int, string) userInput()
    // {
    //     Console.Write("Enter the first number: ");
    //     int n1 = int.Parse(Console.ReadLine());

    //     Console.Write("Enter the second number: ");
    //     int n2 = int.Parse(Console.ReadLine());

    //     Console.Write("Enter the operator, either +, -, *, /  : ");
    //     string op = Console.ReadLine().Trim().ToLower();

    //     return (n1, n2, op);
    // }
    // static void calcResults(int n1, int n2, string op)
    // {
    //     string result = op switch
    //     {
    //         "+" =>$"The sum of {n1} pluss {n2} is: "                + (n1 + n2),
    //         "*" =>$"The product of {n1} times {n2} is: "            + (n1 * n2),
    //         "-" =>$"The difference between {n1} minus {n2} is: "    + (n1 - n2),
    //         "/" =>$"The quotient between {n1} divided by {n2} is: " + (n1 / n2),
    //         _   =>"Feil"
    //     };
    //     Console.WriteLine(result);

    // }







    //    (int num1, int num2, string op) = getNumbers();
    //    string result = op switch
    //    {
    //        "+"  =>$"The sum is {num1 + num2}",
    //        "*"  =>$"The product is {num1 * num2}",
    //        _    =>"Invalid operation"
    //    };




    // static (int, int, string) getNumbers()
    // {
    //     Console.Write("Enter the first number: ");
    //     int num1 = int.Parse(Console.ReadLine());
    //     Console.Write("Enter the operation + or *: ");
    //     string op = Console.ReadLine();
    //     Console.Write("Enter the second number: ");
    //     int num2 = int.Parse(Console.ReadLine());
    //     return (num1, num2, op);
    // }





    // static void addition(int num1, int num2)
    // {
    //    int sum = num1 + num2;
    //    Console.WriteLine($"The sum is {sum}\n");
    // }

    // static void multiplication (int num1, int num2)
    // {
    //     int product = num1 * num2;
    //     Console.WriteLine($"The product is {product}\n");
    // }
}
