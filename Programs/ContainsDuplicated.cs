using System;

namespace DSA_Probs.Programs
{
    public class ContainsDuplicated
    {
        // Entry point of the program
        public static void Main(string[] args)
        {
            //1. Example duplicates in an array
            string[] arr = { "1", "2", "1", "3", "9", "2" };

            Console.WriteLine("Duplicate elements using Nested Loop:");
            FindDuplicatesUsingNestedLoops(arr);
            Console.WriteLine("Duplicate elements using HashSet:");
            FindDuplicatesUsingHashSet(arr);

            //2.From here it is Anagram code
            //Reading First word
            Console.WriteLine("First word :");

            String word1 = Console.ReadLine();
            String word9 = Console.ReadLine();

            //Reading Second word
            Console.WriteLine("Second word :");
            String word2 = Console.ReadLine();
            bool status = IsAnagram(word1, word2);
            if (!status)
            {
                Console.WriteLine("It was not Anagram");
            }
            else
            {
                Console.WriteLine("it is anagram");
            }
        }

        // 1. Using Nested Loops
        public static void FindDuplicatesUsingNestedLoops(string[] arr)
        {
            //starting at 0th index : arr[0]
            for (int i = 0; i < arr.Length; i++)
            {
                //*** Incrementing Index value by adding i, not to the array value
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
            }
        }
        // 2. Using Hash Set
        public static void FindDuplicatesUsingHashSet(string[] arr)
        {

            HashSet<String> set = new HashSet<String>();
            foreach (string s in arr)
            {
                if (!set.Add(s))
                {
                    Console.WriteLine(s);
                }
            }
        }
        public static bool IsAnagram(String word1, String word2)
        {
            char[] firstWord = word1.ToCharArray();
            char[] secondWord = word2.ToCharArray();

            Array.Sort(firstWord);
            Array.Sort(secondWord);

            return new string(firstWord) == new string(secondWord);

        }
    }
}