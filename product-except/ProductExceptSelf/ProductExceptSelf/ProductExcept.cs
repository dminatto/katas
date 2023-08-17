namespace ProductExceptSelf;

public class ProductExcept
{
    public int[] ProductExceptSelf(int[] numbers) {
        int[] answer = new int[numbers.Length];
        
        for(int i = 0; i < numbers.Length; i++) {
            int mult = 1;

            for(int j = 0; j < numbers.Length; j++) {
                if(i == j) continue;
                mult *= numbers[j];
            }
            answer[i] = mult;
        }

        return answer;
    }
}
