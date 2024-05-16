// See https://aka.ms/new-console-template for more information

// Welcome Message
Console.WriteLine("Welcome to the sample calculator!");


// Show Calculator Options
Console.WriteLine("Please select an operation (-1 to exit)");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
Console.WriteLine("5. Fibonacci sequence");
int operation = Convert.ToInt32(Console.ReadLine());

while (operation != -1)
{
    // Prompt user for input
    Console.Write("Please enter the first number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Please enter the second number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

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
            answer = num1 / num2;
            break;
        case 5:
            for (int i = num1; i <= num2; i++)
            {
                answer += i;
            }
            break;
        default:
            Console.WriteLine("Invalid Choice");
            break;
    }

    // print output
    Console.WriteLine($" the solution is {answer}");
    Console.WriteLine($"Press Enter to continue");
    Console.ReadLine();
    Console.Clear();

    // Show Calculator Options
    Console.WriteLine("Please select an operation (-1 to exit)");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Fibonacci sequence");
    operation = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("**************** - Thank you for using the sample Calculator! - ******************");