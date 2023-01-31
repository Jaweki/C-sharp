using System;
namespace Defining{
    class Program {
        static void Main(string[] args){
            Book b1 = new Book("War and Peace", "Leo", 825);
            Book b2 = new Book("New arrival", "Tom", 439);
            Console.WriteLine(b1.GetDescription());
            Console.WriteLine(b2.GetDescription());
        }
        }
}