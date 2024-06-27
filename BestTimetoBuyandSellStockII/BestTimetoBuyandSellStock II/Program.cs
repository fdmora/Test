

    int[] price = { 7, 1, 5, 3, 6, 4 };
    int vmaxProfit = 0;
    vmaxProfit = MaxProfit(price);
    Console.WriteLine(vmaxProfit);
Console.ReadLine();
int MaxProfit(int[] prices)
    {
        int maxProfit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] > prices[i - 1])
            {
                maxProfit += prices[i] - prices[i - 1];
            }
        }

        return maxProfit;
    }

