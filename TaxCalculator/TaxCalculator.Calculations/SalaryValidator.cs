using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator.Calculations
{
    public class SalaryValidator
    {
        public static bool Validate(decimal grossSalary, out string errorMessage)
        {
            if (grossSalary < 0)
            {
                errorMessage = ErrorMessages.salaryLessThanZeroErrorMessage;
                return false;
            }

            errorMessage = String.Empty;
            return true;
        }
    }
}
