using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqJoin
{


    //Yazar (Author) sınıfı tanımlandı.
    public class Author
    {
        public int AuthorId { get; set; }  
        public string Name { get; set; }   
    }

    //Kitap (Book)  sınıfı tanımlandı.
    public class Book
    {
        public int BookId { get; set; }    
        public string Title { get; set; }  
        public int AuthorId { get; set; }  
    }
}

