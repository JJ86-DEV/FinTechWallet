using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    internal class Transaction
    {
        public int Id { get; set; }
        public string SourceWalletId { get; set; } 
        public string DestinationWalletId { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }
        //Withdrawal, Deposit, Transfer
        public DateTime CreatedAt { get; set; }
    }
}
