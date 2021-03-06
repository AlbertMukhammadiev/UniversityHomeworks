﻿using System;

namespace ParseTreeNamespace
{
    /// <summary>
    /// a node that is a difference of the left son(minuend) and right son(subtrahend)
    /// </summary>
    public class Subtraction : Operator
    {
        /// <summary>
        /// returns the difference of the left child(minuend) and right child(subtrahend)
        /// </summary>
        /// <returns></returns>
        public override int Calculate()
        {
            return this.Left.Calculate() - this.Right.Calculate();
        }

        /// <summary>
        /// prints the subtraction of the left child(minuend) and right child(subtrahend) in infix form
        /// </summary>
        public override void PrintNode()
        {
            Console.Write("( ");
            this.Left.PrintNode();
            Console.Write(" - ");
            this.Right.PrintNode();
            Console.Write(" )");
        }
    }
}
