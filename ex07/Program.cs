List<int> firstList = new List<int> { 1, 2, 3, 4, 5 };
List<int> secondList = new List<int> { 4, 5, 6, 7, 8 };
List<int> commonElements = firstList.Intersect(secondList).ToList();

Console.WriteLine("Common Elements:");
foreach (var element in commonElements)
{
    Console.WriteLine(element);
}