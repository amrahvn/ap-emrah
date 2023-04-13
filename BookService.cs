using BookApp1.Core.Models;

namespace BookApp1.App.Services
{
    internal class BookService
    {
        private Book[] books = new Book[0];

        public void GetFullInfo()
        {

            if (books.Length == 0)
            {
                Console.WriteLine("book not included");
            }
            foreach (Book books in books)
            {
                books.GetFullInfo();
            }
        }

              public void Createbooks()
            {
                Book book = new Book();

                Console.WriteLine("Please, enter a book name");
                book.Name = Console.ReadLine();
                Console.WriteLine("Please, enter the price of the book");
                book.Price = double.Parse(Console.ReadLine());

                Array.Resize(ref books, books.Length + 1);
                books[books.Length - 1] = book;
              }
    }
}

