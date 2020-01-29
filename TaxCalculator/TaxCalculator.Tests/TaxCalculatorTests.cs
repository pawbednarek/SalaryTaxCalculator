using NUnit.Framework;
using System;
using TaxCalculator.Calculations;
using TaxCalculator.Calculations.Rates;
using TaxCalculator.Calculations.TaxLogic;
using txCalc = TaxCalculator.Calculations;

namespace TaxCalculator.Tests
{
    [TestFixture]
    public class TaxCalculatorTests
    {
        private ITaxCalculator taxCalculator;

        [SetUp]
        public void Setup()
        {
            taxCalculator = new txCalc.TaxCalculator();
        }

        [Test]
        public void TestWithTaxRatesNotSet()
        {
            var ex = Assert.Throws<InvalidOperationException>(() => taxCalculator.Calculate(1000));
            Assert.AreEqual(ErrorMessages.taxRatesNotSetErrorMessage, ex.Message);
        }

        [Test]
        public void TestWithTaxCalculationLogicNotSet()
        {
            taxCalculator.TaxRates = TaxRatesFactory.GetPolishTaxRates();

            var ex = Assert.Throws<InvalidOperationException>(() => taxCalculator.Calculate(1000));
            Assert.AreEqual(ErrorMessages.taxCalculationLogisNotSetErrorMessage, ex.Message);
        }

        [Test]
        public void TestWithCorrectSetup_EnsureExceptionIsNotThrown()
        {
            taxCalculator.TaxRates = TaxRatesFactory.GetPolishTaxRates();
            taxCalculator.TaxCalculationLogic = new PolishTaxCalculationLogic();

            Assert.DoesNotThrow(() => taxCalculator.Calculate(1000));
        }

        [Test]
        public void TestWithCorrectSetup_EnsureResultIsReturned()
        {
            taxCalculator.TaxRates = TaxRatesFactory.GetPolishTaxRates();
            taxCalculator.TaxCalculationLogic = new PolishTaxCalculationLogic();

            Assert.IsNotNull(taxCalculator.Calculate(1000));
        }
    }
}
