using Kata2_IEquitable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata2_IEquatable
{
    internal class MemberList : IMemberList
    {
        private List<Member> _members = new List<Member>();

        public Member this[int idx]
        {
            get
            {
                return _members[idx];
            }
        }

        public MemberList()
        {
            for (int i = 0; i < 10; i++)
            {
                _members.Add(new Member());
            }
        }
        public int Count()
        {
            return _members.Count();
        }
        public int Count(int year)
        {
            return 0;
        }
        public void Sort()
        {
            _members.Sort((x, y) => x.FirstName.CompareTo(y.FirstName));
            _members.Sort((x, y) => x.LastName.CompareTo(y.LastName));
            _members.Sort((x, y) => x.Level.CompareTo(y.Level));
            _members.Sort((x, y) => x.Since.CompareTo(y.Since));
            _members.Sort();
        }

        public override string ToString()
        {
            string sRet = "";
            for (int i = 0; i < _members.Count; i++)
            {
                sRet += $"{_members[i]}";
                if ((i + 1) % 13 == 0)
                {
                    sRet = sRet + "\n";
                }
            }
            return sRet;
        }
    }
}
