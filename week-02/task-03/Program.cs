byte b = 1;
short s = 11;
int i = 111;
float f = 111.1f;
double d = 1111.11;
char c = 'A';
bool isTrue = true;

int number = 42;
string numberString = number.ToString();

string piStringValue = "3.14";
double piDoubleValue = double.Parse(piStringValue); 

Console.WriteLine($"byte: {b}");
Console.WriteLine($"short: {s}");
Console.WriteLine($"int: {i}");
Console.WriteLine($"float: {f}");
Console.WriteLine($"double: {d}");
Console.WriteLine($"char: {c}");
Console.WriteLine($"bool: {isTrue}");
Console.WriteLine($"Converted int to string: {numberString}");
Console.WriteLine($"Converted string to double: {piDoubleValue}");