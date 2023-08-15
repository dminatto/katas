namespace BuySell;

public class BuySellStock
{
    public int MaxProfit(int[] prices) {

        int minValue = prices.Min();
        int minIndex = prices.ToList().IndexOf(minValue);

        var subArray = prices.Skip(minIndex).Take((prices.Length - minIndex));

        int maxValue = subArray.Max();

        return (maxValue - minValue) > 0 ? (maxValue - minValue) : 0;

    }

}
