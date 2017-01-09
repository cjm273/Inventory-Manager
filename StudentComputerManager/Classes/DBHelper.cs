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
    public static class DBHelper
    {
        private static SqlConnection connection = DBHelper.GetConnection();
        public static SqlConnection GetConnection()
        {
            //
            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;";
            connStr += @"AttachDbFilename=""C:\Users\chrism\documents\visual studio 2015\Projects\StudentComputerManager\StudentComputerManager\ComputerDB.mdf"";";
            connStr += @"Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);
            return conn;
        }

        private static void ExecuteCommand(SqlCommand comm)
        {
            try
            {
                connection.Open();
                comm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void InsertComputer(Computer c)
        {
            string insertStr = "INSERT INTO Computers " +
                "(CPSNum, Serial, Model, Condition, Unassigned, Notes, CPSReturnInfo) " + 
                "VALUES (@cps, @serial, @model, @cond, @unassigned, @notes, @return)";
            SqlCommand insertCommand = new SqlCommand(insertStr, connection);
            insertCommand.Parameters.AddWithValue("@cps", c.CPS);
            insertCommand.Parameters.AddWithValue("@serial", c.SN);
            insertCommand.Parameters.AddWithValue("@model", c.MODEL);
            insertCommand.Parameters.AddWithValue("@cond", c.CONDITION);
            insertCommand.Parameters.AddWithValue("@unassigned", c.UNASSIGNED);
            insertCommand.Parameters.AddWithValue("@notes", c.NOTES);
            insertCommand.Parameters.AddWithValue("@return", c.RETURN_INFO);

            ExecuteCommand(insertCommand);
        }

        public static void InsertStudent(Student student)
        {
            string insertStr = "INSERT INTO Students " +
                "(Id, First, Middle, Last, Grade, HR, TheoPeriod, TheoRoom, StudyHallRoom_Sem1, StudyPeriod_Sem1, StudyHallRoom_Sem2, StudyPeriod_Sem2) " +
                "VALUES (@id, @first, @middle, @last, @grade, @hr, @tp, @tr, @sr1, @sp1, @sr2, @sp2)";
            SqlCommand insertCommand = new SqlCommand(insertStr, connection);
            insertCommand.Parameters.AddWithValue("@id", student.ID);
            insertCommand.Parameters.AddWithValue("@first", student.First);
            insertCommand.Parameters.AddWithValue("@middle", student.Middle);
            insertCommand.Parameters.AddWithValue("@last", student.Last);
            insertCommand.Parameters.AddWithValue("@grade", student.Grade);
            insertCommand.Parameters.AddWithValue("@hr", student.HR);
            insertCommand.Parameters.AddWithValue("@tp", student.TheoPeriod);
            insertCommand.Parameters.AddWithValue("@tr", student.TheoRoom);
            insertCommand.Parameters.AddWithValue("@sr1", student.SH_Room_Fall);
            insertCommand.Parameters.AddWithValue("@sr2", student.SH_Room_Spring);
            insertCommand.Parameters.AddWithValue("@sp1", student.SH_Period_Fall);
            insertCommand.Parameters.AddWithValue("@sp2", student.SH_Period_Spring);

            ExecuteCommand(insertCommand);
        }

        public static void RemoveStudent(int id)
        {
            string removeStr = "DELETE FROM Students WHERE Id=@id";
            string updateStr = "UPDATE Computers SET StudentId=NULL,Unassigned=1 WHERE StudentId=@id";
            SqlCommand deleteCommand = new SqlCommand(removeStr, connection);
            SqlCommand updateCommand = new SqlCommand(updateStr, connection);
            deleteCommand.Parameters.AddWithValue("@id", id);
            updateCommand.Parameters.AddWithValue("@id", id);

            ExecuteCommand(deleteCommand);
            ExecuteCommand(updateCommand);
        }

        public static void RemoveComputer(int cps)
        {
            string removeStr = "DELETE FROM Computers WHERE CPSNum=@cps";
            string updateStr = "UPDATE Students SET CPSNum=NULL WHERE CPSNum=@cps";
            SqlCommand deleteCommand = new SqlCommand(removeStr, connection);
            SqlCommand updateStudent = new SqlCommand(updateStr, connection);
            deleteCommand.Parameters.AddWithValue("@cps", cps);
            updateStudent.Parameters.AddWithValue("@cps", cps);

            ExecuteCommand(deleteCommand);
            ExecuteCommand(updateStudent);
        }

        public static void AssignComputer(int sid, int cps)
        {
            /*TODO: Check to see if entry exists. */
            string assignStr = "UPDATE Students SET CPSNum=@cps WHERE Id=@id";
            string updateStr = "UPDATE Computers SET StudentId=@id WHERE CPSNum=@cps";
            SqlCommand assignComputer = new SqlCommand(assignStr, connection);
            SqlCommand updateComputer = new SqlCommand(updateStr, connection);
            assignComputer.Parameters.AddWithValue("@cps", cps);
            assignComputer.Parameters.AddWithValue("@id", sid);
            updateComputer.Parameters.AddWithValue("@id", sid);
            updateComputer.Parameters.AddWithValue("@cps", cps);

            ExecuteCommand(assignComputer);
            ExecuteCommand(updateComputer);
        }

        public static void UnassignComputer(int sid, int cps)
        {
            /*TODO: Check to see if entry exists. */
            string unassignStr = "UPDATE Students SET CPSNum=NULL WHERE Id=@id";
            string updateStr = "UPDATE Computers SET StudentId=NULL,Unassigned=1 WHERE CPSNum=@cps";
            SqlCommand unassignComputer = new SqlCommand(unassignStr, connection);
            SqlCommand updateComputer = new SqlCommand(updateStr, connection);
            unassignComputer.Parameters.AddWithValue("@id", sid);
            updateComputer.Parameters.AddWithValue("@cps", cps);

            ExecuteCommand(unassignComputer);
            ExecuteCommand(updateComputer);
        }

        public static void GetStudents()
        {

        }

        public static void GetComputers()
        {

        }
    }
}
/*
string insertStr = "INSERT INTO  " +
                "() " + "VALUES ()";
SqlCommand insertCommand = new SqlCommand(insertStr, connection);
insertCommand.Parameters.AddWithValue();
insertCommand.Parameters.AddWithValue();
try
{
    connection.Open();
    insertCommand.ExecuteNonQuery();
}
catch (SqlException ex)
{
    throw ex;
}
finally
{
    connection.Close();
}
*/