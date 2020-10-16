using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

       /* [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }*/

        [TestMethod] // #1 - Only [] should return true
        public void TestCase1()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod] // #2 - 1 Balanced brackets around a word should return true
        public void TestCase2()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
        }

        [TestMethod] // #3- Multiple Balanced brackets around a word should return true
        public void TestCase3()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[LaunchCode]]"));
        }
        
        [TestMethod] //#4 - ]LaunchCode[ should return false 
        public void TestCase4()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]LaunchCode["));
        }

        [TestMethod] //#5 - Left Bracket alone with a word should return false 
        public void TestCase5()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]LaunchCode"));
        }

        [TestMethod] //#6 - Right Bracket alone with a word should return false 
        public void TestCase6()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode"));
        }

        [TestMethod] //#7 - Balanced Brackets + Left bracket around a  word should return false 
        public void TestCase7()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode]["));
        }

        [TestMethod] //#8 - No brackets - should return true
        public void TestCase8()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("LaunchCode"));
        }

        [TestMethod] //#9 - Balanced Brackets at the beginning of a word should return true 
        public void TestCase9()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
        }

        [TestMethod] //#10 - Only ][ should return false 
        public void TestCase10()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod] //#11 - Empty String "" should return true 
        public void TestCase11()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        [TestMethod] //#12 - Launch]Code[ should return false 
        public void TestCase12()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code["));
        }

        [TestMethod] //#13 - [Launch]Code should return true 
        public void TestCase13()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[Launch]Code"));
        }

        [TestMethod] //#14 - [[Launch][Code]] should return true 
        public void TestCase14()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[Launch][Code]]"));
        }
    }
}
