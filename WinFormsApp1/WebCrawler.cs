using System;
using HtmlAgilityPack;

namespace WinFormsApp1
{
    public class WebCrawler : IDataSource
    {
        string savepath = "page.html";
        Logger log = new Logger();
        /// <summary>
        /// Получить текст с веб-страницы
        /// </summary>
        /// <param name="url">Адрес сайта</param>
        /// <returns></returns>
        public string GetText(string url)
        {
            if (!Uri.IsWellFormedUriString(url.Trim(), UriKind.RelativeOrAbsolute) || String.IsNullOrEmpty(url.Trim()))
            {
                log.LogError("Некорректный формат URL");
                return "";
            }
            UriBuilder uribuilder = new UriBuilder(url);
            Uri weburl = uribuilder.Uri;
            try
            {
                System.Net.WebClient client = new System.Net.WebClient();
                client.DownloadFile(weburl, savepath);
                byte[] raw = client.DownloadData(weburl);
                string webData = System.Text.Encoding.UTF8.GetString(raw);
                var pageDoc = new HtmlDocument();
                pageDoc.LoadHtml(webData);
                var pageText = pageDoc.DocumentNode.InnerText;
                return pageText;
            }
            catch (Exception ex)
            {
                log.LogError(ex.Message);
                return "";
            }
        }
    }
}
