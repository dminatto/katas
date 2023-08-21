namespace MinimumRotatedSortedArray.Tests;

public class UnitTestMinimumRotatedSortedArray
{
    [Fact]
    public void Example1()
    {
        int[] numbers = {3,4,5,1,2};
        var m = new MinimumRotatedSortedArray();
        Assert.Equal(1, m.FindMin(numbers));
    }

    [Fact]
    public void Example2()
    {
        int[] numbers = {4,5,6,7,0,1,2};
        var m = new MinimumRotatedSortedArray();
        Assert.Equal(0, m.FindMin(numbers));
    }

    [Fact]
    public void Example3()
    {
        int[] numbers = {11,13,15,17};
        var m = new MinimumRotatedSortedArray();
        Assert.Equal(11, m.FindMin(numbers));
    }
}