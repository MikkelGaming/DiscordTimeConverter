void Menu()
{
    Console.WriteLine("---Menu---\n[1] Current date and time\n[2] Add time onto current date\n[3] Write own date");
    string? choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            CurrentTime();
        break;

        case "2":
            AdditionTime();
        break;

        default: 
            Menu();
        break;

    }
} 

void CurrentTime()
{
    long UnixTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
    Console.WriteLine($"<t:{UnixTime}:F>");
}

void AdditionTime()
{
    long UnixTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
    Console.WriteLine("Input new date\n---Menu---\n1 min = 60\n1 hour = 3600\n24 hours = 86400\n1 week = 604800\n1 month = 2419200\n6 months = 14515200\n 1 year = 29030400\n");

    string? addition = Console.ReadLine();
    long.TryParse(addition, out long add);

    UnixTime += add;
    Console.WriteLine($"<t:{UnixTime}:F>");
}


Menu();

