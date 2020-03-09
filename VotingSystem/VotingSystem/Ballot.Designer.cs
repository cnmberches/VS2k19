namespace VotingSystem
{
    partial class Ballot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ballot));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dept_representation = new System.Windows.Forms.Button();
            this.vp_finance = new System.Windows.Forms.Button();
            this.vp_acad = new System.Windows.Forms.Button();
            this.vp_operation = new System.Windows.Forms.Button();
            this.vp_external = new System.Windows.Forms.Button();
            this.vp_internal = new System.Windows.Forms.Button();
            this.President = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_candidate_name1 = new System.Windows.Forms.Label();
            this.txt_candidate_name2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listview_achievement1 = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView5 = new System.Windows.Forms.ListView();
            this.listview_achievement2 = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView_Platform2 = new System.Windows.Forms.ListView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listView_Platform1 = new System.Windows.Forms.ListView();
            this.vote_party1_btn = new System.Windows.Forms.Button();
            this.vote_party2_btn = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_candidate_nickname2 = new System.Windows.Forms.Label();
            this.txt_candidate_nickname1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1460, 40);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.label2.Location = new System.Drawing.Point(1437, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ballot Form";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.dept_representation);
            this.panel2.Controls.Add(this.vp_finance);
            this.panel2.Controls.Add(this.vp_acad);
            this.panel2.Controls.Add(this.vp_operation);
            this.panel2.Controls.Add(this.vp_external);
            this.panel2.Controls.Add(this.vp_internal);
            this.panel2.Controls.Add(this.President);
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 798);
            this.panel2.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.panel8.Location = new System.Drawing.Point(7, 448);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(240, 1);
            this.panel8.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.panel7.Location = new System.Drawing.Point(7, 104);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(240, 1);
            this.panel7.TabIndex = 7;
            // 
            // dept_representation
            // 
            this.dept_representation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dept_representation.FlatAppearance.BorderSize = 0;
            this.dept_representation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dept_representation.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dept_representation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dept_representation.Location = new System.Drawing.Point(-6, 399);
            this.dept_representation.Name = "dept_representation";
            this.dept_representation.Size = new System.Drawing.Size(266, 43);
            this.dept_representation.TabIndex = 6;
            this.dept_representation.TabStop = false;
            this.dept_representation.Text = "Department Representation";
            this.dept_representation.UseVisualStyleBackColor = true;
            this.dept_representation.Click += new System.EventHandler(this.dept_representation_Click);
            this.dept_representation.Enter += new System.EventHandler(this.dept_representation_Enter);
            this.dept_representation.Leave += new System.EventHandler(this.dept_representation_Leave);
            // 
            // vp_finance
            // 
            this.vp_finance.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.vp_finance.FlatAppearance.BorderSize = 0;
            this.vp_finance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vp_finance.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vp_finance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.vp_finance.Location = new System.Drawing.Point(-5, 351);
            this.vp_finance.Name = "vp_finance";
            this.vp_finance.Size = new System.Drawing.Size(265, 43);
            this.vp_finance.TabIndex = 5;
            this.vp_finance.TabStop = false;
            this.vp_finance.Text = "Vice President For Finance";
            this.vp_finance.UseVisualStyleBackColor = true;
            this.vp_finance.Click += new System.EventHandler(this.vp_finance_Click);
            this.vp_finance.Enter += new System.EventHandler(this.vp_finance_Enter);
            this.vp_finance.Leave += new System.EventHandler(this.vp_finance_Leave);
            // 
            // vp_acad
            // 
            this.vp_acad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.vp_acad.FlatAppearance.BorderSize = 0;
            this.vp_acad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vp_acad.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vp_acad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.vp_acad.Location = new System.Drawing.Point(-6, 159);
            this.vp_acad.Name = "vp_acad";
            this.vp_acad.Size = new System.Drawing.Size(267, 43);
            this.vp_acad.TabIndex = 4;
            this.vp_acad.TabStop = false;
            this.vp_acad.Text = "Vice President For Academic Affairs";
            this.vp_acad.UseVisualStyleBackColor = true;
            this.vp_acad.Click += new System.EventHandler(this.vp_acad_Click);
            this.vp_acad.Enter += new System.EventHandler(this.button5_Enter);
            this.vp_acad.Leave += new System.EventHandler(this.vp_acad_Leave);
            // 
            // vp_operation
            // 
            this.vp_operation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.vp_operation.FlatAppearance.BorderSize = 0;
            this.vp_operation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vp_operation.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vp_operation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.vp_operation.Location = new System.Drawing.Point(-6, 303);
            this.vp_operation.Name = "vp_operation";
            this.vp_operation.Size = new System.Drawing.Size(265, 43);
            this.vp_operation.TabIndex = 3;
            this.vp_operation.TabStop = false;
            this.vp_operation.Text = "Vice President For Operations";
            this.vp_operation.UseVisualStyleBackColor = true;
            this.vp_operation.Click += new System.EventHandler(this.vp_operation_Click);
            this.vp_operation.Enter += new System.EventHandler(this.vp_operation_Enter);
            this.vp_operation.Leave += new System.EventHandler(this.vp_operation_Leave);
            // 
            // vp_external
            // 
            this.vp_external.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.vp_external.FlatAppearance.BorderSize = 0;
            this.vp_external.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vp_external.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vp_external.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.vp_external.Location = new System.Drawing.Point(-5, 255);
            this.vp_external.Name = "vp_external";
            this.vp_external.Size = new System.Drawing.Size(266, 43);
            this.vp_external.TabIndex = 2;
            this.vp_external.TabStop = false;
            this.vp_external.Text = "Vice President For External Affairs";
            this.vp_external.UseVisualStyleBackColor = true;
            this.vp_external.Click += new System.EventHandler(this.vp_external_Click);
            this.vp_external.Enter += new System.EventHandler(this.vp_external_Enter);
            this.vp_external.Leave += new System.EventHandler(this.vp_external_Leave);
            // 
            // vp_internal
            // 
            this.vp_internal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.vp_internal.FlatAppearance.BorderSize = 0;
            this.vp_internal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vp_internal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vp_internal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.vp_internal.Location = new System.Drawing.Point(-5, 207);
            this.vp_internal.Name = "vp_internal";
            this.vp_internal.Size = new System.Drawing.Size(264, 43);
            this.vp_internal.TabIndex = 1;
            this.vp_internal.TabStop = false;
            this.vp_internal.Text = "Vice President For Internal Affairs";
            this.vp_internal.UseVisualStyleBackColor = true;
            this.vp_internal.Click += new System.EventHandler(this.vp_internal_Click);
            this.vp_internal.Enter += new System.EventHandler(this.vp_internal_Enter);
            this.vp_internal.Leave += new System.EventHandler(this.vp_internal_Leave);
            // 
            // President
            // 
            this.President.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.President.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.President.FlatAppearance.BorderSize = 0;
            this.President.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.President.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.President.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.President.Location = new System.Drawing.Point(-4, 111);
            this.President.Name = "President";
            this.President.Size = new System.Drawing.Size(265, 43);
            this.President.TabIndex = 0;
            this.President.TabStop = false;
            this.President.Text = "President";
            this.President.UseVisualStyleBackColor = false;
            this.President.Click += new System.EventHandler(this.President_Click);
            this.President.Enter += new System.EventHandler(this.President_Enter);
            this.President.Leave += new System.EventHandler(this.President_Leave);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(62)))));
            this.panel9.Location = new System.Drawing.Point(0, 835);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1460, 40);
            this.panel9.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(62)))));
            this.label6.Location = new System.Drawing.Point(510, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Partylist1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(62)))));
            this.label7.Location = new System.Drawing.Point(1122, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Partylist2";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(62)))));
            this.panel4.Location = new System.Drawing.Point(471, 187);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(163, 2);
            this.panel4.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(62)))));
            this.panel5.Location = new System.Drawing.Point(1080, 187);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(170, 2);
            this.panel5.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(62)))));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.panel3.Location = new System.Drawing.Point(401, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(403, 2);
            this.panel3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.label4.Location = new System.Drawing.Point(543, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "July 31, 2019";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.label3.Location = new System.Drawing.Point(426, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "CSG OFFICIAL BALLOT";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.panel6.Location = new System.Drawing.Point(849, 172);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 612);
            this.panel6.TabIndex = 40;
            // 
            // txt_candidate_name1
            // 
            this.txt_candidate_name1.AutoSize = true;
            this.txt_candidate_name1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_candidate_name1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.txt_candidate_name1.Location = new System.Drawing.Point(327, 205);
            this.txt_candidate_name1.Name = "txt_candidate_name1";
            this.txt_candidate_name1.Size = new System.Drawing.Size(130, 29);
            this.txt_candidate_name1.TabIndex = 41;
            this.txt_candidate_name1.Text = "Name here";
            // 
            // txt_candidate_name2
            // 
            this.txt_candidate_name2.AutoSize = true;
            this.txt_candidate_name2.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_candidate_name2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.txt_candidate_name2.Location = new System.Drawing.Point(931, 205);
            this.txt_candidate_name2.Name = "txt_candidate_name2";
            this.txt_candidate_name2.Size = new System.Drawing.Size(130, 29);
            this.txt_candidate_name2.TabIndex = 42;
            this.txt_candidate_name2.Text = "Name here";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listview_achievement1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.groupBox1.Location = new System.Drawing.Point(333, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 235);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Achievements";
            // 
            // listview_achievement1
            // 
            this.listview_achievement1.BackColor = System.Drawing.Color.White;
            this.listview_achievement1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listview_achievement1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listview_achievement1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(62)))));
            this.listview_achievement1.HideSelection = false;
            this.listview_achievement1.Location = new System.Drawing.Point(6, 28);
            this.listview_achievement1.Name = "listview_achievement1";
            this.listview_achievement1.Size = new System.Drawing.Size(427, 201);
            this.listview_achievement1.TabIndex = 61;
            this.listview_achievement1.UseCompatibleStateImageBehavior = false;
            this.listview_achievement1.View = System.Windows.Forms.View.List;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView5);
            this.groupBox2.Controls.Add(this.listview_achievement2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.groupBox2.Location = new System.Drawing.Point(937, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 235);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Achievements";
            // 
            // listView5
            // 
            this.listView5.BackColor = System.Drawing.Color.White;
            this.listView5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView5.HideSelection = false;
            this.listView5.Location = new System.Drawing.Point(12, 292);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(427, 193);
            this.listView5.TabIndex = 63;
            this.listView5.UseCompatibleStateImageBehavior = false;
            this.listView5.View = System.Windows.Forms.View.List;
            // 
            // listview_achievement2
            // 
            this.listview_achievement2.BackColor = System.Drawing.Color.White;
            this.listview_achievement2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listview_achievement2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listview_achievement2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(62)))));
            this.listview_achievement2.HideSelection = false;
            this.listview_achievement2.Location = new System.Drawing.Point(6, 20);
            this.listview_achievement2.Name = "listview_achievement2";
            this.listview_achievement2.Size = new System.Drawing.Size(427, 201);
            this.listview_achievement2.TabIndex = 62;
            this.listview_achievement2.UseCompatibleStateImageBehavior = false;
            this.listview_achievement2.View = System.Windows.Forms.View.List;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView_Platform2);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.groupBox3.Location = new System.Drawing.Point(937, 533);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(439, 225);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Platform";
            // 
            // listView_Platform2
            // 
            this.listView_Platform2.BackColor = System.Drawing.Color.White;
            this.listView_Platform2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_Platform2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Platform2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(62)))));
            this.listView_Platform2.HideSelection = false;
            this.listView_Platform2.Location = new System.Drawing.Point(6, 26);
            this.listView_Platform2.Name = "listView_Platform2";
            this.listView_Platform2.Size = new System.Drawing.Size(427, 193);
            this.listView_Platform2.TabIndex = 63;
            this.listView_Platform2.UseCompatibleStateImageBehavior = false;
            this.listView_Platform2.View = System.Windows.Forms.View.List;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listView_Platform1);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.groupBox4.Location = new System.Drawing.Point(333, 533);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(439, 225);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Platform";
            // 
            // listView_Platform1
            // 
            this.listView_Platform1.BackColor = System.Drawing.Color.White;
            this.listView_Platform1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_Platform1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Platform1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(62)))));
            this.listView_Platform1.HideSelection = false;
            this.listView_Platform1.Location = new System.Drawing.Point(6, 26);
            this.listView_Platform1.Name = "listView_Platform1";
            this.listView_Platform1.Size = new System.Drawing.Size(427, 193);
            this.listView_Platform1.TabIndex = 62;
            this.listView_Platform1.UseCompatibleStateImageBehavior = false;
            this.listView_Platform1.View = System.Windows.Forms.View.List;
            // 
            // vote_party1_btn
            // 
            this.vote_party1_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.vote_party1_btn.FlatAppearance.BorderSize = 0;
            this.vote_party1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vote_party1_btn.Font = new System.Drawing.Font("Roboto", 12F);
            this.vote_party1_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.vote_party1_btn.Location = new System.Drawing.Point(498, 783);
            this.vote_party1_btn.Name = "vote_party1_btn";
            this.vote_party1_btn.Size = new System.Drawing.Size(114, 33);
            this.vote_party1_btn.TabIndex = 47;
            this.vote_party1_btn.Text = "Vote";
            this.vote_party1_btn.UseVisualStyleBackColor = false;
            this.vote_party1_btn.Click += new System.EventHandler(this.vote_party1_btn_Click);
            // 
            // vote_party2_btn
            // 
            this.vote_party2_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.vote_party2_btn.FlatAppearance.BorderSize = 0;
            this.vote_party2_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vote_party2_btn.Font = new System.Drawing.Font("Roboto", 12F);
            this.vote_party2_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.vote_party2_btn.Location = new System.Drawing.Point(1116, 783);
            this.vote_party2_btn.Name = "vote_party2_btn";
            this.vote_party2_btn.Size = new System.Drawing.Size(114, 33);
            this.vote_party2_btn.TabIndex = 48;
            this.vote_party2_btn.Text = "Vote";
            this.vote_party2_btn.UseVisualStyleBackColor = false;
            this.vote_party2_btn.Click += new System.EventHandler(this.vote_party2_btn_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Controls.Add(this.label3);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Controls.Add(this.panel3);
            this.panel10.Controls.Add(this.pictureBox3);
            this.panel10.Controls.Add(this.pictureBox2);
            this.panel10.Location = new System.Drawing.Point(255, 39);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1202, 111);
            this.panel10.TabIndex = 50;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(266, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(166, 92);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 53;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(773, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(148, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // txt_candidate_nickname2
            // 
            this.txt_candidate_nickname2.AutoSize = true;
            this.txt_candidate_nickname2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_candidate_nickname2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.txt_candidate_nickname2.Location = new System.Drawing.Point(933, 233);
            this.txt_candidate_nickname2.Name = "txt_candidate_nickname2";
            this.txt_candidate_nickname2.Size = new System.Drawing.Size(115, 20);
            this.txt_candidate_nickname2.TabIndex = 52;
            this.txt_candidate_nickname2.Text = "Nickname here";
            // 
            // txt_candidate_nickname1
            // 
            this.txt_candidate_nickname1.AutoSize = true;
            this.txt_candidate_nickname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_candidate_nickname1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.txt_candidate_nickname1.Location = new System.Drawing.Point(329, 233);
            this.txt_candidate_nickname1.Name = "txt_candidate_nickname1";
            this.txt_candidate_nickname1.Size = new System.Drawing.Size(115, 20);
            this.txt_candidate_nickname1.TabIndex = 51;
            this.txt_candidate_nickname1.Text = "nickName here";
            // 
            // Ballot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1457, 869);
            this.Controls.Add(this.txt_candidate_nickname2);
            this.Controls.Add(this.txt_candidate_nickname1);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.vote_party2_btn);
            this.Controls.Add(this.vote_party1_btn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_candidate_name2);
            this.Controls.Add(this.txt_candidate_name1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ballot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ballot";
            this.Load += new System.EventHandler(this.Ballot_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button President;
        private System.Windows.Forms.Button dept_representation;
        private System.Windows.Forms.Button vp_finance;
        private System.Windows.Forms.Button vp_acad;
        private System.Windows.Forms.Button vp_operation;
        private System.Windows.Forms.Button vp_external;
        private System.Windows.Forms.Button vp_internal;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label txt_candidate_name1;
        private System.Windows.Forms.Label txt_candidate_name2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button vote_party1_btn;
        private System.Windows.Forms.Button vote_party2_btn;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ListView listview_achievement1;
        private System.Windows.Forms.ListView listview_achievement2;
        private System.Windows.Forms.ListView listView_Platform2;
        private System.Windows.Forms.ListView listView_Platform1;
        private System.Windows.Forms.ListView listView5;
        private System.Windows.Forms.Label txt_candidate_nickname2;
        private System.Windows.Forms.Label txt_candidate_nickname1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}