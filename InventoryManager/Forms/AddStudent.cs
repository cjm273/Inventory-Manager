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
            this.Close();
        }

        private void AddStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
