namespace Library_Management_System
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.amgcb = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.amnictb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ameatb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.amdp = new System.Windows.Forms.DateTimePicker();
            this.amratb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.amctb = new System.Windows.Forms.TextBox();
            this.ambtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amutb = new System.Windows.Forms.TextBox();
            this.amptb = new System.Windows.Forms.TextBox();
            this.amfntb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.umdccb = new System.Windows.Forms.ComboBox();
            this.umdbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.umdttb = new System.Windows.Forms.TextBox();
            this.umdmidtb = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dmmidtb = new System.Windows.Forms.TextBox();
            this.dmbtn = new System.Windows.Forms.Button();
            this.libraryDatabaseDataSet = new Library_Management_System.LibraryDatabaseDataSet();
            this.memberDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberDetailsTableAdapter = new Library_Management_System.LibraryDatabaseDataSetTableAdapters.MemberDetailsTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.amgcb);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.amnictb);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.ameatb);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.amdp);
            this.groupBox1.Controls.Add(this.amratb);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.amctb);
            this.groupBox1.Controls.Add(this.ambtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.amutb);
            this.groupBox1.Controls.Add(this.amptb);
            this.groupBox1.Controls.Add(this.amfntb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(13, 129);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1207, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A d d   M e m b e r";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // amgcb
            // 
            this.amgcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.amgcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amgcb.FormattingEnabled = true;
            this.amgcb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.amgcb.Location = new System.Drawing.Point(632, 53);
            this.amgcb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.amgcb.Name = "amgcb";
            this.amgcb.Size = new System.Drawing.Size(230, 21);
            this.amgcb.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(629, 79);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Username:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(400, 122);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "National Identity no:";
            // 
            // amnictb
            // 
            this.amnictb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amnictb.Location = new System.Drawing.Point(403, 140);
            this.amnictb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.amnictb.Name = "amnictb";
            this.amnictb.Size = new System.Drawing.Size(202, 20);
            this.amnictb.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(51, 122);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Email Address:";
            // 
            // ameatb
            // 
            this.ameatb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ameatb.Location = new System.Drawing.Point(54, 140);
            this.ameatb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ameatb.Name = "ameatb";
            this.ameatb.Size = new System.Drawing.Size(323, 20);
            this.ameatb.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(400, 36);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Date of Birth:";
            // 
            // amdp
            // 
            this.amdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amdp.Location = new System.Drawing.Point(403, 54);
            this.amdp.Name = "amdp";
            this.amdp.Size = new System.Drawing.Size(202, 20);
            this.amdp.TabIndex = 11;
            // 
            // amratb
            // 
            this.amratb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amratb.Location = new System.Drawing.Point(54, 97);
            this.amratb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.amratb.Name = "amratb";
            this.amratb.Size = new System.Drawing.Size(323, 20);
            this.amratb.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(51, 79);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Residential Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(401, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Contact no:";
            // 
            // amctb
            // 
            this.amctb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amctb.Location = new System.Drawing.Point(403, 97);
            this.amctb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.amctb.Name = "amctb";
            this.amctb.Size = new System.Drawing.Size(202, 20);
            this.amctb.TabIndex = 7;
            // 
            // ambtn
            // 
            this.ambtn.BackColor = System.Drawing.Color.Black;
            this.ambtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ambtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ambtn.Location = new System.Drawing.Point(1052, 131);
            this.ambtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ambtn.Name = "ambtn";
            this.ambtn.Size = new System.Drawing.Size(112, 35);
            this.ambtn.TabIndex = 6;
            this.ambtn.Text = "ADD";
            this.ambtn.UseVisualStyleBackColor = false;
            this.ambtn.Click += new System.EventHandler(this.ambtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(629, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(629, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gender:";
            // 
            // amutb
            // 
            this.amutb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amutb.Location = new System.Drawing.Point(632, 97);
            this.amutb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.amutb.Name = "amutb";
            this.amutb.Size = new System.Drawing.Size(230, 20);
            this.amutb.TabIndex = 3;
            // 
            // amptb
            // 
            this.amptb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amptb.Location = new System.Drawing.Point(632, 140);
            this.amptb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.amptb.Name = "amptb";
            this.amptb.Size = new System.Drawing.Size(230, 20);
            this.amptb.TabIndex = 2;
            // 
            // amfntb
            // 
            this.amfntb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amfntb.Location = new System.Drawing.Point(54, 54);
            this.amfntb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.amfntb.Name = "amfntb";
            this.amfntb.Size = new System.Drawing.Size(323, 20);
            this.amfntb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.umdccb);
            this.groupBox2.Controls.Add(this.umdbtn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.umdttb);
            this.groupBox2.Controls.Add(this.umdmidtb);
            this.groupBox2.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox2.Location = new System.Drawing.Point(13, 352);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1207, 154);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "U p d a t e   M e m b e r   D e t a i l";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(54, 108);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(65, 26);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "UID";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(394, 81);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Change:";
            // 
            // umdccb
            // 
            this.umdccb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.umdccb.FormattingEnabled = true;
            this.umdccb.Items.AddRange(new object[] {
            "U_FullName",
            "U_NIC",
            "U_Address",
            "U_Email",
            "U_Gender",
            "Username",
            "Password"});
            this.umdccb.Location = new System.Drawing.Point(398, 104);
            this.umdccb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.umdccb.Name = "umdccb";
            this.umdccb.Size = new System.Drawing.Size(207, 28);
            this.umdccb.TabIndex = 9;
            // 
            // umdbtn
            // 
            this.umdbtn.BackColor = System.Drawing.Color.Black;
            this.umdbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.umdbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.umdbtn.Location = new System.Drawing.Point(1052, 99);
            this.umdbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.umdbtn.Name = "umdbtn";
            this.umdbtn.Size = new System.Drawing.Size(112, 35);
            this.umdbtn.TabIndex = 7;
            this.umdbtn.Text = "UPDATE";
            this.umdbtn.UseVisualStyleBackColor = false;
            this.umdbtn.Click += new System.EventHandler(this.umdbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(628, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "To:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Member ID:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // umdttb
            // 
            this.umdttb.Location = new System.Drawing.Point(632, 106);
            this.umdttb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.umdttb.Name = "umdttb";
            this.umdttb.Size = new System.Drawing.Size(230, 26);
            this.umdttb.TabIndex = 1;
            // 
            // umdmidtb
            // 
            this.umdmidtb.Location = new System.Drawing.Point(126, 108);
            this.umdmidtb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.umdmidtb.Name = "umdmidtb";
            this.umdmidtb.Size = new System.Drawing.Size(251, 26);
            this.umdmidtb.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dmmidtb);
            this.groupBox3.Controls.Add(this.dmbtn);
            this.groupBox3.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox3.Location = new System.Drawing.Point(13, 538);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(1207, 154);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "D e l e t e   M e m b e r";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(54, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(65, 26);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "UID";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(50, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Member ID:";
            // 
            // dmmidtb
            // 
            this.dmmidtb.Location = new System.Drawing.Point(126, 103);
            this.dmmidtb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dmmidtb.Name = "dmmidtb";
            this.dmmidtb.Size = new System.Drawing.Size(230, 26);
            this.dmmidtb.TabIndex = 9;
            // 
            // dmbtn
            // 
            this.dmbtn.BackColor = System.Drawing.Color.Black;
            this.dmbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dmbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dmbtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.dmbtn.Location = new System.Drawing.Point(1052, 96);
            this.dmbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dmbtn.Name = "dmbtn";
            this.dmbtn.Size = new System.Drawing.Size(112, 35);
            this.dmbtn.TabIndex = 6;
            this.dmbtn.Text = "DELETE";
            this.dmbtn.UseVisualStyleBackColor = false;
            this.dmbtn.Click += new System.EventHandler(this.dmbtn_Click);
            // 
            // libraryDatabaseDataSet
            // 
            this.libraryDatabaseDataSet.DataSetName = "LibraryDatabaseDataSet";
            this.libraryDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberDetailsBindingSource
            // 
            this.memberDetailsBindingSource.DataMember = "MemberDetails";
            this.memberDetailsBindingSource.DataSource = this.libraryDatabaseDataSet;
            // 
            // memberDetailsTableAdapter
            // 
            this.memberDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(-34, -31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1281, 126);
            this.textBox1.TabIndex = 11;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "     \r\n     NSBM\r\n     Smart Library System\r\n";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Library_Management_System.Properties.Resources.menu;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1158, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 75);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1233, 749);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Management Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox amctb;
        private System.Windows.Forms.Button ambtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amutb;
        private System.Windows.Forms.TextBox amptb;
        private System.Windows.Forms.TextBox amfntb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button umdbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox umdttb;
        private System.Windows.Forms.TextBox umdmidtb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dmmidtb;
        private System.Windows.Forms.Button dmbtn;
        private System.Windows.Forms.ComboBox umdccb;
        private LibraryDatabaseDataSet libraryDatabaseDataSet;
        private System.Windows.Forms.BindingSource memberDetailsBindingSource;
        private LibraryDatabaseDataSetTableAdapters.MemberDetailsTableAdapter memberDetailsTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox amgcb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox amnictb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ameatb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker amdp;
        private System.Windows.Forms.TextBox amratb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
    }
}

