using NUnit.Framework;
using CabInvoiceGenerators;

namespace CabInvoiceGeneratorTesting
{
    public class Tests
    {
        public CabInvoiceGenerator cabInvoiceGenerator;
        [SetUp]
        public void Setup()
        {        
            cabInvoiceGenerator = new CabInvoiceGenerator();
        }
        [Test]
        public void Test1()
        {
            double fair = cabInvoiceGenerator.CalculateFair(2, 5);
            Assert.AreEqual(25, fair);
        }
        [Test]
        public void CheckMinimumFairAsFive()
        {
            double fair = cabInvoiceGenerator.CalculateFair(0, 0);
            Assert.AreEqual(5, fair);
        }
        [Test]
        public void CalAggFairAndMultipleRide()
        {
            cabInvoiceGenerator.AddRide(2, 5);
            cabInvoiceGenerator.AddRide(12, 15);
            double fair = cabInvoiceGenerator.CalculateAggregate();
            Assert.AreEqual(160, fair);
        }       
    }
}