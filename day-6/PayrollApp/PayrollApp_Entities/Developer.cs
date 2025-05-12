namespace PayrollApp.Entities
{
    public class Developer : Employee
    {
        decimal incentivePay;
        decimal totalPay;  // will be set by a method, will NOT be passed from outside the class

        public Developer() { }

        public Developer(int id, string name, decimal basicPay, decimal daPay, decimal hraPay,
            decimal incentivePay) : base(id, name, basicPay, daPay, hraPay)
        {
            this.incentivePay = incentivePay;
        }

        public decimal IncentivePay
        {
            get { return this.incentivePay; }
            set { this.incentivePay = value; }
        }

        public decimal TotalPay
        {
            get { return this.totalPay; } //readOnly 
        }

        public override void CalculateSalary()
        {
            this.totalPay = base.basicPay + base.daPay + base.hraPay + this.incentivePay;
        }

    }
}
