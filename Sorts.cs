using System;

namespace Algorithms
{
    public static class Sorts
    {
        public static int BubbleSort(ref int[] a) {
            int n = a.Length;
            int swaps = 0;
            for(int i = 0; i < n; i++) {
                for(int j = 0; j < n-1; j++) {
                    if(a[j] > a[j+1]) {
                        int temp = a[j];
                        a[j] = a[j+1];
                        a[j+1] = temp;
                        swaps++;
                    }
                }
            }
            return swaps;
        }
    }
}