
﻿using System;
using System.Collections.Generic;

namespace BankProject
{
    public enum AccountType
    {
        Checking,
        Saving
    }

    abstract public class Account
    { 
        protected Client owner;
        public decimal Balance { get; set; }
        public AccountType Type { get; protected set; }
        public List<string> history = new List<string>();
        public Account(Client owner, AccountType type)
        {
            this.owner = owner;
            Balance = 0;
            Type = type;
        }
        public bool Deposit(decimal amount)
        {
            if (amount <= 0) return false;

            Balance += amount;
            history.Add($"Deposited: {amount} EGP on {DateTime.Now}");
            return true;
        }
        public bool Withdraw(decimal amount)
        {
            if (amount <= 0 || amount > Balance) return false;

            Balance -= amount;
            history.Add($"Withdrew: {amount} EGP on {DateTime.Now}");
            return true;
        }
        public bool Transfer(Client receiver, decimal amount)
        {
            if (receiver == null || amount <= 0 || amount > Balance) return false;

            Balance -= amount;
            history.Add($"Transferred: {amount} EGP to {receiver.Name} on {DateTime.Now}");

            receiver.Account.ReceiveTransfer(owner.Username, amount);
            return true;
        }

        protected void ReceiveTransfer(string senderUsername, decimal amount)
        {
            Balance += amount;
            history.Add($"Received: {amount} EGP from {senderUsername} on {DateTime.Now}");
        }
        public List<string> GetHistory()
        {

            return new List<string>(history);
        }
    }
}