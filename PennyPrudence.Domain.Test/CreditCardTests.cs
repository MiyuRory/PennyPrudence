using PennyPrudence.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PennyPrudence.Domain.Test
{
    public class CreditCardTests
    {

        [Fact]
        public void GetTotalInstallments_WithData_ShouldSumTheInstallments()
        {
            //arrange
            BankEntity bank = new BankEntity
            {
                Name = "BBVA",
                
            };

            bank.CreditCards.Add(new CreditCard
            {
                Name = "VISA BBVA"
            });

            var creditCard = bank.CreditCards.First();

            creditCard?.PaymentPlans?.Add(new PaymentPlan
            {
                Description = "PlayStation"
                

            });

            var paymentPlan = creditCard?.PaymentPlans?.First();

            if (paymentPlan != null)
            {
                paymentPlan.CreatedAt = DateTime.Now;

                paymentPlan.TotalAmount = 125000;
                  
            }







        }

    }
}
