using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class Program
    {
         Author[] authors;
         List<Book> books;
        User user;
        static int option;
        static void Main(string[] args)
        {
            Program objProgram = new Program();
            objProgram.FillData();
            objProgram.ShowMenu();
            objProgram.SelectOption();

        }
        public Program()
        {
            user = new User();
        }
        private void ShowMenu()
        {
           
            Console.WriteLine("---------------------- Book Store ----------------------");
            Console.ResetColor();          
            Console.WriteLine("1. View  Books");
            Console.WriteLine("2. View  Authors");
            Console.Write("3. View ShoppingCart ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("(" + user.GetShoppingCartBooks().Length + ")");
            Console.ResetColor();
            Console.WriteLine("4. Exit");
        }
        public  void FillData()
        {
            #region Adding authors
            authors = new Author[6];
            Author author1 = new Author("Author1", "author1@email.com", 'm',new Date(2,10,1985));
            Author author2 = new Author("Author2", "author2@email.com", 'f', new Date(12, 4, 1974));
            Author author3 = new Author("Author3", "author3@email.com", 'm', new Date(25, 5, 1978));
            Author author4 = new Author("Author4", "author4@email.com", 'f', new Date(10, 11,1965));
            Author author5 = new Author("Author5", "author5@email.com", 'm', new Date(23, 5, 1997));
            Author author6 = new Author("Author6", "author6@email.com", 'f', new Date(2, 10, 1998));
            authors[0] = author1;
            authors[1] = author2;
            authors[2] = author3;
            authors[3] = author4;
            authors[4] = author5;
            authors[5] = author6;

            #endregion
            #region Adding books
            books = new List<Book>();

            Book book1 = new Book("book1", new Author[] { author1, author2 }, 1.4, 5);
            book1.SetPublicationDate(new Date(10,1,2004));
            books.Add(book1);
            Book book2 = new Book("book2", new Author[] { author3, author2 }, 5.0, 5);
            book2.SetPublicationDate(new Date(22,4,1994));
            books.Add(book2);
            Book book3 = new Book("book3", new Author[] { author4, author2 },3.4, 5);
            book3.SetPublicationDate(new Date(14,2,1991));
            books.Add(book3);
            Book book4 = new Book("book4", new Author[] { author1, author5 }, 10.1, 5);
            book4.SetPublicationDate(new Date(23,8,1989));
            books.Add(book4);
            Book book5 = new Book("book5", new Author[] { author1, author6 }, 8.3, 5);
            book5.SetPublicationDate(new Date(10,11,2014));
            books.Add(book5);
            Book book6 = new Book("book6", new Author[] { author1, author3 }, 6.5, 5);
            book6.SetPublicationDate(new Date(15,1,2008));
            books.Add(book6);
            Book book7 = new Book("book7", new Author[] { author3, author2 }, 3, 5);
            book7.SetPublicationDate(new Date(18,5,1998));
            books.Add(book7);
            Book book8 = new Book("book8", new Author[] { author4, author2 }, 5, 5);
            book8.SetPublicationDate(new Date(5,3,2004));
            books.Add(book8);
            Book book9 = new Book("book9", new Author[] { author5, author6 }, 25.7, 5);
            book9.SetPublicationDate(new Date(1,6,2002));
            books.Add(book9);
            Book book10 = new Book("book10", new Author[] { author1, author2,author3 }, 15.7, 5);
            book10.SetPublicationDate(new Date(4,1,1988));
            books.Add(book10);
            Book book11 = new Book("book11", new Author[] { author1, author2,author4 }, 13.7, 5);
            book11.SetPublicationDate(new Date(10,1,1965));
            books.Add(book11);
            Book book12 = new Book("book12", new Author[] { author1, author2, author5 }, 12, 5);
            book12.SetPublicationDate(new Date(1,4,2014));
            books.Add(book12);
            Book book13 = new Book("book13", new Author[] { author1, author2,author6 }, 11, 5);
            book13.SetPublicationDate(new Date(10,1,1999));
            books.Add(book13);
            Book book14 = new Book("book14", new Author[] { author1, author4,author6 }, 9, 5);
            book14.SetPublicationDate(new Date(8,8,2008));
            books.Add(book14);
            Book book15 = new Book("book15", new Author[] { author1, author5,author3 }, 8, 5);
            book15.SetPublicationDate(new Date(10,1,2012));
            books.Add(book15);
            Book book16 = new Book("book16", new Author[] { author1 }, 30, 5);
            book16.SetPublicationDate(new Date(25,4,2004));
            books.Add(book16);
            Book book17 = new Book("book17", new Author[] {  author3 }, 20, 5);
            book17.SetPublicationDate(new Date(26,5,1999));
            books.Add(book17);
            Book book18 = new Book("book18", new Author[] {  author2 }, 16, 5);
            book18.SetPublicationDate(new Date(10,10,2000));
            books.Add(book18);
            Book book19 = new Book("book19", new Author[] {  author4 }, 8, 5);
            book19.SetPublicationDate(new Date(9,10,2004));
            books.Add(book19);
            Book book20 = new Book("book20", new Author[] {  author6 },7, 5);
            book20.SetPublicationDate(new Date(11,1,1989));
            books.Add(book20);

            #endregion

            #region link books and authors
             author1.SetBooks( new Book[] { book1, book4, book5, book6, book10, book11, book12, book13, book14, book15, book16 });
            author2.SetBooks(new Book[] { book1 , book2 , book3 , book7 , book8 , book10 , book11 , book12 , book13 , book18 });
            author3.SetBooks(new Book[] { book2 , book6 , book7 , book10 , book17});
            author4.SetBooks(new Book[] {  book3, book8 , book11 , book14 , book19  });
            author5.SetBooks(new Book[] { book4 , book9 , book12 , book15});
            author6.SetBooks(new Book[] { book5 , book9 , book13 , book14 , book20 });
            
            #endregion

        }
        public void SelectOption()
        {
            Console.Write("Please select your option : ");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        Console.Clear();
                        ShowMenu();
                        ViewBooks(this.books);
                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        ShowMenu();
                        ViewAuthors();
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        ShowMenu();
                        ShowShoppingCart();
                        break;
                    }
                case 4:
                    {
                        Environment.Exit(0);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Option");
                        break;
                    }
            }
        }

        public void AddItem(Book item, int qty)
        {           
            item.SetQty(qty);
            user.AddToCart(item);
        }
        public void ViewBooks(List<Book> books)
        {
            int sno = 1;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;          
            Console.WriteLine(" Id\tPrice\t\tName\t\t\t\t\t ");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Book bookItem in books)
            {
                Console.WriteLine(" " + sno + "\t" + bookItem.GetPrice() + "\t\t" + bookItem.GetName());
                Console.WriteLine("-----------------------------------------------------------------");
                sno++;
            }
            while (true)
            {
                Console.Write("Enter Id to View Book or ");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("'Press 0 to go back on main menu'");
                Console.ResetColor();
                try
                {
                    int id = Convert.ToInt32(Console.ReadLine());
                    if (id == 0)
                    {
                        Console.Clear();
                        ShowMenu();
                        SelectOption();
                        break;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("\t\t\tBook Information\t\t\t ");
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.ResetColor();
                        int bookId = --id;
                        Book _book = books[bookId];
                        Console.WriteLine(_book.ToString());
                       
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nDo you want to Add this book in your cart y/n ?");
                        Console.ResetColor();
                        string yes = Console.ReadLine();
                        if (yes.ToLower() == "y")
                        {
                            try
                            {
                                Console.Write("Enter Quantity : ");
                                int qty = Convert.ToInt32(Console.ReadLine());
                                if (qty <= 0)
                                    throw new Exception();

                                AddItem(_book, qty);
                                Console.WriteLine("\nYou have (" + user.GetShoppingCartBooks().Length + ") Items in your cart.\n");
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Invalid qty");
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input...Try again!!");
                }
            }
        }
        public void ViewAuthors()
        {
            int sno = 1;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" Id\temail\t\tName\t\t\t\t\t ");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Author authorsItem in authors)
            {
                Console.WriteLine(" " + sno + "\t" + authorsItem.GetEmail() + "\t\t" + authorsItem.GetName());
                Console.WriteLine("-----------------------------------------------------------------");
                sno++;
            }
            Console.WriteLine("To View Author Details and Books");
            Console.Write("Enter Author Id : ");
            int authId = Convert.ToInt32(Console.ReadLine());
            Author auth = authors[--authId];
            Console.WriteLine("\nName : " + auth.GetName());
            Console.WriteLine("DOB : " + auth.GetDOB().ToString());
            Console.WriteLine("Gender : " + auth.GetGender());
            Console.WriteLine("Email : " + auth.GetEmail());

            Console.WriteLine("\n---------------------------Books---------------------------------");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("\n-----------------------------------------------------------------");
            Console.Write(" \t\t\t AUTHOR : " + auth.GetName() + "\t\t\t\t ");
            List<Book> authBooks = new List<Book>();
            for (int i = 0; i < auth.GetBooks().Length; i++)
            {
                authBooks.Add(auth.GetBooks()[i]);
            }            
            ViewBooks(authBooks);
        }
        public void ShowShoppingCart()
        {
           
            Console.WriteLine("\t\t\tCart Items:"+ user.GetShoppingCart().Count);
            int id = 1;
            Console.WriteLine("ItemId\tQty\tPrice\tTotalPrice\tName\t\t\t ");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.ResetColor();
            double totalAmt = 0;
            List<Book> AllCartItems = user.GetShoppingCart();
            foreach (Book cart in AllCartItems)
            {
                totalAmt += cart.GetQty() * cart.GetPrice();
                Console.WriteLine("" + id + "\t" + cart.GetQty() + "\t" + cart.GetPrice() + "\t" + cart.GetQty() * cart.GetPrice() + "\t\t" + cart.GetName());
                Console.WriteLine("-----------------------------------------------------------------");
                Console.ResetColor();
                id++;
            }
            Console.WriteLine("\t TOTAL AMOUNT : " + totalAmt + "\t\t\t\t\t");
            Console.WriteLine("-----------------------------------------------------------------");

            Console.Write("Enter ItemId to edit the Cart Item or ");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("'Press 0 to go back on main menu'");
            Console.ResetColor();
            int itemId = Convert.ToInt32(Console.ReadLine());
            if (itemId == 0)
            {
                Console.Clear();
                ShowMenu();
                SelectOption();
            }
            else
            {
                List<Book> cartItems = user.GetShoppingCart();
                int idx = itemId;
                Book item = cartItems[--idx];
                Console.WriteLine("ItemId\tQty\tPrice\tTotalPrice\tName\t\t\t ");
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("" + itemId + "\t" + item.GetQty() + "\t" + item.GetPrice() + "\t" + item.GetQty() * item.GetPrice() + "\t\t" + item.GetName());
                Console.WriteLine("-----------------------------------------------------------------");
                int newQty = 0;
                Console.WriteLine("To remove item enter new qty to 0");
                Console.Write("Enter New Qty : ");
                newQty = Convert.ToInt32(Console.ReadLine());

                if (AllCartItems.Any(x => x.GetName() == item.GetName()))
                {
                    if (newQty == 0)
                    {
                        AllCartItems.Remove(item);
                    }
                    else
                    {
                        AllCartItems.FirstOrDefault(x => x.GetName() == item.GetName()).SetQty(newQty);
                    }

                    Console.Clear();
                    ShowMenu();
                    ShowShoppingCart();
                }
            }

        }
    }
}
