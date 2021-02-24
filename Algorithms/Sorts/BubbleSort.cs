using System;

namespace Algorithms
{
    public static class BubbleSort
    {
        public static int Sort(int[] nums) {
            int n = nums.Length;
            int swaps = 0;
            for(int i = 0; i < n; i++) {
                for(int j = 0; j < n-1; j++) {
                    if(nums[j] > nums[j+1]) {
                        int temp = nums[j];
                        nums[j] = nums[j+1];
                        nums[j+1] = temp;
                        swaps++;
                    }
                }
            }
            return swaps;
        }
    }
}