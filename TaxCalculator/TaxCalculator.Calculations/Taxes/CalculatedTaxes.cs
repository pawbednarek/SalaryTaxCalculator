using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator.Calculations.Taxes
{
    public class CalculatedTaxes
    {
        public EmployeeTaxes EmployeeTaxes { get; set; }
        public EmployerTaxes EmployerTaxes { get; set; }

        public CalculatedTaxes()
        {
            this.EmployeeTaxes = new EmployeeTaxes();
            this.EmployerTaxes = new EmployerTaxes();
        }
    }
}
