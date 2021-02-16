using System;
using System.Collections.Generic;

namespace Methods_Demo
{
    class Program
    {
        // The Main Method is a special method -->  https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/main-and-command-args/
        public static void Main(string[] args)
        {
            // Calling your method example 1
            Console.WriteLine("Hello World!");

            // Calling your method example 2
            MyVoidMethod(); // NO ARGUMENTS passed in because we have NO PARAMETERS

            // Calling your method example 3
            MultipleReturnKeywordMethod("John"); // 1 ARGUMENT passed in because we have 1 PARAMETER

            // Calling your method example 4
            ManyParameterMethod("John","Ward",29,"male",87,100);  // 6 ARGUMENTS passed in because we have 6 PARAMETERS

            // Calling your method example 5
            Console.WriteLine(MyStringMethod()); // 0 arguments bc 0 parameters ***NOTE: We had to put this method inside the ( ) of the Console.WriteLine bc the method 
                                                   // returns a string and doesn't write to the console window anywhere inside of the method scope/body ***
        }

        // Methods/Functions have 5 "mandatory" parts 

        // 1.  Access Modifier  --->  an optional list of keywords that give certain qualities to the method and defines the scope and visibility
        //      public, internal, protected, private (we will discuss protected internal, and private protected later)

        // 2.  Return Type  --->  establishes the type returned by the method, or void when not returning anything (void is the absence of a return type)

        // 3.  Name  --->  a descriptive method name ****The PascalCase rule must be applied****

        // 4.  Parameters  --->  an optional list of parameters to be passed into the method

        // 5.  Scope/Body  --->  the block of code to be executed when the method is called
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Scope/Body Example

        //    "{" Open curly brace   

        //    "}" Closing curly brace 

        // Anything to the right of the "open" curly brace is inside the scope {-------->inside scope<--------} Anything to the left of the "close" curly brace is inside the scope

        // Anything to the left of the "open" curly brace is outside the scope <---------{outside scope}---------> Anything to the right of the "close" curly brace is outside the scope

        // For more help understanding scope https://openclassrooms.com/en/courses/5670356-learn-programming-with-c/6080901-understand-variable-scoping-and-access-control
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // return Keyword

        //The return statement terminates the execution of the method in which it appears and returns control to the calling method.
        //It can also return an optional value. If the method is a void type, the return statement can be omitted. 

        public static void MyVoidMethod()
        {
            //code to execute goes here
            //since the return type is void you will not have the return keyword
            Console.WriteLine("Hello");
        }

        public static string MyStringMethod()
        {
            //since the return type is NOT void you will need to have the return keyword
            return "Hello";
        }

        public static string MultipleReturnKeywordMethod(string firstName)
        {
            //I can have multiple return keywords AS LONG AS only 1 gets executed
            if (firstName == "John")
            {
                return "Hello, John!";
            }
            else if (firstName == "Jeremy")
            {
                return "Hello, Jeremy";
            }
            else
            {
                return "Hello";
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Parameters

        // Information can be passed to methods as parameter. Parameters act as variables inside the method.
        // They are specified after the method name, inside the parentheses. You can add as many parameters as you want, just separate them with a comma.

        // This method has no parameters
        public static void NoParameterMethod()
        {
            Console.WriteLine("This method has no parameters");
        }

        // This method has 6 parameters
        public static void ManyParameterMethod(string firstName, string lastName, int age, string gender, int points, int total)
        {
            Console.WriteLine("This method has MANY parameters");
            Console.WriteLine($"Subject {firstName} {lastName} is {age} years old, is {gender}, and scored {points} / {total} on the test");            
        }

    }
}
