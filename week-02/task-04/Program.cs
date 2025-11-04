int[] numbers = [2, 1, 3, 5, 4];

Array.Sort(numbers);
foreach (int num in numbers)
{
    Console.Write(num + " ");
}
Console.WriteLine("\n");

Array.Reverse(numbers);
foreach (int num in numbers)
{
    Console.Write(num + " ");
}
Console.WriteLine("\n");

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}
Console.WriteLine("\n");

int findNumber = 3;
int index = Array.IndexOf(numbers, findNumber);
Console.WriteLine($"Index of {findNumber} is {index}.");
