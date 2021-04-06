using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using HtmlAgilityPack;

namespace WinFormsApp1
{
    public class SimpleParser : IParser
    {
        public char[] separators { get; set;} = { ' ', ',', '.', '!', '?', '"', ';', ':', '[', ']', '(', ')', '\n', '\r', '\t' };
        /// <summary>
        /// Получить статистику по словам в тексте
        /// </summary>
        /// <param name="text">текст для анализа</param>
        /// <returns></returns>
        public Dictionary<string, int> CountWords(String text)
        {
            var result = new Dictionary<string, int>();
            if (!String.IsNullOrEmpty(text.Trim()))
            {
                var words = text.Split(separators).Where(q => !string.IsNullOrEmpty(q));
                var uniqWrds = words.Select(q => q.ToLower().Trim()).Distinct();
                foreach (var word in uniqWrds)
                {
                    result.Add(word, words.Count(q => q.ToLower().Equals(word)));
                }
                result = result.OrderByDescending(q => q.Value).ToArray().ToDictionary(key => key.Key, value => value.Value);
                return result;
            }
            return result;
        }
    }
}
