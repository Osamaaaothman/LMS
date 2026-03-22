using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public bool IsBorrowed { get; set; }

        public Book(int id,string title,string author,double price)
        {
            this.Author = author;
            this.Id = id;
            this.Price = price;
            this.Title = title;
            this.IsBorrowed = false;
        }

        public void display()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=== Book Info ===");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("ID: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Id);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Title: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Title);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Author: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Author);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Price: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"${Price}");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Status: ");
            Console.ForegroundColor = IsBorrowed ? ConsoleColor.Red : ConsoleColor.Green;
            Console.WriteLine(IsBorrowed ? "Borrowed" : "Available");

            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
