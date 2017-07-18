using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Book
    {
        string Name { get; set; }
        Author[] Authors { get; set; }
        double  Price { get; set; }
        int qty { get; set; }

        public Book(string name, Author[] authors,double price) {
           this.Name = name;
            this.Authors = authors;
            this.Price = price;
        }
        public Book(string name, Author[] authors, double price,int qty)
        {
            this.Name = name;
            this.Authors = authors;
            this.Price = price;
            this.qty = qty;
        }

        public string GetName()
        {
            return this.Name;
        }
        public Author[] GetAuthors()
        {
            return this.Authors;
        }
    }
}
