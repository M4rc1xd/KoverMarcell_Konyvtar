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
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);
            Book[] books = { b1, b2, b3 };
            b1.GetBookTitle(books);
        }
    }
}