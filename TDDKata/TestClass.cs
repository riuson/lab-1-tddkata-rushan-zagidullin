﻿// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace TDDKata
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void SimpleTest()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum("2,2");
            Assert.That(value, Is.EqualTo(4), "Wrong actual value");
        }
        
        [Test]
        public void TestSumOneNumber()
        {
            StringCalc calc = new StringCalc();
            string argument = "2";
            int expected = 2;
            
            int value = calc.Sum(argument);
            Assert.That(value, Is.EqualTo(expected), "Wrong sum of one number");
        }
        
        [Test]
        public void TestSumWithZero()
        {
            StringCalc calc = new StringCalc();
            string argument = "2,0";
            int expected = 2;
            
            int value = calc.Sum(argument);
            Assert.That(value, Is.EqualTo(expected), "Wrong sum of a number and zero");
        }
        
        [Test]
        public void TestEmptyString()
        {
            StringCalc calc = new StringCalc();
            string argument = "";
            int expected = 0;
            
            int value = calc.Sum(argument);
            Assert.That(value, Is.EqualTo(expected), "Sum of empty string should return zero");
        }
        
        [Test]
        public void TestNullString()
        {
            StringCalc calc = new StringCalc();
            string argument = null;
            int expected = -1;
            
            int value = calc.Sum(argument);
            Assert.That(value, Is.EqualTo(expected), "Sum of null should return -1");
        }
        
        [Test]
        public void TestNegativeNumbers()
        {
            StringCalc calc = new StringCalc();
            string argument = "4,-1";
            int expected = -1;
            
            int value = calc.Sum(argument);
            Assert.That(value, Is.EqualTo(expected), "Should return -1 when negative numbers passed");
        }
        
        [Test]
        public void TestWrongNumbers()
        {
            StringCalc calc = new StringCalc();
            string argument = "4,not a number";
            int expected = -1;
            
            int value = calc.Sum(argument);
            Assert.That(value, Is.EqualTo(expected), "Should return -1 when unparsable value passed");
        }
        
        [Test]
        public void TestTooManyNumbers()
        {
            StringCalc calc = new StringCalc();
            string argument = "1,2,3";
            int expected = -1;
            
            int value = calc.Sum(argument);
            Assert.That(value, Is.EqualTo(expected), "Should return -1 when more than two numbers passed");
        }
    }
}
