
using System;

class Book
{
    public string Title;
    public string Author;

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public void Display()
    {
        Console.WriteLine($"Book: {Title}, Author: {Author}");
    }
}

class Library
{
    public string Name;
    public Book Book;

    public Library(string name, Book book)
    {
        Name = name;
        Book = book;
    }

    public void DisplayLibrary()
    {
        Console.WriteLine($"Library: {Name}");
        Book.Display();
    }
}

class Program
{
    static void Main()
    {
        Book book = new Book("1984", "George Orwell");
        Library library = new Library("City Library", book);
        library.DisplayLibrary();
    }
}
