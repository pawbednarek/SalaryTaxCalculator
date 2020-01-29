using NUnit.Framework;
using System;
using TaxCalculator.Calculations;

namespace TaxCalculator.Tests
{   [TestFixture]
    public class PolishTaxCalculatorTests
    {
        private ITaxCalculator polishTaxCalculator;

        [SetUp]
        public void Setup()
        {
            polishTaxCalculator = new PolishTaxCalculator();
        }

        [Test]
        public void TestWithNegativeSalary()
        {
            var ex = Assert.Throws<ArgumentException>(() => polishTaxCalculator.Calculate(-1500));
            Assert.AreEqual(ErrorMessages.salaryLessThanZeroErrorMessage, ex.Message);
        }

        [Test]
        public void TestWithZeroSalary()
        {
            var calculatedTaxes = polishTaxCalculator.Calculate(0);

            Assert.IsNotNull(calculatedTaxes);
            Assert.IsNotNull(calculatedTaxes.EmployeeTaxes);
            Assert.IsNotNull(calculatedTaxes.EmployerTaxes);

            Assert.AreEqual(calculatedTaxes.EmployeeTaxes.PensionInsurance, 0);
            Assert.AreEqual(calculatedTaxes.EmployeeTaxes.DisabilityInsurance, 0);
            Assert.AreEqual(calculatedTaxes.EmployeeTaxes.IllnesslInsurance, 0);
            Assert.AreEqual(calculatedTaxes.EmployeeTaxes.MedicalInsurance, 0);
            Assert.AreEqual(calculatedTaxes.EmployeeTaxes.IncomeTaxAdvance, 0);
            Assert.AreEqual(calculatedTaxes.EmployeeTaxes.TotalTaxes, 0);

            Assert.AreEqual(calculatedTaxes.EmployerTaxes.PensionInsurance, 0);
            Assert.AreEqual(calculatedTaxes.EmployerTaxes.DisabilityInsurance, 0);
            Assert.AreEqual(calculatedTaxes.EmployerTaxes.AccidentInsurance, 0);
            Assert.AreEqual(calculatedTaxes.EmployerTaxes.LabourFund, 0);
            Assert.AreEqual(calculatedTaxes.EmployerTaxes.GuaranteedEmployeeBenefitsFund, 0);
            Assert.AreEqual(calculatedTaxes.EmployerTaxes.TotalTaxes, 0);
        }

        [Test]
        public void TestWithPositiveSalary()
        {
            var calculatedTaxes = polishTaxCalculator.Calculate(1500);

            Assert.IsNotNull(calculatedTaxes);
            Assert.IsNotNull(calculatedTaxes.EmployeeTaxes);
            Assert.IsNotNull(calculatedTaxes.EmployerTaxes);

            Assert.AreEqual(calculatedTaxes.EmployeeTaxes.PensionInsurance, 146.4M);
            Assert.AreEqual(calculatedTaxes.EmployeeTaxes.DisabilityInsurance, 22.5M);
            Assert.AreEqual(calculatedTaxes.EmployeeTaxes.IllnesslInsurance, 36.75M);
            Assert.AreEqual(calculatedTaxes.EmployeeTaxes.MedicalInsurance, 135M);
            Assert.AreEqual(calculatedTaxes.EmployeeTaxes.IncomeTaxAdvance, 212.94M);
            Assert.AreEqual(calculatedTaxes.EmployeeTaxes.TotalTaxes, 553.59M);

            Assert.AreEqual(calculatedTaxes.EmployerTaxes.PensionInsurance, 146.4M);
            Assert.AreEqual(calculatedTaxes.EmployerTaxes.DisabilityInsurance, 97.5M);
            Assert.AreEqual(calculatedTaxes.EmployerTaxes.AccidentInsurance, 25.05M);
            Assert.AreEqual(calculatedTaxes.EmployerTaxes.LabourFund, 34.5M);
            Assert.AreEqual(calculatedTaxes.EmployerTaxes.GuaranteedEmployeeBenefitsFund, 1.5M);
            Assert.AreEqual(calculatedTaxes.EmployerTaxes.TotalTaxes, 304.95M);
        }
    }
}