using NUnit.Framework;
using TaxCalculator.Calculations;

namespace TaxCalculator.Tests
{
    [TestFixture]
    public class SalaryValidatorTests
    {
        [Test]
        public void TestWithNegativeSalary()
        {
            var errorMessage = string.Empty;
            bool result = SalaryValidator.Validate(-1000, out errorMessage);

            Assert.IsFalse(result);
            Assert.IsNotNull(errorMessage);
            Assert.IsNotEmpty(errorMessage);
        }

        [Test]
        public void TestWithZeroSalary()
        {
            var errorMessage = string.Empty;
            bool result = SalaryValidator.Validate(0, out errorMessage);

            Assert.IsTrue(result);
            Assert.IsEmpty(errorMessage);
        }

        [Test]
        public void TestWithPositiveSalary()
        {
            var errorMessage = string.Empty;
            bool result = SalaryValidator.Validate(2000, out errorMessage);

            Assert.IsTrue(result);
            Assert.IsEmpty(errorMessage);
        }
    }
}
