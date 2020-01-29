using System;
using System.Collections.Generic;
using System.Text;
using TaxCalculator.Calculations.Rates;
using TaxCalculator.Calculations.Taxes;
using TaxCalculator.Calculations.TaxLogic;

namespace TaxCalculator.Calculations
{
    public class PolishTaxCalculator : TaxCalculator, ITaxCalculator
    {
        public PolishTaxCalculator()
        {
            this.TaxRates = TaxRatesFactory.GetPolishTaxRates();
            this.TaxCalculationLogic = new PolishTaxCalculationLogic();
        }
    }
}
