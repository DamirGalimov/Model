using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLoader
{
    /// <summary>
    /// <       >
    /// </summary>
    public interface IEmployee
    {
        /// <summary>
        /// Имя работника.
        /// </summary>
        string Name
        {
            get;
            set;
        }
        /// <summary>
        /// Фамилия работника.
        /// </summary>
        string Surname
        {
            get;
            set;
        }
        /// <summary>
        /// Отчество работника.
        /// </summary>
        string Patronymic
        {
            get;
            set;
        }
        /// <summary>
        /// День рождения работника.
        /// </summary>
        string Birthday
        {
            get;
            set;
        }
        /// <summary>
        /// Оплата.
        /// </summary>
        int Payment
        {
            get;
            set;
        }
        /// <summary>
        /// Расчет зарплаты.
        /// </summary>
        /// <returns></returns>
        int CalculationOfPayment();
    }
}
