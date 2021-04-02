
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GetText = new System.Windows.Forms.Button();
            this.listWord = new System.Windows.Forms.ListView();
            this.Word = new System.Windows.Forms.ColumnHeader();
            this.Periodicity = new System.Windows.Forms.ColumnHeader();
            this.link = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetText
            // 
            this.GetText.Location = new System.Drawing.Point(470, 12);
            this.GetText.Name = "GetText";
            this.GetText.Size = new System.Drawing.Size(100, 24);
            this.GetText.TabIndex = 0;
            this.GetText.Text = "Получи слова";
            this.GetText.UseVisualStyleBackColor = true;
            this.GetText.Click += new System.EventHandler(this.GetText_Click);
            // 
            // listWord
            // 
            this.listWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listWord.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Word,
            this.Periodicity});
            this.listWord.HideSelection = false;
            this.listWord.Location = new System.Drawing.Point(19, 66);
            this.listWord.Name = "listWord";
            this.listWord.Size = new System.Drawing.Size(551, 353);
            this.listWord.TabIndex = 1;
            this.listWord.UseCompatibleStateImageBehavior = false;
            this.listWord.View = System.Windows.Forms.View.Details;
            // 
            // Word
            // 
            this.Word.Text = "Слово";
            this.Word.Width = 350;
            // 
            // Periodicity
            // 
            this.Periodicity.Text = "Повторяемость";
            this.Periodicity.Width = 200;
            // 
            // link
            // 
            this.link.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.link.Location = new System.Drawing.Point(61, 12);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(403, 23);
            this.link.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "http://";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Статистика встречаемости слов на сайте:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 437);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.link);
            this.Controls.Add(this.listWord);
            this.Controls.Add(this.GetText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Парсинг";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetText;
        private System.Windows.Forms.ListView listWord;
        private System.Windows.Forms.TextBox link;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Word;
        private System.Windows.Forms.ColumnHeader Periodicity;
        private System.Windows.Forms.Label label2;
    }
}

