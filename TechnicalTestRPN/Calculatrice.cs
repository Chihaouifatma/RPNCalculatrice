using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalTestRPN.Operations;

namespace TechnicalTestRPN
{
    public class Calculatrice
    {
        public Stack<decimal> stack;
        public static List<operateur> operateurs;


        static Calculatrice()
        {
            operateurs = new List<operateur>();

            operateurs.Add(new Addition());
            operateurs.Add(new Soustraction());
            operateurs.Add(new Division());
            operateurs.Add(new Multiplication());
        }
        public Calculatrice()
        {
            this.stack = new Stack<decimal>();
        }
        public List<operateur> GetOperateurs()
        {
            return operateurs;
        }

        public Stack<decimal> GetStack()
        {
            return stack;
        }

        public string Create(string valeur)
        {
            foreach (operateur op in operateurs)
            {
                if (op.VerifInput(valeur))
                {
                    op.Calculer(stack);
                    return stack.Peek().ToString();
                }
            }
            decimal numericInput;
            if (decimal.TryParse(valeur, out numericInput))
            {
                stack.Push(numericInput);
                return valeur;
            }

            throw new InvalidOperationException( "valeur invalide" + valeur );

        }
    }
}
