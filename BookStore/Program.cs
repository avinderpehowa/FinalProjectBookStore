using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class Program
    {
        static List<Author> Authors=new List<Author>();
        static void Main(string[] args)
        {

        }
        static void FillData()
        {
            Author author1 = new Author("Author1", "author1@email.com", 'm');
            Author author2 = new Author("Author2", "author2@email.com", 'f');
            Author author3 = new Author("Author3", "author3@email.com", 'm');
            Author author4 = new Author("Author4", "author4@email.com", 'f');
            Author author5 = new Author("Author5", "author5@email.com", 'm');
            Author author6 = new Author("Author6", "author6@email.com", 'f');
            Authors.Add(author1);
            Authors.Add(author2);
            Authors.Add(author3);
            Authors.Add(author4);
            Authors.Add(author5);
            Authors.Add(author6);
            Book book = new Book("book1", new Author[] { author1, author2 }, 5.7, 5);
        }
    }
}
