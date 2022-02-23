using Kata2_IEquitable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata2_IEquatable
{
    internal class Member : IMember
    {


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public MemberLevel Level { get; set; }
        public DateTime Since { get; set; }
        public override int GetHashCode() => (FirstName, LastName, Level, Since).GetHashCode();

        public Member()
        {
            RandomInit();
        }

        public int CompareTo(IMember? other) 
        {
            return this.Level.CompareTo(other.Level);
        }

        public bool Equals(IMember? other)
        {
            return (this.FirstName, this.LastName, this.Level, this.Since) == (other.FirstName, other.LastName, other.Level, other.Since);  
        }

        public void RandomInit()
        {
            FirstName = RandomFirstName();
            LastName = RandomLastName();
            Level = RandomLevel();
            Since = RandomDateTime();

        }
        private string RandomFirstName()
        {
            var rnd = new Random();
            string[] _firstName = "Ferridoun Sophie Jennifor Jonathan".Split(' ');
            return _firstName[rnd.Next(0, _firstName.Length)];
        }
        private string RandomLastName()
        {
            var rnd = new Random();
            string[] _lastName = "Emiiin Lindström Björklund Bravo".Split(' ');
            return _lastName[rnd.Next(0, _lastName.Length)];
        }
        private MemberLevel RandomLevel()
        {
            var rnd = new Random();
            while (true)
            {
                try
                {
                    int day = rnd.Next(0, 3);

                    return new MemberLevel();
                }
                catch { }
            }
        }
        private DateTime RandomDateTime()
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
    }
}
