namespace HappyTicket
{
    internal class Solver
    {
        public string Run(string[] args)
        {
            int n = int.Parse(args[0]);
            return Tickets(n).ToString();
        }

        private long Tickets(int n)
        {
            int maxSum = 9 * n;
            long[] dp = new long[maxSum + 1];
            dp[0] = 1; 

            for (int i = 0; i < n; i++)
            {
                long[] newDp = new long[maxSum + 1];
                for (int sum = 0; sum <= maxSum; sum++)
                {
                    if (dp[sum] == 0) continue;
                    for (int digit = 0; digit <= 9; digit++)
                    {
                        if (sum + digit <= maxSum)
                        {
                            newDp[sum + digit] += dp[sum];
                        }
                    }
                }
                dp = newDp;
            }
            long total = 0;
            foreach (long count in dp)
            {
                total += count * count;
            }

            return total;
        }
    }
}
