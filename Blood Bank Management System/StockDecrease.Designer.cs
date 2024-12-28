namespace Blood_Bank_Management_System
{
    partial class StockDecrease
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockDecrease));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBloodGroups = new ComboBox();
            txtUnits = new ComboBox();
            dataGridView1 = new DataGridView();
            btnDecrease = new Button();
            btnPrint = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LemonChiffon;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(516, 44);
            label1.Name = "label1";
            label1.Size = new Size(305, 45);
            label1.TabIndex = 0;
            label1.Text = "Stock (Decrease)";
            // 
            // label2
            // 
            label2.BackColor = Color.LemonChiffon;
            label2.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(174, 128);
            label2.Name = "label2";
            label2.Size = new Size(173, 33);
            label2.TabIndex = 1;
            label2.Text = "Blood Group:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LemonChiffon;
            label3.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(712, 137);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 2;
            label3.Text = "Units:";
            // 
            // txtBloodGroups
            // 
            txtBloodGroups.DropDownStyle = ComboBoxStyle.DropDownList;
            txtBloodGroups.FormattingEnabled = true;
            txtBloodGroups.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" });
            txtBloodGroups.Location = new Point(371, 129);
            txtBloodGroups.Name = "txtBloodGroups";
            txtBloodGroups.Size = new Size(202, 33);
            txtBloodGroups.TabIndex = 3;
            txtBloodGroups.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtUnits
            // 
            txtUnits.DropDownStyle = ComboBoxStyle.DropDownList;
            txtUnits.FormattingEnabled = true;
            txtUnits.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            txtUnits.Location = new Point(800, 134);
            txtUnits.Name = "txtUnits";
            txtUnits.Size = new Size(206, 33);
            txtUnits.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 192);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1325, 369);
            dataGridView1.TabIndex = 5;
            // 
            // btnDecrease
            // 
            btnDecrease.BackColor = Color.LemonChiffon;
            btnDecrease.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDecrease.Image = (Image)resources.GetObject("btnDecrease.Image");
            btnDecrease.ImageAlign = ContentAlignment.MiddleLeft;
            btnDecrease.Location = new Point(1030, 134);
            btnDecrease.Name = "btnDecrease";
            btnDecrease.Size = new Size(118, 34);
            btnDecrease.TabIndex = 6;
            btnDecrease.Text = "Decrease";
            btnDecrease.TextAlign = ContentAlignment.MiddleRight;
            btnDecrease.UseVisualStyleBackColor = false;
            btnDecrease.Click += btnDecrease_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.LemonChiffon;
            btnPrint.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.Image = (Image)resources.GetObject("btnPrint.Image");
            btnPrint.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrint.Location = new Point(102, 596);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(112, 34);
            btnPrint.TabIndex = 7;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.LemonChiffon;
            btnClose.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(1058, 596);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += button3_Click;
            // 
            // StockDecrease
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1349, 698);
            Controls.Add(btnClose);
            Controls.Add(btnPrint);
            Controls.Add(btnDecrease);
            Controls.Add(dataGridView1);
            Controls.Add(txtUnits);
            Controls.Add(txtBloodGroups);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "StockDecrease";
            Text = "StockDecrease";
            Load += StockDecrease_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox txtBloodGroups;
        private ComboBox txtUnits;
        private DataGridView dataGridView1;
        private Button btnDecrease;
        private Button btnPrint;
        private Button btnClose;
    }
}