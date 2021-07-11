using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalTestRPN.Operations
{
    public abstract class OperationBinaire : operateur
    {
        public abstract decimal Calculer(decimal left, decimal right);
        public sealed override void Calculer(Stack<decimal> stack)
        {
            if (stack.Count < 2)
            {
                throw new InvalidOperationException("A binary operator requires at least 2 numbers in the stack");
            }

            decimal right = stack.Pop();
            decimal left = stack.Pop();

            decimal result = Calculer(left, right);

            stack.Push(result);
        }
    }
}
