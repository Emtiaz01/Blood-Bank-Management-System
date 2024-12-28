namespace Blood_Bank_Management_System
{
    partial class DeleteDonor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteDonor));
            label1 = new Label();
            label2 = new Label();
            txtDonorID = new TextBox();
            btnSearch = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtName = new TextBox();
            txtFather = new TextBox();
            txtMother = new TextBox();
            txtMobile = new TextBox();
            txtEmail = new TextBox();
            txtCity = new TextBox();
            txtAddress = new RichTextBox();
            txtBloodGroup = new ComboBox();
            txtGender = new ComboBox();
            btnDelete = new Button();
            btnClose = new Button();
            btnReset = new Button();
            txtDob = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LemonChiffon;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(520, 9);
            label1.Name = "label1";
            label1.Size = new Size(243, 45);
            label1.TabIndex = 0;
            label1.Text = "Delete Donor";
            // 
            // label2
            // 
            label2.BackColor = Color.LemonChiffon;
            label2.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(447, 82);
            label2.Name = "label2";
            label2.Size = new Size(116, 31);
            label2.TabIndex = 1;
            label2.Text = "Donor ID:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDonorID
            // 
            txtDonorID.Location = new Point(578, 82);
            txtDonorID.Name = "txtDonorID";
            txtDonorID.Size = new Size(170, 31);
            txtDonorID.TabIndex = 2;
            txtDonorID.TextChanged += txtDonorID_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LemonChiffon;
            btnSearch.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(772, 82);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(118, 31);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LemonChiffon;
            label3.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label3.Location = new Point(179, 242);
            label3.Name = "label3";
            label3.Size = new Size(151, 25);
            label3.TabIndex = 4;
            label3.Text = "Father's Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LemonChiffon;
            label4.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label4.Location = new Point(179, 165);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 4;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LemonChiffon;
            label5.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label5.Location = new Point(179, 304);
            label5.Name = "label5";
            label5.Size = new Size(145, 25);
            label5.TabIndex = 4;
            label5.Text = "Moter's Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LemonChiffon;
            label6.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label6.Location = new Point(179, 359);
            label6.Name = "label6";
            label6.Size = new Size(135, 25);
            label6.TabIndex = 4;
            label6.Text = "Date of Birth";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LemonChiffon;
            label7.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label7.Location = new Point(179, 422);
            label7.Name = "label7";
            label7.Size = new Size(110, 25);
            label7.TabIndex = 4;
            label7.Text = "Mobile No";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.LemonChiffon;
            label8.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label8.Location = new Point(179, 494);
            label8.Name = "label8";
            label8.Size = new Size(82, 25);
            label8.TabIndex = 4;
            label8.Text = "Gender";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.LemonChiffon;
            label9.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label9.Location = new Point(793, 165);
            label9.Name = "label9";
            label9.Size = new Size(68, 25);
            label9.TabIndex = 4;
            label9.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.LemonChiffon;
            label10.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label10.Location = new Point(793, 237);
            label10.Name = "label10";
            label10.Size = new Size(134, 25);
            label10.TabIndex = 4;
            label10.Text = "Blood Group";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.LemonChiffon;
            label11.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label11.Location = new Point(793, 359);
            label11.Name = "label11";
            label11.Size = new Size(88, 25);
            label11.TabIndex = 4;
            label11.Text = "Address";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.LemonChiffon;
            label12.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label12.Location = new Point(793, 298);
            label12.Name = "label12";
            label12.Size = new Size(51, 25);
            label12.TabIndex = 4;
            label12.Text = "City";
            // 
            // txtName
            // 
            txtName.Location = new Point(337, 165);
            txtName.Name = "txtName";
            txtName.Size = new Size(238, 31);
            txtName.TabIndex = 5;
            // 
            // txtFather
            // 
            txtFather.Location = new Point(337, 239);
            txtFather.Name = "txtFather";
            txtFather.Size = new Size(238, 31);
            txtFather.TabIndex = 5;
            // 
            // txtMother
            // 
            txtMother.Location = new Point(337, 301);
            txtMother.Name = "txtMother";
            txtMother.Size = new Size(238, 31);
            txtMother.TabIndex = 5;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(337, 419);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(238, 31);
            txtMobile.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(958, 162);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(238, 31);
            txtEmail.TabIndex = 5;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(958, 298);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(238, 31);
            txtCity.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(958, 359);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(238, 150);
            txtAddress.TabIndex = 6;
            txtAddress.Text = "";
            // 
            // txtBloodGroup
            // 
            txtBloodGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            txtBloodGroup.FormattingEnabled = true;
            txtBloodGroup.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" });
            txtBloodGroup.Location = new Point(958, 237);
            txtBloodGroup.Name = "txtBloodGroup";
            txtBloodGroup.Size = new Size(238, 33);
            txtBloodGroup.TabIndex = 7;
            // 
            // txtGender
            // 
            txtGender.DropDownStyle = ComboBoxStyle.DropDownList;
            txtGender.FormattingEnabled = true;
            txtGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            txtGender.Location = new Point(337, 494);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(238, 33);
            txtGender.TabIndex = 7;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LemonChiffon;
            btnDelete.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(277, 603);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.LemonChiffon;
            btnClose.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(971, 603);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.LemonChiffon;
            btnReset.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(599, 603);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 34);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // txtDob
            // 
            txtDob.Location = new Point(337, 359);
            txtDob.Name = "txtDob";
            txtDob.Size = new Size(238, 31);
            txtDob.TabIndex = 9;
            // 
            // DeleteDonor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1344, 689);
            Controls.Add(txtDob);
            Controls.Add(btnReset);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(txtGender);
            Controls.Add(txtBloodGroup);
            Controls.Add(txtAddress);
            Controls.Add(txtCity);
            Controls.Add(txtEmail);
            Controls.Add(txtMobile);
            Controls.Add(txtMother);
            Controls.Add(txtFather);
            Controls.Add(txtName);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnSearch);
            Controls.Add(txtDonorID);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "DeleteDonor";
            Text = "DeleteDonor";
            Load += DeleteDonor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtDonorID;
        private Button btnSearch;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtName;
        private TextBox txtFather;
        private TextBox txtMother;
        private TextBox txtMobile;
        private TextBox txtEmail;
        private TextBox txtCity;
        private RichTextBox txtAddress;
        private ComboBox txtBloodGroup;
        private ComboBox txtGender;
        private Button btnDelete;
        private Button btnClose;
        private Button btnReset;
        private DateTimePicker txtDob;
    }
}