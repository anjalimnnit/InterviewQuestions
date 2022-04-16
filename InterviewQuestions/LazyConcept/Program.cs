using System;

namespace LazyConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonalLoan p1 = new PersonalLoan("123");
            Console.WriteLine(p1.AccountNumber);
            var n = p1.LoanDetail.Value;
            Console.WriteLine(n.AccountNumber);
            Console.WriteLine(n.IsLoanApproved);
            Console.WriteLine(n.LoanAmount);
        }
    }
}
