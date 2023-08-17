namespace ProductExceptSelf.Tests;

public class UnitTest1
{
    [Fact]
    public void Exemplo1()
    {
        int[] nums = {1,2,3,4};
        var p = new ProductExcept();
        int[] answer = {24,12,8,6}; 
        Assert.Equal(answer, p.ProductExceptSelf(nums));

    }

    [Fact]
    public void Exemplo2()
    {
        int[] nums = {-1,1,0,-3,3};
        var p = new ProductExcept();
        int[] answer = {0,0,9,0,0};
        Assert.Equal(answer, p.ProductExceptSelf(nums));
    }
}