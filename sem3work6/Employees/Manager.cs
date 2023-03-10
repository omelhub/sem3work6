using sem3work6.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem3work6.Employees
{
    public class Manager : Employee
    {
        public string JobTitle = "Менеджер";

        public Manager(string name, double baseSalary, IBankService bankService = null) : base(name, baseSalary, bankService) { }

        public override string GetInfo()
        {
            string info = base.GetInfo();
            info += $"Должность: {JobTitle}\n";
            return info;
        }
    }
}
