using System;
using System.Collections.ObjectModel;

namespace Algorithms
{
    class Program
    {
        public static readonly ReadOnlyCollection<string> algorithms = new ReadOnlyCollection<string>(new string[] {
            "quicksort", "mergesort", "timsort", "heapsort", "bubble-sort", "insertion-sort", "selection-sort", "tree-sort", "shell-sort", "bucket-sort"});
        
        static int Main(string[] args)
        {
            if (args.Length == 0 || !algorithms.Contains(args[0])) {
                Console.WriteLine("Please select a sorting algorithm.");
                Console.WriteLine("Usage: <quicksort|mergesort|timsort|heapsort|bubble-sort|insertion-sort|selection-sort|tree-sort|shell-sort|bucket-sort>");
                return 1;
            }

            Console.WriteLine("Please enter a list of numbers:");
            var chars = Console.ReadLine().Split(' ');
            int[] nums = new int[chars.Length];
            for(int i = 0; i < chars.Length; i++) {
                int num;
                bool success = Int32.TryParse(chars[i], out num);
                if(!success) {
                    Console.WriteLine("List must only contain numbers.");
                    return 1;
                }
                else {
                    nums[i] = num;
                }
            }

            int swaps = 0;
            string algorithm = args[0];
            switch (algorithm) {
                case "bubble-sort":
                    swaps = BubbleSort.Sort(nums);
                    break;
                case "mergesort":
                    MergeSort.Sort(nums, 0, nums.Length - 1);
                    break;
                default:
                    Console.WriteLine("Algorithm not implemented yet.");
                    return 1;
            }

            Console.Write("Sorted list: ");
            for (int i = 0; i < nums.Length; i++) {
                Console.Write($"{nums[i]} ");
            }
            if(algorithm == "bubble-sort") {
                Console.WriteLine();
                Console.WriteLine($"List is sorted in {swaps} swaps.");
            }

            return 0;
        }
    }
}
