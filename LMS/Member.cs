using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    public abstract class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Book[] Books { get; set; }
        public int BorrowIndex { get; set; }

        public Member(int id,string name,string phone)
        {
            this.Name = name;
            this.Id = id;
            this.Phone = phone;
            this.Books = new Book[GetMaxBorrowLimit()];
        }
        public bool BorrowBook(Book book)
        {
            if (book.IsBorrowed)
            {
                return false;
            }
            if (BorrowIndex < this.GetMaxBorrowLimit())
            {
                book.IsBorrowed = true;
                Books[BorrowIndex] = book;
                BorrowIndex++;
                return true;
            } 
            return false;
        }

        public bool ReturnBook(Book book)
        {
            if (BorrowIndex == 0)
            {
                return false;
            }
            for (int i=0;i<BorrowIndex;i++)
            {
                if (Books[i].Id == book.Id)
                {
                    Books[i]=Books[BorrowIndex-1];
                    Books[BorrowIndex - 1] = null;
                    BorrowIndex--;
                    return true;
                }
            }
            return false;
        }
        public abstract int GetMaxBorrowLimit();


    }
}
