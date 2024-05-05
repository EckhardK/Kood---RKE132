Console.WriteLine("Enter your year of birth");
int yearOfBirth = Int32.Parse(Console.ReadLine())
int userAge = DateTime.Now.Year - yearOfBirth;

Console.WriteLine($"You are {userAge} years old.")