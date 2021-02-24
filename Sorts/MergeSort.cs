using System;

namespace Algorithms
{
    public static class MergeSort
    {
        public static void Sort(int[] nums, int start, int end) {
            if (start < end) {
                int middle = start + (end - start) / 2;
                
                Sort(nums, start, middle);
                Sort(nums, middle + 1, end);

                Merge(nums, start, middle, end);
            }
        }

        private static void Merge(int[] nums, int start, int middle, int end) {
            int size1 = middle - start + 1;
            int size2 = end - middle;

            int[] arr1 = new int[size1];
            int[] arr2 = new int[size2];

            Array.Copy(nums, start, arr1, 0, size1);
            Array.Copy(nums, middle + 1, arr2, 0, size2);

            int i = 0;
            int j = 0;
            int index = start;

            while (i < size1 && j < size2) {
                if(arr1[i] <= arr2[j]) {
                    nums[index] = arr1[i];
                    i++;
                }
                else {
                    nums[index] = arr2[j];
                    j++;
                }
                index++;
            }

            while (i < size1) {
                nums[index] = arr1[i];
                i++;
                index++;
            }

            while (j < size2) {
                nums[index] = arr2[j];
                j++;
                index++;
            }
        }
    }
}