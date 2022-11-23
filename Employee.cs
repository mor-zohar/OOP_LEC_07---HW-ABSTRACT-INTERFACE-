using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEC_07___HW
{
    internal class Employee : Person,ICalculate
    {
        public double Salarry { get; set; }
        public Employee(double salarry,string name,string address)
            :base(name,address)
        {
            Salarry = salarry;
        }

        public override string PrintInfo()
        {
            return $"Employee:\n{GetInfo()}Your salary: {Salarry}";
        }

        public double DivideSalary()
        {
           return Salarry / 10; 
        }
    }
}
