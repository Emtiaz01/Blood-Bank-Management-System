namespace Blood_Bank_Management_System
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            menuStrip1 = new MenuStrip();
            donorToolStripMenuItem = new ToolStripMenuItem();
            addNewDonoToolStripMenuItem = new ToolStripMenuItem();
            updateDetailsToolStripMenuItem = new ToolStripMenuItem();
            allDonorListToolStripMenuItem = new ToolStripMenuItem();
            searchDonorToolStripMenuItem = new ToolStripMenuItem();
            locationToolStripMenuItem = new ToolStripMenuItem();
            bloodGroupToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            increaseToolStripMenuItem = new ToolStripMenuItem();
            decreaseToolStripMenuItem = new ToolStripMenuItem();
            detailsToolStripMenuItem = new ToolStripMenuItem();
            deleteDonorToolStripMenuItem = new ToolStripMenuItem();
            deleteDonorToolStripMenuItem1 = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(255, 192, 192);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { donorToolStripMenuItem, searchDonorToolStripMenuItem, stockToolStripMenuItem, deleteDonorToolStripMenuItem, logOutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1225, 68);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // donorToolStripMenuItem
            // 
            donorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewDonoToolStripMenuItem, updateDetailsToolStripMenuItem, allDonorListToolStripMenuItem });
            donorToolStripMenuItem.Image = (Image)resources.GetObject("donorToolStripMenuItem.Image");
            donorToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            donorToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            donorToolStripMenuItem.Name = "donorToolStripMenuItem";
            donorToolStripMenuItem.Size = new Size(129, 64);
            donorToolStripMenuItem.Text = "Donor";
            // 
            // addNewDonoToolStripMenuItem
            // 
            addNewDonoToolStripMenuItem.Image = (Image)resources.GetObject("addNewDonoToolStripMenuItem.Image");
            addNewDonoToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            addNewDonoToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addNewDonoToolStripMenuItem.Name = "addNewDonoToolStripMenuItem";
            addNewDonoToolStripMenuItem.Size = new Size(248, 34);
            addNewDonoToolStripMenuItem.Text = "Add New Dono";
            // 
            // updateDetailsToolStripMenuItem
            // 
            updateDetailsToolStripMenuItem.Image = (Image)resources.GetObject("updateDetailsToolStripMenuItem.Image");
            updateDetailsToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            updateDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            updateDetailsToolStripMenuItem.Name = "updateDetailsToolStripMenuItem";
            updateDetailsToolStripMenuItem.Size = new Size(248, 34);
            updateDetailsToolStripMenuItem.Text = "Update Details";
            // 
            // allDonorListToolStripMenuItem
            // 
            allDonorListToolStripMenuItem.Image = (Image)resources.GetObject("allDonorListToolStripMenuItem.Image");
            allDonorListToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            allDonorListToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            allDonorListToolStripMenuItem.Name = "allDonorListToolStripMenuItem";
            allDonorListToolStripMenuItem.Size = new Size(248, 34);
            allDonorListToolStripMenuItem.Text = "All Donor Details";
            allDonorListToolStripMenuItem.Click += allDonorListToolStripMenuItem_Click;
            // 
            // searchDonorToolStripMenuItem
            // 
            searchDonorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { locationToolStripMenuItem, bloodGroupToolStripMenuItem });
            searchDonorToolStripMenuItem.Image = (Image)resources.GetObject("searchDonorToolStripMenuItem.Image");
            searchDonorToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            searchDonorToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            searchDonorToolStripMenuItem.Name = "searchDonorToolStripMenuItem";
            searchDonorToolStripMenuItem.Size = new Size(186, 64);
            searchDonorToolStripMenuItem.Text = "Search Donor";
            // 
            // locationToolStripMenuItem
            // 
            locationToolStripMenuItem.Image = (Image)resources.GetObject("locationToolStripMenuItem.Image");
            locationToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            locationToolStripMenuItem.Size = new Size(216, 34);
            locationToolStripMenuItem.Text = "Location";
            // 
            // bloodGroupToolStripMenuItem
            // 
            bloodGroupToolStripMenuItem.Image = (Image)resources.GetObject("bloodGroupToolStripMenuItem.Image");
            bloodGroupToolStripMenuItem.Name = "bloodGroupToolStripMenuItem";
            bloodGroupToolStripMenuItem.Size = new Size(216, 34);
            bloodGroupToolStripMenuItem.Text = "Blood Group";
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { increaseToolStripMenuItem, decreaseToolStripMenuItem, detailsToolStripMenuItem });
            stockToolStripMenuItem.Image = (Image)resources.GetObject("stockToolStripMenuItem.Image");
            stockToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            stockToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(121, 64);
            stockToolStripMenuItem.Text = "Stock";
            // 
            // increaseToolStripMenuItem
            // 
            increaseToolStripMenuItem.Image = (Image)resources.GetObject("increaseToolStripMenuItem.Image");
            increaseToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            increaseToolStripMenuItem.Name = "increaseToolStripMenuItem";
            increaseToolStripMenuItem.Size = new Size(185, 34);
            increaseToolStripMenuItem.Text = "Increase";
            // 
            // decreaseToolStripMenuItem
            // 
            decreaseToolStripMenuItem.Image = (Image)resources.GetObject("decreaseToolStripMenuItem.Image");
            decreaseToolStripMenuItem.Name = "decreaseToolStripMenuItem";
            decreaseToolStripMenuItem.Size = new Size(185, 34);
            decreaseToolStripMenuItem.Text = "Decrease";
            // 
            // detailsToolStripMenuItem
            // 
            detailsToolStripMenuItem.Image = (Image)resources.GetObject("detailsToolStripMenuItem.Image");
            detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            detailsToolStripMenuItem.Size = new Size(185, 34);
            detailsToolStripMenuItem.Text = "Details";
            // 
            // deleteDonorToolStripMenuItem
            // 
            deleteDonorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deleteDonorToolStripMenuItem1 });
            deleteDonorToolStripMenuItem.Image = (Image)resources.GetObject("deleteDonorToolStripMenuItem.Image");
            deleteDonorToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            deleteDonorToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            deleteDonorToolStripMenuItem.Name = "deleteDonorToolStripMenuItem";
            deleteDonorToolStripMenuItem.Size = new Size(184, 64);
            deleteDonorToolStripMenuItem.Text = "Delete Donor";
            // 
            // deleteDonorToolStripMenuItem1
            // 
            deleteDonorToolStripMenuItem1.Image = (Image)resources.GetObject("deleteDonorToolStripMenuItem1.Image");
            deleteDonorToolStripMenuItem1.Name = "deleteDonorToolStripMenuItem1";
            deleteDonorToolStripMenuItem1.Size = new Size(220, 34);
            deleteDonorToolStripMenuItem1.Text = "Delete Donor";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Image = (Image)resources.GetObject("logOutToolStripMenuItem.Image");
            logOutToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            logOutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(148, 64);
            logOutToolStripMenuItem.Text = "LogOut";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1225, 691);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "dashboard";
            Text = "dashboard";
            Load += dashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem donorToolStripMenuItem;
        private ToolStripMenuItem searchDonorToolStripMenuItem;
        private ToolStripMenuItem deleteDonorToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem addNewDonoToolStripMenuItem;
        private ToolStripMenuItem updateDetailsToolStripMenuItem;
        private ToolStripMenuItem allDonorListToolStripMenuItem;
        private ToolStripMenuItem locationToolStripMenuItem;
        private ToolStripMenuItem bloodGroupToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem increaseToolStripMenuItem;
        private ToolStripMenuItem decreaseToolStripMenuItem;
        private ToolStripMenuItem detailsToolStripMenuItem;
        private ToolStripMenuItem deleteDonorToolStripMenuItem1;
    }
}