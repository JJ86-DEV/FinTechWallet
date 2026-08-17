using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    internal class Wallet
    {
        public int Id { get; set; }//Primary key
        public string UserId { get; set; }//Connected to the User entity
        public string Currency { get; set; }
        //defined anum outside the class for the currency
        public decimal Balance { get; private set; }
        public DateTime CreatedAt { get; set; }

        //(encapsulation)methods to credit and debit the wallet
        public void Credit(decimal amount)
        {
            Balance += amount; //adds money 
        }
        public void Debit(decimal amount)
        {
            Balance -= amount; //removes money
        }

    }
}