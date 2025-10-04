using Tumakov.Enums;

namespace Tumakov.Structs
{
    public struct Account
    {
        long accountNumber; // поле, которое хранит номер счета
        BankAccount BankAccount; // поле, хранящее тип банковского счета
        decimal balance; // поле, которое хранит баланс
        
        public Account(long accountNumber, BankAccount bankAccount, decimal balance) // конструктор Account
        {
            this.accountNumber = accountNumber;
            this.BankAccount = bankAccount;
            this.balance = balance;
        }

        public override string ToString() // просто переопределил метод ToString(), чтобы сделать красивый вывод
        {
            return $"Тип счета: {BankAccount}\nНомер счета: {accountNumber}\nБаланс: {balance}";
        }
    }
}
