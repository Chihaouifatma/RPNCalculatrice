using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechnicalTestRPN.Operations;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechnicalTestRPN
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : Controller
    {
      Calculatrice calculatrice = new Calculatrice();

        // list all operand
        [HttpGet]
        [Route("rpn/op")]
        public ActionResult<List<operateur>> Get()
        {
            return calculatrice.GetOperateurs();
        }

        // create new stack
        [HttpPost]
        public Stack<decimal> Post(string valeur)
        {
            if (valeur != null)
            {
             
                string cleanvalue = valeur.Trim().ToLower();
                calculatrice.Create(valeur);
                   
            }
            return calculatrice.GetStack();
         }


    }
}
