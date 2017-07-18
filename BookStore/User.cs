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

        public void AddAuthor(Author author)
        {
            favoriteAuthors.Add(author);
        }
        public Author[] GetAuthors()
        {
            return favoriteAuthors.ToArray();
        }
        //public Book[] GetShoppingCart()
        //{
        //    return ShoppingCart.ToArray();
        //}
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
        public string GetShoppingCart()
        {
            StringBuilder cart = new StringBuilder();
            cart.Append("Cart Items:");
            foreach (var item in ShoppingCart) {
                cart.AppendLine("\t" + item.GetName());
            }
            return cart.ToString();
        }
    }
}
