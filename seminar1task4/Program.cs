System.Console.WriteLine("Write any number:");
int max = Convert.ToInt32(Console.ReadLine());
int min = max * -1;

if (max <= min)
{
    max = max * -1;
    min = min * -1;
}

while(min <= max)
{
    System.Console.WriteLine(min);
    min++;
}