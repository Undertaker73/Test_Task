
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
            this.gettextbutton = new System.Windows.Forms.Button();
            this.statisticslistword = new System.Windows.Forms.ListView();
            this.Word = new System.Windows.Forms.ColumnHeader();
            this.Periodicity = new System.Windows.Forms.ColumnHeader();
            this.urltextbox = new System.Windows.Forms.TextBox();
            this.urllabel = new System.Windows.Forms.Label();
            this.infolabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gettextbutton
            // 
            this.gettextbutton.Location = new System.Drawing.Point(470, 12);
            this.gettextbutton.Name = "gettextbutton";
            this.gettextbutton.Size = new System.Drawing.Size(100, 24);
            this.gettextbutton.TabIndex = 0;
            this.gettextbutton.Text = "Получи слова";
            this.gettextbutton.UseVisualStyleBackColor = true;
            this.gettextbutton.Click += new System.EventHandler(this.GetTextClick);
            // 
            // statisticslistword
            // 
            this.statisticslistword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statisticslistword.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Word,
            this.Periodicity});
            this.statisticslistword.HideSelection = false;
            this.statisticslistword.Location = new System.Drawing.Point(19, 66);
            this.statisticslistword.Name = "statisticslistword";
            this.statisticslistword.Size = new System.Drawing.Size(551, 353);
            this.statisticslistword.TabIndex = 1;
            this.statisticslistword.UseCompatibleStateImageBehavior = false;
            this.statisticslistword.View = System.Windows.Forms.View.Details;
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
            // urltextbox
            // 
            this.urltextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urltextbox.Location = new System.Drawing.Point(61, 12);
            this.urltextbox.Name = "urltextbox";
            this.urltextbox.Size = new System.Drawing.Size(403, 23);
            this.urltextbox.TabIndex = 2;
            // 
            // urllabel
            // 
            this.urllabel.AutoSize = true;
            this.urllabel.Location = new System.Drawing.Point(19, 15);
            this.urllabel.Name = "urllabel";
            this.urllabel.Size = new System.Drawing.Size(34, 15);
            this.urllabel.TabIndex = 3;
            this.urllabel.Text = "URL :";
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.Location = new System.Drawing.Point(19, 45);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(235, 15);
            this.infolabel.TabIndex = 4;
            this.infolabel.Text = "Статистика встречаемости слов на сайте:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 437);
            this.Controls.Add(this.infolabel);
            this.Controls.Add(this.urllabel);
            this.Controls.Add(this.urltextbox);
            this.Controls.Add(this.statisticslistword);
            this.Controls.Add(this.gettextbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Парсинг";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gettextbutton;
        private System.Windows.Forms.ListView statisticslistword;
        private System.Windows.Forms.TextBox urltextbox;
        private System.Windows.Forms.Label urllabel;
        private System.Windows.Forms.ColumnHeader Word;
        private System.Windows.Forms.ColumnHeader Periodicity;
        private System.Windows.Forms.Label infolabel;
    }
}

