namespace BuySell.Tests;

public class UnitTest1
{
    [Fact]
    public void Exemple1()
    {
        int[] prices = {7, 1, 5, 3 ,6 ,4};
        var s = new BuySellStock();
        var result = s.MaxProfit(prices); 
        Assert.Equal(5, result);
    }

    [Fact]
    public void Exemple2()
    {
        int[] prices = {7, 6, 4, 3, 1};
        var s = new BuySellStock();
        var result = s.MaxProfit(prices); 
        Assert.Equal(0, result);
    }

    
}