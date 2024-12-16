using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 10, 20, 30, 40, 50 };

            // Create a stack of integers & Push elements ont the stack
            Stack<int> myStack = new Stack<int>(myArray);

            // Display the intial stack
            Console.WriteLine("Intial Stack:");
            foreach (int number in myArray)
            {
                Console.WriteLine(number);
            }

            // Perform stack operations
            myStack.Push(60); // Pushing numbers on the stack
            Console.WriteLine("After the last push \n");
            foreach (int number in myStack)
            {
                Console.WriteLine(number); 
            }

            int popped = myStack.Pop(); //Pops the top number
            Console.WriteLine($"\nPopped {popped}"); 

            int peeked = myStack.Peek();  // Peek at the top number
            Console.WriteLine($"\n Peeked at {peeked}");
        }

        public int[] ProductExceptSelf(int[] nums)
        {

            int[] result = new int[nums.Length];



            // Calculate left products

            result[0] = 1;

            for (int i = 1; i < nums.Length; i++)
            {

                result[i] = result[i - 1] * nums[i - 1];

            }



            // Calculate right products and update result

            int rightProduct = 1;

            for (int i = nums.Length - 1; i >= 0; i--)
            {

                result[i] *= rightProduct;

                rightProduct *= nums[i];

            }



            return result;

        }




    }
}
