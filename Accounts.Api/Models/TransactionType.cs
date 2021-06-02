using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Accounts.Api.Models
{
    public class TransactionType
    {
        public int? Id { get; set; }
        public string Deposit { get; set; }
        public string Withdraw { get; set; }
    }
}