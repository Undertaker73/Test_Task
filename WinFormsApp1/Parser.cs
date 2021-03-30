using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using HtmlAgilityPack;

namespace WinFormsApp1
{
    class Parser
    {
        public Dictionary<string,int> sendPostRequest(string url)
        {
            var result = new Dictionary<string, int>();
            try
            {
                System.Net.WebClient wc = new System.Net.WebClient();
                byte[] raw = wc.DownloadData(url);
                string webData = System.Text.Encoding.UTF8.GetString(raw);

                var pageDoc = new HtmlDocument();
                pageDoc.LoadHtml(webData);
                var pageText = pageDoc.DocumentNode.InnerText;

                if (!String.IsNullOrEmpty(pageText))
                {
                    return countWords(pageText);
                }
                result.Add("Текст на странице пустой", 0);
                return result;
            }
            catch
            {
                result.Add("Не удалось получить текст с сайта", 0);
                return result;
            }
        }

        public Dictionary<string, int> countWords(string text)
        {
            var result = new Dictionary<string, int>();
            try 
            {
                var words = text.Split(' ', ',', '.', '!', '?', '"', ';', ':', '[', ']', '(', ')', '\n', '\r', '\t').Where(q => !string.IsNullOrEmpty(q));
                var uniqWrds = words.Select(q => q.ToLower().Trim()).Distinct();
                foreach (var word in uniqWrds)
                {
                    result.Add(word, words.Count(q => q.ToLower().Equals(word)));
                }
                result = result.OrderByDescending(q => q.Value).ToArray().ToDictionary(key => key.Key, value => value.Value);
                return result;
            }
            catch
            {
                result.Add("Не удалось выделить слова", 0);
                return result;
            }
        }
    }
}
