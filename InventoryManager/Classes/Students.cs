/**
 * Christopher McManamon
 * mcmanamon.14@osu.edu
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StudentComputerManager
{
    /**
     * 
     * Manages the adding and removing of students to and from the database
     * 
     * */
    public static class Students
    {
        private static SqlConnection connection = DBHelper.GetConnection();

        public static int AddStudent(Student s)
        {
            int error = 0;
            
            DBHelper.InsertStudent(s);

            return error;
        }

        public static int RemoveStudent(int id)
        {
            int error = 0;

            DBHelper.RemoveStudent(id);

            return error;
        }
    }
}
