using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.University
{
   public class Lesson
    {
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string section;
        public string Section
        {
            get { return section; }
            set { section = value; }
        }
        public string day;
        public string Day
        {
            get { return day; }
            set { day = value; }
        }
        public int time_startHH;
        public int time_startMM;
        public string time_start;
        public string TimeStart
        {
            get { return time_start; }
            set
            {
               time_start = value;
               time_startHH = Convert.ToInt32(time_start.Remove(2));
               time_startMM = Convert.ToInt32(time_start.Substring(3, 2)); 
            }
        }
        public string time_end;
        public int time_endHH;
        public int time_endMM;
        public string TimeEnd
        {
            get { return time_end; }
            set
            {
                time_end = value;
                time_endHH = Convert.ToInt32(time_end.Remove(2));
                time_endMM = Convert.ToInt32(time_end.Substring(3, 2));
            }
        }
        public string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string teacher;
        public string Teacher
        {
            get { return teacher; }
            set { teacher = value; }
        }
        public Lesson(string name, string day, string time_start, string time_end, string address, string teacher, string section)
        {
            Name = name;
            Day = day;
            TimeStart = time_start;
            TimeEnd = time_end;
            Address = address;
            Teacher = teacher;
            Section = section;
        }
        public Lesson()
        {
           
        }
    }
}
