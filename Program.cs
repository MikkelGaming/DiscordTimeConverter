long UnixTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
Console.WriteLine($"<t:{UnixTime}:F>");
Console.WriteLine("Input new date\n---Menu---\n1 min = 60\n1 hour = 3600\n24 hours = 86400\n1 week = 604800\n1 month = 2419200\n6 months = 14515200\n 1 year = 29030400\n");

string addition = Console.ReadLine();
long.TryParse(addition, out long add);
UnixTime += add;
Console.WriteLine($"<t:{UnixTime}:F>");