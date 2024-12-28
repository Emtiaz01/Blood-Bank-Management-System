using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management_System
{
    public partial class StockDecrease : Form
    {
        function fn = new function();
        String query;
        public StockDecrease()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StockDecrease_Load(object sender, EventArgs e)
        {
            query = "select blood_group,quantity from stock";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            query = "update stock set quantity = quantity- " + txtUnits.Text + " where blood_group = '" + txtBloodGroups.Text + "'";
            fn.setData(query);
            StockDecrease_Load(this, null);
        }
    }
}
