using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem3work6.Services
{
    public class Gazprombank : IBankService
    {
        public string Name { get; } = "Газпромбанк";

        public double CalculateSalary(double baseSalary)
        {
            return baseSalary * 0.985;
        }
    }
}
