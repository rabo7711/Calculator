CalculatorApp();
    void CalculatorApp()
{
    int firstNumber = 0;
    int secondNumber = 0;
    int result = 0;
    int choice = 0;
    Console.WriteLine("type 1st number, and then enter");
    firstNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("type 2nd number, and then enter");
    secondNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Choose an option from the following list");
    Console.WriteLine("1 - Add");
    Console.WriteLine("2 - Subtract");
    Console.WriteLine("3 - Divide");
    Console.WriteLine("4 - Multiply");

    choice = Convert.ToInt32(Console.ReadLine());
    if (choice == 1)
    {
        result = firstNumber + secondNumber;
        Console.WriteLine($"Adding {firstNumber} and {secondNumber} equals {result}");
    }
    else if (choice == 2)
    {
        result = firstNumber - secondNumber;
        Console.WriteLine($"Subtracting {firstNumber} and {secondNumber} equals {result}");
    }
    else if (choice == 3)
    {
        result = firstNumber / secondNumber;
        Console.WriteLine($"Dividing {firstNumber} and {secondNumber} equals {result}");
    }
    else if (choice == 4)
    {
        result = firstNumber * secondNumber;
        Console.WriteLine($"Multiplying {firstNumber} and {secondNumber} equals {result}");
    }
    else
    {
        Console.WriteLine("You did not select a valid number between 1 and 4");
    }
}


