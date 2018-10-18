using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;
using Domain;

namespace ServicesUnitTest
{
    [TestClass]
    public class AccountServiceUnitTest
    {
        [TestMethod]
        public void CreateAccountSetsBalanceToZero()
        {
            // Arrange    
            AccountService acctService = new AccountService();
            // Act
            string accountName = "Test1";
            acctService.CreateAccount(accountName, AccountType.Silver);
            decimal balance = acctService.GetAccountBalance(accountName);
            // Assert
            Assert.AreEqual(balance, 0.00M);
        }

        [TestMethod]
        public void DepositAddsFundsToAccountBalance()
        {
            // Arrange    
            AccountService acctService = new AccountService();
            // Act
            string accountName = "Test2";
            acctService.CreateAccount(accountName, AccountType.Silver);
            acctService.Deposit(accountName, 100M);
            acctService.Deposit(accountName, 25M);
            decimal balance = acctService.GetAccountBalance(accountName);
            // Assert
            Assert.AreEqual(balance, 125M);
        }

        [TestMethod]
        public void WithdrawalRemovesFundsFromAccountBalance()
        {
            // Arrange    
            AccountService acctService = new AccountService();
            // Act
            string accountName = "Test2";
            acctService.CreateAccount(accountName, AccountType.Silver);
            acctService.Deposit(accountName, 100M);
            acctService.Withdrawal(accountName, 25M);
            decimal balance = acctService.GetAccountBalance(accountName);
            // Assert
            Assert.AreEqual(balance, 75M);
        }

        [TestMethod]
        public void WithdrawalCanCreateNegativeBalance()
        {
            // Arrange    
            AccountService acctService = new AccountService();
            // Act
            string accountName = "Test2";
            acctService.CreateAccount(accountName, AccountType.Silver);
            acctService.Withdrawal(accountName, 100M);
            decimal balance = acctService.GetAccountBalance(accountName);
            // Assert
            Assert.AreEqual(balance, -100M);
        }

        [TestMethod]
        public void RewardPoints_Silver_Deposit()
        {
            // Arrange    
            AccountService acctService = new AccountService();
            // Act
            string accountName = "Test3";
            acctService.CreateAccount(accountName, AccountType.Silver);
            acctService.Deposit(accountName, 1000M);
            acctService.Deposit(accountName, 1000M);
            int points = acctService.GetRewardPoints(accountName);
            // Assert
            Assert.AreEqual(points, 200);
        }
        [TestMethod]
        public void RewardPoints_Silver_Withdrawal()
        {
            // Arrange    
            AccountService acctService = new AccountService();
            // Act
            string accountName = "Test3";
            acctService.CreateAccount(accountName, AccountType.Silver);
            acctService.Deposit(accountName, 1000M);
            acctService.Deposit(accountName, 1000M);
            acctService.Withdrawal(accountName, 1000M);
            int points = acctService.GetRewardPoints(accountName);
            // Assert
            Assert.AreEqual(points, 200);
        }
        [TestMethod]
        public void RewardPoints_Gold_Deposit()
        {
            // Arrange    
            AccountService acctService = new AccountService();
            // Act
            string accountName = "Test3";
            acctService.CreateAccount(accountName, AccountType.Gold);
            acctService.Deposit(accountName, 4000M);
            acctService.Deposit(accountName, 4000M);
            int points = acctService.GetRewardPoints(accountName);
            // Assert
            Assert.AreEqual(points, 800+2+800);
        }
        [TestMethod]
        public void RewardPoints_Gold_Withdrawal()
        {
            // Arrange    
            AccountService acctService = new AccountService();
            // Act
            string accountName = "Test3";
            acctService.CreateAccount(accountName, AccountType.Gold);
            acctService.Deposit(accountName, 4000M);
            acctService.Deposit(accountName, 4000M);
            acctService.Withdrawal(accountName, 4000M);
            int points = acctService.GetRewardPoints(accountName);
            // Assert
            Assert.AreEqual(points, 800 + 2 + 800);
        }
        [TestMethod]
        public void RewardPoints_Platinum_Deposit()
        {
            // Arrange    
            AccountService acctService = new AccountService();
            // Act
            string accountName = "Test3";
            acctService.CreateAccount(accountName, AccountType.Platinum);
            acctService.Deposit(accountName, 4000M);
            acctService.Deposit(accountName, 4000M);
            int points = acctService.GetRewardPoints(accountName);
            // Assert
            Assert.AreEqual(points, 2000+4+2000);
        }
        [TestMethod]
        public void RewardPoints_Platinum_Withdrawal()
        {
            // Arrange    
            AccountService acctService = new AccountService();
            // Act
            string accountName = "Test3";
            acctService.CreateAccount(accountName, AccountType.Platinum);
            acctService.Deposit(accountName, 4000M);
            acctService.Deposit(accountName, 4000M);
            acctService.Withdrawal(accountName, 4000M);
            int points = acctService.GetRewardPoints(accountName);
            // Assert
            Assert.AreEqual(points, 2000 + 4 + 2000);
        }

        [TestMethod]
        public void FindNullAccount()
        {
            //Arrange
            AccountService acctService = new AccountService();
            //Act
            string accountName = "Test4";
            acctService.CreateAccount(accountName, AccountType.Platinum);

            acctService.Deposit("Test5", 400M);
        }
    }
}
