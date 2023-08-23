namespace MinimumRotatedSortedArray;

public class MinimumRotatedSortedArray
{
    public int FindMin(int[] numbers) {

        int start = 0;
        int end = numbers.Length - 1;

        if (numbers[start] <= numbers[end]) return numbers[start];

        while(start < end) {
            int mid = (start + (end - start)/2);

            if(numbers[mid] >= numbers[0]) {
                start = mid + 1;
            } else {
                end = mid;
            }
        }

        return numbers[start];        
    }

}
