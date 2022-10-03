int Prompt( )
{
    Console.WriteLine("Write number >");
    string inputString = Console.ReadLine();
    int value = Convert.ToInt32(inputString);
    return value;
}

int number = Prompt();
int square = Prompt();
if(number * number == square)
{
    System.Console.WriteLine("Yes");
}
else
{
    System.Console.WriteLine("No");
}