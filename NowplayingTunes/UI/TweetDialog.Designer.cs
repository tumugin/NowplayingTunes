namespace NowplayingTunes.UI
{
    partial class TweetDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TweetDigit = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AccountList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EnableAlbumArtTweet = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(506, 130);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TweetDigit
            // 
            this.TweetDigit.AutoSize = true;
            this.TweetDigit.Location = new System.Drawing.Point(489, 9);
            this.TweetDigit.Name = "TweetDigit";
            this.TweetDigit.Size = new System.Drawing.Size(29, 18);
            this.TweetDigit.TabIndex = 1;
            this.TweetDigit.Text = "140";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(443, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "ツイート";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AccountList
            // 
            this.AccountList.CheckBoxes = true;
            this.AccountList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.AccountList.FullRowSelect = true;
            this.AccountList.Location = new System.Drawing.Point(12, 236);
            this.AccountList.Name = "AccountList";
            this.AccountList.Size = new System.Drawing.Size(506, 153);
            this.AccountList.TabIndex = 4;
            this.AccountList.UseCompatibleStateImageBehavior = false;
            this.AccountList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "アカウントID";
            this.columnHeader1.Width = 138;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Access Token";
            this.columnHeader2.Width = 172;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Token Secret";
            this.columnHeader3.Width = 188;
            // 
            // EnableAlbumArtTweet
            // 
            this.EnableAlbumArtTweet.AutoSize = true;
            this.EnableAlbumArtTweet.Location = new System.Drawing.Point(12, 168);
            this.EnableAlbumArtTweet.Name = "EnableAlbumArtTweet";
            this.EnableAlbumArtTweet.Size = new System.Drawing.Size(207, 22);
            this.EnableAlbumArtTweet.TabIndex = 5;
            this.EnableAlbumArtTweet.Text = "アルバムアートワークを添付する";
            this.EnableAlbumArtTweet.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "ツイートに使用するアカウント";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(337, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "アカウント設定";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TweetDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 200);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnableAlbumArtTweet);
            this.Controls.Add(this.AccountList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TweetDigit);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TweetDialog";
            this.Text = "カスタムツイート";
            this.Load += new System.EventHandler(this.TweetDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label TweetDigit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.CheckBox EnableAlbumArtTweet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ListView AccountList;
    }
}