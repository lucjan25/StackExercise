using System;
using System.Collections.Generic;

namespace StackExerciseBiblioteka
{
    public interface StackExcercise
    {
        public String pop();
        public void push(String item);
        public String top();
        public bool isEmpty();
    }
    public class StackClass : StackExcercise
    {
        private Stack<String> stack = new Stack<String>();
        public string pop()
        {
            if (this.isEmpty() == false)
                return stack.Pop();
            else
                throw new StackEmptyException();
        }

        public void push(string item)
        {
            stack.Push(item);
        }

        public string top()
        {
            if (this.isEmpty() == false)
                return stack.Peek();
            else
                throw new StackEmptyException();
        }
        public bool isEmpty()
        {
            bool empty = true;
            if (stack.Count != 0)
                empty = false;
            return empty;
        }
    }
    public class StackEmptyException : Exception
    {
        public StackEmptyException() : base("Stack is empty.")
        { }
    }
}
