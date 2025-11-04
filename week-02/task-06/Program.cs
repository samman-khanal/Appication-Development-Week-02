List<string> fruits = new List<string>
{
    "Apple",
    "Banana",
    "Orange"
};
fruits.Add("Grapes");

fruits.Remove("Banana");

Console.WriteLine("Fruits in the list:");
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

Dictionary<int, string> fruitList = new Dictionary<int, string>
{
    { 1, "Apple" },
    { 2, "Orange"},
    { 3, "Grapes" }
};
fruitList.Add(4, "Mango");

Console.WriteLine("\nFruits in the dictionary:");
foreach (KeyValuePair<int, string> item in fruitList)
{
    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
}
