using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator.Calculations.Rates
{
    public class EmployerTaxRates
    {
        public decimal PensionInsuranceRate { get; set; }
        public decimal DisabilityInsuranceRate { get; set; }
        public decimal AccidentInsuranceRate { get; set; }
        public decimal LabourFundRate { get; set; }
        public decimal GuaranteedEmployeeBenefitsFundRate { get; set; }
    }
}
