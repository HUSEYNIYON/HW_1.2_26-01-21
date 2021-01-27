using System;

namespace HW_1._2_26_01_21
{
    class Book
    {
        Title title;
        Author author;
        Content content;
        public Book(string t, string a, string c)
        {
            title = new Title(t);
            author = new Author(a);
            content = new Content(c);
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Title = ");
            Console.ForegroundColor = ConsoleColor.Red;
            title.Show();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Author = ");
            Console.ForegroundColor = ConsoleColor.Blue;
            author.Show();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Content = ");
            Console.ForegroundColor = ConsoleColor.Green;
            content.Show();
        }
    }
    class Title
    {
        string title;
        public Title(string t)
        {
            title = t;
        }
        public void Show()
        {
            Console.WriteLine(title);
        }
    }
    class Author
    {
        string author;
        public Author(string a)
        {
            author = a;
        }
        public void Show()
        {
            Console.WriteLine(author);
        }
    }
    class Content
    {
        string content;
        public Content(string c)
        {
            content = c;
        }
        public void Show()
        {
            Console.WriteLine(content);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Title = ");
            string title = Console.ReadLine();
            Console.Write("Author = ");
            string author = Console.ReadLine();
            Console.Write("Content = ");
            string content = Console.ReadLine();
            Book book1 = new Book(title, author, content);
            book1.Show();

        }
    }
   

}
          
