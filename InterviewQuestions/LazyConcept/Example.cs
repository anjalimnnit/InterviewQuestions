using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyConcept
{
    public class Loan
    {
        public string AccountNumber { get; set; }
        public float LoanAmount { get; set; }
        public bool IsLoanApproved { get; set; }
        public Loan(string accountNumber)
        {
            Console.WriteLine("loan class constructor called.....");
            this.AccountNumber = accountNumber;
            this.LoanAmount = 1000;
            this.IsLoanApproved = true;
            Console.WriteLine("loan object created.....");
        }
    }
        public class PersonalLoan
        { 
        public Loan GetLoanDetails()
        {
           return new Loan(AccountNumber){ AccountNumber = AccountNumber, IsLoanApproved = false, LoanAmount = 1000 };
        }
            public string AccountNumber { get; set; }
            public string AccounHolderName { get; set; }
            public Lazy<Loan> LoanDetail { get; set; }
            public PersonalLoan(string accountNumber)
            {
            Console.WriteLine("account class constructor called.....");
            this.AccountNumber = accountNumber;
                LoanDetail = new Lazy<Loan>(() => GetLoanDetails());
            }
        }

}
