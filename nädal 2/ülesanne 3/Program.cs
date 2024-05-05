console.WriteLine("Are you sure you wwant to delete the file y/n?");

char userChoice = Char.Parse(Console.ReadLine());
if(userChoice == 'y')
{
console.WriteLine("The file has been deleted.");
}
else
console.WriteLine("Cancelled.");