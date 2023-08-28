namespace _3Sum.Tests;

public class ThreeSumUnitTest
{
    [Fact]
    public void Example1()
    {
        int[] numbers = {-1,0,1,2,-1,-4};
        var output = new List<IList<int>>() {new List<int> {-1,-1,2}, new List<int> {-1,0,1}};

        var t = new ThreeSumSolution();

        Assert.Equal(output, t.ThreeSum(numbers));
    }

    [Fact]
    public void Example2()
    {
        int[] numbers = {0,1,1};
        var output =  new List<IList<int>>() {};

        var t = new ThreeSumSolution();

        Assert.Equal(output, t.ThreeSum(numbers));

    }

    [Fact]
    public void Example3()
    {
        int[] numbers = {0,0,0};
        var output = new List<IList<int>>() {new List<int> {0,0,0}};

        var t = new ThreeSumSolution();

        Assert.Equal(output, t.ThreeSum(numbers));

    }
}