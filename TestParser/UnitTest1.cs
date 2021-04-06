using System;
using NUnit.Framework;
using WinFormsApp1;
using System.Collections.Generic;
using System.Linq;

namespace TestParser
{
    public class Tests
    {
        
        [Test]
        public void CountWordsTestRightResult()
        {
            string s = "אכüפא אכüפא מלודא בנאגמ";
            var rightResult = new Dictionary<string, int>
                {
                    {"אכüפא", 2},
                    {"מלודא", 1},
                    {"בנאגמ", 1}
                };
            SimpleParser parser = new SimpleParser();
            var result = parser.CountWords(s);
            CollectionAssert.AreEquivalent(rightResult.ToList(), result.ToList());
        }

        [Test]
        public void CountWordsTestEmptyResult()
        {
            string s = "";
            int rightResult = 0;
            SimpleParser parser = new SimpleParser();
            var result = parser.CountWords(s);
            Assert.AreEqual(rightResult, result.Count);
        }

        [Test]
        public void CountWordsTestWhitespaceResult()
        {
            string s = "        ";
            int rightResult = 0;
            SimpleParser parser = new SimpleParser();
            var result = parser.CountWords(s);
            Assert.AreEqual(rightResult, result.Count);
        }

        [Test]
        public void GetTextEmptyTest()
        {
            WebCrawler webpage = new WebCrawler();
            string pagetext = webpage.GetText("");
            Assert.AreEqual(pagetext, "");
        }

         [Test]
        public void GetTextNotEmptyTest()
        {
            WebCrawler webpage = new WebCrawler();
            string pagetext = webpage.GetText("google.com");
            Assert.IsTrue(!String.IsNullOrEmpty(pagetext));
        }
    }
}