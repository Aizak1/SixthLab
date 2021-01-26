using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthLab
{
    class Program
    {
        Book[] books = new Book[] { new Book("Autumn",30,"Axe",30,40,50),
                                                    new Book("Winter",50,"Ice",300,600,900),
                                                    new Book("Spring",100,"Dream",1000,3000,5000),
                                                    new Book("Summer",40,"Flight",50,100,150),
                                                    new Book("Libertaria",300,"Lumus",100,320,400)
                                                                };
        static void Main(string[] args)
        {
            Program executer = new Program();
            Console.Write("Enter Books name -> ");
            string userbookName = Console.ReadLine();
            Console.Write("Enter one of three prices -> ");
            int price = int.Parse(Console.ReadLine());
            bool isBookExists = executer.FindBookWithConditions(userbookName,price);
            if (isBookExists)
            {
                Book requiredBook = executer.PickBookWithConditions(userbookName);
                Console.Write("Amount of Pages -> ");
                int useramountOfPages = int.Parse(Console.ReadLine());
                Console.Write("Enter year -> ");
                int year = int.Parse(Console.ReadLine());
               
                executer.GenerateFinalCortage(requiredBook,useramountOfPages,year,price);
            }
            else
            {
                Console.WriteLine("This Bookshop doesn't have this book");
            }
            
          
            
            
            
        }

        

        private  bool FindBookWithConditions(string userbookName,int price)
        {
          

            foreach (var _ in books.Where(item => item.Name == userbookName && (item.FirstPrice == price || item.SecondPrice == price || item.ThirdPrice == price)).Select(item => new { }))
            {
                return true;
            }

            return false;
        }
        private Book PickBookWithConditions(string userbookName)
        {
            return books.First(book => book.Name == userbookName);
        }
        private void GenerateFinalCortage(Book requiredBook, int useramountOfPages, int year, int price)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
            Console.WriteLine($"Book Name - > {requiredBook.Name}");
            Console.WriteLine($"Author- > {requiredBook.Author}");
            Console.WriteLine($"Code - > {requiredBook.Author}{year}");
            Console.WriteLine($"Average Price -> {(float)(requiredBook.FirstPrice+requiredBook.SecondPrice+requiredBook.ThirdPrice)/3}");
            bool pagesMatch = requiredBook.AmountOfPages == useramountOfPages ? true : false;
            if (pagesMatch)
                Console.WriteLine("Yes");
            else

                Console.WriteLine("No");
            
            
            
        }
    }
}
