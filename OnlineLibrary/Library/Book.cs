namespace Library
{
    public class Book
    {
        private string? ISBN;
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }

        public Book(string isbn, string title, string author, int publicyear)
        {
            SetISBN(isbn);
            this.Title = title;
            this.Author = author;
            this.PublicationYear = publicyear;
        }

        public void SetISBN(string isbn)
        {
            if (isbn.Length >= 8 && isbn.Length <= 10)
            {
                this.ISBN = isbn;
            }
            else
            {
                System.Console.WriteLine("Длина ISBN должна быть от 8 до 10 символов.");
            }
        }

        public string GetISBN()
        {
            return ISBN != null ? $"ISBN: {ISBN}" : "ISBN не установлен.";
        }

        public void ShowInfo()
        {
            System.Console.WriteLine($"Title: {Title}, Author: {Author}, PublYear: {PublicationYear}, {GetISBN()}");
        }
    }
}
