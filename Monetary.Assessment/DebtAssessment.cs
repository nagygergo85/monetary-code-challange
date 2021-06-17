using Monetary.Common.Interfaces;
using Monetary.Common.Models;
using Monetary.CreditDecision;
using Monetary.InterestRate;
using System;

namespace Monetary.Assessment
{
    public class DebtAssessment: IAssessment
    {
        public IDecision decisionService;
        public IInterestRate interestRateService;

        public DebtAssessment()
        {
            decisionService = new CreditDebtDecision();
            interestRateService = new CreditInterestRate();
        }

        public MonetaryOutput GetMonetaryAssessment(MonetaryInput input)
        {
            var output = new MonetaryOutput();
            var decision = decisionService.GetDecision(input.CreditAmount);
            var interestRate = interestRateService.GetInterestRate(input.CreditAmount, input.ExistingAmount);

            output.Decision = decision;
            output.InterestRate = interestRate;

            return output;
        }
    }
}
