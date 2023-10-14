namespace BankAccount
{
    class CheckingAccount : BankAccount
    {
        double overdraftLimit; // Ліміт овердрафту

        public CheckingAccount(string accountHolder, double balance, double overdraftLimit) : base(accountHolder, balance)
        {
            this.overdraftLimit = overdraftLimit;
        }

        public override double Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Внесено {amount:C}. Новий баланс: {balance:C}");
            }
            else
            {
                Console.WriteLine("Сума для внесення повинна бути більше нуля.");
            }

            return balance;
        }

        public override double Withdraw(double amount)
        {
            if (amount > 0)
            {
                if (balance - amount >= -overdraftLimit)
                {
                    balance -= amount;
                    Console.WriteLine($"Знято {amount:C}. Новий баланс: {balance:C}");
                }
                else
                {
                    Console.WriteLine("Перевищено ліміт овердрафту.");
                }
            }
            else
            {
                Console.WriteLine("Сума для зняття повинна бути більше нуля.");
            }

            return balance;
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Баланс: {balance:C}");
            Console.WriteLine($"Власник рахунку: {accountHolder}");
            Console.WriteLine($"Ліміт овердрафту: {overdraftLimit:C}");
        }
    }
}
