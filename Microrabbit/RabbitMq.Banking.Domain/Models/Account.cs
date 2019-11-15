using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMq.Banking.Domain.Models
{
  public  class Account 
    {
        public int AccountId { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; set; }
    }
}
