using PayrollApp.Entities;

namespace PayrollApp.UserInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();

            Console.WriteLine("How many Employees you want to Add :  ");
            int employeeNumber = int.Parse(Console.ReadLine());

            Developer[] devArray = new Developer[employeeNumber]; // array of Developer Class Objects
            Hr[] hrArray = new Hr[employeeNumber]; //array of Hr class objects

            //Employee[] empArray = new Employee[employeeNumber];  // array of Employee class object

            for (int i = 0; i < employeeNumber; i++)
            {
                Console.WriteLine("PLease select below to create an object of 1.Developer 2.HR : ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    devArray[i] = (Developer)prog.CreateEmpObject(choice,i);
                }

                else
                {
                    hrArray[i] = (Hr)prog.CreateEmpObject(choice,i);
                }
            }


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
            
            foreach (Hr hr in hrArray)
            {
                hr.CalculateSalary();
                Console.WriteLine($"ID : {hr.Id}");
                Console.WriteLine($"Name : {hr.Name}");
                Console.WriteLine($"DA Pay : {hr.DaPay}");
                Console.WriteLine($"HRA Pay : {hr.HraPay}");
                Console.WriteLine($"Incentive Pay : {hr.GratuityPay}");
                Console.WriteLine($"Total Pay : {hr.TotalPay}");
                Console.WriteLine("---------------------------\n");
            }
            

        }

        public Employee CreateEmpObject(int isHrOrDev, int index)
        {

            Console.WriteLine($"----| Please Enter the Details for EMP Number - {index}: |----\n");

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

            if (isHrOrDev == 1) // developer
            {
                Console.WriteLine("Enter  Incentive Pay : ");
                decimal incentivePay = decimal.Parse(Console.ReadLine());

                Developer developer = new Developer(id: id, name: name, basicPay: basicPay, daPay: daPay, hraPay: hraPay, incentivePay: incentivePay);

                return (Employee)developer;
            }
            else if (isHrOrDev == 2)
            {
                Console.WriteLine("Enter  Gratuity Pay : ");
                decimal gratuityPay = decimal.Parse(Console.ReadLine());

                Hr hr = new Hr(id: id, name: name, basicPay: basicPay, daPay: daPay, hraPay: hraPay, gratuityPay: gratuityPay);

                return (Employee)hr;
            }

            return null;

                
        }


        public Developer CreateDeveloperObject()
        {

            Console.WriteLine("----| Please Enter the Developer Details for EMP: |----\n");

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

            return developer;
        }


        public Hr CreateHrObject()
        {

            Console.WriteLine("----| Please Enter the HR Employee Details -: |----\n");

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

            Console.WriteLine("Enter  Gratuity Pay : ");
            decimal gratuityPay = decimal.Parse(Console.ReadLine());

            Hr hr = new Hr(id: id, name: name, basicPay: basicPay, daPay: daPay, hraPay: hraPay, gratuityPay: gratuityPay);

            return hr;
        }

    }

}
