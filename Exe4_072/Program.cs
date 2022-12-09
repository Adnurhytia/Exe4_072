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
        bool empty()
        {
            if (top == -1)
                return true;
            else
                return false;
        }
        public void display()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return ;

            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine(dinda[i]);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack(29);
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n***Stack Menu***\n");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.Write("\nEnter your choice: ");
                string sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == "" ? "0" : sInput);
                switch (ch)
                {
                    case '1':
                        s.push(29);
                        break;
                    case '2':
                        s.pop();
                        break;
                    case '3':
                        s.display();
                        break;
                    case '4':
                        return ;
                    default:
                        Console.WriteLine("\nInvalid Choice");
                        break;
                }
            }
        }
    }
}