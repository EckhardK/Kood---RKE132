Console.WriteLine("Sisesta oma hinne: ");

string input = Console.ReadLine().ToUpper();

if (input.Length != 1)

{
Console.WriteLine("Vale väärtus");
}
else
{
char grade = input[0];

if (grade == 'A')
{
Console.WriteLine("Suurepärane!");
}
else if (grade == 'B')
{
Console.WriteLine("Väga hea!");
}
else if (grade == 'C')
{
Console.WriteLine("Hea!");
}
else if (grade == 'D')
{
Console.WriteLine("Rahuldav");
}
else if (grade == 'E')
{
Console.WriteLine("Kasin");
}
else if (grade == 'F')
{
Console.WriteLine("Puudulik");
}
else
{
Console.WriteLine("Vale väärtus");
}
}