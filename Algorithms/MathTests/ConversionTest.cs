using Microsoft.VisualStudio.TestTools.UnitTesting;
using Math;


namespace MathTests
{
    [TestClass]
    public class ConversionTest
    {
        private readonly Conversion conversion = new Conversion();

        [TestMethod]
        public void DecimalToBinary_Test_Method()
        {
            string binary;

            binary = conversion.DecimalToBinary(20);
            Assert.AreEqual("10100", binary);
        }
    }
}
