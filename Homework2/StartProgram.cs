using Tumakov.Enums;
using Tumakov.Structs;

class SolveHomework
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Упражнение 3.1 Создать перечислимый тип данных отображающий виды банковского\r\nсчета (текущий и сберегательный). Создать переменную типа перечисления, присвоить ей\r\nзначение и вывести это значение на печать.\n");
        BankAccount bankAccount = new BankAccount();
        bankAccount = BankAccount.Current;
        Console.WriteLine($"Тип счета: {bankAccount}\n");

        Console.WriteLine("Упражнение 3.2 Создать структуру данных, которая хранит информацию о банковском\r\nсчете – его номер, тип и баланс. Создать переменную такого типа, заполнить структуру\r\nзначениями и напечатать результат.\n");
        Account account = new Account(14123124, BankAccount.Current, 141234124124);
        Console.WriteLine(account.ToString() + "\n");

        Console.WriteLine("Домашнее задание 3.1 Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать\r\nструктуру работник с двумя полями: имя, ВУЗ. Заполнить структуру данными и\r\nраспечатать.\n");
        Worker worker = new Worker("Roman", University.КХТИ);
        Console.WriteLine(worker.ToString());
    }
}