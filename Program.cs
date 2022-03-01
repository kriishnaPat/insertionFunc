using System;

namespace sortFunction
{
    class Program
    {
        static int insertionSort(int[] anArray){
            for (int i=1; i<anArray.Length-1; i++){
                int insert_value = anArray[i];
                int position = i-1;
                while(position >= 0 && anArray[position] > insert_value){
                    anArray[position+1] = anArray[position];
                    position = position - 1;
                }
                anArray[position+1] = insert_value;
            }
            foreach (int x in anArray)
                Console.Write(x + "  ");
            return 0;
        }
        static void Main(string[] args)
        {
            int[] nums = {10, 70, 30, 100, 40, 45, 90, 80, 85};
            string[] words = {"dog","at", "good", "eye", "cat", "ball", "fish"};
            Console.WriteLine(insertionSort(nums));
        }
    }
}
