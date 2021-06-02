using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Transactions.Api.Models
{
    public class TransactionType
    {
        public int? Id { get; set; }
        public string Deposit { get; set; }
        public string Withdraw { get; set; }
    }
}