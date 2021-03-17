using System;

namespace Algorithms
{
    public static class Search
    {
        // Time complexity is O(log(n))
        public static bool BinarySearch (int target, int[] arr) {
            int floorIndex = -1;
            int ceilingIndex = arr.Length;

            while(floorIndex + 1 < ceilingIndex) {
                int distance = ceilingIndex - floorIndex;
                int halfDistance = distance / 2;
                int guessIndex = floorIndex + halfDistance;

                int guessValue = arr[guessIndex];
                if(guessValue == target) {
                    return true;
                }
                else if(guessValue > target) {
                    ceilingIndex = guessIndex;
                }
                else {
                    floorIndex = guessIndex;
                }
            }
            return false;
        }
    }
}