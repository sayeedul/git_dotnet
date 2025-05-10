namespace PayrollApp.Entities
{
    public class Developer
    {
        int id; // should be assigned ONLY through constructor
        string name;
        decimal basicPay;
        decimal daPay;
        decimal hraPay;
        decimal incentivePay;
        decimal totalPay;  // will be set by a method, will NOT be passed from outside the class

        public Developer() { }

        public Developer(int id, string name, decimal basicPay, decimal daPay, decimal hraPay,
            decimal incentivePay)
        {
            this.id = id;
            this.name = name;
            this.basicPay = basicPay;
            this.daPay = daPay;
            this.hraPay = hraPay;
            this.incentivePay = incentivePay;
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
        public decimal IncentivePay
        {
            get { return this.incentivePay; }
            set { this.incentivePay = value; }
        }
        public decimal TotalPay
        {
            get { return this.totalPay; } //readOnly 
        }

        public void CalculateSalary()
        {
            this.totalPay = this.basicPay + this.daPay + this.hraPay + this.incentivePay;
        }

    }
}
