string path = @"C:\Users\JV\data";
string fileName = "chuck.txt";

string[] lines = File.ReadAllLines(Path.Combine(path, fileName));
   
foreach (string hero in lines)
{
    Console.WriteLine(hero);
}