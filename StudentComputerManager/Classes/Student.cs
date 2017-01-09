/**
 * Christopher McManamon
 * mcmanamon.14@osu.edu
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentComputerManager
{
    public class Student
    {
        public int ID { get; private set; }
        public int Grade { get; private set; }
        public int HR { get; private set; }
        public int TheoPeriod { get; private set; }
        public int TheoRoom { get; private set; }
        public int SH_Period_Fall { get; private set; }
        public int SH_Period_Spring { get; private set; }
        public string SH_Room_Fall { get; private set; }
        public string SH_Room_Spring { get; private set; }
        public string First { get; private set; }
        public string Last { get; private set; }
        public string Middle { get; private set; }

        public Student() { }
        public Student(int id, string first, string middle, string last, int grade, int hr, int tp, int tr, int shp1, string shr1, int shp2, string shr2)
        {
            this.ID = id;
            this.First = first;
            this.Middle = middle;
            this.Last = last;
            this.Grade = grade;
            this.HR = hr;
            this.TheoPeriod = tp;
            this.TheoRoom = tr;
            this.SH_Room_Fall = shr1;
            this.SH_Period_Fall = shp1;
            this.SH_Room_Spring = shr2;
            this.SH_Period_Spring = shp2;
        }
    }
}
