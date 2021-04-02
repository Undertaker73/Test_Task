﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void GetText_Click(object sender, EventArgs e)
        {
            listWord.Items.Clear();
            label2.Text = "Идет анализ текста c сайта...";
            if (!String.IsNullOrEmpty(link.Text.Trim()))
            {
                var listStatistic = Parser.sendPostRequest("http://" + link.Text.Replace("http://", "").Replace("https://", ""));
                label2.Text = (listStatistic.FirstOrDefault().Value != 0) ? "Статистика встречаемости слов на сайте:" : "Произошла ошибка :";
                foreach (var word in listStatistic)
                {
                    AddItem(word.Key, word.Value.ToString(), word.Key);
                }
            } 
            else 
            {
                label2.Text = "Произошла ошибка :";
                AddItem("Поле не должно быть пустым, введите URL", "0", "Ошибка");
            }
        }

        private void AddItem(string word, string periodicity, string tag)
        {
            var row = new string[] { word, periodicity };
            var lvi = new ListViewItem(row);
            lvi.Tag = tag;
            listWord.Items.Add(lvi);
        }
    }
}
