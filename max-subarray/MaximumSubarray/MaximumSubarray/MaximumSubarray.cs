namespace MaximumSubarray;

public class MaximumSubArray
{
    public int MaxSubArray(int[] numbers) {
        int n = numbers.Length;
        int sum = 0;
        
        for(int i = 0; i <= n; i++) {
            for(int j = n; j >= 0; j--) {
                var nArray = numbers.Skip(i).Take(j).ToArray();
                if(nArray.Sum() > sum){
                    sum = nArray.Sum();
                }
            }
        }

        return sum;
    }
}
