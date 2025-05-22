using NUnit.Framework;
using MyApp;  // Простір імен основного проєкту

namespace MyApp.Tests
{
    public class Tests
    {
        [Test]
        public void TestAddition()
        {
            var result = Calculator.Add(2, 3);
            Assert.AreEqual(5, result);
        }
    }
}