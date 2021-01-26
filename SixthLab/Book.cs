using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthLab
{
    struct Book
    {
        public string Name { get; }
        public int AmountOfPages { get; }
        public string Author { get; }
        public int FirstPrice { get; }
        public int SecondPrice { get; }
        public int ThirdPrice { get; }

       

        public Book(string name,int amountOfPages,string author,int firstPrice,int secondPrice,int thirdPrice)
        {
            
            Name = name;
            AmountOfPages = amountOfPages;
            Author = author;
            FirstPrice = firstPrice;
            SecondPrice = secondPrice;
            ThirdPrice = thirdPrice;
            
        }

      
    }
}
