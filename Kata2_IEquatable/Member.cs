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

        public int CompareTo(IMember? other)
        {
            throw new NotImplementedException();
        }

        public bool Equals(IMember? other)
        {
            throw new NotImplementedException();
        }

        public void RandomInit()
        {
            throw new NotImplementedException();
        }
    }
}
