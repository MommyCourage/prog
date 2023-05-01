using System;

using System.Security.Cryptography;

namespace Lab

{

class Program

{

public enum Cities

{

Kyiv,

Kharkiv,

Lviv,

Madrid,

Barcelona,

Toledo,

Venice,

Rome,

Florence

}

static void Main(string[] args)

{

Console.WriteLine("Cities in Ukraine: ");

Console.WriteLine($"{(int)Cities.Kyiv} – {Cities.Madrid}");

Console.WriteLine($"{(int)Cities.Kharkiv} – {Cities.Kharkiv}");

Console.WriteLine($"{(int)Cities.Lviv} – {Cities.Lviv}");

Console.WriteLine("Cities in Spain: ");
Console.WriteLine($"{(int)Cities.Madrid} – {Cities.Madrid}");

Console.WriteLine($"{(int)Cities.Barcelona} – {Cities.Barcelona}");

Console.WriteLine($"{(int)Cities.Toledo} – {Cities.Toledo}");

Console.WriteLine("Cities in Italy: ");

Console.WriteLine($"{(int)Cities.Venice} – {Cities.Venice}");

Console.WriteLine($"{(int)Cities.Rome} – {Cities.Rome}");

Console.WriteLine($"{(int)Cities.Florence} – {Cities.Florence}");

Console.Write("\nEnter the cities you want to visit (separated by commas): ");

string str = Console.ReadLine();

List<string> nums = str.Split(',').ToList();

nums = nums.Distinct().ToList();

Console.WriteLine("\nThe cities you want to visit: \n");

foreach (var element in nums)

{

Console.WriteLine($"{element} - {(Cities)int.Parse(element)}");

}

Console.WriteLine("\nPolina Teslya\n");

}

}

}