Console.WriteLine("enter the color of the traffic light:");
string
 userColor = Console.ReadLine().ToLower();
if
(userColor == "red"
)
{
Console.WriteLine("Hold");
}
else if (userColor == "yellow")
{
Console.WriteLine("Get ready");
}
else if (userColor == "green")
{
Console.WriteLine("Go!");
}
else
{
Console.WriteLine("The trafficlight is broken.");