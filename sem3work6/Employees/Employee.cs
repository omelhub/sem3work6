using sem3work6.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem3work6.Employees
{
    public abstract class Employee
    {
        public string Name { get; }
        public double BaseSalary { get; }
        public virtual IBankService BankService { get; protected set; }

        public Employee(string name, double baseSalary, IBankService bankService = null)
        {
            Name = name;
            BaseSalary = baseSalary;
            BankService = bankService == null ? new Sberbank() : bankService;
        }

        public virtual string GetInfo()
        {
            string info = new string('=', 16);
            info += $"\n";
            info += $"Имя: {Name} \n";
            info += $"Базовая зарплата: {BaseSalary} \n";
            info += $"Для перечисления зарплаты используется сервис {BankService.Name} \n";
            info += $"Зарплата после удержания комиссии сервиса: {BankService.CalculateSalary(BaseSalary)} \n";
            return info;
        }

        public double CalculateSalary()
        {
            return BankService.CalculateSalary(BaseSalary);
        }

        public virtual void SetBankService(IBankService bankService)
        {
            BankService = bankService;
        }
    }
}
