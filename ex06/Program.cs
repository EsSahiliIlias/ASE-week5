List<double> firstList = GenerateRandomNumbers(10);


List<int> secondList = GenerateRandomIntegers(10);

var mergedList = firstList.Select(n => n.ToString()).Concat(secondList.Select(n => n.ToString()));

Console.WriteLine("Merged List:");
foreach (var item in mergedList)
{
    Console.WriteLine(item);
}

static List<double> GenerateRandomNumbers(int count)
{
    Random random = new Random();
    List<double> randomNumbers = new List<double>();

    for (int i = 0; i < count; i++)
    {
        randomNumbers.Add(random.NextDouble() * 100);
    }

    return randomNumbers;
}

static List<int> GenerateRandomIntegers(int count)
{
    Random random = new Random();
    List<int> randomIntegers = new List<int>();

    for (int i = 0; i < count; i++)
    {
        randomIntegers.Add(random.Next(1, 100));
    }

    return randomIntegers;
}