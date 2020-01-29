using System;
using System.Collections.Generic;
using System.Text;
using TaxCalculator.Calculations.Rates;
using TaxCalculator.Calculations.Taxes;
using TaxCalculator.Calculations.TaxLogic;

namespace TaxCalculator.Calculations
{
    public interface ITaxCalculator
    {
        public TaxRates TaxRates { get; set; }
        public ITaxCalculationLogic TaxCalculationLogic { get; set; }

        public CalculatedTaxes Calculate(decimal grossSalary);
    }
}
