using System;



namespace TemperatureConverter

{

class Program

{

static void Main(string[] args)

{

Console.WriteLine("Vali temperatuurimuutuja:");

Console.WriteLine("1. Fahrenheit to Celsius");

Console.WriteLine("2. Celsius to Fahrenheit");

int userChoice = Int32.Parse(Console.ReadLine());



if (userChoice == 1)

{

Console.WriteLine("Sisesta Fahrenheit arv:");

double fahrenheit = Double.Parse(Console.ReadLine());

double celsius = ConvertToCelsius(fahrenheit);

Console.WriteLine($"{fahrenheit} Fahrenheit on {celsius} Celsius");

}

else if (userChoice == 2)

{

Console.WriteLine("Sisesta Celsius arv:");

double celsius = Double.Parse(Console.ReadLine());

double fahrenheit = ConvertToFahrenheit(celsius);

Console.WriteLine($"{celsius} Celsius on {fahrenheit} Fahrenheit");

}

else

{

Console.WriteLine("Vale valik!");

}

}



static double ConvertToCelsius(double fahrenheit)

{

return (fahrenheit - 32) * 5 / 9;

}



static double ConvertToFahrenheit(double celsius)

{

return (celsius * 9) / 5 + 32;

}

}

}