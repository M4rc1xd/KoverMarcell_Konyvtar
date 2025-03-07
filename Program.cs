using System;

namespace Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("A kis herceg", "Antoine de Saint-Exupéry", 96, 1943);
            Book b2 = new Book("A pal utcai fiuk", "Molnár Ferenc", 256, 1907);
            Book b3 = new Book("Egri csillagok", "Gárdonyi Géza", 400, 1901);
            Book[] books = { b1, b2, b3 };
            Console.WriteLine(b1.GetBookByTitle(books, "A kis herceg"));
            Console.WriteLine(b1.GetBookByTitle(books, "A pal utcai fiuk"));
            Console.WriteLine(b1.GetBookByTitle(books, "Egri csillagok"));
            b1.EditBookData();
            System.Console.WriteLine(b1);
        }
    }
}