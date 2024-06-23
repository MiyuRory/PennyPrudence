using FluentAssertions;
using PennyPrudence.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PennyPrudence.Domain.Test
{
    public class PaymentPlanTests
    {
        [Fact]
        public void IsValid_WithLessThanTotalInstallments_ShouldBeFalse()
        {
            var paymentPlan = new PaymentPlan();
            paymentPlan.Description = "Guitar";
            paymentPlan.TotalAmount = 100000;
            paymentPlan.Number = 2;
            paymentPlan.Installments.Add(new Installment { Amount = 50000 });

            paymentPlan.GetTotalFromInstallments.Should().Be(50000);
            paymentPlan.IsValid.Should().BeFalse();
        }

        [Fact]
        public void IsValid_WithEqualThanTotalInstallments_ShouldBeTrue()
        {
            var paymentPlan = new PaymentPlan();
            paymentPlan.Description = "Guitar";
            paymentPlan.TotalAmount = 100000;
            paymentPlan.Number = 2;
            paymentPlan.Installments.Add(new Installment { Amount = 50000 });
            paymentPlan.Installments.Add(new Installment { Amount = 50000 });

            paymentPlan.GetTotalFromInstallments.Should().Be(100000);
            paymentPlan.IsValid.Should().BeTrue();
        }

        [Fact]
        public void FillInstallments_WithCleanPP_CreatesValidPP()
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

            paymentPlan.FillInstallments();

            paymentPlan.IsValid.Should().BeTrue();


        }
    }
}
