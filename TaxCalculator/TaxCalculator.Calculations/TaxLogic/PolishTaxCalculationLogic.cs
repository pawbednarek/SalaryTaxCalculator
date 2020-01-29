using System;
using System.Collections.Generic;
using System.Text;
using TaxCalculator.Calculations.Rates;
using TaxCalculator.Calculations.Taxes;

namespace TaxCalculator.Calculations.TaxLogic
{
    // Tax calculation logic sources:
    // https://poradnik.ngo.pl/umowa-o-prace-obliczanie-wynagrodzenia-1538045119973
    public class PolishTaxCalculationLogic : ITaxCalculationLogic
    {
        public CalculatedTaxes CalculateTaxes(decimal grossSalary, TaxRates taxRates)
        {
            var calculatedTaxes = new CalculatedTaxes();
            calculatedTaxes.EmployeeTaxes = this.CalculateEmployeeTaxes(grossSalary, taxRates);
            calculatedTaxes.EmployerTaxes = this.CalculateEmployerTaxes(grossSalary, taxRates);

            return calculatedTaxes;
        }

        private EmployeeTaxes CalculateEmployeeTaxes(decimal grossSalary, TaxRates taxRates)
        {
            var employeeTaxes = new EmployeeTaxes();

            employeeTaxes.PensionInsurance = grossSalary * taxRates.EmployeeTaxes.PensionInsuranceRate;
            employeeTaxes.DisabilityInsurance = grossSalary * taxRates.EmployeeTaxes.DisabilityInsuranceRate;
            employeeTaxes.IllnesslInsurance = grossSalary * taxRates.EmployeeTaxes.IllnesslInsuranceRate;
            employeeTaxes.MedicalInsurance = grossSalary * taxRates.EmployeeTaxes.MedicalInsuranceRate;

            var baseSalary = grossSalary - (employeeTaxes.PensionInsurance + employeeTaxes.DisabilityInsurance + employeeTaxes.IllnesslInsurance);
            var costOfGettingIncome = 111.25M;
            var income = Math.Max(0, baseSalary - costOfGettingIncome);
            income = Math.Round(income);

            employeeTaxes.IncomeTaxAdvance = income * taxRates.EmployeeTaxes.IncomeTaxAdvanceRate;

            return employeeTaxes;
        }

        private EmployerTaxes CalculateEmployerTaxes(decimal grossSalary, TaxRates taxRates)
        {
            var employerTaxes = new EmployerTaxes();

            employerTaxes.PensionInsurance = grossSalary * taxRates.EmployerTaxes.PensionInsuranceRate;
            employerTaxes.DisabilityInsurance = grossSalary * taxRates.EmployerTaxes.DisabilityInsuranceRate;
            employerTaxes.AccidentInsurance = grossSalary * taxRates.EmployerTaxes.AccidentInsuranceRate;
            employerTaxes.LabourFund = grossSalary * taxRates.EmployerTaxes.LabourFundRate;
            employerTaxes.GuaranteedEmployeeBenefitsFund = grossSalary * taxRates.EmployerTaxes.GuaranteedEmployeeBenefitsFundRate;

            return employerTaxes;
        }
    }
}
