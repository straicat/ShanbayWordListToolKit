namespace 单词书创建
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.easywords = new System.Windows.Forms.Label();
            this.easypath = new System.Windows.Forms.TextBox();
            this.vieweasy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.leastlen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.leasttimes = new System.Windows.Forms.ComboBox();
            this.onekeycreate = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.autofix = new System.Windows.Forms.CheckBox();
            this.showtimes = new System.Windows.Forms.CheckBox();
            this.viewall = new System.Windows.Forms.Button();
            this.viewsource = new System.Windows.Forms.Button();
            this.allpath = new System.Windows.Forms.TextBox();
            this.sourcewords = new System.Windows.Forms.Label();
            this.allwords = new System.Windows.Forms.Label();
            this.sourcepaths = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tryfix = new System.Windows.Forms.CheckBox();
            this.clickspan = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.yundic = new System.Windows.Forms.TabPage();
            this.wordinfo = new System.Windows.Forms.RichTextBox();
            this.query = new System.Windows.Forms.Button();
            this.tarword = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.shanbeidic = new System.Windows.Forms.RadioButton();
            this.help = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.janeeyre = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.yundic.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.help.SuspendLayout();
            this.SuspendLayout();
            // 
            // easywords
            // 
            this.easywords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.easywords.AutoSize = true;
            this.easywords.Location = new System.Drawing.Point(8, 221);
            this.easywords.Name = "easywords";
            this.easywords.Size = new System.Drawing.Size(53, 12);
            this.easywords.TabIndex = 6;
            this.easywords.Text = "过滤词表";
            // 
            // easypath
            // 
            this.easypath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.easypath.Location = new System.Drawing.Point(67, 221);
            this.easypath.Multiline = true;
            this.easypath.Name = "easypath";
            this.easypath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.easypath.Size = new System.Drawing.Size(310, 100);
            this.easypath.TabIndex = 7;
            this.easypath.TextChanged += new System.EventHandler(this.easypath_TextChanged);
            // 
            // vieweasy
            // 
            this.vieweasy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.vieweasy.Location = new System.Drawing.Point(391, 221);
            this.vieweasy.Name = "vieweasy";
            this.vieweasy.Size = new System.Drawing.Size(75, 23);
            this.vieweasy.TabIndex = 8;
            this.vieweasy.Text = "浏览";
            this.vieweasy.UseVisualStyleBackColor = true;
            this.vieweasy.Click += new System.EventHandler(this.vieweasy_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "长度过滤";
            // 
            // leastlen
            // 
            this.leastlen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.leastlen.FormattingEnabled = true;
            this.leastlen.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.leastlen.Location = new System.Drawing.Point(346, 343);
            this.leastlen.Name = "leastlen";
            this.leastlen.Size = new System.Drawing.Size(120, 20);
            this.leastlen.TabIndex = 10;
            this.leastlen.Text = "5";
            this.leastlen.SelectedIndexChanged += new System.EventHandler(this.leastlen_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "词频过滤";
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
            this.leasttimes.Location = new System.Drawing.Point(67, 343);
            this.leasttimes.Name = "leasttimes";
            this.leasttimes.Size = new System.Drawing.Size(124, 20);
            this.leasttimes.TabIndex = 13;
            this.leasttimes.Text = "3";
            this.leasttimes.SelectedIndexChanged += new System.EventHandler(this.leasttimes_SelectedIndexChanged);
            // 
            // onekeycreate
            // 
            this.onekeycreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.onekeycreate.BackColor = System.Drawing.SystemColors.Control;
            this.onekeycreate.Cursor = System.Windows.Forms.Cursors.Default;
            this.onekeycreate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.onekeycreate.Location = new System.Drawing.Point(127, 473);
            this.onekeycreate.Name = "onekeycreate";
            this.onekeycreate.Size = new System.Drawing.Size(233, 34);
            this.onekeycreate.TabIndex = 21;
            this.onekeycreate.Text = "一键制作";
            this.onekeycreate.UseVisualStyleBackColor = false;
            this.onekeycreate.Click += new System.EventHandler(this.onekeycreate_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.yundic);
            this.tabControl1.Controls.Add(this.help);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(484, 562);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.autofix);
            this.tabPage1.Controls.Add(this.showtimes);
            this.tabPage1.Controls.Add(this.viewall);
            this.tabPage1.Controls.Add(this.viewsource);
            this.tabPage1.Controls.Add(this.onekeycreate);
            this.tabPage1.Controls.Add(this.allpath);
            this.tabPage1.Controls.Add(this.sourcewords);
            this.tabPage1.Controls.Add(this.allwords);
            this.tabPage1.Controls.Add(this.sourcepaths);
            this.tabPage1.Controls.Add(this.vieweasy);
            this.tabPage1.Controls.Add(this.easywords);
            this.tabPage1.Controls.Add(this.easypath);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.leasttimes);
            this.tabPage1.Controls.Add(this.leastlen);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(476, 536);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "词表创建";
            // 
            // autofix
            // 
            this.autofix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.autofix.AutoSize = true;
            this.autofix.Location = new System.Drawing.Point(67, 400);
            this.autofix.Name = "autofix";
            this.autofix.Size = new System.Drawing.Size(72, 16);
            this.autofix.TabIndex = 22;
            this.autofix.Text = "自动修正";
            this.autofix.UseVisualStyleBackColor = true;
            this.autofix.CheckedChanged += new System.EventHandler(this.autofix_CheckedChanged);
            // 
            // showtimes
            // 
            this.showtimes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showtimes.AutoSize = true;
            this.showtimes.Location = new System.Drawing.Point(288, 400);
            this.showtimes.Name = "showtimes";
            this.showtimes.Size = new System.Drawing.Size(72, 16);
            this.showtimes.TabIndex = 0;
            this.showtimes.Text = "显示词频";
            this.showtimes.UseVisualStyleBackColor = true;
            // 
            // viewall
            // 
            this.viewall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.viewall.Location = new System.Drawing.Point(391, 118);
            this.viewall.Name = "viewall";
            this.viewall.Size = new System.Drawing.Size(75, 23);
            this.viewall.TabIndex = 5;
            this.viewall.Text = "浏览";
            this.viewall.UseVisualStyleBackColor = true;
            this.viewall.Click += new System.EventHandler(this.button1_Click);
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
            // allpath
            // 
            this.allpath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allpath.Location = new System.Drawing.Point(67, 118);
            this.allpath.Multiline = true;
            this.allpath.Name = "allpath";
            this.allpath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.allpath.Size = new System.Drawing.Size(310, 100);
            this.allpath.TabIndex = 4;
            this.allpath.TextChanged += new System.EventHandler(this.allpath_TextChanged);
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
            this.allwords.Location = new System.Drawing.Point(8, 118);
            this.allwords.Name = "allwords";
            this.allwords.Size = new System.Drawing.Size(53, 12);
            this.allwords.TabIndex = 3;
            this.allwords.Text = "大纲词汇";
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
            this.sourcepaths.Size = new System.Drawing.Size(310, 100);
            this.sourcepaths.TabIndex = 1;
            this.sourcepaths.TextChanged += new System.EventHandler(this.sourcepath_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(476, 536);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "工具箱";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tryfix);
            this.groupBox2.Controls.Add(this.clickspan);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.inputwait);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.readydelay);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.startinput);
            this.groupBox2.Controls.Add(this.inputlistview);
            this.groupBox2.Controls.Add(this.inputlistpath);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(8, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 228);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "自动输入";
            // 
            // tryfix
            // 
            this.tryfix.AutoSize = true;
            this.tryfix.Location = new System.Drawing.Point(11, 131);
            this.tryfix.Name = "tryfix";
            this.tryfix.Size = new System.Drawing.Size(72, 16);
            this.tryfix.TabIndex = 17;
            this.tryfix.Text = "尝试修正";
            this.tryfix.UseVisualStyleBackColor = true;
            this.tryfix.Visible = false;
            // 
            // clickspan
            // 
            this.clickspan.FormattingEnabled = true;
            this.clickspan.Items.AddRange(new object[] {
            "100",
            "200",
            "500",
            "800"});
            this.clickspan.Location = new System.Drawing.Point(393, 76);
            this.clickspan.Name = "clickspan";
            this.clickspan.Size = new System.Drawing.Size(59, 20);
            this.clickspan.TabIndex = 16;
            this.clickspan.Text = "500";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "击键间隔(ms)";
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
            this.inputwait.Location = new System.Drawing.Point(228, 75);
            this.inputwait.Name = "inputwait";
            this.inputwait.Size = new System.Drawing.Size(76, 20);
            this.inputwait.TabIndex = 14;
            this.inputwait.Text = "1000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "等待时延(ms)";
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
            this.readydelay.Location = new System.Drawing.Point(86, 76);
            this.readydelay.Name = "readydelay";
            this.readydelay.Size = new System.Drawing.Size(53, 20);
            this.readydelay.TabIndex = 12;
            this.readydelay.Text = "5";
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
            this.startinput.Location = new System.Drawing.Point(169, 170);
            this.startinput.Name = "startinput";
            this.startinput.Size = new System.Drawing.Size(103, 37);
            this.startinput.TabIndex = 10;
            this.startinput.Text = "开始";
            this.startinput.UseVisualStyleBackColor = true;
            this.startinput.Click += new System.EventHandler(this.startinput_Click);
            // 
            // inputlistview
            // 
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
            this.inputlistpath.Location = new System.Drawing.Point(66, 30);
            this.inputlistpath.Name = "inputlistpath";
            this.inputlistpath.Size = new System.Drawing.Size(283, 21);
            this.inputlistpath.TabIndex = 1;
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
            this.groupBox1.Size = new System.Drawing.Size(458, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "词表处理";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "组数：";
            // 
            // groupnum
            // 
            this.groupnum.Enabled = false;
            this.groupnum.FormattingEnabled = true;
            this.groupnum.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.groupnum.Location = new System.Drawing.Point(137, 117);
            this.groupnum.Name = "groupnum";
            this.groupnum.Size = new System.Drawing.Size(121, 20);
            this.groupnum.TabIndex = 9;
            this.groupnum.Text = "10";
            // 
            // listgroup
            // 
            this.listgroup.AutoSize = true;
            this.listgroup.Location = new System.Drawing.Point(18, 119);
            this.listgroup.Name = "listgroup";
            this.listgroup.Size = new System.Drawing.Size(72, 16);
            this.listgroup.TabIndex = 8;
            this.listgroup.Text = "词表分组";
            this.listgroup.UseVisualStyleBackColor = true;
            this.listgroup.CheckedChanged += new System.EventHandler(this.listgroup_CheckedChanged);
            // 
            // dolistact
            // 
            this.dolistact.Location = new System.Drawing.Point(169, 209);
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
            this.listrandom.Location = new System.Drawing.Point(277, 74);
            this.listrandom.Name = "listrandom";
            this.listrandom.Size = new System.Drawing.Size(72, 16);
            this.listrandom.TabIndex = 5;
            this.listrandom.Text = "词表乱序";
            this.listrandom.UseVisualStyleBackColor = true;
            // 
            // worddisct
            // 
            this.worddisct.AutoSize = true;
            this.worddisct.Location = new System.Drawing.Point(18, 74);
            this.worddisct.Name = "worddisct";
            this.worddisct.Size = new System.Drawing.Size(72, 16);
            this.worddisct.TabIndex = 4;
            this.worddisct.Text = "词表去重";
            this.worddisct.UseVisualStyleBackColor = true;
            // 
            // wordlistview
            // 
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
            this.wordlistpath.Location = new System.Drawing.Point(66, 29);
            this.wordlistpath.Name = "wordlistpath";
            this.wordlistpath.Size = new System.Drawing.Size(283, 21);
            this.wordlistpath.TabIndex = 2;
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
            // yundic
            // 
            this.yundic.BackColor = System.Drawing.SystemColors.Control;
            this.yundic.Controls.Add(this.wordinfo);
            this.yundic.Controls.Add(this.query);
            this.yundic.Controls.Add(this.tarword);
            this.yundic.Controls.Add(this.groupBox3);
            this.yundic.Location = new System.Drawing.Point(4, 22);
            this.yundic.Name = "yundic";
            this.yundic.Size = new System.Drawing.Size(476, 536);
            this.yundic.TabIndex = 4;
            this.yundic.Text = "在线词典";
            // 
            // wordinfo
            // 
            this.wordinfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wordinfo.Location = new System.Drawing.Point(0, 246);
            this.wordinfo.Name = "wordinfo";
            this.wordinfo.ReadOnly = true;
            this.wordinfo.Size = new System.Drawing.Size(476, 290);
            this.wordinfo.TabIndex = 3;
            this.wordinfo.Text = "";
            // 
            // query
            // 
            this.query.Location = new System.Drawing.Point(357, 155);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(75, 23);
            this.query.TabIndex = 2;
            this.query.Text = "查询";
            this.query.UseVisualStyleBackColor = true;
            this.query.Click += new System.EventHandler(this.query_Click);
            // 
            // tarword
            // 
            this.tarword.Location = new System.Drawing.Point(57, 157);
            this.tarword.Name = "tarword";
            this.tarword.Size = new System.Drawing.Size(280, 21);
            this.tarword.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.shanbeidic);
            this.groupBox3.Location = new System.Drawing.Point(9, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(459, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查词引擎";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(171, 36);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "韦氏词典";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            // 
            // shanbeidic
            // 
            this.shanbeidic.AutoSize = true;
            this.shanbeidic.Checked = true;
            this.shanbeidic.Location = new System.Drawing.Point(24, 36);
            this.shanbeidic.Name = "shanbeidic";
            this.shanbeidic.Size = new System.Drawing.Size(59, 16);
            this.shanbeidic.TabIndex = 0;
            this.shanbeidic.TabStop = true;
            this.shanbeidic.Text = "扇贝网";
            this.shanbeidic.UseVisualStyleBackColor = true;
            // 
            // help
            // 
            this.help.Controls.Add(this.janeeyre);
            this.help.Controls.Add(this.richTextBox1);
            this.help.Location = new System.Drawing.Point(4, 22);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(476, 536);
            this.help.TabIndex = 3;
            this.help.Text = "帮助";
            this.help.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(465, 525);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "欢迎使用~\n由于平时比较忙，本软件的开发一般在周末进行，时间不多，所以暂时不能为您提供详尽的帮助文档，敬请谅解。\n如果觉得本软件不错，可以支持作者。我制作的单词书" +
    "链接：\n";
            // 
            // janeeyre
            // 
            this.janeeyre.AutoSize = true;
            this.janeeyre.Location = new System.Drawing.Point(8, 80);
            this.janeeyre.Name = "janeeyre";
            this.janeeyre.Size = new System.Drawing.Size(119, 12);
            this.janeeyre.TabIndex = 1;
            this.janeeyre.TabStop = true;
            this.janeeyre.Text = "简·爱（Jane Eyre）";
            this.janeeyre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.janeeyre_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 562);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "Form1";
            this.Text = "单词书制作工具（By Jacky）";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.yundic.ResumeLayout(false);
            this.yundic.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.help.ResumeLayout(false);
            this.help.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label easywords;
        private System.Windows.Forms.TextBox easypath;
        private System.Windows.Forms.Button vieweasy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox leastlen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox leasttimes;
        private System.Windows.Forms.Button onekeycreate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label allwords;
        private System.Windows.Forms.TextBox allpath;
        private System.Windows.Forms.Button viewall;
        private System.Windows.Forms.Label sourcewords;
        private System.Windows.Forms.TextBox sourcepaths;
        private System.Windows.Forms.Button viewsource;
        private System.Windows.Forms.TabPage help;
        private System.Windows.Forms.CheckBox showtimes;
        private System.Windows.Forms.CheckBox autofix;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.TabPage yundic;
        private System.Windows.Forms.Button query;
        private System.Windows.Forms.TextBox tarword;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton shanbeidic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox readydelay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox clickspan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox inputwait;
        private System.Windows.Forms.CheckBox tryfix;
        private System.Windows.Forms.RichTextBox wordinfo;
        private System.Windows.Forms.LinkLabel janeeyre;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

