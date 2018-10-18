using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class NullAccount : IAccount
    {
        /// <summary>
        /// get/set balance from null account
        /// </summary>
        public decimal Balance { get; set; }

        /// <summary>
        /// get/set reward points from null account
        /// </summary>
        public int RewardPoints { get; set; }

        /// <summary>
        /// does nothing when you try to add a transaction
        /// </summary>
        /// <param name="amount"></param>
        public void AddTransaction(decimal amount)
        {
            
        }

        /// <summary>
        /// return 0 when you try to calculate the reward points
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public int CalculateRewardPoints(decimal amount)
        {
            return 0;
        }
    }
}
