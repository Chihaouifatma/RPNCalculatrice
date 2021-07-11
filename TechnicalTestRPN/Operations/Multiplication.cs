using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalTestRPN.Operations
{
    public class Multiplication : OperationBinaire
    {
        public override bool VerifInput(string input)
        {
            return (input == "*");
        }
        public override decimal Calculer(decimal left, decimal right)
        {
            return left * right;
        }
    }
}
