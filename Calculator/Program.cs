CalculatorApp();
void CalculatorApp()
{
    try
    {
        Console.Write("Enter the first number: ");
        int FirstNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int SecondNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the operation (+,-,*,/): ");
        char Operation = Convert.ToChar(Console.ReadLine());
        int result=0;
        switch (Operation)
        {
            case '+':
                result = FirstNumber + SecondNumber;
                break;
            case '-':
                result = FirstNumber - SecondNumber;
                break;
            case '*':
                result = FirstNumber * SecondNumber;
                break;
            case '/':
                result = FirstNumber / SecondNumber;
                break;
            default:
                Console.WriteLine("Invalid operation");
                return;
        }
        Console.WriteLine($"Result: {result}");
    }
    catch(FormatException ex)
    {
        Console.WriteLine("Please enter a valid number.");
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"You cannot divide by zero.");
    }
    finally
    {
        Console.WriteLine("Operation Completed.");
    }
}