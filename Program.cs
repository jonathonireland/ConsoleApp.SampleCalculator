// See https://aka.ms/new-console-template for more information

// Welcome Message
Console.WriteLine("Welcome to the sample calculator!");

// Variable Declarations
int operation = 0;

int num1, num2 = 0;

// Show Calculator Options

while (operation != -1)
{
    Console.WriteLine("Please select an operation (-1 to exit)");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Fibonacci sequence");
    
    try
    {
        operation = Convert.ToInt32(Console.ReadLine());
    } 
    catch (Exception)
    {
        Console.WriteLine("Invalid input, press any key to try again. ");
        Console.ReadLine();
        Console.Clear();
        continue;
    }

    if(operation == -1)
    {
        break;
    }

    try
    {
        // Prompt user for input
        Console.Write("Please enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
    } 
    catch (Exception)
    {
        Console.WriteLine("Invalid input, press any key to try again. ");
        Console.ReadLine();
        Console.Clear();
        continue;
    }
    // Decide which operation is needed based on selected option

    int answer = 0;
    switch (operation)
    {
        case 1:
            answer = num1 + num2;
            break;
        case 2:
            answer = num1 - num2;
            break;
        case 3:
            answer = num1 * num2;
            break;
        case 4:
            try
            { 
                answer = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                Console.WriteLine("Press Enter to continue. ");
                Console.ReadLine();
                Console.Clear();
                continue;
            }
            catch (Exception)
            {
                throw;
            }
            break;
        case 5:
            for (int i = num1; i <= num2; i++)
            {
                answer += i;
            }
            break;
        default:
            Console.WriteLine("Invalid Choice, Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            continue;
    }

    // print output
    Console.WriteLine($" the solution is {answer}");
    Console.WriteLine($"Press Enter to continue");
    Console.ReadLine();
    Console.Clear();

}

Console.WriteLine("**************** - Thank you for using the sample Calculator! - ******************");