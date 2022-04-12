using System;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            string choice;
            double input1, input2;
            bool run = true;
            
            do
            {
                Console.Clear();
                
                Console.WriteLine("First number: ");
                input1 = ConvertToDouble(Console.ReadLine());
                Console.WriteLine("Second number: ");
                input2 = ConvertToDouble(Console.ReadLine());
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();

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
                            Add(input1, input2);
                            break;
                        case "2":
                            Subtract(input1, input2);
                            break;
                        case "3":
                            Multiply(input1, input2);
                            break;
                        case "4":
                            Divide(input1, input2);
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
        public static void Add(double input1, double input2 )
        {
            Console.Clear();
            double result;
            result = input1 + input2;

            Console.WriteLine($"{input1.ToString()} plus {input2.ToString()} equals {result.ToString()}");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }
        public static void Add(double[] input1, double[] input2)
        {

            Console.Clear();
            

            //result[1] = input1[1] + input2[1];

           // Console.WriteLine($"{input1.ToString()} plus {input2.ToString()} equals {result.ToString()}");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();

        }
        public static void Subtract(double input1,double input2)
        {
            Console.Clear();
            double result;
            result = input1 - input2;
            Console.WriteLine($"{input1.ToString()} minus {input2.ToString()} equals {result.ToString()}");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }
        public static void Subtract(double[] input1, double[] input2)
        {
            Console.Clear();
            double result;
            result = input1[1] - input2[1];
            Console.WriteLine($"{input1.ToString()} minus {input2.ToString()} equals {result.ToString()}");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }
        public static void Multiply(double input1, double input2)
        {
            Console.Clear();
            double result;
           
            result = input1 * input2;
            Console.WriteLine($"{input1.ToString()} Multiplied by {input2.ToString()} equals {result.ToString()}");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }
        public static void Divide(double input1, double input2)
        {
            Console.Clear();
            double result;
            
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
