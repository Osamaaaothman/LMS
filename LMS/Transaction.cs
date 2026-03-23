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
        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("========================================");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($" Transaction #{Id}");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" Book: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(BookTitle);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" Member: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(MemberName);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" Date: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(BorrowDate.ToString("yyyy-MM-dd HH:mm"));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" Type: ");

            if (Type == TransactionType.Borrow)
                Console.ForegroundColor = ConsoleColor.Green;
            else
                Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(Type);

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("========================================");

            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
