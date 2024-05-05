Console.WriteLine("Enter your age.");


int userAge = Int 32.Parse(Console.ReadLine());

if (userAge > 18)
{
Console.WriteLine("You are too young to drive on your own.");
}
else if (userAge < 18)
{
Console.WriteLine("You are old enough to drive on your own.");
}
else
{
Console.WriteLine("Congratulations! You've turned eghteen and may apply for your driving license now.");
}