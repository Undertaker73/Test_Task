using NUnit.Framework;
using WinFormsApp1;
using System.Collections.Generic;
using System.Linq;

namespace TestParser
{
    public class Tests
    {
        
        [Test]
        public void countWordsTest()
        {
            string s1 = "альфа альфа омега браво";
            var rightResult = new Dictionary<string, int>
                {
                    {"альфа", 2},
                    {"омега", 1},
                    {"браво", 1}
                };
            var result = Parser.countWords(s1);
            CollectionAssert.AreEquivalent(rightResult.ToList(), result.ToList());
        }

        [Test]
        public void sendPostRequestTest()
        {
            var rightResult = new Dictionary<string, int>
            {
                {"и", 44},
                {"в", 37},
                {"мы", 25}
            };
            var result = Parser.sendPostRequest("https://www.simbirsoft.com");
            CollectionAssert.AreEquivalent(rightResult.ToList(), result.Take(3).ToList());
        }

        [Test]
        public void sendPostRequestErrorTest()
        {
            var rightResult = new Dictionary<string, int>
            {
                { "Не удалось получить текст с сайта", 0 }
            };
            var result = Parser.sendPostRequest("");
            CollectionAssert.AreEquivalent(rightResult.ToList(), result.ToList());
        }
    }
}