using System;
using TaxCalculator.Calculations.Rates;
using TaxCalculator.Calculations.Taxes;
using TaxCalculator.Calculations.TaxLogic;

namespace TaxCalculator.Calculations
{
    public class TaxCalculator : ITaxCalculator
    {
        public TaxRates TaxRates { get; set; }
        public ITaxCalculationLogic TaxCalculationLogic { get; set; }
        
        public TaxCalculator() { }
        public TaxCalculator(TaxRates taxRates, ITaxCalculationLogic taxCalculationLogic)
        {
            this.TaxRates = taxRates;
            this.TaxCalculationLogic = taxCalculationLogic;
        }

        public CalculatedTaxes Calculate(decimal grossSalary)
        {
            if (this.TaxRates == null)
            {
                throw new InvalidOperationException(ErrorMessages.taxRatesNotSetErrorMessage);
            }

            if (this.TaxCalculationLogic == null)
            {
                throw new InvalidOperationException(ErrorMessages.taxCalculationLogisNotSetErrorMessage);
            }

            var errorMessage = String.Empty;
            if (!SalaryValidator.Validate(grossSalary, out errorMessage))
            {
                throw new ArgumentException(errorMessage);
            }

            return this.TaxCalculationLogic.CalculateTaxes(grossSalary, this.TaxRates); ;
        }
    }
}
