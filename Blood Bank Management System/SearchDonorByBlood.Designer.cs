namespace Blood_Bank_Management_System
{
    partial class SearchDonorByBlood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchDonorByBlood));
            label1 = new Label();
            label2 = new Label();
            txtSearchBlood = new TextBox();
            dataGridView1 = new DataGridView();
            btnPrint = new Button();
            button2 = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LemonChiffon;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(409, -1);
            label1.Name = "label1";
            label1.Size = new Size(549, 45);
            label1.TabIndex = 0;
            label1.Text = "Search Blood Donor (By Blood)";
            // 
            // label2
            // 
            label2.BackColor = Color.LemonChiffon;
            label2.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(489, 72);
            label2.Name = "label2";
            label2.Size = new Size(168, 38);
            label2.TabIndex = 1;
            label2.Text = "Blood Group";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSearchBlood
            // 
            txtSearchBlood.BackColor = Color.LemonChiffon;
            txtSearchBlood.Location = new Point(663, 76);
            txtSearchBlood.Name = "txtSearchBlood";
            txtSearchBlood.Size = new Size(202, 31);
            txtSearchBlood.TabIndex = 2;
            txtSearchBlood.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1322, 418);
            dataGridView1.TabIndex = 3;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.LemonChiffon;
            btnPrint.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.Image = (Image)resources.GetObject("btnPrint.Image");
            btnPrint.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrint.Location = new Point(99, 618);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(112, 34);
            btnPrint.TabIndex = 4;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LemonChiffon;
            button2.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(1103, 618);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 4;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // SearchDonorByBlood
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1346, 732);
            Controls.Add(button2);
            Controls.Add(btnPrint);
            Controls.Add(dataGridView1);
            Controls.Add(txtSearchBlood);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "SearchDonorByBlood";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchDonorByBlood";
            Load += SearchDonorByBlood_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSearchBlood;
        private DataGridView dataGridView1;
        private Button btnPrint;
        private Button button2;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}