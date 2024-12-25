using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management_System
{
    public partial class AddNewDonor : Form
    {
        function fn = new function();
        public AddNewDonor()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddNewDonor_Load(object sender, EventArgs e)
        {
            String query = "select max(Did) from BloodDonor";
            DataSet ds = fn.getData(query);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtFather.Text != "" && txtMother.Text != "" && txtDOB.Text != "" && txtMobile.Text != "" && txtGender.Text != "" && txtEmail.Text != "" && txtBloodGroup.Text != "" && txtCity.Text != "" && txtAddress.Text != "")
            {
                String Dname = txtName.Text;
                String Fname = txtFather.Text;
                String Mname = txtMother.Text;
                String Dob = txtDOB.Text;
                String Mobile = txtMobile.Text;
                String Gender = txtGender.Text;
                String Email = txtEmail.Text;
                String Bloodgroup = txtBloodGroup.Text;
                String City = txtCity.Text;
                String Daddress = txtAddress.Text;

                String query = "insert into BdDonor (Dname, Fname, Mname, Dob, Mobile, Gender, Email, Bloodgroup, City, Daddress) values ('" + Dname + "','" + Fname + "','" + Mname + "','" + Dob + "','" + Mobile + "','" + Gender + "','" + Email + "','" + Bloodgroup + "','" + City + "','" + Daddress + "')";

                fn.setData(query);
            }

            else
            {
                MessageBox.Show("Fill all Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtName.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtEmail.Clear();
            txtCity.Clear();
            txtAddress.Clear();
            txtDOB.ResetText();
            txtGender.ResetText();
            txtBloodGroup.ResetText();
        }
    }
}
