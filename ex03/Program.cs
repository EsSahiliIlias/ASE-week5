List<int> randomNumbers = GenerateRandomNumbers(50);

var orderedList = randomNumbers.OrderBy(num => num);
Console.WriteLine("Ordered List:");
Console.WriteLine(string.Join(", ", orderedList));

var evenNumbers = randomNumbers.Where(num => num % 2 == 0);
Console.WriteLine("\nEven Numbers:");
Console.WriteLine(string.Join(", ", evenNumbers));

var oddNumbers = randomNumbers.Where(num => num % 2 != 0);
Console.WriteLine("\nOdd Numbers:");
Console.WriteLine(string.Join(", ", oddNumbers));

var divisibleBy3 = randomNumbers.Where(num => num % 3 == 0);
Console.WriteLine("\nNumbers Divisible by 3:");
Console.WriteLine(string.Join(", ", divisibleBy3));

var divisibleBy3And5 = randomNumbers.Where(num => num % 3 == 0 && num % 5 == 0);
Console.WriteLine("\nNumbers Divisible by 3 and 5:");
Console.WriteLine(string.Join(", ", divisibleBy3And5));

var numbersSmallerThan30 = randomNumbers.Where(num => num < 30);
Console.WriteLine("\nNumbers Smaller Than 30:");
Console.WriteLine(string.Join(", ", numbersSmallerThan30));

var numbersBetween20And30 = randomNumbers.Where(num => num > 20 && num < 30);
Console.WriteLine("\nNumbers Between 20 and 30:");
Console.WriteLine(string.Join(", ", numbersBetween20And30));

var sum = numbersBetween20And30.Sum();
Console.WriteLine($"\nSum of Numbers Between 20 and 30: {sum}");

var average = numbersBetween20And30.Average();
Console.WriteLine($"Average of Numbers Between 20 and 30: {average}");

var max = numbersBetween20And30.Max();
Console.WriteLine($"Max of Numbers Between 20 and 30: {max}");

var min = numbersBetween20And30.Min();
Console.WriteLine($"Min of Numbers Between 20 and 30: {min}");

var firstBiggerThan20 = randomNumbers.First(num => num > 20);
Console.WriteLine($"\nFirst Number Bigger Than 20: {firstBiggerThan20}");

var incrementedValues = randomNumbers.Select(num => num + 1);
Console.WriteLine("\nIncremented Values:");
Console.WriteLine(string.Join(", ", incrementedValues));


static List<int> GenerateRandomNumbers(int count)
{
    Random random = new Random();
    List<int> numbers = new List<int>();
    for (int i = 0; i < count; i++)
    {
        numbers.Add(random.Next(1, 101)); // Generate random numbers between 1 and 100
    }
    return numbers;
}