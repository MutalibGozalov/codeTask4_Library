using oop._2nd.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("------------Book-----------------");

        Book harryPotter = new Book("harry potter and the philosopher's stone", "Joanne Rowling", 1000, 45.54);
        Console.WriteLine($@"
Book id:         {harryPotter.Id}
Book Name:       {harryPotter.Name}
Author name:     {harryPotter.AuthorName}
Pgae count:      {harryPotter.PageCount}
Price:           {harryPotter.Price}
Code:            {harryPotter.Code}
");

        Book lotr = new Book("The Lord of the Rings", "J. R. R. Tolkien", 1200, 604.24);
        Console.WriteLine($@"
Book id:         {lotr.Id}
Book Name:       {lotr.Name}
Author name:     {lotr.AuthorName}
Pgae count:      {lotr.PageCount}
Price:           {lotr.Price}
Code:            {lotr.Code}
");




        Console.WriteLine("------------Library-----------------");


        Library lib = new Library();

        lib.AddBook(harryPotter);
        lib.AddBook(lotr);

Console.WriteLine("Library.GetBook(2): \n");

        Book book2 = lib.GetBook(2);
        Console.WriteLine($@"
Book id:         {book2.Id}
Book Name:       {book2.Name}
Author name:     {book2.AuthorName}
Pgae count:      {book2.PageCount}
Price:           {book2.Price}
Code:            {book2.Code}
");


Console.WriteLine("Library.FindAllBooks(1): \n");

        Book[] books = lib.FindAllBooks(1);

        foreach (var book in books)
        {
            Console.WriteLine($@"
Book id:         {book.Id}
Book Name:       {book.Name}
Author name:     {book.AuthorName}
Pgae count:      {book.PageCount}
Price:           {book.Price}
Code:            {book.Code}
");
        }

Console.WriteLine("Library.RemoveAllBooks(): ");

        lib.RemoveAllBooks();

        Console.WriteLine("Book count: "+lib.FindAllBooks(0).Length);

//-------------------------------------------------------------------
Console.WriteLine("\n\norder.Sale():");
        Order order = new Order();

        order.Sale();

    }

}