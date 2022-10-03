int Prompt( )
{
    Console.WriteLine("Write number >");
    string inputString = Console.ReadLine();
    int value = Convert.ToInt32(inputString);
    return value;
}

int value = Prompt();   
int square = value * value;
Console.WriteLine($"Square of {value} is {square}");   