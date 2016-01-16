﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTextDemo
{
    [TestClass]
    public class TestTextFunctions
    {
        //Write a function that reverses words in a sentence
        //able was I ere I saw elba
        //elba saw I ere I was able
        [TestMethod]
        public void TestPalindrome()
        {
            string sentence = "able was I ere I saw elba";
            string expected = "elba saw I ere I was able";
            var palindrome = new TextDemo.TextFunctions().Palindrome(sentence);
            Assert.AreEqual(expected,palindrome);
        }
    }
}
