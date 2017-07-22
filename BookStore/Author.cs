using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
   public  class Author
    {
        string Name { get; set; }
         Book[] Books { get; set; }
        string Email { get; set; }
        Date DOB { get; set; }
        char Gender { get; set; }

      public  Author(string name, string email, char gender, Date DOB)
        {
            this.Name = name;
            this.Email = email;
            this.Gender = gender;
            this.DOB = DOB;
        }
        public Author(string name, string email, char gender,Book[] books)
        {
            this.Name = name;
            this.Email = email;
            this.Gender = gender;
            this.Books = books;
        }
        public void SetBooks(Book[] books)
        {
            this.Books = books;
        }
        public string GetName() {
            return this.Name;
        }
        public Book[] GetBooks()
        {
            return this.Books;
        }
        public Date GetDOB()
        {
            return this.DOB;
        }
        public void  SetDOB(Date date)
        {
            this.DOB = date;           
        }
        public string GetEmail()
        {
            return this.Email;
        }
        public void SetEmail(string email)
        {
             this.Email=email;
        }
        public char GetGender()
        {
            return this.Gender;
        }
        public void SetGender(char gender)
        {
            this.Gender = gender;
        }
        public string GetBookNames() {
            StringBuilder names = new StringBuilder();
            names.Append(this.GetName() + ":");
            var books = this.GetBooks();
            for (int i = 0; i < books.Length; i++)
            {
                names.Append(" " + books[i] + ",");
            }
            return names.ToString();
        }
    }
}
