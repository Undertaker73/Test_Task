using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using HtmlAgilityPack;

namespace WinFormsApp1
{
    public class Parser
    {
        public static Dictionary<string,int> sendPostRequest(string url)
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
                result.Add("Текст на странице отсутствует", 0);
                return result;
            }
            catch (Exception ex)
            {
                result.Add("Не удалось получить текст с сайта", 0);
                Logger.LogException(ex.Message);
                return result;
            }
        }

        public static Dictionary<string, int> countWords(string text)
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
            catch (Exception ex)
            {
                result.Add("Не удалось выделить слова", 0);
                Logger.LogException(ex.Message);
                return result;
            }
        }
    }
}
