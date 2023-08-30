// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter your name");
string name = Console.ReadLine();

Console.WriteLine("Please enter your age");
string age = Console.ReadLine();

Console.WriteLine("In which country do you live?");
string country = Console.ReadLine();

Console.WriteLine($"Hello, my name is {name}. I'm {age} years old and I live in {country}.");

Console.ReadLine();