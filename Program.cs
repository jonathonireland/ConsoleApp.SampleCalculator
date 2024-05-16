// See https://aka.ms/new-console-template for more information

// Welcome Message
Console.WriteLine("Welcome to the sample calculator!");


// Show Calculator Options
Console.WriteLine("Please select an operation");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
int operation = Convert.ToInt32(Console.ReadLine());


// Prompt user for input
Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// Decide which operation is needed based on selected option

int resultOfOutput = 0;
switch (operation)
{
    case 1:
        int sum = num1 + num2;
        resultOfOutput = sum;
        break;
    case 2:
        int difference = num1 - num2;
        resultOfOutput = difference;
        break;
    case 3:
        int product = num1 * num2;
        resultOfOutput = product;
        break;
    case 4:
        int quotient = num1 / num2;
        resultOfOutput = quotient;
        break;
    default:
        Console.WriteLine("Invalid Choice");
        break;
}

// print output
Console.WriteLine($" the solution is {resultOfOutput}");

