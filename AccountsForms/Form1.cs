using Domain;
using Services;
using System;
using System.Windows.Forms;

namespace AccountsForms
{
    /// <summary>
    /// This is the main GUI form for the accounts
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// accService is the link to the accounts through the 
        /// IAccountServices interface
        /// </summary>
        IAccountServices accService = new AccountService();
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Create a new account button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string accountName = txtAccountName.Text;
            listBoxAccounts.Items.Add(accountName);
            accService.CreateAccount(accountName, AccountType.Silver);
            txtAccountName.Text = "";
        }
        /// <summary>
        /// Account listbox item selected
        /// Find the account and update the balance displayed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string accName = listBoxAccounts.SelectedItem.ToString();
            decimal balance = accService.GetAccountBalance(accName);
            int reward = accService.GetRewardPoints(accName);

            txtBalance.Text = balance.ToString();
            txtReward.Text = reward.ToString();

            btnDeposit.Enabled = true;
            btnWithDrawal.Enabled = true;
        }

        /// <summary>
        /// deposits money into the selected account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            //gets account name
            string accName = listBoxAccounts.SelectedItem.ToString();
            //gets the deposit amount if there is one there
            decimal depositAmount;
            Decimal.TryParse(txtDepositAmount.Text, out(depositAmount));
            //deposits the money into the account
            accService.Deposit(accName, depositAmount);

            //sets the text boxes
            txtBalance.Text = accService.GetAccountBalance(accName).ToString();
            txtReward.Text = accService.GetRewardPoints(accName).ToString();
            txtDepositAmount.Text = "";
        }

        /// <summary>
        /// withdraws money from the account 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWithDrawal_Click(object sender, EventArgs e)
        {
            //gets the account name
            string accName = listBoxAccounts.SelectedItem.ToString();
            //gets withdrawl the amount if there is one
            decimal withdrawlAmount;
            Decimal.TryParse(txtWithdrawalAmount.Text, out(withdrawlAmount));
            //withdrawls money from the account
            accService.Withdrawal(accName, withdrawlAmount);

            //sets text boxes
            txtBalance.Text = accService.GetAccountBalance(accName).ToString();
            txtReward.Text = accService.GetRewardPoints(accName).ToString();
            txtWithdrawalAmount.Text = "";
        }
    }
}
