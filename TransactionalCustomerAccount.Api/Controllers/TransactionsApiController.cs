using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TransactionalCustomerAccount.Models;

namespace TransactionalCustomerAccount.Api.Controllers
{
    public class TransactionsApiController : ApiController
    {
        [HttpPost]
        public IHttpActionResult PostTransactionAccountById([FromBody] int? Id)
        {
            Transactions trans = new Transactions();

            if (Id > 0)
            {
                trans.TransactionId = 1;
                trans.TransactionType = "Deposit";
            }
            
            return Ok(trans);
        }

        [HttpPost]
        public List<Transactions> PostAllTransactionAccounts(int? CustomerId)
        {
            Transactions trans1 = new Transactions();
            Transactions trans2 = new Transactions();
            Transactions trans3 = new Transactions();

            trans1.TransactionId = 1;
            trans1.TransactionType = "Deposit";

            trans2.TransactionId = 2;
            trans2.TransactionType = "Withdraw";

            trans3.TransactionId = 3;
            trans3.TransactionType = "EFT";

            List<Transactions> transactions = new List<Transactions>
            {
                trans1,
                trans2,
                trans3
            };

            return transactions;

        }
    }
}
