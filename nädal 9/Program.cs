if (File.Exists(Path.Combine(folderPath, fileName)))
{
Console.WriteLine($"File {fileName} exists.");

}
else
{
Console.WriteLine($"File {fileName} does not exist.");
}