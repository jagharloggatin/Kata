﻿// See https://aka.ms/new-console-template for more information

#region Refresh how to generate random initialization data
Console.WriteLine(RandomDate());
Console.WriteLine(RandomCity());

static DateTime RandomDate()
{
    var rnd = new Random();
    while (true)
    {
        try
        {
            int year = rnd.Next(1980, DateTime.Today.Year);
            int month = rnd.Next(1, 13);
            int day = rnd.Next(1, 31);

            return new DateTime(year, month, day);
        }
        catch { }
    }
}

static string RandomCity()
{
    var rnd = new Random();
    string[] _cities = "Stockholm Göteborg Malmö".Split(' ');
    return _cities[rnd.Next(0, _cities.Length)];
}
#endregion