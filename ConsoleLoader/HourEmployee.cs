using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLoader
{
    /// <summary>
    ///  По часовая зарплата
    /// </summary>
    public class HourEmployee : IEmployee
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
        /// Расчет зарплаты.
        /// </summary>
        /// <returns></returns>
        public int CalculationOfPayment()
        {
            return Payment * HoursOfWork;
        }
        /// <summary>
        /// Отработанные часы.
        /// </summary>
        public int HoursOfWork
        {
            get;
            set;
        }
        /// <summary>
        /// Почасовая оплата.
        /// </summary>
        public int Payment
        {
            get;
            set;
        }
        /// <summary>
        /// Конструктор класса HourEmployee.
        /// </summary>
        /// <param name="surname">Фамилия работника.</param>
        /// <param name="name">Имя работника.</param>
        /// <param name="patronymic">Отчество работника.</param>
        /// <param name="birthday">День рождения работника.</param>
        /// <param name="payment">Почасовая оплата.</param>
        /// <param name="hours">Количество часов.</param>
        public HourEmployee(string surname, string name, string patronymic, string birthday, int payment, int hours)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Birthday = birthday;
            Payment = payment;
            HoursOfWork = hours;
        }
    }
}
