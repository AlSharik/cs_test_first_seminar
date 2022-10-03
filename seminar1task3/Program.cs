/*
int Prompt( )
{
    Console.WriteLine("Write number >");
    string inputString = Console.ReadLine();
    int value = Convert.ToInt32(inputString);
    return value;
}

int day = Prompt();
switch(day)
{
    case 1:
        System.Console.WriteLine("Понедельник");
        break;
    case 2:
        System.Console.WriteLine("Вторник");
        break;
    case 3:
        System.Console.WriteLine("Среда");
        break;
    case 4:
        System.Console.WriteLine("Четверг");
        break;
    case 5:
        System.Console.WriteLine("Пятницы");
        break;
    case 6:
        System.Console.WriteLine("Суббота");
        break;
    case 7:
        System.Console.WriteLine("Воскресенье");
        break;
    default:
        System.Console.WriteLine("Такого дня недели не существует");
        break;
}
*/

Console.WriteLine("Write number day of the week");
int day = Convert.ToInt32(Console.ReadLine());
//int day = int.Parse(Console.ReadLine());
string [] days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
if( day >= 1 && day <= 7)
{
    System.Console.WriteLine(days[day-1]);
}
else
{
    System.Console.WriteLine("Такого дня недели не существует");
}