using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            bool run = true;
            
            do
            {
                Console.Clear();
                Console.WriteLine("Let's Calculate!");
                Console.WriteLine("1.Add\n2.Subtract\n3.Multiply\n4.Divide\n0.Quit");
                Console.WriteLine("Choice: ");
                choice = Console.ReadLine();
                if (choice == "0" || choice == "1" || choice == "2" || choice == "3" || choice == "4"){
                    switch (choice)
                    {
                        case "0":
                            run = false;
                            break;
                        case "1":
                            Add();
                            break;
                        case "2":
                            Subtract();
                            break;
                        case "3":
                            Multiply();
                            break;
                        case "4":
                            Divide();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("invalid input");
                    Console.ReadLine();
                }
            }while( run==true );   
        }
        public static void Add()
        {
            Console.Clear();
            double input1, input2, result;
            Console.WriteLine("First number: ");
            input1 = ConvertToDouble(Console.ReadLine());
            Console.WriteLine("Second number: ");
            input2 = ConvertToDouble(Console.ReadLine());
            result = input1 + input2;
            Console.WriteLine($"{input1.ToString()} plus {input2.ToString()} equals {result.ToString()}");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }
        public static void Subtract()
        {
            Console.Clear();
            double input1, input2, result;
            Console.WriteLine("First number: ");
            input1 = ConvertToDouble(Console.ReadLine());
            Console.WriteLine("Second number: ");
            input2 = ConvertToDouble(Console.ReadLine());
            result = input1 - input2;
            Console.WriteLine($"{input1.ToString()} minus {input2.ToString()} equals {result.ToString()}");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }
        public static void Multiply()
        {
            Console.Clear();
            double input1, input2, result;
            Console.WriteLine("First number: ");
            input1 = ConvertToDouble(Console.ReadLine());
            Console.WriteLine("Second number: ");
            input2 = ConvertToDouble(Console.ReadLine());
            result = input1 * input2;
            Console.WriteLine($"{input1.ToString()} Multiplied by {input2.ToString()} equals {result.ToString()}");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }
        public static void Divide()
        {
            Console.Clear();
            double input1, input2, result;
            Console.WriteLine("First number: ");
            input1 = ConvertToDouble(Console.ReadLine());
            Console.WriteLine("Second number: ");
            input2 = ConvertToDouble(Console.ReadLine());
            if (input2 == 0)
            {
                Console.WriteLine("Cannot divide by 0.\nPress enter to continue.");
                Console.ReadLine();
            }
            else
            {
                result = input1 / input2;
                Console.WriteLine($"{input1.ToString()} divided by {input2.ToString()} equals {result.ToString()}");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
            }
        }
        public static double ConvertToDouble(string input)
        {
            double result;
            while (double.TryParse(input, out result) == false)
            {
                Console.WriteLine("Invalid input.");
            }
            return result;
        }
    }
}
