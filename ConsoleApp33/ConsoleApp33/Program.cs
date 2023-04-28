using System;

namespace BankAccountNS
{
    public class BankAccount
    {
        private readonly string m_customerName;
        private double m_balance;

        private BankAccount() { }

        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        public string CustomerName
        {
            get { return m_customerName; }
        }

        public double Balance
        {
            get { return m_balance; }
        }

        public void Debit(double amount)
        {
            if (amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance += amount; // intentionally incorrect code
        }

        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance += amount;
        }

        public static void Main()
        {
            Console.Write("Введите имя: ");
            string? name = Console.ReadLine();
            BankAccount ba = new BankAccount($"{name}", 0);
            Console.Write("Введите размер зарплаты: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Введите размер дебета: ");
            decimal debit = Convert.ToDecimal(Console.ReadLine());
            ba.Credit(500);
            ba.Debit(200);
            Console.WriteLine("Добро пожаловать,ваш баланс: ${0}", ba.Balance);
        }
    }
}