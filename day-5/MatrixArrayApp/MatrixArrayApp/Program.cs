namespace MatrixArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();

            int n = 0;
            do
            { x:
                Console.WriteLine("Enter Size of the 'n' for n*n Odd matrix : ");
                n = int.Parse(Console.ReadLine());

                if (prog.CheckIfSizeIsOdd(n) == false)
                {
                    Console.WriteLine("Please Enter Odd value for size 'n' : ");
                    goto x;
                }
                else
                    break;
            }
            while (true);
          

            int[,] twoDimArray = new int[n, n];

            prog.TakeInput2DArray(ref twoDimArray, n);

            int[] OneDimArray = new int[n * n];
            int index = 0;
            for (int row = 0; row < n; row++)
            {
                for (int column = 0; column < n; column++)
                {
                    OneDimArray[index++] = twoDimArray[row, column]; 
                }
            }

            Array.Sort(OneDimArray);
            int[] newArr =  prog.ArrangeElementsOfArray(OneDimArray, n);

            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine($"arr[{i}] : {newArr[i]}");
            }


        }


        int[] ArrangeElementsOfArray(int[] sortedArray, int n)
        {
           
            int[] arr = new int[n * n];
            int mid = n * n / 2;
            arr[mid] = sortedArray[0];
            int left = mid - 1;
            int right = mid + 1;
            for (int i = 1; i < n * n; i=i+2)
            {
                //if (i % 2 != 0)
                //{
                //    arr[left] = sortedArray[i];
                //    left--;
                //}
                //else
                //{
                //    arr[right] = sortedArray[i];
                //    right++;
                //}

                arr[left--] = sortedArray[i];
                arr[right++] = sortedArray[i+1];
            }
            return arr;
        }

        public Boolean CheckIfSizeIsOdd(int n)
        {
            if (n % 2 != 0)
                 return true; 
            else
                return false;
        }

        public void TakeInput2DArray(ref int[,] twoDimArray, int n)
        {
            for (int row = 0; row < n; row++)
            {
                for (int column = 0; column < n; column++)
                {
                    Console.WriteLine($"Enter value at numbers[{row}{column}] : ");

                    twoDimArray[row, column] = int.Parse(Console.ReadLine());
                }
            }

            //return twoDimArray;
        }




    }
}
