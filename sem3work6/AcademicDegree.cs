using sem3work6.Employees;
using sem3work6.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem3work6
{
    internal class AcademicDegree : EmployeeDecorator
    {
        public string DissertationTitle { get; set; }
        public int Year { get; set; }
        public string ScienceArea { get; set; }

        public AcademicDegree(Employee employee) : base(employee) { }

        public override string GetInfo()
        {
            string info = base.GetInfo();
            info += new string('-', 16);
            info += $"\n";
            info += $"Научная работа: {DissertationTitle} \n";
            info += $"Год защиты: {Year} \n";
            info += $"Область: {ScienceArea} \n";
            return info;
        }
    }
}
