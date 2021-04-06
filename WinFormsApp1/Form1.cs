using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string[] statusmessages =
        {
         "Идет анализ текста c сайта...",
         "Некорректный формат URL",
         "Пожалуйста введите URL, поле не должно быть пустым",
         "Статистика встречаемости слов на сайте:",
         "C указанного URL не удалось получить слова"
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void GetTextClick(object sender, EventArgs e)
        {
            statisticslistword.Items.Clear();
            infolabel.Text = statusmessages[0];
            if (!String.IsNullOrEmpty(urltextbox.Text.Trim()))
            {
                if (!Uri.IsWellFormedUriString(urltextbox.Text.Trim(), UriKind.RelativeOrAbsolute))
                {
                    infolabel.Text = statusmessages[1];
                    return;
                }
                SimpleParser parser = new SimpleParser();
                WebCrawler webpage = new WebCrawler();
                string pagetext = webpage.GetText(urltextbox.Text.Trim());
                Dictionary<string, int> listStatistic = parser.CountWords(pagetext);
                infolabel.Text = (listStatistic.Count() != 0) ? statusmessages[3] : statusmessages[4];
                foreach (var word in listStatistic)
                {
                    AddItem(word.Key, word.Value.ToString(), word.Key);
                }
                return;
            } 
            infolabel.Text = statusmessages[2];
        }

        private void AddItem(string word, string periodicity, string tag)
        {
            var row = new string[] { word, periodicity };
            var lvi = new ListViewItem(row);
            lvi.Tag = tag;
            statisticslistword.Items.Add(lvi);
        }
    }
}
