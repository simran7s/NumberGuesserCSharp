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
           
            //Run GetAppInfo Function
            GetAppInfo();


            //Ask users name and greet
            GreetUser();

            //Play again after we guess right
            while (true)
            {
                // Set corret number
                //int correctNumber = 7;


                //Create new random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);


                //set guess var
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                //While guess is not correct
                while (guess != correctNumber)
                {
                    //get users input
                    string guessInput = Console.ReadLine();

                    //Make sure its a number

                    if (!int.TryParse(guessInput, out guess))
                    {
                        //Print Coloured Message
                        PrintColorMessage(ConsoleColor.Red, "That is not a number. Please enter an actual number");
                    
                        //keep going
                        continue;
                    }


                    //Cast input to number
                    guess = Int32.Parse(guessInput);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Print Error Message
                        PrintColorMessage(ConsoleColor.Red, "Wrong Number. Please try again");
                    }
                }


                //Output success message
                PrintColorMessage(ConsoleColor.Yellow, "YOU ARE CORRECT!");


                string answer = "";


                //Ask to play again
                while (answer != "Y" || answer != "N")
                {
                    Console.WriteLine("Do you want to play again? [Y or N]");
                    answer = Console.ReadLine().ToUpper();

                    if (answer == "Y")
                    {
                        break;
                    }
                    else if (answer == "N")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Please answer with input Y or N");
                    }
                }    
            }
        }


        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.1";
            string appAuthor = "Simran Sandhu";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;


            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);


            //Change colour back to default colour (white)
            Console.ResetColor();
        }

        static void GreetUser()
        {
            //Ask for user name

            Console.WriteLine("What is your name?");

            //Get user input
            string input = Console.ReadLine();


            Console.WriteLine("Hello {0}, let's play a game", input);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message); 
            Console.ResetColor();
        }
    }


   

}
