using System;

namespace PassingParametersBy_Value_Ref_Out_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                There are three ways to pass arguments to a method when the method is called: By value, By reference, and as Output.
                By value copies the argument's value into the method's formal parameter. 
                Here, we can make changes to the parameter within the method without having any effect on the argument. 
            */



            /*
                                                            Ref Parameters
                Ref is a keyword in C# which is used for passing the value types by reference. 
                Or we can say that if any changes made in this argument in the method will reflect in that variable when the control return to the calling method.
                The ref parameter does not pass the property. 
                In ref parameters, it is necessary that the parameters should initialize before it pass to ref. 
                The passing of value through the ref parameter is useful when the called method also needs to change the value of the passed parameter. 
            */

            // Assigning value 
            string val = "Dog";

            // Pass as a reference parameter 
            CompareValue(ref val);

            // Display the given value 
            Console.WriteLine(val);


            /*
                                                    Out Parameters
                The out is a keyword in C# which is used for the passing the arguments to methods as a reference type. 
                It is generally used when a method returns multiple values. 
                The out parameter does not pass the property. 
                It is not necessary to initialize parameters before it passes to out.
                The declaring of parameter throughout parameter is useful when a method returns multiple values.
            */

            // Creating variable 
            // without assigning value 
            int num;

            // Pass variable num to the method 
            // using out keyword 
            AddNum(out num);

            // Display the value of num 
            Console.WriteLine("The sum of"
              + " the value is: {0}", num);

        }

        static void CompareValue(ref string val1)
        {
            // Compare the value 
            if (val1 == "Dog")
            {
                Console.WriteLine("Matched!");
            }

            // Assigning new value 
            val1 = "Cat";
        }

        // Method in which out parameter is passed 
        // and this method returns the value of 
        // the passed parameter 
        public static void AddNum(out int num)
        {
            num = 40;
            num += num;
        }
    }
}
