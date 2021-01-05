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

    class ComputerAssistedInstruction
    {

        //Create a new object to generate random numbers.
        Random randomNumber = new Random();

        //Initialize the integer variables for the class.
        private int firstNumber;
        private int secondNumber;
        private int listNumber;


        //Main constructor that sets the properties to the variables.
        public ComputerAssistedInstruction()
        {
            FirstNumber = this.firstNumber;
            SecondNumber = this.secondNumber;
            ListNumber = this.listNumber;
        }

        //Implicit property for the first number variable.
        public int FirstNumber
        {
            get; set;
        }

        //Implicit property for the second number variable.
        public int SecondNumber
        {
            get; set;
        }

        //Implicit property for the list number variable.
        public int ListNumber
        {
            get; set;
        }


        //Asks a new question every time the user gets the previous one right and agrees to play again.
        public void AskRandomQuestion(int choice)
        {
            //Skip a line
            Console.WriteLine($"");

            //The first number property equals to a random number between 1 and 9.
            FirstNumber = randomNumber.Next(1,10);

            //The second number property equals to a random number between 1 and 9.
            SecondNumber = randomNumber.Next(1,10);

            //The list number propety equals to a random index value between 0 and 3.
            ListNumber = randomNumber.Next(0, 4);

            //Call the method in order for the user to answer the random question.
            AskQuestion(choice);

        }


        //Asks the same question every time the user answers a question incorrectly.
        public void AskQuestion(int choice)
        {

            //Skip a line.
            Console.WriteLine($"");

            //Create a new list of problems for the fifth selection.
            List<string> problemList = new List<string>();

            //Add questions to the list, so that the random index number can generate one.
            problemList.Add($"How much is {FirstNumber} plus {SecondNumber}? ");
            problemList.Add($"How much is {FirstNumber} minus {SecondNumber}? ");
            problemList.Add($"How much is {FirstNumber} times {SecondNumber}? ");
            problemList.Add($"How much is {FirstNumber} divided by {SecondNumber}? ");

            //Create a new list of calculations for the fifth selection.
            List<int> calculationList = new List<int>();

            //Add calculations to the list, so that the random index number can generate one.
            calculationList.Add(FirstNumber + SecondNumber);
            calculationList.Add(FirstNumber - SecondNumber);
            calculationList.Add(FirstNumber * SecondNumber);
            calculationList.Add(FirstNumber / SecondNumber);

            //Based on the choice number that was passed from the user, the same arithmetic question will be asked.
            switch (choice)
            {
                //If the selection is one, prompt the user to answer an addition question.
                case 1:
                    Console.Write($"How much is {FirstNumber} plus {SecondNumber}? ");

                    //The correct addition answer is stored in a variable.
                    int correctAdditionValue = FirstNumber + SecondNumber;

                    //Call the method to determine whether the inputted value is similar to the correct value.
                    validateAnswer(choice, correctAdditionValue); break;

                //If the selection is two, prompt the user to answer a subtraction question.
                case 2:
                    Console.Write($"How much is {FirstNumber} minus {SecondNumber}? ");

                    //The correct subtraction answer is stored in a variable.
                    int correctSubtractionValue = FirstNumber - SecondNumber;

                    //Call the method to determine whether the inputted value is similar to the correct value.
                    validateAnswer(choice, correctSubtractionValue); break;

                //If the selection is three, prompt the user to answer a multiplication question.
                case 3:
                    Console.Write($"How much is {FirstNumber} times {SecondNumber}? ");

                    //The correct multiplication answer is stored in a variable.
                    int correctMultiplicationValue = FirstNumber * SecondNumber;

                    //Call the method to determine whether the inputted value is similar to the correct value.
                    validateAnswer(choice, correctMultiplicationValue); break;

                //If the selection is four, prompt the user to answer a division question.
                case 4:
                    Console.Write($"How much is {FirstNumber} divided by {SecondNumber}? ");

                    //The correct division answer is stored in a variable.
                    int correctDivisionValue = FirstNumber / SecondNumber;

                    //Call the method to determine whether the inputted value is similar to the correct value.
                    validateAnswer(choice, correctDivisionValue); break;

                //If the selection is five, prompt the user to answer a random question from the list.
                case 5:
                    Console.Write(problemList[ListNumber]);

                    //The correct answer is stored in a variable, based on the random calculation.
                    int correctValue = calculationList[ListNumber];

                    //Call the method to determine whether the inputted value is similar to the correct value.
                    validateAnswer(choice, correctValue); break;
            }

        }


        //Validates if the user's answers is similar to the correct value.
        public void validateAnswer(int choice, int correctValue)
        {

            //Create a new object to generate random reponses.
            Random randomResponse = new Random();

            //Read the value that the user has prompted in order for it to be compared.
            int inputtedValue = int.Parse(Console.ReadLine());

            //If the inputted value is equal to the correct value,
            if (inputtedValue == correctValue)
            {
                //The correct reponse number is equal to a random number generated from 1 to 4.
                int correctResponse = randomResponse.Next(1,5);

                //Based on the reponse number value, a random reponse will be generated when the user gets the correct answer.
                switch (correctResponse)
                {
                    case 1: Console.WriteLine($"Very Good!"); break;
                    case 2: Console.WriteLine($"Excellent!"); break;
                    case 3: Console.WriteLine($"Nice Work!"); break;
                    case 4: Console.WriteLine($"Keep Up the Good Work!"); break;
                }

            }

            //If the inputted value is not equal to the correct value,
            else
            {

                //The incorrect reponse number is equal to a random number generated from 1 to 4.
                int incorrectResponse = randomResponse.Next(1,5);

                //Based on the reponse number value, a random reponse will be generated when the user gets an incorrect answer.
                switch (incorrectResponse)
                {
                    case 1: Console.WriteLine($"No. Please Try Again."); break;
                    case 2: Console.WriteLine($"Wrong. Try Once More."); break;
                    case 3: Console.WriteLine($"Don't Give Up!"); break;
                    case 4: Console.WriteLine($"No. Keep Trying."); break;
                }

                //Call the method in order for the user to answer the same question, until it is correct.
                AskQuestion(choice);
                 
            }
        }

    }
}
