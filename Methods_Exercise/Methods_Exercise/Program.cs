using System;
using System.Linq;

namespace Methods_Exercise
{   
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for their name and store their answer in the variable underneath

            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            
            //Ask the user for their favorite color and store their answer in the variable 
            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine();

            //Ask the user for their favoritte animal and store their answer in the variable 
            Console.WriteLine("What is your favorite animal");
            var animal = Console.ReadLine();

            //Ask the user for their favorite band and store their answer in the variable 
            Console.WriteLine("What is your favorite band");
            var band = Console.ReadLine();

            //This section is writing all the variables from above to the console
            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"My favorite color is {color}");
            Console.WriteLine($"My favorite animal is {animal}");
            Console.WriteLine($"My favorite band is {band}");

            //This section is Calling/Invoking all the methods from below and writing them to the console
            Console.WriteLine(Add(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)); //params Add method can take ANY NUMBER OF ARGUMENTS!!!

            Console.WriteLine(Add(10,44)); //Hover over Add to see which overload we are using for this invocation

            Console.WriteLine(Subtract(14, 19)); //subtract method can only take 2 arguments. If we want to add more we will need to make an overload of this method

            Console.WriteLine(Multiply(34343, 2828));//multiply method can only take 2 arguments

            //These 2 methods are not wrapped in the Console.WriteLine(  ) parentheses because the Console.WriteLine is INSIDE those 2 methods
            Divide(10, 2);
            Greeting();

        }        
        //Adds the 2 parameters x and y together and returns the result
        public static int Add(int x, int y)
        {
            return x + y;
        }

        //Subtracts the 2 parameters x and y and returns the result
        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        //Multiplies the 2 parameters x and y and returns the result
        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        //Divides the 2 parameters and prints the result (void return type will not have the "return" keyword)
        public static void Divide(int x, int y)
        {
            Console.WriteLine(x / y); 
        }      

        //When this method is called it writes "Hey what's up class?" to the console window (void return type will not have the "return" keyword)
        public static void Greeting()  //No parameters required for this method
        {
            Console.WriteLine("Hey what's up class?");
        }

        //This is an Overload of the Add Method from above.
        //We use the params keyword to store the parameter list in an array so we can do calculations/operations on all of them 
        public static int Add(params int[] array)
        {
            //return array.Sum();
            int result = 0;

            foreach (var number in array)
            {
                result += number;
            }
            return result;
        }

    }

}



