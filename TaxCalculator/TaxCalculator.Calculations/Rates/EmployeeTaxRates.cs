using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator.Calculations.Rates
{
    public class EmployeeTaxRates
    {
        public decimal PensionInsuranceRate { get; set; }
        public decimal DisabilityInsuranceRate { get; set; }
        public decimal IllnesslInsuranceRate { get; set; }
        public decimal MedicalInsuranceRate { get; set; }
        public decimal IncomeTaxAdvanceRate { get; set; }
    }
}
