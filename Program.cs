using System;

namespace FirstCSharpCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.ReadKey();
            Book b1 = new Book("Harry Potter", "Rowlen",400);


            Console.WriteLine(b1.Title);

            //Console.ReadLine();

            Book[] shelve = {new Book("Moon Light","Unknown",200),
            new Book("Sun","Known",150), new Book("The earth","Glob",567)

            };

            foreach (Book book in shelve)
            {
                Console.WriteLine(book.Title+" "+book.page);
            }
            
        }
    }
}
