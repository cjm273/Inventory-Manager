using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentComputerManager
{
    public partial class AddStudent : Form
    {

        public AddStudent()
        {
            InitializeComponent();
            this.FormClosed += AddStudent_FormClosed;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void b_submitStudent_Click(object sender, EventArgs e)
        {
            Student s = new Student(int(txt_id.Text), txt_fname.Text, txt_mname.Text, txt_lname.Text, int(cb_grade.Text), int(txt_hr.Text), int(cb_tp.Text), int(txt_tr.Text), int(cb_shp1.Text), txt_shr1.Text, int(cb_shp2.Text), txt_shr2.Text);
            DBHelper.InsertStudent(s);
            this.Close();
        }

        private void AddStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void b_clearForm_Click(object sender, EventArgs e)
        {
            txt_id.Clear;
            cb_grade.ResetText;
            txt_fname.Clear;
            txt_mname.Clear;
            txt_lname.Clear;
            txt_hr.Clear;
            txt_tr.Clear;
            cb_tp.ResetText;
            cb_shp1.ResetText;
            txt_shr1.Clear;
            cb_shp2.ResetText;
            txt_shr2.Clear;
            
            
        }
    }
}
