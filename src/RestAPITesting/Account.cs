﻿namespace RestAPITesting
{
    public class Account
    {
        private decimal balance;

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            balance -= amount;
        }

        public void TransferFunds(Account destination, decimal amount)
        {
        }

        public decimal Balance
        {
            get { return balance; }
        }
    }
}
