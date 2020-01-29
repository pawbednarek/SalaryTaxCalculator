using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator.Calculations
{
    public class ErrorMessages
    {
        public static readonly string taxRatesNotSetErrorMessage = "Tax rates are not set.";
        public static readonly string taxCalculationLogisNotSetErrorMessage = "Tax calculation logic is not defined.";
        public static readonly string salaryLessThanZeroErrorMessage = "Gross salary is less than zero.";
    }
}
