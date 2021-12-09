using System; //importing other namespaces that can be used here


namespace NumberGuesser //container for classes or functions
{
    class Program //used to create objects
    {

        //entry point method

        //static = using static lets all instances of a class share the same variables
        //void = no return
        static void Main(string[] args)
        {

            string name = "Simran Sandhu";

            int age = 21;



            Console.WriteLine(name + " is " + age + " years old");
            Console.WriteLine("{0} is {1} years old", name, age); //better way to write this
        }
    }
}
