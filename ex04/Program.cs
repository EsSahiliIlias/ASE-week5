List<string> cities = new List<string> { "London", "Paris", "Milan", "New York", "Los Angeles" };

// 1. All cities starting with L
var citiesStartingWithL = cities.Where(city => city.StartsWith("L"));

Console.WriteLine("Cities starting with L:");
foreach (var city in citiesStartingWithL)
{
    Console.WriteLine(city);
}

// 2. All cities starting with L and ending with N
var citiesStartingAndEndingWithLAndN = cities.Where(city => city.StartsWith("L") && city.EndsWith("n"));

Console.WriteLine("\nCities starting with L and ending with N:");
foreach (var city in citiesStartingAndEndingWithLAndN)
{
    Console.WriteLine(city);
}

// 3. All cities with a length of 6
var citiesWithLengthSix = cities.Where(city => city.Length == 6);

Console.WriteLine("\nCities with a length of 6:");
foreach (var city in citiesWithLengthSix)
{
    Console.WriteLine(city);
}