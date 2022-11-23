using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEC_07___HW
{
    internal class Customer : Person
    {
        public string Email { get; set; }
        public Customer(string email, string name, string address)
            : base(name,address)
        {
            Email = email;
        }

        public override string PrintInfo()
        {
            return $"Customer:\n{GetInfo()}Your Email: {Email}" ;
        }
    }
}
