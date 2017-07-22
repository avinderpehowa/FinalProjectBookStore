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
        Author[] authors { get; set; }
        double  price { get; set; }
        int qty { get; set; }
        Date publication { get; set; }

        public Book(string name, Author[] authors,double price) {
           this.Name = name;
            this.authors = authors;
            this.price = price;
        }
        public Book(string name, Author[] authors, double price,int qty)
        {
            this.Name = name;
            this.authors = authors;
            this.price = price;
            this.qty = qty;
        }

        public string GetName()
        {
            return this.Name;
        }
        public Author[] GetAuthors()
        {
            return this.authors;
        }
        public Date GetPublicationDate()
        {
            return this.publication;
        }
        public void SetPublicationDate(Date date)
        {
            this.publication = date;
        }
        public double GetPrice()
        {
            return this.price;
        }
        public void SetPrice(double price)
        {
            this.price = price;
        }
        public int GetQty()
        {
            return qty;
        }
        public void SetQty(int qty)
        {
            this.qty = qty;
        }
        public string ToString()
        {
            string output = "\nName              : " + this.GetName() + "\nPrice             : " + this.GetPrice();
            Date pubDate = this.GetPublicationDate();
            output= output+"\nPublication Date  : " + pubDate.ToString()+ "   (dd/mm/yyyy)";
            output = output + "\nAuthors           : " + this.GetAuthorNames();
            return output;
        }
        public string GetAuthorNames()
        {
            string authName = "";
            for (int i = 0; i < this.authors.Length; i++)
            {
                if (i == 0)
                {
                    authName += this.authors[i].GetName();
                }
                else {

                    authName += ","+this.authors[i].GetName();
                }
            }
            return authName;
        }
    }
}
