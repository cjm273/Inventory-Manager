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
    public static class Computers
    {
        private static SqlConnection connection = DBHelper.GetConnection();

        public static int AddComputer(Computer c)
        {
            int error = 0;

            DBHelper.InsertComputer(c);

            return error;
        }

        public static int RemoveComputer(int cps)
        {
            int error = 0;

            DBHelper.RemoveComputer(cps);

            return error;
        }
    }
}
