using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLoader
{
    class Realization
    {
        public static void Main()
        {
            IEmployee employee1 = new MonthEmployee("Сидоров", "Сергей", "Сергеевич", "05.08.1968", 200, 23);
            Console.WriteLine(employee1.Surname + " " + employee1.Name + " " + employee1.Patronymic + " " + employee1.Birthday + " " + "Зарплата: " + employee1.CalculationOfPayment() + '\n');
            IEmployee employee2 = new HourEmployee("Антонов", "Андрей", "Викторович", "07.10.1952", 200, 29);
            Console.WriteLine(employee2.Surname + " " + employee2.Name + " " + employee2.Patronymic + " " + employee2.Birthday + " " + "Зарплата: " + employee2.CalculationOfPayment() + '\n');
            IEmployee employee3 = new PlaymentEmployee("Иванов", "Петр", "Анатольевич ", "14.07.1988", 200, 18, 150000);
            Console.WriteLine(employee3.Surname + " " + employee3.Name + " " + employee3.Patronymic + " " + employee3.Birthday + " " + "Зарплата: " + employee3.CalculationOfPayment() + '\n');
            Console.ReadKey();
        }
    }
}
