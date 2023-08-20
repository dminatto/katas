namespace MaximumSubarray.Tests;

public class UnitTest1
{
    [Fact]
    public void Example1()
    {
        int[] numbers = {-2, 1, -3, 4, -1, 2, 1, -5, 4};
        var m = new MaximumSubArray();

        Assert.Equal(6, m.MaxSubArray(numbers));
    }

    [Fact]
    public void Example2()
    {
        int[] numbers = {1};
        var m = new MaximumSubArray();
        Assert.Equal(1, m.MaxSubArray(numbers));
    }

    [Fact]
    public void Example3()
    {
        int[] numbers = {5,4,-1,7,8};
        var m = new MaximumSubArray();

        Assert.Equal(23, m.MaxSubArray(numbers));
    }

    
    [Fact]
    public void Example4()
    {
        int[] numbers = {-2, -5, 6, -2, -3, 1, 5, -6};
        var m = new MaximumSubArray();

        Assert.Equal(7, m.MaxSubArray(numbers));
    }
}