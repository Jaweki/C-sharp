using System;
namespace For{
    class Program{
        static void Main(string[] args){
            string str = ("The quick brown fox jump over the lazy dog");
            /*int myVal = 15;
            int[] nums = new int[]{3,14,15,92,6};
         
         Console.WriteLine("The basic for loop");
         for (int i=0; i<myVal; i++){
             Console.WriteLine("i is currently {0}", i);
         }
         foreach(int i in nums){
             Console.WriteLine("i is currently {0}", i);
         }*/
         var count = 0;
         foreach( char c in str){
             if (c == 'o'){
                 count++;
             }
         }
             Console.WriteLine("Counted {0} o character", count);
         
        }
    }
}