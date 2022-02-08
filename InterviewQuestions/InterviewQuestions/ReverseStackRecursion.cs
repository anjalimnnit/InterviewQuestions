using System;
using System.Collections.Generic;

namespace InterviewQuestions
{
    public class ReverseStackRecursion
    {
        Stack<int> numbers = new();
        public void ReverseStack()
        {
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            numbers.Push(4);
            numbers.Push(5);
            Console.WriteLine("Values in stack are");
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
            Reverse(numbers);
            Console.WriteLine("Values in stack after reversing are");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        public void InsertBottom(int x, Stack<int> numbers)
        {
            if(numbers.Count == 0)
            {
                numbers.Push(x);
                return;
            }
            int temp = numbers.Peek();
            numbers.Pop();
            InsertBottom(x, numbers);
            numbers.Push(temp);
        }

        public void Reverse(Stack<int> numbers)
        {
            if (numbers.Count == 0)
                return;
            int temp = numbers.Peek();
            numbers.Pop();
            Reverse(numbers);
            InsertBottom(temp, numbers);
        }
        
    }
}
