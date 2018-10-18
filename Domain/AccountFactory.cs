using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    /// <summary>
    /// Factory method to create the correct type of account
    /// given the account type.
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public static class AccountFactory
    {
        public static IAccount CreateAccount(AccountType type)
        {
            IAccount account = null;
            switch (type)
            {
                case AccountType.Silver:
                    account = new SilverAccount();
                    break;
                case AccountType.Gold:
                    account = new GoldAccount();
                    break;
                case AccountType.Platinum:
                    account = new PlatinumAccount();
                    break;
            }
            return account;
        }
    }
}
