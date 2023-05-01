 

using System; 

 

namespace Study 

{ 

    class Program 

    { 

        static void Main(string[] args) 

        { 

            double[] arr = { 2.5, 1, 10, -2, 7.15, -11, 0, 18.64, 1.25, -3 }; 

            double minimum = arr[0]; 

            double sum = 0; 

            double product = 1; 

 

            for (int i = 0; i < arr.Length; ++i) 

            { 

                Console.Write($"{arr[i]} "); 

            } 

            Console.WriteLine(); 

 

            for (int i = 0; i < arr.Length; ++i) 

            { 

                if (arr[i] > 0) 

                { 

                    product *= arr[i]; 

                } 

            } 

            Console.WriteLine("The product of the posistive numbers of the array: " + product); 

 

            for (int i = 0; i < arr.Length; ++i) 

            { 

                if (minimum > arr[i]) 

                { 

                    minimum = arr[i]; 

                } 

            } 

 

            for (int i = 0; i < arr.Length; ++i) 

            { 

                if (arr[i] != minimum) 

                { 

                    sum += arr[i]; 

                } 

                else 

                { 

                    break; 

                } 

            } 

            Console.Write("The sum of the elements placed before the minimum element: " + sum); 

        } 

    } 

} 