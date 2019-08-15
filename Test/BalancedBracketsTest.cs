using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace Test
{
    [TestClass]
    public class BalancedBracketsTest
    {
        [TestMethod]
        public void ShouldValidateString1()
        {
            string brackets = "(){}[]";

            bool result = BalancedBrackets.IsBalancedBrackets(brackets);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldValidateString2()
        {
            string brackets = "[{()}](){}";

            bool result = BalancedBrackets.IsBalancedBrackets(brackets);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldNotValidateString1()
        {
            string brackets = "[]{()";

            bool result = BalancedBrackets.IsBalancedBrackets(brackets);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ShouldNotValidateString2()
        {
            string brackets = "[]{(})[{)]";

            bool result = BalancedBrackets.IsBalancedBrackets(brackets);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ShouldNotValidateStringEmpty()
        {
            string brackets = "";

            bool result = BalancedBrackets.IsBalancedBrackets(brackets);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ShouldNotValidateNotBrackets()
        {
            string brackets = "ABC123";

            bool result = BalancedBrackets.IsBalancedBrackets(brackets);

            Assert.IsFalse(result);
        }
    }
}
