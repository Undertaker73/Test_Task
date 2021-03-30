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
        Parser s;
        public Form1()
        {
            InitializeComponent();
        }

        private void GetText_Click(object sender, EventArgs e)
        {
            var s = new Parser();
            listWord.Items.Clear();
            var listStatistic = s.sendPostRequest(link.Text);
            foreach (var word in listStatistic)
            {
                var row = new string[] { word.Key, word.Value.ToString() };
                var lvi = new ListViewItem(row);
                lvi.Tag = word;
                listWord.Items.Add(lvi);
            }
        }
    }
}
