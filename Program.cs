// Implement a stack by using array with push and pop operations
using System.Collections.Generic;

namespace StackAssignment
{
   internal class StackArray
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(27);
            stack.Push(37);
            stack.Push(67);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            stack.Pop();
            Console.WriteLine("after the pop: ");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"after peek: {stack.Peek()}");
            Console.ReadKey();
        }
    }
}
