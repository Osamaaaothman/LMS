using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    public class StudentMember : Member
    {

        public StudentMember(int id,string name,string phone) : base(id,name,phone)
        {

        }

        public override int GetMaxBorrowLimit()
        {
            return 3;
        }

    }
}
