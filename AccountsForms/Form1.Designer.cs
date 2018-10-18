namespace AccountsForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.listBoxAccounts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDepositAmount = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnWithDrawal = new System.Windows.Forms.Button();
            this.txtWithdrawalAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReward = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(53, 51);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(100, 20);
            this.txtAccountName.TabIndex = 0;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(53, 91);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(100, 23);
            this.btnAddAccount.TabIndex = 1;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // listBoxAccounts
            // 
            this.listBoxAccounts.FormattingEnabled = true;
            this.listBoxAccounts.Location = new System.Drawing.Point(52, 164);
            this.listBoxAccounts.Name = "listBoxAccounts";
            this.listBoxAccounts.Size = new System.Drawing.Size(137, 147);
            this.listBoxAccounts.TabIndex = 2;
            this.listBoxAccounts.SelectedIndexChanged += new System.EventHandler(this.listBoxAccounts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Account Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Current Accounts";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(261, 77);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(100, 20);
            this.txtBalance.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Account Balance";
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.Location = new System.Drawing.Point(341, 184);
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.Size = new System.Drawing.Size(100, 20);
            this.txtDepositAmount.TabIndex = 7;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Enabled = false;
            this.btnDeposit.Location = new System.Drawing.Point(255, 182);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 8;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Amount";
            // 
            // btnWithDrawal
            // 
            this.btnWithDrawal.Enabled = false;
            this.btnWithDrawal.Location = new System.Drawing.Point(255, 212);
            this.btnWithDrawal.Name = "btnWithDrawal";
            this.btnWithDrawal.Size = new System.Drawing.Size(75, 23);
            this.btnWithDrawal.TabIndex = 10;
            this.btnWithDrawal.Text = "Withdrawal";
            this.btnWithDrawal.UseVisualStyleBackColor = true;
            this.btnWithDrawal.Click += new System.EventHandler(this.btnWithDrawal_Click);
            // 
            // txtWithdrawalAmount
            // 
            this.txtWithdrawalAmount.Location = new System.Drawing.Point(344, 214);
            this.txtWithdrawalAmount.Name = "txtWithdrawalAmount";
            this.txtWithdrawalAmount.Size = new System.Drawing.Size(100, 20);
            this.txtWithdrawalAmount.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Wells Fargo Account Creator";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Reward Points";
            // 
            // txtReward
            // 
            this.txtReward.Location = new System.Drawing.Point(408, 75);
            this.txtReward.Name = "txtReward";
            this.txtReward.ReadOnly = true;
            this.txtReward.Size = new System.Drawing.Size(100, 20);
            this.txtReward.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 385);
            this.Controls.Add(this.txtReward);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWithdrawalAmount);
            this.Controls.Add(this.btnWithDrawal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.txtDepositAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxAccounts);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.txtAccountName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.ListBox listBoxAccounts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDepositAmount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnWithDrawal;
        private System.Windows.Forms.TextBox txtWithdrawalAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReward;
    }
}

