﻿using MyException;
using System;

namespace StackNamespace
{
    public class Stack : IStack
    {
        private StackElement head;
        private class StackElement
        {
            /// <summary>
            /// class constructor
            /// </summary>
            /// <param name="value"></param>
            public StackElement(int value)
            {
                this.Value = value;
            }

            public int Value { get; set; }
            public StackElement Next { get; set; }
        }

        public void Push(int value)
        {
            StackElement newElement = new StackElement(value);
            if (this.head == null)
            {
                this.head = newElement;
                return;
            }

            newElement.Next = this.head;
            this.head = newElement;
        }

        public int GetValue()
        {
            if (this.head == null)
            {
                throw new EmptyStackException("you are trying to access a non-existent object");
            }

            return this.head.Value;
        }

        public void Pop()
        {
            if (this.head == null)
            {
                throw new EmptyStackException("you are trying to access a non-existent object");
            }

            this.head = this.head.Next;
        }

        public bool IsEmpty()
        {
            return this.head == null;
        }

        public void PrintStack()
        {
            if (this.head == null)
            {
                throw new EmptyStackException("Stack is empty");
            }

            StackElement i = this.head;
            while (i != null)
            {
                Console.WriteLine(i.Value + " ");
                i = i.Next;
            }
        }
    }
}