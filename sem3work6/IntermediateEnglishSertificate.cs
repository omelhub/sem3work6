using sem3work6.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem3work6
{
    internal class IntermediateEnglishSertificate : EmployeeDecorator
    {
        public IntermediateEnglishSertificate(Employee employee) : base(employee) { }

        public string ExaminationTitle { get; set; }
        public int YearOfSertificate { get; set; }

        public override string GetInfo()
        {
            string info = base.GetInfo();
            info += new string('-', 16);
            info += $"\n";
            info += $"Экзамен: {ExaminationTitle} \n";
            info += $"Год получения сертификата: {YearOfSertificate} \n";
            return info;
        }
    }
}
