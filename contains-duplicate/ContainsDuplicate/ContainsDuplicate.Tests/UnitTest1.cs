namespace ContainsDuplicate.Tests;

public class UnitTest1
{
    [Fact]
    public void Exemple1()
    {
        int[] nums = {1,2,3,1};
        var d = new Duplicates();
        var result = d.ContainsDuplicate(nums);
        Assert.True(result);
    }

    [Fact]
    public void Exemple2()
    {
        int[] nums = {1,2,3,4};
        var d = new Duplicates();
        var result = d.ContainsDuplicate(nums);
        Assert.False(result);
    }

    [Fact]
    public void Exemple3()
    {
        int[] nums = {1,1,1,3,3,4,3,2,4,2};
        var d = new Duplicates();
        var result = d.ContainsDuplicate(nums);
        Assert.True(result);
    }
}