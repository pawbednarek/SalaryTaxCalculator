using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator.Calculations.Taxes
{
    public class EmployerTaxes
    {
        public decimal PensionInsurance { get; set; }
        public decimal DisabilityInsurance { get; set; }
        public decimal AccidentInsurance { get; set; }
        public decimal LabourFund { get; set; }
        public decimal GuaranteedEmployeeBenefitsFund { get; set; }

        public decimal TotalTaxes
        {
            get
            {
                return this.PensionInsurance + this.DisabilityInsurance + this.AccidentInsurance + this.LabourFund + this.GuaranteedEmployeeBenefitsFund;
            }
        }
    }
}
