namespace BankAccount
{
    class CheckingAccount : BankAccount
    {
        double overdraftLimit; // ˳�� ����������

        public CheckingAccount(string accountHolder, double balance, double overdraftLimit) : base(accountHolder, balance)
        {
            this.overdraftLimit = overdraftLimit;
        }

        public override double Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"������� {amount:C}. ����� ������: {balance:C}");
            }
            else
            {
                Console.WriteLine("���� ��� �������� ������� ���� ����� ����.");
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
                    Console.WriteLine($"����� {amount:C}. ����� ������: {balance:C}");
                }
                else
                {
                    Console.WriteLine("���������� ��� ����������.");
                }
            }
            else
            {
                Console.WriteLine("���� ��� ������ ������� ���� ����� ����.");
            }

            return balance;
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"������: {balance:C}");
            Console.WriteLine($"������� �������: {accountHolder}");
            Console.WriteLine($"˳�� ����������: {overdraftLimit:C}");
        }
    }
}
