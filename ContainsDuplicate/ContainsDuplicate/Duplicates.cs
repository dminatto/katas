namespace ContainsDuplicate;

public class Duplicates
{
    public bool hasDuplicate = false;

    public bool ContainsDuplicate(int[] nums) {

        foreach(int num in nums) {
            var count = nums.Count(n => (num == n));
            if(count > 1) {
                hasDuplicate = true;
                break;
            }
        }

        return hasDuplicate;
    }
}
