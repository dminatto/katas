namespace _3Sum;

public class ThreeSumSolution
{
    public IList<IList<int>> ThreeSum(int[] numbers) {
        
        var result = new List<IList<int>>();

        if(numbers.Length <= 2) return result;

        Array.Sort(numbers);

         for (var i = 0; i < numbers.Length; i++)
        {
            if (i > 0 && numbers[i] == numbers[i - 1])
            {
                continue;
            }

            var l = i + 1;
            var r = numbers.Length - 1;

            while (l < r)
            {
                if (l - 1 != i && numbers[l] == numbers[l - 1])
                {
                    l++;
                    continue;
                } 
                
                var sum = numbers[i] + numbers[l] + numbers[r];

                if (sum > 0)
                {
                    r--;
                }
                else if (sum < 0)
                {
                    l++;
                }
                else
                {
                    result.Add(new List<int> {numbers[i], numbers[l], numbers[r]});
                    l++;
                }
                
            }
        }

        return result;
    }

}
