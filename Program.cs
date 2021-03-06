﻿using System;

/*
Представьте, что вы реализуете программу для банка, которая помогает определить, погасил ли клиент кредит или нет. 
Допустим, ежемесячная сумма платежа должна составлять 100 грн. Клиент должен выполнить 7 платежей, но может платить реже большими суммами. 
Т.е., может двумя платежами по 300 и 400 грн. закрыть весь долг.
Создайте метод, который будет в качестве аргумента принимать сумму платежа, введенную экономистом банка. 
Метод выводит на экран информацию о состоянии кредита (сумма задолженности, сумма переплаты, сообщение об отсутствии долга).
*/

namespace Accounting
{
    class Program
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Сумма задолженности составляет " + Loans.credit + " грн.\n");
            Console.ResetColor();

            int payment = 0;   // Общая сумма совершенных платежей.
            for (int quantity = 0; quantity < 7; quantity++)
            {
                Console.Write("Укажите размер внесенной суммы: ");
                int tranche = Convert.ToInt32(Console.ReadLine());

                // Если платеж меньше 100 - платеж не принимаем.
                if (tranche < 100)
                {
                    Console.WriteLine("Размер минимального платежа составляет 100 грн.");
                    quantity--;
                    continue;
                }

                // Увеличиваем общую сумму полатежей на размер последнего транша.
                payment += tranche;

                Loans.Accounting(payment);

                // Если сумма платежей равна/больше размера кредита - прекращаем прием платежей.
                if (payment >= Loans.credit) break;
            }

            Console.ReadLine();
        }
    }
}
