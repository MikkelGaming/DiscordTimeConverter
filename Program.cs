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
            SmartTimeAddition();
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

void SmartTimeAddition()
{
    long UnixTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

    Console.WriteLine("Format:\n1m = 1 min\n1h = 1 hour\n1d = 1 day\n1w = 1 week\n1M = 1 month\n1y = 1 year");
    string? addition = Console.ReadLine();
    if (addition != null)
    {
        Char[] chars = addition.ToCharArray();
        string addNum = addition.Substring(0, addition.Length - 1);
        long add;
        long.TryParse(addNum, out add);

        switch (chars[^1])
        {
            case 'm':
                UnixTime += add * 60;
            break;

            case 'h':
                UnixTime += add * 3600;
            break;

            case 'd':
                UnixTime += add * 86400;
            break;

            case 'w':
                UnixTime += add * 604800;
            break;

            case 'M':
                UnixTime += add * 2419200;
            break;

            case 'y':
                UnixTime += add * 2419200 * 12;
            break;
        }
    }

    Console.WriteLine($"<t:{UnixTime}:F>");
}


Menu();

