using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Explorer Mode
            //Practicing Creating Variables
            int numberOfCupsOfCoffee = 5;
            string fullName = "Philippa Matthews";
            var rightNow = DateTime.Now;
            Console.WriteLine($"{fullName} drinks {numberOfCupsOfCoffee} cups of coffee on {rightNow}.");


            //Practicing getting input from the user
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello {userName}, welcome to my world.");


            //Practicing getting different types of input from the user
            Console.WriteLine("Please type in one number: ");
            string firstNumberAsString = Console.ReadLine();
            Console.WriteLine("Please type in a second number: ");
            string secondNumberAsString = Console.ReadLine();


            //Converting string input into numbers
            double firstOperand = double.Parse(firstNumberAsString);
            double secondOperand = double.Parse(secondNumberAsString);


            //Doing Math
            var sum = firstOperand + secondOperand;
            var difference = firstOperand - secondOperand;
            var product = firstOperand * secondOperand;
            var quotient = firstOperand / secondOperand;
            var remainder = firstOperand % secondOperand;
            Console.WriteLine($"If you add {firstOperand} and {secondOperand}, you get {sum}. If you subtract them, you get {difference}");
            Console.WriteLine($"If you multiply {firstOperand} and {secondOperand}, you get {product} and if you divide them, you get {quotient}");
            Console.WriteLine($"when you divide {firstOperand} by {secondOperand}, the remainder is {remainder}");

        }
    }
}
