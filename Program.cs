// See https://aka.ms/new-console-template for more information

void PrintMenu()
{
    Console.WriteLine("Please select an operation (-1 to exit)");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Fibonacci sequence");
}

// Addition Method for Switch Case
int Sum(int num1, int num2)
{
    return num1 + num2;
}

// Subtraction Method for Switch Case 
int Difference(int num1, int num2) 
{
    return num1 - num2;
}

// Multiplication Method for Switch Case
int Product(int num1, int num2)
{
    return num1 * num2;
}

// Divide Method for Switch Case
int Quotient(int num1, int num2)
{
    return num1 / num2;
}

// Fibonnaci Method for Switch Case 
int Fibonnaci(int num1, int num2) 
{
    int answer = 0;
    for (int i = num1; i <= num2; i++)
    {
        answer += i;
    }
    return answer;
}

// Welcome Message
Console.WriteLine("Welcome to the sample calculator!");

// Variable Declarations
int operation = 0;
int num1 = 0; 
int num2 = 0;

// Show Calculator Options

while (operation != -1)
{
    try
    {
        // Welcome Message
        PrintMenu();

        operation = Convert.ToInt32(Console.ReadLine());

        if (operation == -1)
        {
            break;
        }

        // Prompt user for input
        Console.Write("Please enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        // Decide which operation is needed based on selected option

        int answer = 0;
        switch (operation)
        {
            case 1:
                answer = Sum(num1, num2);
                break;
            case 2:
                answer = Difference(num1, num2);
                break;
            case 3:
                answer = Product(num1, num2);
                break;
            case 4:
                answer = Quotient(num1, num2);
                break;
            case 5:
                answer = Fibonnaci(num1, num2);
                break;
            default:
                throw new Exception("Invalid Menu Item Selected.");
        }

        // print output
        Console.WriteLine($" the solution is {answer}");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Cannot divide by zero");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally 
    {
        Console.WriteLine("Press any key to try again. ");
        Console.ReadLine();
        Console.Clear();
    }
}


Console.WriteLine("**************** - Thank you for using the sample Calculator! - ******************");