namespace Books
{
    public class Book
    {
        string title;
        string author;
        int pageCount;
        int releaseYear;

        public Book(string title, string author, int pageCount, int releaseYear)
        {
            this.title = title;
            this.author = author;
            this.pageCount = pageCount;
            this.releaseYear = releaseYear;
        }

        public string Title {get => title;}
        public string Author {get => author;}
        public int PageCount {get => pageCount;}
        public int ReleaseYear {get => releaseYear;}

        public string GetBookByTitle(Book[] books, string title){
            foreach (var book in books)
            {
                if (book.Title == title)
                {
                    return book.ToString();
                }
            }
            return "Nincs ilyen könyv!";
        }

        public void EditBookData(){
            System.Console.WriteLine("Kérem adja meg a könyv új címét:");
            this.title = System.Console.ReadLine();
            System.Console.WriteLine("Kérem adja meg a könyv új szerzőjét:");
            this.author = System.Console.ReadLine();
            System.Console.WriteLine("Kérem adja meg a könyv új oldalszámát:");
            this.pageCount = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Kérem adja meg a könyv új megjelenési évét:");
            this.releaseYear = int.Parse(System.Console.ReadLine());
        }
        public override string ToString()
        {
            return $"{this.author}: {this.title} - {this.pageCount} oldal. Megjelenés: {this.releaseYear}";
        }
    }
}