
using Xunit;
using xUnitAPIdemo.BusinessLogic;

namespace xUnitAPIdemo.UnitTests._2_BankAccount
{
    public class BankTest
    {
        [Fact]
        public void Deposit_ShouldIncreaseBalance()
        {
            // Arrange
            BankAccount account = new BankAccount();

            // Act
            account.Deposit(100);

            // assert
            Assert.Equal(100, account.Balance);
        }

        [Fact]
        public void Deposit_ShouldNotIncreaseBalance()
        {
            // Arrange
            BankAccount account = new BankAccount();

            // assert
            Assert.Throws<ArgumentException>(() => account.Deposit(-2));
        }
    }
}

