using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Accounts.Api.Models
{
    public class Account
    {
        public int? Id { get; set; }
        public int? CustomerId { get; set; }
        public int? TransactionId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Balance { get; set; }
    }
}