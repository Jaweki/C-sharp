using System;
namespace IfStatement{
    class Program{
        static void Main(string[]args){
            int theVal = 50;
            if (theVal == 50){
                Console.WriteLine("The val is 50");
            }
            else if (theVal>50 || theVal<=60){
                Console.WriteLine("The val is between 50 and 60");
            }
            else {
                Console.WriteLine("The val is someting else");
            }
        }
    }
}