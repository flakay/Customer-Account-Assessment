using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Accounts.Api.Models
{
    public class Transaction
    {
        public int? Id { get; set; }
        public string TransactionType { get; set; }
    }
}