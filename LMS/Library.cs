using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    public class Library
    {
        private int totalBooks;
        private int totalMembers;
        private int totalTransactions;
        public Book[]Books { get; set; }
        public Member[]Members { get; set; }
        public Transaction[]Transactions { get; set; }
        public static int TotalBorrowedBooks { get; set; }
        public Library(int booksNum, int memberNum, int transactionsNum) { 
            this.Members = new Member[memberNum];
            this.Books = new Book[booksNum];
            this.Transactions = new Transaction[transactionsNum];
            totalTransactions = 0;
            totalMembers = 0;
            totalBooks = 0;
        }

        public bool AddBook(Book book) {
            Books[totalBooks] = book;
            totalBooks++;
            return true;
        }
        public bool AddMember(Member mem)
        {
            Members[totalMembers] = mem;
            totalMembers++;
            return true;
        }

        public bool BorrowBook(int memberId,int bookId )
        {
            Book book = null;
            Member member = null;
            foreach (Book b in Books)
            {
                if (b.Id == bookId)
                {
                    book = b;
                    break;
                }
            }
            foreach (Member m in Members)
            {
                if (m.Id == memberId)
                {
                    member = m;
                    break;
                }
            }
            if (book == null)
            {
                Console.WriteLine("Book not found");
                return false;
            }
            if (member == null)
            {
                Console.WriteLine("Member not found");
                return false;
            }
            if (member.BorrowBook(book))
            {
                Transaction t=new Transaction();
                t.BookTitle = book.Title;
                t.MemberName = member.Name;
                t.BorrowDate = DateTime.Now;
                t.Type = TransactionType.Borrow;
                Transactions[totalTransactions] = t;
                totalTransactions++;
                TotalBorrowedBooks++;
                return true;

            }
            else
            {
                Console.WriteLine("Borrowing failed. Member may have reached the borrowing limit or the book is already borrowed.");
                return false;
            }


        }


        
    }
}
