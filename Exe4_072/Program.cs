using System;

namespace ExerciseStackUsingLinkedList
{
    class Stack
    {
        private string[] dinda;
        private int top;
        private int max;
        public Stack(int size)
        {
            dinda = new string[29];
            top = -1;
            max = 29;
        }
        public void push(int item)
        {
            if (top === max - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                top++;
                Console.Write(("Pushed element is: "));
                dinda[top] = Console.ReadLine();
            }
        }
        public void pop()
        {
            Console.WriteLine("\nThe popped element is: " + dinda[top]);
            top = top - 1;
        }
    }
}