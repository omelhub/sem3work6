using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem3work6.Services
{
    public class Sberbank : IBankService
    {
        public string Name { get; } = "Сбербанк";

        public double CalculateSalary(double baseSalary)
        {
            return baseSalary * 0.99;
        }
    }
}
