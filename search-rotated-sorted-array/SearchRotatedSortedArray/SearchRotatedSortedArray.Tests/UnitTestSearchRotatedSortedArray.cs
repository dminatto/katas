namespace SearchRotatedSortedArray.Tests;

public class UnitTestSearchRotatedSortedArray
{
    [Fact]
    public void Example1()
    {
        int[] numbers = {4,5,6,7,0,1,2};
        int target = 0;

        var s = new SearchRotatedSortedArray();
        Assert.Equal(4, s.Search(numbers, target));
    }

    [Fact]
    public void Example2()
    {
        int[] numbers = {4,5,6,7,0,1,2};
        int target = 3;

        var s = new SearchRotatedSortedArray();
        Assert.Equal(-1, s.Search(numbers, target));

    }

    [Fact]
    public void Example3()
    {
        int[] numbers = {1};
        int target = 0;

        var s = new SearchRotatedSortedArray();
        Assert.Equal(-1, s.Search(numbers, target));

    }
}