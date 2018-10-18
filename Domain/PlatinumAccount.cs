using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class PlatinumAccount : IAccount
    {
        /// <summary>
        /// 1 point for each $2 deposited
        /// 1 point for each $1,000 in account balance
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public int CalculateRewardPoints(decimal amount)
        {
            return Math.Max((int)decimal.Ceiling((Balance / PlatinumBalanceCostPerPoint) + (amount / PlatinumTransactionCostPerPoint)), 0);
        }

        public void AddTransaction(decimal amount)
        {
            // only award reward points on deposit
            if (amount > 0) RewardPoints += CalculateRewardPoints(amount);
            // always update balance
            Balance += amount;
        }

        private const int PlatinumTransactionCostPerPoint = 2;
        private const int PlatinumBalanceCostPerPoint = 1000;

        public decimal Balance { get; set; }
        public int RewardPoints { get; set; }
    }
}
