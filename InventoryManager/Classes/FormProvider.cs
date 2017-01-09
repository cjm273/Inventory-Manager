using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentComputerManager
{
    class FormProvider
    {
        private static Main _main;
        private static AddStudent _addStudent;
        private static AddComputer _addComputer;

        public static Main MainForm
        {
            get
            {
                if(_main == null)
                {
                    _main = new Main();
                }
                return _main;
            }
        }

        public static AddStudent AddStudentForm
        {
            get
            {
                if(_addStudent == null)
                {
                    _addStudent = new AddStudent();
                }
                return _addStudent;
            }
        }

        public static AddComputer AddComputerForm
        {
            get
            {
                if(_addComputer == null)
                {
                    _addComputer = new AddComputer();
                }
                return _addComputer;
            }
        }
    }
}
