using System;

namespace Accounting
{
    class Loans
    {
        internal static int credit = 700;   // Размер предоставленного кредита.
        internal static int debt;           // Остаток задолженности.

        /// <summary>
        /// Метод выводит на экран информацию о состоянии кредита (сумма задолженности, сумма переплаты, сообщение об отсутствии долга).
        /// </summary>
        /// <param name="payment">Размер платежа.</param>
        internal static void Accounting(int payment)
        {
            debt = credit - payment;

            if (debt > 0)
            {
                Console.WriteLine($"Сумма задолженности составляет: {debt} грн.\n");
            }
            else if (debt < 0)
            {
                debt *= -1;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\nЗадолженность по кредиту погашена в полном объеме.");
                Console.WriteLine($"Внимание! По кредиту есть переплата в размере: {debt} грн.");
            }
            else if (debt == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\nЗадолженность по кредиту погашена в полном объеме.");
            }
        }
    }
}
