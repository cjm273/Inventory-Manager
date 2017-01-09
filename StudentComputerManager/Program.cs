/**
 * Christopher McManamon
 * mcmanamon.14@osu.edu
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentComputerManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Student s = new Student(200000, "Brutus", "", "Buckeye", 9, 118, 1, 119, 4, "Cafe", 6, "Cafe");
            //Computer c = new Computer(191000, "NT000000000000", "Acer Switch 10", "Fair", false, "", "");

            //Students.AddStudent(s);
            //Computers.AddComputer(c);

            //DBHelper.AssignComputer(s.ID, c.CPS);
            //DBHelper.UnassignComputer(s.ID, c.CPS);
            //Students.RemoveStudent(200000);
            //Computers.RemoveComputer(191000);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(FormProvider.MainForm);
        }
    }
}
