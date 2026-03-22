using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{

    public enum TransactionType
    {
        Borrow,
        Return
    }
    public class Transaction
    {
        public int Id { get; set; }
        public string BookTitle { get; set; }
        public string MemberName { get; set; }
        public DateTime BorrowDate { get; set; }
        public TransactionType Type { get; set; }

    }
}
