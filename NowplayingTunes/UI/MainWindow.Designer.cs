namespace NowplayingTunes
{
    partial class MainWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonBasicSettings = new System.Windows.Forms.Button();
            this.ButtonVesionInfo = new System.Windows.Forms.Button();
            this.ButtonDebugSettings = new System.Windows.Forms.Button();
            this.ButtonUpdateSettings = new System.Windows.Forms.Button();
            this.ButtonAutoPostSettings = new System.Windows.Forms.Button();
            this.SettingPanelTabControl = new System.Windows.Forms.TabControl();
            this.BasicSettings = new System.Windows.Forms.TabPage();
            this.CheckBoxExitWithiTunes = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxTweetText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AccountList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonSelectedDelete = new System.Windows.Forms.Button();
            this.ButtonAccountAdd = new System.Windows.Forms.Button();
            this.AutoPostSettings = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CheckBoxDeleteText140 = new System.Windows.Forms.CheckBox();
            this.checkBoxPostAlbumArtWork = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownWaitSecond2 = new System.Windows.Forms.NumericUpDown();
            this.CheckBoxCheckTime = new System.Windows.Forms.CheckBox();
            this.CheckBoxEnableCheckAlbum = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownWaitSecond = new System.Windows.Forms.NumericUpDown();
            this.CheckBoxEnablePostWait = new System.Windows.Forms.CheckBox();
            this.CheckBoxEnableAutoPost = new System.Windows.Forms.CheckBox();
            this.UpdateSettings = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.NotifyUpdate = new System.Windows.Forms.CheckBox();
            this.CheckUpdate = new System.Windows.Forms.CheckBox();
            this.DebugMode = new System.Windows.Forms.TabPage();
            this.DebugTextBox = new System.Windows.Forms.TextBox();
            this.VersionInfo = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.カスタム投稿TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.今すぐツイートToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NewVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.SettingPanelTabControl.SuspendLayout();
            this.BasicSettings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.AutoPostSettings.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWaitSecond2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWaitSecond)).BeginInit();
            this.UpdateSettings.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.DebugMode.SuspendLayout();
            this.VersionInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.ButtonBasicSettings);
            this.panel1.Controls.Add(this.ButtonVesionInfo);
            this.panel1.Controls.Add(this.ButtonDebugSettings);
            this.panel1.Controls.Add(this.ButtonUpdateSettings);
            this.panel1.Controls.Add(this.ButtonAutoPostSettings);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 359);
            this.panel1.TabIndex = 0;
            // 
            // ButtonBasicSettings
            // 
            this.ButtonBasicSettings.BackColor = System.Drawing.Color.White;
            this.ButtonBasicSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBasicSettings.Location = new System.Drawing.Point(0, 0);
            this.ButtonBasicSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonBasicSettings.Name = "ButtonBasicSettings";
            this.ButtonBasicSettings.Size = new System.Drawing.Size(189, 55);
            this.ButtonBasicSettings.TabIndex = 0;
            this.ButtonBasicSettings.Text = "基本設定";
            this.ButtonBasicSettings.UseVisualStyleBackColor = false;
            this.ButtonBasicSettings.Click += new System.EventHandler(this.ButtonBasicSettings_Click);
            // 
            // ButtonVesionInfo
            // 
            this.ButtonVesionInfo.BackColor = System.Drawing.Color.White;
            this.ButtonVesionInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonVesionInfo.Location = new System.Drawing.Point(0, 252);
            this.ButtonVesionInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonVesionInfo.Name = "ButtonVesionInfo";
            this.ButtonVesionInfo.Size = new System.Drawing.Size(189, 55);
            this.ButtonVesionInfo.TabIndex = 4;
            this.ButtonVesionInfo.Text = "バージョン情報";
            this.ButtonVesionInfo.UseVisualStyleBackColor = false;
            this.ButtonVesionInfo.Click += new System.EventHandler(this.ButtonVesionInfo_Click);
            // 
            // ButtonDebugSettings
            // 
            this.ButtonDebugSettings.BackColor = System.Drawing.Color.White;
            this.ButtonDebugSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDebugSettings.Location = new System.Drawing.Point(0, 189);
            this.ButtonDebugSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonDebugSettings.Name = "ButtonDebugSettings";
            this.ButtonDebugSettings.Size = new System.Drawing.Size(189, 55);
            this.ButtonDebugSettings.TabIndex = 3;
            this.ButtonDebugSettings.Text = "デバッグモード";
            this.ButtonDebugSettings.UseVisualStyleBackColor = false;
            this.ButtonDebugSettings.Click += new System.EventHandler(this.ButtonDebugSettings_Click);
            // 
            // ButtonUpdateSettings
            // 
            this.ButtonUpdateSettings.BackColor = System.Drawing.Color.White;
            this.ButtonUpdateSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUpdateSettings.Location = new System.Drawing.Point(0, 126);
            this.ButtonUpdateSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonUpdateSettings.Name = "ButtonUpdateSettings";
            this.ButtonUpdateSettings.Size = new System.Drawing.Size(189, 55);
            this.ButtonUpdateSettings.TabIndex = 2;
            this.ButtonUpdateSettings.Text = "アップデート設定";
            this.ButtonUpdateSettings.UseVisualStyleBackColor = false;
            this.ButtonUpdateSettings.Click += new System.EventHandler(this.ButtonUpdateSettings_Click);
            // 
            // ButtonAutoPostSettings
            // 
            this.ButtonAutoPostSettings.BackColor = System.Drawing.Color.White;
            this.ButtonAutoPostSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAutoPostSettings.Location = new System.Drawing.Point(0, 63);
            this.ButtonAutoPostSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonAutoPostSettings.Name = "ButtonAutoPostSettings";
            this.ButtonAutoPostSettings.Size = new System.Drawing.Size(189, 55);
            this.ButtonAutoPostSettings.TabIndex = 1;
            this.ButtonAutoPostSettings.Text = "自動投稿設定";
            this.ButtonAutoPostSettings.UseVisualStyleBackColor = false;
            this.ButtonAutoPostSettings.Click += new System.EventHandler(this.ButtonAutoPostSettings_Click);
            // 
            // SettingPanelTabControl
            // 
            this.SettingPanelTabControl.Controls.Add(this.BasicSettings);
            this.SettingPanelTabControl.Controls.Add(this.AutoPostSettings);
            this.SettingPanelTabControl.Controls.Add(this.UpdateSettings);
            this.SettingPanelTabControl.Controls.Add(this.DebugMode);
            this.SettingPanelTabControl.Controls.Add(this.VersionInfo);
            this.SettingPanelTabControl.Location = new System.Drawing.Point(190, -26);
            this.SettingPanelTabControl.Name = "SettingPanelTabControl";
            this.SettingPanelTabControl.SelectedIndex = 0;
            this.SettingPanelTabControl.Size = new System.Drawing.Size(435, 385);
            this.SettingPanelTabControl.TabIndex = 1;
            // 
            // BasicSettings
            // 
            this.BasicSettings.Controls.Add(this.CheckBoxExitWithiTunes);
            this.BasicSettings.Controls.Add(this.label7);
            this.BasicSettings.Controls.Add(this.groupBox2);
            this.BasicSettings.Controls.Add(this.groupBox1);
            this.BasicSettings.Location = new System.Drawing.Point(4, 27);
            this.BasicSettings.Name = "BasicSettings";
            this.BasicSettings.Size = new System.Drawing.Size(427, 354);
            this.BasicSettings.TabIndex = 0;
            this.BasicSettings.Text = "基本設定";
            this.BasicSettings.UseVisualStyleBackColor = true;
            // 
            // CheckBoxExitWithiTunes
            // 
            this.CheckBoxExitWithiTunes.AutoSize = true;
            this.CheckBoxExitWithiTunes.Location = new System.Drawing.Point(9, 284);
            this.CheckBoxExitWithiTunes.Name = "CheckBoxExitWithiTunes";
            this.CheckBoxExitWithiTunes.Size = new System.Drawing.Size(290, 22);
            this.CheckBoxExitWithiTunes.TabIndex = 3;
            this.CheckBoxExitWithiTunes.Text = "iTunesの終了と同時になうぷれTunesを終了する";
            this.CheckBoxExitWithiTunes.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(272, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "※設定はこのウィンドウを閉じると保存されます";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TextBoxTweetText);
            this.groupBox2.Location = new System.Drawing.Point(3, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ツイート設定";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "置き換え文字一覧表示";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "※置き換え文字を入力してください";
            // 
            // TextBoxTweetText
            // 
            this.TextBoxTweetText.Location = new System.Drawing.Point(6, 21);
            this.TextBoxTweetText.Name = "TextBoxTweetText";
            this.TextBoxTweetText.Size = new System.Drawing.Size(400, 25);
            this.TextBoxTweetText.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.AccountList);
            this.groupBox1.Controls.Add(this.ButtonSelectedDelete);
            this.groupBox1.Controls.Add(this.ButtonAccountAdd);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Twitter認証設定";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(344, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "※自動投稿に使用するアカウントにチェックをいれてください";
            // 
            // AccountList
            // 
            this.AccountList.CheckBoxes = true;
            this.AccountList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.AccountList.FullRowSelect = true;
            this.AccountList.Location = new System.Drawing.Point(10, 25);
            this.AccountList.Name = "AccountList";
            this.AccountList.Size = new System.Drawing.Size(405, 102);
            this.AccountList.TabIndex = 3;
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
            this.columnHeader2.Width = 132;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Token Secret";
            this.columnHeader3.Width = 123;
            // 
            // ButtonSelectedDelete
            // 
            this.ButtonSelectedDelete.Location = new System.Drawing.Point(202, 154);
            this.ButtonSelectedDelete.Name = "ButtonSelectedDelete";
            this.ButtonSelectedDelete.Size = new System.Drawing.Size(103, 23);
            this.ButtonSelectedDelete.TabIndex = 2;
            this.ButtonSelectedDelete.Text = "選択を削除";
            this.ButtonSelectedDelete.UseVisualStyleBackColor = true;
            this.ButtonSelectedDelete.Click += new System.EventHandler(this.ButtonSelectedDelete_Click);
            // 
            // ButtonAccountAdd
            // 
            this.ButtonAccountAdd.Location = new System.Drawing.Point(311, 154);
            this.ButtonAccountAdd.Name = "ButtonAccountAdd";
            this.ButtonAccountAdd.Size = new System.Drawing.Size(104, 23);
            this.ButtonAccountAdd.TabIndex = 1;
            this.ButtonAccountAdd.Text = "アカウント追加";
            this.ButtonAccountAdd.UseVisualStyleBackColor = true;
            this.ButtonAccountAdd.Click += new System.EventHandler(this.ButtonAccountAdd_Click);
            // 
            // AutoPostSettings
            // 
            this.AutoPostSettings.Controls.Add(this.groupBox3);
            this.AutoPostSettings.Location = new System.Drawing.Point(4, 27);
            this.AutoPostSettings.Name = "AutoPostSettings";
            this.AutoPostSettings.Size = new System.Drawing.Size(427, 354);
            this.AutoPostSettings.TabIndex = 1;
            this.AutoPostSettings.Text = "自動投稿設定";
            this.AutoPostSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CheckBoxDeleteText140);
            this.groupBox3.Controls.Add(this.checkBoxPostAlbumArtWork);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.numericUpDownWaitSecond2);
            this.groupBox3.Controls.Add(this.CheckBoxCheckTime);
            this.groupBox3.Controls.Add(this.CheckBoxEnableCheckAlbum);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.numericUpDownWaitSecond);
            this.groupBox3.Controls.Add(this.CheckBoxEnablePostWait);
            this.groupBox3.Controls.Add(this.CheckBoxEnableAutoPost);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 303);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "自動投稿";
            // 
            // CheckBoxDeleteText140
            // 
            this.CheckBoxDeleteText140.AutoSize = true;
            this.CheckBoxDeleteText140.Location = new System.Drawing.Point(6, 260);
            this.CheckBoxDeleteText140.Name = "CheckBoxDeleteText140";
            this.CheckBoxDeleteText140.Size = new System.Drawing.Size(252, 22);
            this.CheckBoxDeleteText140.TabIndex = 12;
            this.CheckBoxDeleteText140.Text = "140文字に収まらない場合は自動的に削る";
            this.CheckBoxDeleteText140.UseVisualStyleBackColor = true;
            // 
            // checkBoxPostAlbumArtWork
            // 
            this.checkBoxPostAlbumArtWork.AutoSize = true;
            this.checkBoxPostAlbumArtWork.Location = new System.Drawing.Point(6, 232);
            this.checkBoxPostAlbumArtWork.Name = "checkBoxPostAlbumArtWork";
            this.checkBoxPostAlbumArtWork.Size = new System.Drawing.Size(339, 22);
            this.checkBoxPostAlbumArtWork.TabIndex = 11;
            this.checkBoxPostAlbumArtWork.Text = "自動投稿でアルバムアートワークを添付してツイートする";
            this.checkBoxPostAlbumArtWork.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "秒";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "投稿待機時間";
            // 
            // numericUpDownWaitSecond2
            // 
            this.numericUpDownWaitSecond2.Location = new System.Drawing.Point(110, 201);
            this.numericUpDownWaitSecond2.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.numericUpDownWaitSecond2.Name = "numericUpDownWaitSecond2";
            this.numericUpDownWaitSecond2.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownWaitSecond2.TabIndex = 8;
            // 
            // CheckBoxCheckTime
            // 
            this.CheckBoxCheckTime.AutoSize = true;
            this.CheckBoxCheckTime.Location = new System.Drawing.Point(6, 173);
            this.CheckBoxCheckTime.Name = "CheckBoxCheckTime";
            this.CheckBoxCheckTime.Size = new System.Drawing.Size(411, 22);
            this.CheckBoxCheckTime.TabIndex = 7;
            this.CheckBoxCheckTime.Text = "指定した時間以上前回のツイートから経過しなかったらツイートしない";
            this.CheckBoxCheckTime.UseVisualStyleBackColor = true;
            // 
            // CheckBoxEnableCheckAlbum
            // 
            this.CheckBoxEnableCheckAlbum.AutoSize = true;
            this.CheckBoxEnableCheckAlbum.Location = new System.Drawing.Point(6, 144);
            this.CheckBoxEnableCheckAlbum.Name = "CheckBoxEnableCheckAlbum";
            this.CheckBoxEnableCheckAlbum.Size = new System.Drawing.Size(387, 22);
            this.CheckBoxEnableCheckAlbum.TabIndex = 6;
            this.CheckBoxEnableCheckAlbum.Text = "前回再生していた曲とアルバムが変わっていなかったら投稿しない";
            this.CheckBoxEnableCheckAlbum.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "※投稿待機時間の間は曲が変更されても前に再生していた曲は\r\n投稿されません";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "秒";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "投稿待機時間";
            // 
            // numericUpDownWaitSecond
            // 
            this.numericUpDownWaitSecond.Location = new System.Drawing.Point(110, 77);
            this.numericUpDownWaitSecond.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.numericUpDownWaitSecond.Name = "numericUpDownWaitSecond";
            this.numericUpDownWaitSecond.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownWaitSecond.TabIndex = 2;
            // 
            // CheckBoxEnablePostWait
            // 
            this.CheckBoxEnablePostWait.AutoSize = true;
            this.CheckBoxEnablePostWait.Location = new System.Drawing.Point(6, 49);
            this.CheckBoxEnablePostWait.Name = "CheckBoxEnablePostWait";
            this.CheckBoxEnablePostWait.Size = new System.Drawing.Size(243, 22);
            this.CheckBoxEnablePostWait.TabIndex = 1;
            this.CheckBoxEnablePostWait.Text = "指定した秒数ツイートするのを遅らせる";
            this.CheckBoxEnablePostWait.UseVisualStyleBackColor = true;
            // 
            // CheckBoxEnableAutoPost
            // 
            this.CheckBoxEnableAutoPost.AutoSize = true;
            this.CheckBoxEnableAutoPost.Location = new System.Drawing.Point(6, 24);
            this.CheckBoxEnableAutoPost.Name = "CheckBoxEnableAutoPost";
            this.CheckBoxEnableAutoPost.Size = new System.Drawing.Size(141, 22);
            this.CheckBoxEnableAutoPost.TabIndex = 0;
            this.CheckBoxEnableAutoPost.Text = "自動投稿をONにする";
            this.CheckBoxEnableAutoPost.UseVisualStyleBackColor = true;
            // 
            // UpdateSettings
            // 
            this.UpdateSettings.Controls.Add(this.groupBox4);
            this.UpdateSettings.Location = new System.Drawing.Point(4, 27);
            this.UpdateSettings.Name = "UpdateSettings";
            this.UpdateSettings.Size = new System.Drawing.Size(427, 354);
            this.UpdateSettings.TabIndex = 2;
            this.UpdateSettings.Text = "アップデート設定";
            this.UpdateSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.NotifyUpdate);
            this.groupBox4.Controls.Add(this.CheckUpdate);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(421, 277);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "アップデート通知設定";
            // 
            // NotifyUpdate
            // 
            this.NotifyUpdate.AutoSize = true;
            this.NotifyUpdate.Location = new System.Drawing.Point(6, 46);
            this.NotifyUpdate.Name = "NotifyUpdate";
            this.NotifyUpdate.Size = new System.Drawing.Size(171, 22);
            this.NotifyUpdate.TabIndex = 1;
            this.NotifyUpdate.Text = "アップデートの通知をする";
            this.NotifyUpdate.UseVisualStyleBackColor = true;
            // 
            // CheckUpdate
            // 
            this.CheckUpdate.AutoSize = true;
            this.CheckUpdate.Location = new System.Drawing.Point(6, 24);
            this.CheckUpdate.Name = "CheckUpdate";
            this.CheckUpdate.Size = new System.Drawing.Size(219, 22);
            this.CheckUpdate.TabIndex = 0;
            this.CheckUpdate.Text = "起動時にアップデートの確認をする";
            this.CheckUpdate.UseVisualStyleBackColor = true;
            // 
            // DebugMode
            // 
            this.DebugMode.Controls.Add(this.DebugTextBox);
            this.DebugMode.Location = new System.Drawing.Point(4, 27);
            this.DebugMode.Name = "DebugMode";
            this.DebugMode.Size = new System.Drawing.Size(427, 354);
            this.DebugMode.TabIndex = 3;
            this.DebugMode.Text = "デバッグモード";
            this.DebugMode.UseVisualStyleBackColor = true;
            // 
            // DebugTextBox
            // 
            this.DebugTextBox.Location = new System.Drawing.Point(3, 3);
            this.DebugTextBox.Multiline = true;
            this.DebugTextBox.Name = "DebugTextBox";
            this.DebugTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DebugTextBox.Size = new System.Drawing.Size(421, 310);
            this.DebugTextBox.TabIndex = 0;
            // 
            // VersionInfo
            // 
            this.VersionInfo.Controls.Add(this.panel2);
            this.VersionInfo.Controls.Add(this.label9);
            this.VersionInfo.Controls.Add(this.pictureBox1);
            this.VersionInfo.Location = new System.Drawing.Point(4, 27);
            this.VersionInfo.Name = "VersionInfo";
            this.VersionInfo.Size = new System.Drawing.Size(427, 354);
            this.VersionInfo.TabIndex = 4;
            this.VersionInfo.Text = "バージョン情報";
            this.VersionInfo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(217, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 152);
            this.panel2.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(90, 123);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(104, 18);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "自作ソフトの部屋";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "バージョン:2.0.2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "開発:大石一稀(Kazuki Oishi)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(210, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 41);
            this.label9.TabIndex = 1;
            this.label9.Text = "なうぷれTunes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "なうぷれTunes";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.カスタム投稿TToolStripMenuItem,
            this.今すぐツイートToolStripMenuItem,
            this.toolStripSeparator1,
            this.設定ToolStripMenuItem,
            this.終了ToolStripMenuItem,
            this.toolStripSeparator2,
            this.NewVersionToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(218, 126);
            // 
            // カスタム投稿TToolStripMenuItem
            // 
            this.カスタム投稿TToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("カスタム投稿TToolStripMenuItem.Image")));
            this.カスタム投稿TToolStripMenuItem.Name = "カスタム投稿TToolStripMenuItem";
            this.カスタム投稿TToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.カスタム投稿TToolStripMenuItem.Text = "カスタムツイート(&C)";
            this.カスタム投稿TToolStripMenuItem.Click += new System.EventHandler(this.カスタム投稿TToolStripMenuItem_Click);
            // 
            // 今すぐツイートToolStripMenuItem
            // 
            this.今すぐツイートToolStripMenuItem.Image = global::NowplayingTunes.Properties.Resources.twitter_bird_light_bgs;
            this.今すぐツイートToolStripMenuItem.Name = "今すぐツイートToolStripMenuItem";
            this.今すぐツイートToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.今すぐツイートToolStripMenuItem.Text = "今すぐツイート(&T)";
            this.今すぐツイートToolStripMenuItem.Click += new System.EventHandler(this.今すぐツイートToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(214, 6);
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("設定ToolStripMenuItem.Image")));
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.設定ToolStripMenuItem.Text = "設定(&S)";
            this.設定ToolStripMenuItem.Click += new System.EventHandler(this.設定ToolStripMenuItem_Click);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("終了ToolStripMenuItem.Image")));
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.終了ToolStripMenuItem.Text = "終了(&E)";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(214, 6);
            // 
            // NewVersionToolStripMenuItem
            // 
            this.NewVersionToolStripMenuItem.Enabled = false;
            this.NewVersionToolStripMenuItem.Name = "NewVersionToolStripMenuItem";
            this.NewVersionToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.NewVersionToolStripMenuItem.Text = "アップデートを確認していません";
            this.NewVersionToolStripMenuItem.Click += new System.EventHandler(this.NewVersionToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(621, 358);
            this.Controls.Add(this.SettingPanelTabControl);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "なうぷれTunes";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.SettingPanelTabControl.ResumeLayout(false);
            this.BasicSettings.ResumeLayout(false);
            this.BasicSettings.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.AutoPostSettings.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWaitSecond2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWaitSecond)).EndInit();
            this.UpdateSettings.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.DebugMode.ResumeLayout(false);
            this.DebugMode.PerformLayout();
            this.VersionInfo.ResumeLayout(false);
            this.VersionInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonVesionInfo;
        private System.Windows.Forms.Button ButtonDebugSettings;
        private System.Windows.Forms.Button ButtonUpdateSettings;
        private System.Windows.Forms.Button ButtonAutoPostSettings;
        private System.Windows.Forms.Button ButtonBasicSettings;
        private System.Windows.Forms.TabControl SettingPanelTabControl;
        private System.Windows.Forms.TabPage BasicSettings;
        private System.Windows.Forms.TabPage AutoPostSettings;
        private System.Windows.Forms.TabPage UpdateSettings;
        private System.Windows.Forms.TabPage DebugMode;
        private System.Windows.Forms.TabPage VersionInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonSelectedDelete;
        private System.Windows.Forms.Button ButtonAccountAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxTweetText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownWaitSecond2;
        private System.Windows.Forms.CheckBox CheckBoxCheckTime;
        private System.Windows.Forms.CheckBox CheckBoxEnableCheckAlbum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownWaitSecond;
        private System.Windows.Forms.CheckBox CheckBoxEnablePostWait;
        private System.Windows.Forms.CheckBox CheckBoxEnableAutoPost;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox NotifyUpdate;
        private System.Windows.Forms.CheckBox CheckUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem カスタム投稿TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 今すぐツイートToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.ListView AccountList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DebugTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox checkBoxPostAlbumArtWork;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem NewVersionToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox CheckBoxDeleteText140;
        private System.Windows.Forms.CheckBox CheckBoxExitWithiTunes;
    }
}

