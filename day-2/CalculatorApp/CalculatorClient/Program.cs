using CalculatorLibrary;

Calculator calc = new Calculator();

System.Console.WriteLine("------------| WELCOME TO CALCULATOR APP |--------------");

int yes_no = 2;
do
{
    System.Console.WriteLine("Please Select Below Choice : ");
    System.Console.WriteLine("1.ADD");
    System.Console.WriteLine("2.SUBTRACT");
    System.Console.WriteLine("3.MULTIPLY");
    System.Console.WriteLine("4.DIVIDE");

    string input = Console.ReadLine();
    int value = int.Parse(input);

    System.Console.WriteLine("Please Enter 2 Numbers : ");

    System.Console.Write("First Number : ");
    string input1 = Console.ReadLine();
    int num1 = int.Parse(input1);

    System.Console.Write("Second Number : ");
    string input2 = Console.ReadLine();
    int num2 = int.Parse(input2);


    switch (value)
    {
        case 1:
            Console.WriteLine($"Addition of the numbers : {num1} and {num2} is {calc.Add(num1, num2)}");
            break;

        case 2:
            Console.WriteLine($"Subtraction of the numbers : {num1} and {num2} is {calc.Subtract(num1, num2)}");
            break;

        case 3:
            Console.WriteLine($"Subtraction of the numbers : {num1} and {num2} is {calc.Multiply(num1, num2)}");
            break;

        case 4:
            Console.WriteLine($"Subtraction of the numbers : {num1} and {num2} is {calc.Divide(num1, num2)}");
            break;

        default:
            Console.WriteLine("WRONG CHOICE SELECTED. PLEASE SELECT CORRECT OPTION !!!");
            break;
    }

    Console.WriteLine("Do you Want to CONTINUE : 1.Yes | 2.No ");
    yes_no = int.Parse(Console.ReadLine());

    //if( yes_no == 2)
    // { break; }

}
while (yes_no==1);
