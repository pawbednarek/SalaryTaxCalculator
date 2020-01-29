using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator.Calculations.Taxes
{
    public class EmployeeTaxes
    {
        public decimal PensionInsurance { get; set; }
        public decimal DisabilityInsurance { get; set; } 
        public decimal IllnesslInsurance { get; set; }
        public decimal MedicalInsurance { get; set; }
        public decimal IncomeTaxAdvance { get; set; }

        public decimal TotalTaxes
        {
            get
            {
                return this.PensionInsurance + this.DisabilityInsurance + this.IllnesslInsurance + this.MedicalInsurance + this.IncomeTaxAdvance;
            }
        }
    }
}
