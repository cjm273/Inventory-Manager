/**
 * Christopher McManamon
 * mcmanamon.14@osu.edu
 * */

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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void b_addStudent_Click(object sender, EventArgs e)
        {
            FormProvider.AddStudentForm.ShowDialog();
        }

        private void b_addComputer_Click(object sender, EventArgs e)
        {
            FormProvider.AddComputerForm.ShowDialog();
        }
    }
}
