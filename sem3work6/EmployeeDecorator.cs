using sem3work6.Employees;
using sem3work6.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem3work6
{
    public abstract class EmployeeDecorator : Employee
    {
        protected Employee Employee { get; set; }

        public EmployeeDecorator(Employee employee) : base(employee.Name, employee.BaseSalary, employee.BankService)
        {
            Employee = employee;
        }

        public override void SetBankService(IBankService bankService)
        {
            Employee.SetBankService(bankService);
            base.SetBankService(bankService);
        }
    }
}
