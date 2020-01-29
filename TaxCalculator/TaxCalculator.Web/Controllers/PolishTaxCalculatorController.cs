using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using TaxCalculator.Calculations;
using TaxCalculator.Calculations.Taxes;

namespace TaxCalculator.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PolishTaxCalculatorController : ControllerBase
    {
        private ITaxCalculator _polishTaxCalculator;

        public PolishTaxCalculatorController(ITaxCalculator polishTaxCalculator)
        {
            _polishTaxCalculator = polishTaxCalculator;
        }

        [HttpGet]
        public ActionResult<CalculatedTaxes> Calculate(decimal grossSalary)
        {
            try
            {
                return _polishTaxCalculator.Calculate(grossSalary);
            }
            catch (ArgumentException)
            {
                return BadRequest();
            }
            catch (InvalidOperationException)
            {
                return new StatusCodeResult(500);   //internal server error
            }
        }
    }
}
