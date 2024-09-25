namespace BookStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookManager manager = new BookManager();
            while (true)
            {
                Console.WriteLine("Welcome to Book Store System");
                Menu(manager);
            }
        }


        private static void Menu(BookManager manager)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Display All Books");
            Console.WriteLine("3. Search Book By Author");
            Console.WriteLine("4. Search Book By Title");
            Console.WriteLine("5. Count of Books");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option (1-6): ");
            int choice = Convert.ToInt32(Console.ReadLine());
            
            Console.Clear();

            if (choice == (int)BookMenuItem.add)
            {
                AddNewBook(manager);
                PauseForContinue();
            }
            else if (choice == (int)BookMenuItem.viewAll)
            {
                manager.ViewAll();
                PauseForContinue();
            }
            else if (choice == (int)BookMenuItem.searchByAuthor)
            {
                SearchByAuthor(manager);
                PauseForContinue();
            }
            else if (choice == (int)BookMenuItem.searchByTitle)
            {
                SearchByTitle(manager);
                PauseForContinue();
            }
            else if (choice == (int)BookMenuItem.bookCount)
            {
                manager.CountBooks();
                PauseForContinue();
            }
            else if (choice == (int)BookMenuItem.exit)
            {
                Environment.Exit(0);
                PauseForContinue();
            }
            else 
            {
                Console.WriteLine("Invalid choice. please try again.");
                PauseForContinue();
            }
        }
        private static void AddNewBook(BookManager manager)
        {
            Book newBook = new Book();

            Console.Write("Enter Book Code: ");
            newBook.Code = Console.ReadLine();

            Console.Write("Enter Book Title: ");
            newBook.Title= Console.ReadLine();

            Console.Write("Enter Book Author: ");
            newBook.Author = Console.ReadLine();

            Console.Write("Enter Book Pages Number: ");
            newBook.Pages = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Book Price: ");
            newBook.Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Stock: ");
            newBook.Stock = Convert.ToInt32(Console.ReadLine());

            manager.Add(newBook);
        }

        private static void SearchByAuthor(BookManager manager)
        {
            Console.Write("Enter Author Name to Search: ");
            string AuthorName = Console.ReadLine();

            manager.SearchByAuthor(AuthorName);
        }

        private static void SearchByTitle(BookManager manager)
        {
            Console.Write("Enter book title to Search: ");
            string title = Console.ReadLine();

            manager.SearchByBookTitle(title);
        }

        private static void PauseForContinue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}