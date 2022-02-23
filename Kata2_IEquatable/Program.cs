// See https://aka.ms/new-console-template for more information

#region Refresh how to generate random initialization data
using Kata2_IEquatable;

//Console.WriteLine(RandomDate());
//Console.WriteLine(RandomCity());

var member = new Member();

//Console.WriteLine($"\t{member.FirstName}\t{member.LastName}\t{member.Level}\t{member.Since}");

var _memberList = new MemberList();

for (int i = 0; i < _memberList.Count(); i++)
{
    Console.WriteLine($"{_memberList[i].FirstName}");
    Console.WriteLine($"{_memberList[i].LastName}");
    Console.WriteLine($"{_memberList[i].Level}");
    Console.WriteLine($"{_memberList[i].Since}\n");
}

static DateTime RandomDate()
{
    var rnd = new Random();
    while (true)
    {
        try
        {
            int year = rnd.Next(1980, DateTime.Today.Year);
            int month = rnd.Next(1, 13);
            int day = rnd.Next(1, 32);

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