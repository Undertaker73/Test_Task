using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    interface IDataSource
    {
        public string GetText(string url);
    }
}
