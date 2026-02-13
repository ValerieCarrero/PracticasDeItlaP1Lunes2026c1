int TypedNumber = 0;
bool IsValidNumber = false;

Console.WriteLine("Par or Odd Number Validator");
Console.WriteLine("------------------------------");

while (!IsValidNumber)
{
    Console.WriteLine("Enter a number: ");
    try
    {
        TypedNumber = Convert.ToInt32(Console.ReadLine());
        IsValidNumber = true;

    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
    }

    catch (OverflowException)
    {
        Console.WriteLine("The number is too large or too small");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Unexpected error: {ex.Message}");
    }

}

if (TypedNumber % 2 == 0)
{
    Console.WriteLine($"The number {TypedNumber} is even.");
}
else
{
    Console.WriteLine($"The number {TypedNumber} is odd.");
}
