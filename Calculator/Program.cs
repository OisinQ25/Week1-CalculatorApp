// See https://aka.ms/new-console-template for more information

// Integer stores first number
// Ask user to input first number
Console.WriteLine("Type in the first number followed by the Enter key");
int firstNumber = Convert.ToInt32(Console.ReadLine());

// Integer stores second number
// Ask user to input second number
Console.WriteLine("Type in the second number followed by the Enter key");
int secondNumber = Convert.ToInt32(Console.ReadLine());

// Perform Calculation
int result = firstNumber + secondNumber;

// Output to screen
Console.WriteLine("Adding {0} and {1} give the answer {2}" , firstNumber, secondNumber, result);