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
    }
}