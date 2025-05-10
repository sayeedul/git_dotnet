///* Array in C# is a class.
// array is collection of homogenous elements (similar type)

// 1. Single Dimentional Array : 
//   <data-type>[] <arr-ref-var-name> = new <data-type>[<size>];

//2. multi- Dimentional Array : 
//   <data-type>[,] <arr-ref-var-name> = new <data-type>[<row-count>][element-count-per-row];

//*/

////int[] numbers = new int[10];

////for (int i = 0; i < numbers.Length; i++)
////{
////    //Console.WriteLine($"numbers[{i}] : {numbers[i]}"); 
////    // 0 is by default in the values for all elements.
////    Console.WriteLine($"Enter value at numbers[{i}] : ");

////    numbers[i] = int.Parse(Console.ReadLine());
////}
////Console.WriteLine("\n\n");
////int index = 0;
////// Read only loop
////// duting iteration using foreach loop the data structire should not be modified (no new item should be added or deleted.) but can be only UPDATED.
////foreach (int item in numbers)
////{
////    Console.WriteLine($"Value at numbers[{index}] : {item}");
////    index++;
////}

////Array.Sort(numbers);
////Console.WriteLine($"numbers : {numbers}"); // print addrss type 

////Array.Reverse(numbers);

//// 2-D array 

//int[,] twoDimArray = new int[3, 2];

//// total length : twoDimArray.Length = 6
//Console.WriteLine(twoDimArray.GetLength(0));
//Console.WriteLine(twoDimArray.GetLength(1));

//for (int row = 0; row < twoDimArray.GetLength(0); row++)
//{
//    for (int column = 0; column < twoDimArray.GetLength(1); column++)
//    {
//        Console.WriteLine($"Enter value at numbers[{row}{column}] : ");

//        twoDimArray[row,column] = int.Parse(Console.ReadLine());
//    }
//}



string[] names = new string[] { "Sayeed", "rahman" };
string[] names1 = { "Sayeed", "rahman" };
string[] names2 = ["Sayeed", "rahman"];

Console.WriteLine(names[0]);
Console.WriteLine(names1[1]);
Console.WriteLine(names2[0]);
//Console.ReadKey();

// JAGGED ARRAY -----------------------------------

int[] first = new int[] { 1, 2, 3, 4 };
int[] second = new int[] { 10,11 };
int[] third = new int[] { 1, 2, 3, 4 ,5, 6};

int[][] jaggedArray = new int[][] { first, second, third };

for (int i = 0; i < jaggedArray.Length; i++)
{
    int[] Arr = jaggedArray[i];
	for (int j = 0; j < Arr.Length; j++)
	{
        Console.WriteLine($"Arr{i}[j] : {Arr[j]}");
	}
}

// OR 

Console.WriteLine("\n\n");

for (int i = 0; i < jaggedArray.Length; i++)
{
    for (int j = 0; j < jaggedArray.Length; j++)
    {
        Console.WriteLine($"Arr[i][j] : {jaggedArray[i][j]}");
    }
}