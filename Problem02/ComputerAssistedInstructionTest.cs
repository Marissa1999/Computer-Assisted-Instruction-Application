//ID: 1775227
//Name: Marissa Goncalves
//Assignment 2 - Problem 2: Computer-Assisted Instruction

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{

    class ComputerAssistedInstructionTest
    { 

        //Main method in order to run the entire program.
        static void Main(string[] args)
        {

            //Boolean value to control do-while loop, if the user wants to play again.
            Boolean agreeToTryAgain = true;
        
            //Display the table selection of arithmetic problems for students to choose from.
            Console.WriteLine($"--------------------------------------");
            Console.WriteLine($"|    Elementary School Arithmetic    |");
            Console.WriteLine($"--------------------------------------");
            Console.WriteLine($"|  Addition Problems         |   1   |");
            Console.WriteLine($"--------------------------------------");
            Console.WriteLine($"|  Subtraction Problems      |   2   |");
            Console.WriteLine($"--------------------------------------");
            Console.WriteLine($"|  Multiplication Problems   |   3   |");
            Console.WriteLine($"--------------------------------------");
            Console.WriteLine($"|  Division Problems         |   4   |");
            Console.WriteLine($"--------------------------------------");
            Console.WriteLine($"|  All Problems              |   5   |");
            Console.WriteLine($"--------------------------------------");

            //Skip a line.
            Console.WriteLine($"");

            //Prompt the user to enter a number of their selection.
            Console.Write($"Please enter a selection of arithmetic problems to study: ");

            //Read the number that the user has prompted in order to proceed with a question.
            int arithmeticChoice = int.Parse(Console.ReadLine());

            //Start the application after the selection.
            do
            {
            
                //Create a new object from the ComputerAssistedInstruction class.
                var session = new ComputerAssistedInstruction();

                //Call the method to ask a new question, based on their chosen set of problems.
                session.AskRandomQuestion(arithmeticChoice);           

                //Skip a line.
                Console.WriteLine($"");

                //Prompt the user whether to play again with a new question
                Console.Write($"Would you like to play again? Yes(Y) or No(N). ");

                //Read their response that the user has prompted.
                string gameDecision = Console.ReadLine();

                //Skip a line.
                Console.WriteLine($"");

                //If the user says "yes", the entire game will be repeated with a new question.
                if (gameDecision == "Y")
                {
                    //The boolean value will remain true, as the do-while loop will repeat itself once more.
                    agreeToTryAgain = true;

                    //Skip a line.
                    Console.WriteLine($"");
                }

                else if (gameDecision == "N")
                {
                    //The boolean value will become false, in which the user exits the game entirely.
                    agreeToTryAgain = false;

                    //Skip a line.
                    Console.WriteLine($"");
                }

            }

            //While the user agrees to try again, the loop will be repeated once more.
            while (agreeToTryAgain == true);
     

        }

    }

}
