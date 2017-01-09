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
    public class Computer
    {
        public int CPS { get; private set; }
        public string SN { get; private set; }
        public string MODEL { get; private set; }
        public string CONDITION { get; private set; }
        public bool UNASSIGNED { get; private set; }
        public string NOTES { get; private set; }
        public string RETURN_INFO { get; private set; }

        public Computer() { }
        public Computer(int cps, string sn, string model, string cond, bool unassigned, string notes, string ret_info)
        {
            this.CPS = cps;
            this.SN = sn;
            this.MODEL = model;
            this.CONDITION = cond;
            this.UNASSIGNED = unassigned;
            this.NOTES = notes;
            this.RETURN_INFO = ret_info;
        }
    }
}
