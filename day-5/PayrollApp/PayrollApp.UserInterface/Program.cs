using PayrollApp.Entities;

namespace PayrollApp.UserInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
            Developer[] devArray = prog.CreateDeveloperObject(); // calling the method to create object of Developer class

            Console.WriteLine("\n----| EMPLOYEE(S) DETAILS |----");
            foreach (Developer dev in devArray)
            {
                dev.CalculateSalary();
                Console.WriteLine($"ID : {dev.Id}");
                Console.WriteLine($"Name : {dev.Name}");
                Console.WriteLine($"DA Pay : {dev.DaPay}");
                Console.WriteLine($"HRA Pay : {dev.HraPay}");
                Console.WriteLine($"Incentive Pay : {dev.IncentivePay}");
                Console.WriteLine($"Total Pay : {dev.TotalPay}");
                Console.WriteLine("---------------------------\n");
            }
            
        }


        public Developer[] CreateDeveloperObject()
        {
            Console.WriteLine("How many Employees you want to Add :  ");
            int employeeNumber = int.Parse(Console.ReadLine());
            
            Developer[] devArray = new Developer[employeeNumber]; // array of Developer Class Object

            for (int i = 0; i < employeeNumber; i++)
            {
                Console.WriteLine($"----| Please Enter the EMPLOYEE Details for EMP-{i+1}: |----\n");

                Console.WriteLine("Enter ID : ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Name : ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter  Basic Pay : ");
                decimal basicPay = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter  DA Pay : ");
                decimal daPay = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter  HRA Pay : ");
                decimal hraPay = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter  Incentive Pay : ");
                decimal incentivePay = decimal.Parse(Console.ReadLine());

                Developer developer = new Developer(id: id, name: name, basicPay: basicPay, daPay: daPay, hraPay: hraPay, incentivePay: incentivePay);


                devArray[i] = developer;

            }

            return devArray;
        }
    }
}
