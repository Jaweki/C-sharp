using System;
namespace Switch{
    class Program{
        static void Main(string[] args){
            int theVal = 51;

            switch (theVal){
                case 50:
                Console.WriteLine("The Val is 50");
                break;
                case 51:
                Console.WriteLine("the Val is 51");
                break;
                case 52:
                case 53:
                case 54:
                Console.WriteLine("the Val is between 52 and ");
                break;
                default:
                Console.WriteLine("the value is something else");
                break;
            }
        }
    }
}