using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop._2nd.Models
{
    internal class Library
    {
       public Book[] libBooks = new Book[0];


       public void AddBook(Book book)
        {
            Array.Resize(ref this.libBooks, this.libBooks.Length + 1);
            this.libBooks[this.libBooks.Length - 1] = book;
        }
       public Book GetBook(int id)
        {
            Book book = Array.Find(this.libBooks, b => b.Id == id);
            return book;
        }
       public Book[] FindAllBooks(double price)
        {
            Book[] books = Array.FindAll(this.libBooks, b => b.Price>0);

            return books;
        }
       public void RemoveAllBooks()
        {
            Array.Clear(this.libBooks);
        }
    }
}
