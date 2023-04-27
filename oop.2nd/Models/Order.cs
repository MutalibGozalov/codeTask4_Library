using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop._2nd.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public List<Book> Books = new List<Book>();
        public double TotalPrice { get; set; }
        public DateTime Date { get; set; }

        public Order()
        {
            Library library = new Library();
            Book[] libBooks = library.FindAllBooks(1);
            Books.AddRange(libBooks);
        }

        public void Sale()
        {
            this.Date = DateTime.Now;
            foreach (Book book in this.Books) {
                this.TotalPrice += book.Price;
            }

            switch (this.TotalPrice)
            {
                case < 100:
                    Console.WriteLine("Endirim: 0%");
                    break;
                case >100  and < 200:
                    Console.WriteLine("Endirim: 10%");
                    break;
                case > 200:
                    Console.WriteLine("Endirim: 20%");
                    break;
            }
            Console.WriteLine("Order date: "+Date.ToShortDateString());
        }
    }
}
