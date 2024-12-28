namespace Blood_Bank_Management_System
{
    partial class StockIncrease
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockIncrease));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnIncrease = new Button();
            btnPrint = new Button();
            btnClose = new Button();
            dataGridView1 = new DataGridView();
            txtUnits = new ComboBox();
            txtBloodGroup = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LemonChiffon;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(476, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(295, 45);
            label1.TabIndex = 0;
            label1.Text = "Stock (Increase)";
            // 
            // label2
            // 
            label2.BackColor = Color.LemonChiffon;
            label2.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(138, 110);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(156, 35);
            label2.TabIndex = 1;
            label2.Text = "Blood Group:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LemonChiffon;
            label3.Location = new Point(688, 115);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 1;
            label3.Text = "Units:";
            // 
            // btnIncrease
            // 
            btnIncrease.BackColor = Color.LemonChiffon;
            btnIncrease.Image = (Image)resources.GetObject("btnIncrease.Image");
            btnIncrease.ImageAlign = ContentAlignment.MiddleLeft;
            btnIncrease.Location = new Point(1058, 111);
            btnIncrease.Name = "btnIncrease";
            btnIncrease.Size = new Size(112, 34);
            btnIncrease.TabIndex = 2;
            btnIncrease.Text = "Increase";
            btnIncrease.TextAlign = ContentAlignment.MiddleRight;
            btnIncrease.UseVisualStyleBackColor = false;
            btnIncrease.Click += btnIncrease_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.LemonChiffon;
            btnPrint.Image = (Image)resources.GetObject("btnPrint.Image");
            btnPrint.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrint.Location = new Point(124, 588);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(112, 34);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(1130, 588);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 172);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1322, 362);
            dataGridView1.TabIndex = 5;
            // 
            // txtUnits
            // 
            txtUnits.DropDownStyle = ComboBoxStyle.DropDownList;
            txtUnits.FormattingEnabled = true;
            txtUnits.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            txtUnits.Location = new Point(765, 110);
            txtUnits.Name = "txtUnits";
            txtUnits.Size = new Size(234, 33);
            txtUnits.TabIndex = 6;
            // 
            // txtBloodGroup
            // 
            txtBloodGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            txtBloodGroup.FormattingEnabled = true;
            txtBloodGroup.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" });
            txtBloodGroup.Location = new Point(299, 112);
            txtBloodGroup.Name = "txtBloodGroup";
            txtBloodGroup.Size = new Size(234, 33);
            txtBloodGroup.TabIndex = 6;
            // 
            // StockIncrease
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1346, 689);
            Controls.Add(txtBloodGroup);
            Controls.Add(txtUnits);
            Controls.Add(dataGridView1);
            Controls.Add(btnClose);
            Controls.Add(btnPrint);
            Controls.Add(btnIncrease);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "StockIncrease";
            Load += StockIncrease_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnIncrease;
        private Button btnPrint;
        private Button btnClose;
        private DataGridView dataGridView1;
        private ComboBox txtUnits;
        private ComboBox txtBloodGroup;
    }
}