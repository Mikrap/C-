namespace WinFormsApp1
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            Panel panel2;
            ListViewItem listViewItem1 = new ListViewItem("1");
            ListViewItem listViewItem2 = new ListViewItem("2");
            ListViewItem listViewItem3 = new ListViewItem("3");
            ListViewItem listViewItem4 = new ListViewItem("4");
            TreeNode treeNode1 = new TreeNode("звено1");
            TreeNode treeNode2 = new TreeNode("уровень1", new TreeNode[] { treeNode1 });
            TreeNode treeNode3 = new TreeNode("звено2");
            TreeNode treeNode4 = new TreeNode("уровень2", new TreeNode[] { treeNode3 });
            TreeNode treeNode5 = new TreeNode("звено3");
            TreeNode treeNode6 = new TreeNode("уровень3", new TreeNode[] { treeNode5 });
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            ок = new RadioButton();
            отмена = new RadioButton();
            groupBox2 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            radioButton9 = new RadioButton();
            radioButton10 = new RadioButton();
            radioButton11 = new RadioButton();
            radioButton12 = new RadioButton();
            radioButton13 = new RadioButton();
            radioButton14 = new RadioButton();
            radioButton15 = new RadioButton();
            radioButton16 = new RadioButton();
            radioButton17 = new RadioButton();
            radioButton18 = new RadioButton();
            radioButton19 = new RadioButton();
            radioButton20 = new RadioButton();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            groupBox3 = new GroupBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            checkedListBox1 = new CheckedListBox();
            numericUpDown1 = new NumericUpDown();
            domainUpDown1 = new DomainUpDown();
            imageList1 = new ImageList(components);
            listView1 = new ListView();
            treeView1 = new TreeView();
            trackBar1 = new TrackBar();
            timer1 = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            dateTimePicker1 = new DateTimePicker();
            monthCalendar1 = new MonthCalendar();
            pictureBox1 = new PictureBox();
            notifyIcon1 = new NotifyIcon(components);
            panel2 = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(38, 70);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "включить";
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(157, 70);
            button2.Name = "button2";
            button2.Size = new Size(85, 23);
            button2.TabIndex = 1;
            button2.Text = "выключить";
            button2.UseVisualStyleBackColor = true;
            button2.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(22, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(284, 153);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "действие1";
            groupBox1.UseWaitCursor = true;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // ок
            // 
            ок.AutoSize = true;
            ок.Location = new Point(67, 97);
            ок.Name = "ок";
            ок.Size = new Size(41, 19);
            ок.TabIndex = 3;
            ок.TabStop = true;
            ок.Text = "ОК";
            ок.UseVisualStyleBackColor = true;
            // 
            // отмена
            // 
            отмена.AutoSize = true;
            отмена.Location = new Point(153, 97);
            отмена.Name = "отмена";
            отмена.Size = new Size(65, 19);
            отмена.TabIndex = 4;
            отмена.TabStop = true;
            отмена.Text = "отмена";
            отмена.UseVisualStyleBackColor = true;
            отмена.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(отмена);
            groupBox2.Controls.Add(ок);
            groupBox2.Location = new Point(9, 17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(254, 153);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Действие2";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(17, 15);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(17, 43);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(17, 68);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(94, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(17, 93);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(94, 19);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(radioButton4);
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(radioButton3);
            panel2.Controls.Add(radioButton2);
            panel2.Location = new Point(409, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(175, 74);
            panel2.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(radioButton5);
            flowLayoutPanel1.Controls.Add(radioButton6);
            flowLayoutPanel1.Controls.Add(radioButton7);
            flowLayoutPanel1.Controls.Add(radioButton8);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(652, 136);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 100);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(3, 3);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(94, 19);
            radioButton5.TabIndex = 1;
            radioButton5.TabStop = true;
            radioButton5.Text = "radioButton5";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(3, 28);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(94, 19);
            radioButton6.TabIndex = 2;
            radioButton6.TabStop = true;
            radioButton6.Text = "radioButton6";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(3, 53);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(94, 19);
            radioButton7.TabIndex = 3;
            radioButton7.TabStop = true;
            radioButton7.Text = "radioButton7";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(3, 78);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(94, 19);
            radioButton8.TabIndex = 4;
            radioButton8.TabStop = true;
            radioButton8.Text = "radioButton8";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(radioButton17);
            flowLayoutPanel2.Controls.Add(radioButton18);
            flowLayoutPanel2.Controls.Add(radioButton19);
            flowLayoutPanel2.Controls.Add(radioButton20);
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(879, 22);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(241, 100);
            flowLayoutPanel2.TabIndex = 9;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(radioButton13);
            flowLayoutPanel3.Controls.Add(radioButton14);
            flowLayoutPanel3.Controls.Add(radioButton15);
            flowLayoutPanel3.Controls.Add(radioButton16);
            flowLayoutPanel3.Location = new Point(611, 22);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(241, 100);
            flowLayoutPanel3.TabIndex = 10;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(radioButton9);
            flowLayoutPanel4.Controls.Add(radioButton10);
            flowLayoutPanel4.Controls.Add(radioButton11);
            flowLayoutPanel4.Controls.Add(radioButton12);
            flowLayoutPanel4.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel4.Location = new Point(876, 136);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(200, 100);
            flowLayoutPanel4.TabIndex = 11;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(3, 78);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(94, 19);
            radioButton9.TabIndex = 5;
            radioButton9.TabStop = true;
            radioButton9.Text = "radioButton9";
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(3, 53);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(100, 19);
            radioButton10.TabIndex = 6;
            radioButton10.TabStop = true;
            radioButton10.Text = "radioButton10";
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            radioButton11.AutoSize = true;
            radioButton11.Location = new Point(3, 28);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(100, 19);
            radioButton11.TabIndex = 7;
            radioButton11.TabStop = true;
            radioButton11.Text = "radioButton11";
            radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            radioButton12.AutoSize = true;
            radioButton12.Location = new Point(3, 3);
            radioButton12.Name = "radioButton12";
            radioButton12.Size = new Size(100, 19);
            radioButton12.TabIndex = 8;
            radioButton12.TabStop = true;
            radioButton12.Text = "radioButton12";
            radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton13
            // 
            radioButton13.AutoSize = true;
            radioButton13.Location = new Point(3, 3);
            radioButton13.Name = "radioButton13";
            radioButton13.Size = new Size(100, 19);
            radioButton13.TabIndex = 2;
            radioButton13.TabStop = true;
            radioButton13.Text = "radioButton13";
            radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            radioButton14.AutoSize = true;
            radioButton14.Location = new Point(109, 3);
            radioButton14.Name = "radioButton14";
            radioButton14.Size = new Size(100, 19);
            radioButton14.TabIndex = 3;
            radioButton14.TabStop = true;
            radioButton14.Text = "radioButton14";
            radioButton14.UseVisualStyleBackColor = true;
            // 
            // radioButton15
            // 
            radioButton15.AutoSize = true;
            radioButton15.Location = new Point(3, 28);
            radioButton15.Name = "radioButton15";
            radioButton15.Size = new Size(100, 19);
            radioButton15.TabIndex = 4;
            radioButton15.TabStop = true;
            radioButton15.Text = "radioButton15";
            radioButton15.UseVisualStyleBackColor = true;
            // 
            // radioButton16
            // 
            radioButton16.AutoSize = true;
            radioButton16.Location = new Point(109, 28);
            radioButton16.Name = "radioButton16";
            radioButton16.Size = new Size(100, 19);
            radioButton16.TabIndex = 5;
            radioButton16.TabStop = true;
            radioButton16.Text = "radioButton16";
            radioButton16.UseVisualStyleBackColor = true;
            // 
            // radioButton17
            // 
            radioButton17.AutoSize = true;
            radioButton17.Location = new Point(138, 3);
            radioButton17.Name = "radioButton17";
            radioButton17.Size = new Size(100, 19);
            radioButton17.TabIndex = 2;
            radioButton17.TabStop = true;
            radioButton17.Text = "radioButton17";
            radioButton17.UseVisualStyleBackColor = true;
            // 
            // radioButton18
            // 
            radioButton18.AutoSize = true;
            radioButton18.Location = new Point(32, 3);
            radioButton18.Name = "radioButton18";
            radioButton18.Size = new Size(100, 19);
            radioButton18.TabIndex = 3;
            radioButton18.TabStop = true;
            radioButton18.Text = "radioButton18";
            radioButton18.UseVisualStyleBackColor = true;
            // 
            // radioButton19
            // 
            radioButton19.AutoSize = true;
            radioButton19.Location = new Point(138, 28);
            radioButton19.Name = "radioButton19";
            radioButton19.Size = new Size(100, 19);
            radioButton19.TabIndex = 4;
            radioButton19.TabStop = true;
            radioButton19.Text = "radioButton19";
            radioButton19.UseVisualStyleBackColor = true;
            // 
            // radioButton20
            // 
            radioButton20.AutoSize = true;
            radioButton20.Location = new Point(32, 28);
            radioButton20.Name = "radioButton20";
            radioButton20.Size = new Size(100, 19);
            radioButton20.TabIndex = 5;
            radioButton20.TabStop = true;
            radioButton20.Text = "radioButton20";
            radioButton20.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 22);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(365, 243);
            tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(357, 215);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "страница1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(357, 215);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "страница2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(357, 215);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "страница3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(38, 285);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(284, 114);
            splitContainer1.SplitterDistance = 94;
            splitContainer1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 710);
            label1.Name = "label1";
            label1.Size = new Size(169, 15);
            label1.TabIndex = 14;
            label1.Text = "Знакомство с windows forms ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.Location = new Point(197, 710);
            label2.Name = "label2";
            label2.Size = new Size(142, 15);
            label2.TabIndex = 15;
            label2.Text = "Худяков Кирилл 21ИСС1";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Maroon;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = SystemColors.ActiveCaption;
            linkLabel1.Location = new Point(360, 710);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(53, 15);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "ссылка1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(38, 421);
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(215, 23);
            textBox1.TabIndex = 17;
            textBox1.Text = "Окно ввода тектса";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(38, 467);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(199, 23);
            maskedTextBox1.TabIndex = 18;
            maskedTextBox1.Text = "masket tet box";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBox3);
            groupBox3.Controls.Add(checkBox2);
            groupBox3.Controls.Add(checkBox1);
            groupBox3.Location = new Point(865, 257);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(252, 142);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "check box";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(11, 32);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(71, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "хорошо";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoCheck = false;
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(11, 57);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(64, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "средне";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(11, 82);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(60, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "плохо";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Элемент1", "Элемент2", "Элемент3", "Элемент4" });
            listBox1.Location = new Point(596, 339);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(224, 169);
            listBox1.TabIndex = 20;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "номер", "почта", "фамилия ", "имя" });
            comboBox1.Location = new Point(652, 269);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 21;
            comboBox1.Text = "combo box";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "эл.1", "эл.2", "эл.3", "эл.4" });
            checkedListBox1.Location = new Point(409, 339);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 94);
            checkedListBox1.TabIndex = 22;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Hexadecimal = true;
            numericUpDown1.Location = new Point(409, 439);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 23;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Items.Add("номер№1");
            domainUpDown1.Items.Add("номер№2");
            domainUpDown1.Items.Add("номер№3");
            domainUpDown1.Items.Add("номер№4");
            domainUpDown1.Location = new Point(409, 485);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(120, 23);
            domainUpDown1.TabIndex = 24;
            domainUpDown1.Text = "domainUpDown1";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // listView1
            // 
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4 });
            listView1.Location = new Point(394, 128);
            listView1.Name = "listView1";
            listView1.Size = new Size(233, 187);
            listView1.TabIndex = 25;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(858, 421);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Узел5";
            treeNode1.Text = "звено1";
            treeNode2.Name = "Узел0";
            treeNode2.Text = "уровень1";
            treeNode3.Name = "Узел4";
            treeNode3.Text = "звено2";
            treeNode4.Name = "Узел1";
            treeNode4.Text = "уровень2";
            treeNode5.Name = "Узел3";
            treeNode5.Text = "звено3";
            treeNode6.Name = "Узел2";
            treeNode6.Text = "уровень3";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode2, treeNode4, treeNode6 });
            treeView1.Size = new Size(121, 97);
            treeView1.TabIndex = 26;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(285, 421);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(104, 45);
            trackBar1.TabIndex = 27;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(277, 485);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 23);
            progressBar1.TabIndex = 28;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(596, 525);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 29;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(614, 563);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 30;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(828, 576);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 130);
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // Form2
            // 
            AllowDrop = true;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1154, 749);
            Controls.Add(pictureBox1);
            Controls.Add(monthCalendar1);
            Controls.Add(dateTimePicker1);
            Controls.Add(progressBar1);
            Controls.Add(trackBar1);
            Controls.Add(treeView1);
            Controls.Add(listView1);
            Controls.Add(domainUpDown1);
            Controls.Add(numericUpDown1);
            Controls.Add(checkedListBox1);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(groupBox3);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(splitContainer1);
            Controls.Add(tabControl1);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Cursor = Cursors.Arrow;
            HelpButton = true;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private RadioButton ок;
        private RadioButton отмена;
        private GroupBox groupBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private RadioButton radioButton17;
        private RadioButton radioButton18;
        private RadioButton radioButton19;
        private RadioButton radioButton20;
        private RadioButton radioButton13;
        private RadioButton radioButton14;
        private RadioButton radioButton15;
        private RadioButton radioButton16;
        private FlowLayoutPanel flowLayoutPanel4;
        private RadioButton radioButton9;
        private RadioButton radioButton10;
        private RadioButton radioButton11;
        private RadioButton radioButton12;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private SplitContainer splitContainer1;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private GroupBox groupBox3;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private ListBox listBox1;
        private ComboBox comboBox1;
        private CheckedListBox checkedListBox1;
        private NumericUpDown numericUpDown1;
        private DomainUpDown domainUpDown1;
        private ImageList imageList1;
        private ListView listView1;
        private TreeView treeView1;
        private TrackBar trackBar1;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBar1;
        private DateTimePicker dateTimePicker1;
        private MonthCalendar monthCalendar1;
        private PictureBox pictureBox1;
        private NotifyIcon notifyIcon1;
    }
}