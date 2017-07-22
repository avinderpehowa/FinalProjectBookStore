using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
  public  class User
    {
        List<Author> favoriteAuthors { get; set; }
        List<Book> ShoppingCart { get; set; }

        public User()
        {
            favoriteAuthors = new List<Author>();
            ShoppingCart = new List<Book>();
        }
        public void AddAuthor(Author author)
        {
            favoriteAuthors.Add(author);
        }
        public Author[] GetAuthors()
        {
            return favoriteAuthors.ToArray();
        }
        public Book[] GetShoppingCartBooks()
        {
            return ShoppingCart.ToArray();
        }
        public void AddToCart(Book book) {
            ShoppingCart.Add(book);
        }
        public void RemoveAuthor(Author author)
        {
            favoriteAuthors.Remove(author);
        }
        public void RemoveFromCart(Book book)
        {
            ShoppingCart.Remove(book);
        }
        public List<Book> GetShoppingCart()
        {
           
            return this.ShoppingCart;
        }
    }
}
