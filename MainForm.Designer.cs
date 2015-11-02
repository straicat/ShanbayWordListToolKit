namespace ShanbayWordListToolKit
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolkit = new System.Windows.Forms.TabPage();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errorlog = new System.Windows.Forms.CheckBox();
            this.tryfix = new System.Windows.Forms.CheckBox();
            this.inputwait = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.readydelay = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.startinput = new System.Windows.Forms.Button();
            this.inputlistview = new System.Windows.Forms.Button();
            this.inputlistpath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupnum = new System.Windows.Forms.ComboBox();
            this.listgroup = new System.Windows.Forms.CheckBox();
            this.dolistact = new System.Windows.Forms.Button();
            this.listrandom = new System.Windows.Forms.CheckBox();
            this.worddisct = new System.Windows.Forms.CheckBox();
            this.wordlistview = new System.Windows.Forms.Button();
            this.wordlistpath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listcreate = new System.Windows.Forms.TabPage();
            this.listcreatebar = new System.Windows.Forms.ProgressBar();
            this.myzone = new System.Windows.Forms.LinkLabel();
            this.viewall = new System.Windows.Forms.Button();
            this.viewsource = new System.Windows.Forms.Button();
            this.onekeycreate = new System.Windows.Forms.Button();
            this.allpath = new System.Windows.Forms.TextBox();
            this.sourcepaths = new System.Windows.Forms.TextBox();
            this.easypath = new System.Windows.Forms.TextBox();
            this.sourcewords = new System.Windows.Forms.Label();
            this.allwords = new System.Windows.Forms.Label();
            this.vieweasy = new System.Windows.Forms.Button();
            this.easywords = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.leasttimes = new System.Windows.Forms.ComboBox();
            this.leastlen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabcollection = new System.Windows.Forms.TabControl();
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolkit.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.listcreate.SuspendLayout();
            this.tabcollection.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolkit
            // 
            this.toolkit.BackColor = System.Drawing.SystemColors.Control;
            this.toolkit.Controls.Add(this.linkLabel);
            this.toolkit.Controls.Add(this.groupBox2);
            this.toolkit.Controls.Add(this.groupBox1);
            this.toolkit.Location = new System.Drawing.Point(4, 22);
            this.toolkit.Name = "toolkit";
            this.toolkit.Padding = new System.Windows.Forms.Padding(3);
            this.toolkit.Size = new System.Drawing.Size(476, 536);
            this.toolkit.TabIndex = 1;
            this.toolkit.Text = "工具箱";
            // 
            // linkLabel
            // 
            this.linkLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.linkLabel.AutoSize = true;
            this.linkLabel.Font = new System.Drawing.Font("宋体", 9F);
            this.linkLabel.Location = new System.Drawing.Point(200, 495);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(77, 12);
            this.linkLabel.TabIndex = 23;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "我的扇贝空间";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.myzone_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.errorlog);
            this.groupBox2.Controls.Add(this.tryfix);
            this.groupBox2.Controls.Add(this.inputwait);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.readydelay);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.startinput);
            this.groupBox2.Controls.Add(this.inputlistview);
            this.groupBox2.Controls.Add(this.inputlistpath);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(8, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 234);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "自动输入";
            // 
            // errorlog
            // 
            this.errorlog.AutoSize = true;
            this.errorlog.Checked = true;
            this.errorlog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.errorlog.Location = new System.Drawing.Point(262, 121);
            this.errorlog.Name = "errorlog";
            this.errorlog.Size = new System.Drawing.Size(180, 16);
            this.errorlog.TabIndex = 18;
            this.errorlog.Text = "将输入失败的词条记录到文件";
            this.errorlog.UseVisualStyleBackColor = true;
            // 
            // tryfix
            // 
            this.tryfix.AutoSize = true;
            this.tryfix.Checked = true;
            this.tryfix.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tryfix.Location = new System.Drawing.Point(11, 121);
            this.tryfix.Name = "tryfix";
            this.tryfix.Size = new System.Drawing.Size(72, 16);
            this.tryfix.TabIndex = 17;
            this.tryfix.Text = "尝试修正";
            this.tryfix.UseVisualStyleBackColor = true;
            // 
            // inputwait
            // 
            this.inputwait.FormattingEnabled = true;
            this.inputwait.Items.AddRange(new object[] {
            "500",
            "800",
            "1000",
            "1500",
            "2000"});
            this.inputwait.Location = new System.Drawing.Point(366, 75);
            this.inputwait.Name = "inputwait";
            this.inputwait.Size = new System.Drawing.Size(76, 20);
            this.inputwait.TabIndex = 14;
            this.inputwait.Text = "1000";
            this.inputwait.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "输入间隔(ms)";
            // 
            // readydelay
            // 
            this.readydelay.FormattingEnabled = true;
            this.readydelay.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.readydelay.Location = new System.Drawing.Point(98, 76);
            this.readydelay.Name = "readydelay";
            this.readydelay.Size = new System.Drawing.Size(76, 20);
            this.readydelay.TabIndex = 12;
            this.readydelay.Text = "5";
            this.readydelay.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "准备时间(s)";
            // 
            // startinput
            // 
            this.startinput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startinput.Location = new System.Drawing.Point(178, 177);
            this.startinput.Name = "startinput";
            this.startinput.Size = new System.Drawing.Size(103, 37);
            this.startinput.TabIndex = 10;
            this.startinput.Text = "开始";
            this.startinput.UseVisualStyleBackColor = true;
            this.startinput.Click += new System.EventHandler(this.startinput_Click);
            // 
            // inputlistview
            // 
            this.inputlistview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputlistview.Location = new System.Drawing.Point(367, 28);
            this.inputlistview.Name = "inputlistview";
            this.inputlistview.Size = new System.Drawing.Size(75, 23);
            this.inputlistview.TabIndex = 2;
            this.inputlistview.Text = "浏览";
            this.inputlistview.UseVisualStyleBackColor = true;
            this.inputlistview.Click += new System.EventHandler(this.inputlistview_Click);
            // 
            // inputlistpath
            // 
            this.inputlistpath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputlistpath.Location = new System.Drawing.Point(66, 30);
            this.inputlistpath.Name = "inputlistpath";
            this.inputlistpath.Size = new System.Drawing.Size(283, 21);
            this.inputlistpath.TabIndex = 1;
            this.inputlistpath.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.inputlistpath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "选择词表";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupnum);
            this.groupBox1.Controls.Add(this.listgroup);
            this.groupBox1.Controls.Add(this.dolistact);
            this.groupBox1.Controls.Add(this.listrandom);
            this.groupBox1.Controls.Add(this.worddisct);
            this.groupBox1.Controls.Add(this.wordlistview);
            this.groupBox1.Controls.Add(this.wordlistpath);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "词表处理";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "组数：";
            this.label4.Visible = false;
            // 
            // groupnum
            // 
            this.groupnum.FormattingEnabled = true;
            this.groupnum.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.groupnum.Location = new System.Drawing.Point(143, 101);
            this.groupnum.Name = "groupnum";
            this.groupnum.Size = new System.Drawing.Size(70, 20);
            this.groupnum.TabIndex = 9;
            this.groupnum.Text = "10";
            this.groupnum.Visible = false;
            this.groupnum.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // listgroup
            // 
            this.listgroup.AutoSize = true;
            this.listgroup.Location = new System.Drawing.Point(18, 103);
            this.listgroup.Name = "listgroup";
            this.listgroup.Size = new System.Drawing.Size(72, 16);
            this.listgroup.TabIndex = 8;
            this.listgroup.Text = "词表分组";
            this.listgroup.UseVisualStyleBackColor = true;
            this.listgroup.CheckedChanged += new System.EventHandler(this.listgroup_CheckedChanged);
            // 
            // dolistact
            // 
            this.dolistact.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dolistact.Location = new System.Drawing.Point(178, 138);
            this.dolistact.Name = "dolistact";
            this.dolistact.Size = new System.Drawing.Size(103, 35);
            this.dolistact.TabIndex = 6;
            this.dolistact.Text = "执行";
            this.dolistact.UseVisualStyleBackColor = true;
            this.dolistact.Click += new System.EventHandler(this.dolistact_Click);
            // 
            // listrandom
            // 
            this.listrandom.AutoSize = true;
            this.listrandom.Location = new System.Drawing.Point(277, 66);
            this.listrandom.Name = "listrandom";
            this.listrandom.Size = new System.Drawing.Size(72, 16);
            this.listrandom.TabIndex = 5;
            this.listrandom.Text = "词表乱序";
            this.listrandom.UseVisualStyleBackColor = true;
            // 
            // worddisct
            // 
            this.worddisct.AutoSize = true;
            this.worddisct.Location = new System.Drawing.Point(18, 66);
            this.worddisct.Name = "worddisct";
            this.worddisct.Size = new System.Drawing.Size(72, 16);
            this.worddisct.TabIndex = 4;
            this.worddisct.Text = "词表去重";
            this.worddisct.UseVisualStyleBackColor = true;
            // 
            // wordlistview
            // 
            this.wordlistview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wordlistview.Location = new System.Drawing.Point(367, 27);
            this.wordlistview.Name = "wordlistview";
            this.wordlistview.Size = new System.Drawing.Size(75, 23);
            this.wordlistview.TabIndex = 3;
            this.wordlistview.Text = "浏览";
            this.wordlistview.UseVisualStyleBackColor = true;
            this.wordlistview.Click += new System.EventHandler(this.wordlistview_Click);
            // 
            // wordlistpath
            // 
            this.wordlistpath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wordlistpath.Location = new System.Drawing.Point(66, 29);
            this.wordlistpath.Name = "wordlistpath";
            this.wordlistpath.Size = new System.Drawing.Size(283, 21);
            this.wordlistpath.TabIndex = 2;
            this.wordlistpath.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.wordlistpath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "选择文件";
            // 
            // listcreate
            // 
            this.listcreate.BackColor = System.Drawing.SystemColors.Control;
            this.listcreate.Controls.Add(this.listcreatebar);
            this.listcreate.Controls.Add(this.myzone);
            this.listcreate.Controls.Add(this.viewall);
            this.listcreate.Controls.Add(this.viewsource);
            this.listcreate.Controls.Add(this.onekeycreate);
            this.listcreate.Controls.Add(this.allpath);
            this.listcreate.Controls.Add(this.sourcepaths);
            this.listcreate.Controls.Add(this.easypath);
            this.listcreate.Controls.Add(this.sourcewords);
            this.listcreate.Controls.Add(this.allwords);
            this.listcreate.Controls.Add(this.vieweasy);
            this.listcreate.Controls.Add(this.easywords);
            this.listcreate.Controls.Add(this.label1);
            this.listcreate.Controls.Add(this.leasttimes);
            this.listcreate.Controls.Add(this.leastlen);
            this.listcreate.Controls.Add(this.label3);
            this.listcreate.Location = new System.Drawing.Point(4, 22);
            this.listcreate.Name = "listcreate";
            this.listcreate.Size = new System.Drawing.Size(476, 536);
            this.listcreate.TabIndex = 2;
            this.listcreate.Text = "词表创建";
            // 
            // listcreatebar
            // 
            this.listcreatebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listcreatebar.Location = new System.Drawing.Point(10, 395);
            this.listcreatebar.Name = "listcreatebar";
            this.listcreatebar.Size = new System.Drawing.Size(456, 10);
            this.listcreatebar.TabIndex = 23;
            // 
            // myzone
            // 
            this.myzone.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.myzone.AutoSize = true;
            this.myzone.Font = new System.Drawing.Font("宋体", 9F);
            this.myzone.Location = new System.Drawing.Point(200, 495);
            this.myzone.Name = "myzone";
            this.myzone.Size = new System.Drawing.Size(77, 12);
            this.myzone.TabIndex = 22;
            this.myzone.TabStop = true;
            this.myzone.Text = "我的扇贝空间";
            this.myzone.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.myzone_LinkClicked);
            // 
            // viewall
            // 
            this.viewall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.viewall.Location = new System.Drawing.Point(391, 143);
            this.viewall.Name = "viewall";
            this.viewall.Size = new System.Drawing.Size(75, 23);
            this.viewall.TabIndex = 5;
            this.viewall.Text = "浏览";
            this.viewall.UseVisualStyleBackColor = true;
            this.viewall.Click += new System.EventHandler(this.viewall_Click);
            // 
            // viewsource
            // 
            this.viewsource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewsource.Location = new System.Drawing.Point(391, 15);
            this.viewsource.Name = "viewsource";
            this.viewsource.Size = new System.Drawing.Size(75, 23);
            this.viewsource.TabIndex = 2;
            this.viewsource.Text = "浏览";
            this.viewsource.UseVisualStyleBackColor = true;
            this.viewsource.Click += new System.EventHandler(this.viewsource_Click);
            // 
            // onekeycreate
            // 
            this.onekeycreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.onekeycreate.BackColor = System.Drawing.SystemColors.Control;
            this.onekeycreate.Cursor = System.Windows.Forms.Cursors.Default;
            this.onekeycreate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.onekeycreate.Location = new System.Drawing.Point(122, 435);
            this.onekeycreate.Name = "onekeycreate";
            this.onekeycreate.Size = new System.Drawing.Size(233, 34);
            this.onekeycreate.TabIndex = 21;
            this.onekeycreate.Text = "一键制作";
            this.onekeycreate.UseVisualStyleBackColor = false;
            this.onekeycreate.Click += new System.EventHandler(this.onekeycreate_Click);
            // 
            // allpath
            // 
            this.allpath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allpath.Location = new System.Drawing.Point(67, 143);
            this.allpath.Multiline = true;
            this.allpath.Name = "allpath";
            this.allpath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.allpath.Size = new System.Drawing.Size(310, 70);
            this.allpath.TabIndex = 4;
            this.allpath.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.allpath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // sourcepaths
            // 
            this.sourcepaths.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sourcepaths.Location = new System.Drawing.Point(67, 15);
            this.sourcepaths.Multiline = true;
            this.sourcepaths.Name = "sourcepaths";
            this.sourcepaths.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sourcepaths.Size = new System.Drawing.Size(310, 126);
            this.sourcepaths.TabIndex = 1;
            this.sourcepaths.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.sourcepaths.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // easypath
            // 
            this.easypath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.easypath.Location = new System.Drawing.Point(67, 215);
            this.easypath.Multiline = true;
            this.easypath.Name = "easypath";
            this.easypath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.easypath.Size = new System.Drawing.Size(310, 70);
            this.easypath.TabIndex = 7;
            this.easypath.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.easypath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // sourcewords
            // 
            this.sourcewords.AutoSize = true;
            this.sourcewords.Location = new System.Drawing.Point(8, 15);
            this.sourcewords.Name = "sourcewords";
            this.sourcewords.Size = new System.Drawing.Size(53, 12);
            this.sourcewords.TabIndex = 0;
            this.sourcewords.Text = "单词来源";
            // 
            // allwords
            // 
            this.allwords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.allwords.AutoSize = true;
            this.allwords.Location = new System.Drawing.Point(8, 143);
            this.allwords.Name = "allwords";
            this.allwords.Size = new System.Drawing.Size(53, 12);
            this.allwords.TabIndex = 3;
            this.allwords.Text = "大纲词汇";
            // 
            // vieweasy
            // 
            this.vieweasy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.vieweasy.Location = new System.Drawing.Point(391, 215);
            this.vieweasy.Name = "vieweasy";
            this.vieweasy.Size = new System.Drawing.Size(75, 23);
            this.vieweasy.TabIndex = 8;
            this.vieweasy.Text = "浏览";
            this.vieweasy.UseVisualStyleBackColor = true;
            this.vieweasy.Click += new System.EventHandler(this.vieweasy_Click);
            // 
            // easywords
            // 
            this.easywords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.easywords.AutoSize = true;
            this.easywords.Location = new System.Drawing.Point(8, 215);
            this.easywords.Name = "easywords";
            this.easywords.Size = new System.Drawing.Size(53, 12);
            this.easywords.TabIndex = 6;
            this.easywords.Text = "过滤词表";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "长度过滤";
            // 
            // leasttimes
            // 
            this.leasttimes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.leasttimes.FormattingEnabled = true;
            this.leasttimes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.leasttimes.Location = new System.Drawing.Point(67, 301);
            this.leasttimes.Name = "leasttimes";
            this.leasttimes.Size = new System.Drawing.Size(124, 20);
            this.leasttimes.TabIndex = 13;
            this.leasttimes.Text = "3";
            this.leasttimes.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // leastlen
            // 
            this.leastlen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.leastlen.FormattingEnabled = true;
            this.leastlen.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.leastlen.Location = new System.Drawing.Point(346, 301);
            this.leastlen.Name = "leastlen";
            this.leastlen.Size = new System.Drawing.Size(120, 20);
            this.leastlen.TabIndex = 10;
            this.leastlen.Text = "3";
            this.leastlen.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "词频过滤";
            // 
            // tabcollection
            // 
            this.tabcollection.Controls.Add(this.listcreate);
            this.tabcollection.Controls.Add(this.toolkit);
            this.tabcollection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcollection.Location = new System.Drawing.Point(0, 0);
            this.tabcollection.Name = "tabcollection";
            this.tabcollection.SelectedIndex = 0;
            this.tabcollection.Size = new System.Drawing.Size(484, 562);
            this.tabcollection.TabIndex = 23;
            // 
            // notify
            // 
            this.notify.Text = "单词书制作工具";
            this.notify.Visible = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 562);
            this.Controls.Add(this.tabcollection);
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "MainForm";
            this.Text = "单词书制作工具";
            this.toolkit.ResumeLayout(false);
            this.toolkit.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.listcreate.ResumeLayout(false);
            this.listcreate.PerformLayout();
            this.tabcollection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage toolkit;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox errorlog;
        private System.Windows.Forms.CheckBox tryfix;
        private System.Windows.Forms.ComboBox inputwait;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox readydelay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button startinput;
        private System.Windows.Forms.Button inputlistview;
        private System.Windows.Forms.TextBox inputlistpath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox groupnum;
        private System.Windows.Forms.CheckBox listgroup;
        private System.Windows.Forms.Button dolistact;
        private System.Windows.Forms.CheckBox listrandom;
        private System.Windows.Forms.CheckBox worddisct;
        private System.Windows.Forms.Button wordlistview;
        private System.Windows.Forms.TextBox wordlistpath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage listcreate;
        private System.Windows.Forms.ProgressBar listcreatebar;
        private System.Windows.Forms.LinkLabel myzone;
        private System.Windows.Forms.Button viewall;
        private System.Windows.Forms.Button viewsource;
        private System.Windows.Forms.Button onekeycreate;
        private System.Windows.Forms.TextBox allpath;
        private System.Windows.Forms.TextBox sourcepaths;
        private System.Windows.Forms.TextBox easypath;
        private System.Windows.Forms.Label sourcewords;
        private System.Windows.Forms.Label allwords;
        private System.Windows.Forms.Button vieweasy;
        private System.Windows.Forms.Label easywords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox leasttimes;
        private System.Windows.Forms.ComboBox leastlen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabcollection;
        private System.Windows.Forms.NotifyIcon notify;

    }
}

