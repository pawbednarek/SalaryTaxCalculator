using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator.Calculations.Rates
{
    public class TaxRatesFactory
    {
        // Tax rates sources:
        // https://poradnikprzedsiebiorcy.pl/-skladki-zus-za-pracownikow-stopy-procentowe-i-zrodla-ich-finansowania
        // https://www.zus.pl/firmy/rozliczenia-z-zus/skladki-na-ubezpieczenia/fp-sfwon-i-fgsp
        public static TaxRates GetPolishTaxRates()
        {
            var polishTaxRates = new TaxRates();
            
            var polishEmployeeTaxRates = new EmployeeTaxRates();
            polishEmployeeTaxRates.PensionInsuranceRate = 0.0976M;
            polishEmployeeTaxRates.DisabilityInsuranceRate = 0.015M;
            polishEmployeeTaxRates.IllnesslInsuranceRate = 0.0245M;
            polishEmployeeTaxRates.MedicalInsuranceRate = 0.09M;
            polishEmployeeTaxRates.IncomeTaxAdvanceRate = 0.18M;


            var polishEmployerTaxRates = new EmployerTaxRates();
            polishEmployerTaxRates.PensionInsuranceRate = 0.0976M;
            polishEmployerTaxRates.DisabilityInsuranceRate = 0.0650M;
            polishEmployerTaxRates.AccidentInsuranceRate = 0.0167M;
            polishEmployerTaxRates.LabourFundRate = 0.023M;
            polishEmployerTaxRates.GuaranteedEmployeeBenefitsFundRate = 0.001M;

            polishTaxRates.EmployeeTaxes = polishEmployeeTaxRates;
            polishTaxRates.EmployerTaxes = polishEmployerTaxRates;

            return polishTaxRates;
        }
    }
}
