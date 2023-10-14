namespace BankAccount
{
    internal class CheckingAccount : BankAccount
    {
        double overdraftLimit;
        public CheckingAccount(string accountHolder, double balance, double overdraftLimit) : base(accountHolder, balance)
        {
            this.overdraftLimit = overdraftLimit;
        }
        public override double Deposit(double amount)
        {
            throw new NotImplementedException();
        }

        public override void DisplayAccountInfo()
        {
            throw new NotImplementedException();
        }

        public override double Withdraw(double amount)
        {
            throw new NotImplementedException();
        }
    }
}