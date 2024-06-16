using FluentAssertions;
using PennyPrudence.Domain.Models;

namespace PennyPrudence.Domain.Test
{
    public class CreditCardStatementTests
    {
        [Theory]
        [InlineData(2.22,2.22,2.22,6.66)]
        [InlineData(5.23,2.22,10,17.45)]
        public void GetTotalInstallments_WithData_ShouldSumTheInstallments(decimal a, decimal b, decimal c, decimal total)
        {
            //arrange
            var myStatement = new CreditCardStatement() { Installments = new List<Installment>() };
            myStatement.Installments.Add(new Installment { Amount = a });
            myStatement.Installments.Add(new Installment { Amount = b });
            myStatement.Installments.Add(new Installment { Amount = c });
            //act

            //assert
            myStatement.GetTotalInstallments.Should().Be(total);
        }

        [Theory]
        [InlineData(2.22, 2.22, 2.22, 13.34)]
        [InlineData(5.23, 2.22, 10, 2.55)]
        public void GetConsumesWithoutInstallments_WithInstallments_ShouldRestThemFromTheTotal(decimal a, decimal b, decimal c, decimal total)
        {
            //arrange

            var myStatement = new CreditCardStatement() { Installments = new List<Installment>() };
            myStatement.Installments.Add(new Installment { Amount = a });
            myStatement.Installments.Add(new Installment { Amount = b });
            myStatement.Installments.Add(new Installment { Amount = c });
            myStatement.Total = 20;
            //act

            //assert
            myStatement.GetConsumesWithoutInstallments.Should().Be(total);
        }
    }
}