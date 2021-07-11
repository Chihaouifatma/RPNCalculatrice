using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalTestRPN.Operations
{
    public abstract class operateur
    {
        public abstract void Calculer(Stack<decimal> stack);
        public abstract bool VerifInput(string input);

    }
}
