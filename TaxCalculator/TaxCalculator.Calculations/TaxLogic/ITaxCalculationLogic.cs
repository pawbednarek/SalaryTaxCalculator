using System;
using System.Collections.Generic;
using System.Text;
using TaxCalculator.Calculations.Rates;
using TaxCalculator.Calculations.Taxes;

namespace TaxCalculator.Calculations.TaxLogic
{
    public interface ITaxCalculationLogic
    {
        public CalculatedTaxes CalculateTaxes(decimal grossSalary, TaxRates taxRates);
    }
}
