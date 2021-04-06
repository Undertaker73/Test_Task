using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    interface IParser
    {
        public char[] separators { get; set; }
        public Dictionary<string, int> CountWords(string text);
    }
}
