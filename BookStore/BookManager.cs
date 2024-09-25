using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class BookManager
    {
        List<Book> Books;
        public BookManager()
        {
            Books = new List<Book>();
        }

        public void Add(Book book)
        {
            Books.Add(book);
            Console.WriteLine("Book Added Successfuly");
        }

        public void ViewAll()
        {
            Console.WriteLine("Books in Store");
            if (Books.Count > 0)
            {
                Console.WriteLine("Code".PadRight(15) + "Title".PadRight(15) + "Author".PadRight(15) + "Stock".PadRight(15)+ "Price");
                foreach (Book book in Books)
                {
                    Console.WriteLine(book.Code.PadRight(15) + book.Title.PadRight(15) + book.Author.PadRight(15) + book.Stock.ToString().PadRight(15) + book.Price);
                }
            }
            else
            {
                Console.WriteLine("Store is Empty. No Books Available");
            }
        }
        public void SearchByAuthor(string AuthorName)
        {
            List<Book> books = Books.Where(b => b.Author == AuthorName).ToList();

            if (books.Count > 0)
            {
                Console.WriteLine($"Books for the Author {AuthorName}");

                Console.WriteLine("Code".PadRight(15) + "Title".PadRight(15) + "Pages".PadRight(15) + "Stock".PadRight(15) + "Price");
                foreach (Book book in books)
                {
                    Console.WriteLine(book.Code.PadRight(15) + book.Title.PadRight(15) + book.Pages.ToString().PadRight(15) + book.Stock.ToString().PadRight(15)+ book.Price);
                }
            }
            else
            {
                Console.WriteLine($"No Books for the Author {AuthorName}");
            }
        }

        public void SearchByBookTitle(string BookTitle)
        {
            List<Book> books = Books.Where(b => b.Title.Contains(BookTitle, StringComparison.OrdinalIgnoreCase)).ToList();

            if (books.Count > 0)
            {
                Console.WriteLine($"Books with Title {BookTitle}");

                Console.WriteLine("Code".PadRight(15) + "Title".PadRight(15) + "Author".PadRight(15) + "Stock".PadRight(15) + "Price");
                foreach (Book book in books)
                {
                    Console.WriteLine(book.Code.PadRight(15) + book.Title.PadRight(15) + book.Author.PadRight(15) + book.Stock.ToString().PadRight(15)+ book.Price);
                }
            }
            else
            {
                Console.WriteLine($"No Books with Title {BookTitle}");
            }
        }

        public void CountBooks()
        {
            Console.WriteLine($"{Books.Count()} Books availble in store");
        }

    }
}
