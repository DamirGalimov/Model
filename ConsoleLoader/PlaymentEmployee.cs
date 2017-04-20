using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLoader
{
    /// <summary>
    /// Оплата по окладу
    /// </summary>
    class PlaymentEmployee : IEmployee
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
        /// Количество рабочих дней.
        /// </summary>
        public int DaysOfWork
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

        public int Salary
        /// <summary>
        /// Оплата с окладом.
        /// </summary>
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
            int pit = (Salary - (((Salary - 400) * 13) / 100)) / 30;
            return pit * DaysOfWork;
        }
        public PlaymentEmployee(string surname, string name, string patronymic, string birthday, int payment, int days, int salary)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Birthday = birthday;
            Payment = payment;
            DaysOfWork = days;
            Salary = salary;
        }
    }
}
