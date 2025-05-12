using System.ComponentModel;

namespace PayrollApp.Entities
{
    public class Employee
    {
        protected readonly int id; // should be assigned ONLY through constructor
        protected string name;
        protected decimal basicPay;
        protected decimal daPay;
        protected decimal hraPay;
        //protected decimal totalPay;  // will be set by a method, will NOT be passed from outside the class


        public Employee() { }

        public Employee(int id, string name, decimal basicPay, decimal daPay, decimal hraPay)
        {
            this.id = id;
            this.name = name;
            this.basicPay = basicPay;
            this.daPay = daPay;
            this.hraPay = hraPay;
        }

        public int Id
        {
            get { return this.id; } //readOnly
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public decimal BasicPay
        {
            get { return this.basicPay; }
            set { this.basicPay = value; }
        }
        public decimal DaPay
        {
            get { return this.daPay; }
            set { this.daPay = value; }
        }
        public decimal HraPay
        {
            get { return this.hraPay; }
            set { this.hraPay = value; }
        }

        //public decimal TotalPay
        //{
        //    get { return this.totalPay; } //readOnly 
        //}

        public virtual void CalculateSalary() { }

    }
}
