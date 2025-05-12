using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollApp.Entities
{
    public class Hr : Employee
    {
        /*
         * -- Below data members inherited from the Parent class Employee
        readonly int id;  should be assigned ONLY through constructor
        string name;
        decimal basicPay;
        decimal daPay;
        decimal hraPay;
         */
        decimal gratuityPay;
        decimal totalPay;  // will be set by a method, will NOT be passed from outside the class

        public Hr() { }

        public Hr(int id, string name, decimal basicPay, decimal daPay, decimal hraPay,
            decimal gratuityPay) : base(id,name,basicPay,daPay,hraPay)
        {
            this.gratuityPay = gratuityPay;
            
        }
        
        public decimal TotalPay 
        {
            get { return this.totalPay; } //readOnly 
        }

        public decimal GratuityPay
        {
            get { return this.gratuityPay;  }
            set { this.gratuityPay = value; }
        }

        public override void CalculateSalary() // overriding the Parent Virtual Function
        {
            this.totalPay = base.basicPay + base.daPay + base.hraPay + this.gratuityPay;
        }
    }
}
