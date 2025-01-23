namespace Library
{
    public class Librari
    {
        public string Name { get; set; }
        private int index = 0;
        private Book[] Books;

        public Librari(string name, int razmer)
        {
            this.Name = name;
            this.Books = new Book[razmer];
        }

        public void Dobavit(Book book)
        {
            if (index < Books.Length)
            {
                Books[index] = book;
                index++;
            }
            else
            {
                System.Console.WriteLine("Book ne dobavlena");
            }
        }

        public void AuthorFind(string author)
        {
            bool found = false;
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i] != null && Books[i].Author == author)
                {
                    System.Console.WriteLine($"Title: {Books[i].Title}, Author: {Books[i].Author}, PublYear: {Books[i].PublicationYear}");
                    found = true;
                }
            }

            if (!found)
            {
                System.Console.WriteLine($"Book {author} not found");
            }
        }
    }
}
