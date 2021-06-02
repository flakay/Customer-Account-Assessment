using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using TransactionalCustomerAccount.Models;

namespace TransactionalCustomerAccount.Api.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AccountApiController : ApiController
    {
        [HttpPost]
        public IHttpActionResult PostAccountById([FromBody] int? id)
        {
            Account account = new Account();

            if (id > 0)
            {
                account.AccountId = 1;
                account.CustomerId = id;
                account.TransactionId = 1;
                account.Name = "Michael";
                account.Surname = "Orms";
                account.Balance = 10000;
                account.TransactionType = "Deposit";
            }

            return Ok(account);
        }
        [HttpGet]
        public List<Account> GetAllAccounts()
        {
            Account account1 = new Account();
            Account account2 = new Account();
            Account account3 = new Account();

            account1.AccountId = 1;
            account1.CustomerId = 1;
            account1.TransactionId = 1;
            account1.Name = "Michael";
            account1.Surname = "Orms";
            account1.Balance = 10000;

            account2.AccountId = 2;
            account2.CustomerId = 2;
            account2.TransactionId = 2;
            account2.Name = "James";
            account2.Surname = "Spader";
            account2.Balance = 5000;

            account3.AccountId = 3;
            account3.CustomerId = 3;
            account3.TransactionId = 3;
            account3.Name = "Timothy";
            account3.Surname = "Dalton";
            account3.Balance = 20000;

            List<Account> accounts = new List<Account>
            {
                account1,
                account2,
                account3
            };

            return accounts;
        }
    }
}
