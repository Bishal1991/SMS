namespace StudentManagementSystem
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
            PhNumTxt = new TextBox();
            SectionTxt = new TextBox();
            RollNumTxt = new TextBox();
            NameTxt = new TextBox();
            AddressTxt = new TextBox();
            AgeTxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            AddBtn = new Button();
            ViewBtn = new Button();
            UpdateBtn = new Button();
            dltBtn = new Button();
            dataGridView1 = new DataGridView();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // PhNumTxt
            // 
            PhNumTxt.Location = new Point(251, 345);
            PhNumTxt.Name = "PhNumTxt";
            PhNumTxt.Size = new Size(163, 27);
            PhNumTxt.TabIndex = 0;
            // 
            // SectionTxt
            // 
            SectionTxt.Location = new Point(251, 204);
            SectionTxt.Name = "SectionTxt";
            SectionTxt.Size = new Size(163, 27);
            SectionTxt.TabIndex = 4;
            // 
            // RollNumTxt
            // 
            RollNumTxt.Location = new Point(251, 156);
            RollNumTxt.Name = "RollNumTxt";
            RollNumTxt.Size = new Size(163, 27);
            RollNumTxt.TabIndex = 5;
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(251, 104);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(163, 27);
            NameTxt.TabIndex = 6;
            // 
            // AddressTxt
            // 
            AddressTxt.Location = new Point(251, 298);
            AddressTxt.Name = "AddressTxt";
            AddressTxt.Size = new Size(163, 27);
            AddressTxt.TabIndex = 9;
            // 
            // AgeTxt
            // 
            AgeTxt.Location = new Point(251, 251);
            AgeTxt.Name = "AgeTxt";
            AgeTxt.Size = new Size(163, 27);
            AgeTxt.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 64);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 11;
            label2.Text = "ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 107);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 12;
            label3.Text = "Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(145, 159);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 13;
            label4.Text = "Roll Number :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(180, 207);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 14;
            label5.Text = "Section :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(202, 258);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 15;
            label6.Text = "Age :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(176, 301);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 16;
            label7.Text = "Address :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(130, 348);
            label8.Name = "label8";
            label8.Size = new Size(115, 20);
            label8.TabIndex = 17;
            label8.Text = "Phone Number :";
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(164, 416);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(94, 29);
            AddBtn.TabIndex = 18;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // ViewBtn
            // 
            ViewBtn.Location = new Point(298, 416);
            ViewBtn.Name = "ViewBtn";
            ViewBtn.Size = new Size(94, 29);
            ViewBtn.TabIndex = 19;
            ViewBtn.Text = "View";
            ViewBtn.UseVisualStyleBackColor = true;
            ViewBtn.Click += ViewBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(164, 466);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(94, 29);
            UpdateBtn.TabIndex = 20;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // dltBtn
            // 
            dltBtn.Location = new Point(298, 466);
            dltBtn.Name = "dltBtn";
            dltBtn.Size = new Size(94, 29);
            dltBtn.TabIndex = 21;
            dltBtn.Text = "Delete";
            dltBtn.UseVisualStyleBackColor = true;
            dltBtn.Click += dltBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(486, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(618, 441);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtID
            // 
            txtID.Location = new Point(251, 64);
            txtID.Name = "txtID";
            txtID.Size = new Size(163, 27);
            txtID.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1152, 766);
            Controls.Add(txtID);
            Controls.Add(dataGridView1);
            Controls.Add(dltBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(ViewBtn);
            Controls.Add(AddBtn);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(AddressTxt);
            Controls.Add(AgeTxt);
            Controls.Add(NameTxt);
            Controls.Add(RollNumTxt);
            Controls.Add(SectionTxt);
            Controls.Add(PhNumTxt);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PhNumTxt;
        private TextBox SectionTxt;
        private TextBox RollNumTxt;
        private TextBox NameTxt;
        private TextBox AddressTxt;
        private TextBox AgeTxt;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button AddBtn;
        private Button ViewBtn;
        private Button UpdateBtn;
        private Button dltBtn;
        private DataGridView dataGridView1;
        private TextBox txtID;
    }
}
