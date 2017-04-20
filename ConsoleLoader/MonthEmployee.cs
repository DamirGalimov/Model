using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLoader
{
    /// <summary>
    /// Оплата за месяц
    /// </summary>
    public class MonthEmployee : IEmployee
    {
        /// <summary>
        /// Имя работника.
        /// </summary>
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// Фамилия работника.
        /// </summary>
        public string Surname
        {
            get;
            set;
        }
        /// <summary>
        /// Отчество работника.
        /// </summary>
        public string Patronymic
        {
            get;
            set;
        }
        /// <summary>
        /// День рождения работника.
        /// </summary>
        public string Birthday
        {
            get;
            set;
        }
        /// <summary>
        /// Дневная оплата.
        /// </summary>
        public int Payment
        {
            get;
            set;
        }
        /// <summary>
        /// Количество рабочих дней.
        /// </summary>
        public int DaysOfWork
        {
            get;
            set;
        }
        /// <summary>
        /// Расчет зарплаты.
        /// </summary>
        /// <returns></returns>
        public int CalculationOfPayment()
        {
            return Payment * DaysOfWork;
        }
        /// <summary>
        /// Конструктор класса MonthEmployee.
        /// </summary>
        /// <param name="surname">Фамилия работника.</param>
        /// <param name="name">Имя работника.</param>
        /// <param name="patronymic">Отчество работника.</param>
        /// <param name="birthday">День рождения работника.</param>
        /// <param name="payment">Дневная оплата.</param>
        /// <param name="days">Количество дней.</param>
        public MonthEmployee(string surname, string name, string patronymic, string birthday, int payment, int days)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Birthday = birthday;
            Payment = payment;
            DaysOfWork = days;
        }
    }
}
