using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalTestRPN.Operations
{
    public class Division : OperationBinaire
    {
        public override bool VerifInput(string input)
        {
            return (input == "/");
        }
        public override decimal Calculer(decimal left, decimal right)
        {
            if (right == 0)
            {
                throw new InvalidOperationException("ne peut pas diviser /0");
            }
            return left / right; return left / right;
        }
    }
}
