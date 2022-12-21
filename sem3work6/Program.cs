using sem3work6.Employees;
using sem3work6.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem3work6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee> { new Engineer("Иванов Иван Иванович", 20_000),

                        new AcademicDegree(new Manager("Петров Петр Петрович", 30_000, new Gazprombank())) { DissertationTitle = "Коммуникации в проекте", Year = 1998, ScienceArea = "Менеджмент"},

                        new IntermediateEnglishSertificate(new AcademicDegree(new Scientist("Антон Вячеславович Лапенко", 50_000))
                        { DissertationTitle = "Риторика как феномен культуры", Year = 2022, ScienceArea = "Риторика"})
                        { ExaminationTitle = "С1", YearOfSertificate = 2023}
            };

            employees[2].SetBankService(new Gazprombank());

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.GetInfo());
            }
            Console.ReadKey();
        }
    }
}
