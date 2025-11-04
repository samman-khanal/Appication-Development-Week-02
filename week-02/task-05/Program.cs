DateTime birthDate = new DateTime(2005, 10, 27);

DateTime currentDate = DateTime.Now;

TimeSpan age = currentDate - birthDate;
int ageInYear = (int)(age.TotalDays / 365.25);

Console.WriteLine($"BirthDate: {birthDate.ToShortDateString()}");
Console.WriteLine($"Current Date: {currentDate.ToShortDateString()}");
Console.WriteLine($"Age in years: {ageInYear}");

DateTime newBirthDate = birthDate.AddDays(10);
Console.WriteLine($"New BirthDate after adding 10 days: {newBirthDate.ToShortDateString()}");
