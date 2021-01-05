using System;

namespace SortBinaryArray
{
    //Sort Binary Array in Linear Time
    //Given a binary array, sort it in linear time and constant space.
    //Output should print all zeroes followed by all ones.
    class Program
    {

        static void Main(string[] args)
        {
            int[] BinaryArray = { 1, 0, 1, 0, 1, 0, 0, 1 };

            SortBinaryArray(BinaryArray);
        }


        public static void SortBinaryArray(int[] array)
        {
            
            int NextAvailableindex = 0;

            //Fill the array with the number of 0
            for(int i = 0; i<array.Length; i++){
                if(array[i]==0){ //
                    array[NextAvailableindex++] = 0;
                }
            }

            //Fill the rest of the array with 1
            for(int i = NextAvailableindex; i<array.Length; i++){
                array[i] = 1;
            }


            //Print array
            for(int i = 0; i<array.Length; i++){
                Console.Write($"{array[i]} ");
            }
           


        }
    }
}
