namespace xUnitAPIdemo.BusinessLogic
{
    public class BankAccount
    {
        public int Balance { get; set; }

        public void Deposit(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive");
            }

            Balance += amount;
        }
    }
}
