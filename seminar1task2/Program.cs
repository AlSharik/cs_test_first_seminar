/*
Первый вариант, до того как я узнал у существовании int.parse
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
*/

System.Console.WriteLine("Write number");
int number = int.Parse(Console.ReadLine());

System.Console.WriteLine("Write square");
int square = int.Parse(Console.ReadLine());

if(number * number == square)
{
    System.Console.WriteLine("Yes");
}
else
{
    System.Console.WriteLine("No");
}
//