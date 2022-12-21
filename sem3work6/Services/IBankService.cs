using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem3work6.Services
{
    public interface IBankService
    {
        public string Name { get; }

        public double CalculateSalary(double baseSalary);
    }
}
