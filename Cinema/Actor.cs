using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema
{
    public class Actor
    {
        public String Name { get; set; }
        public DateTime DOB { get; set; }

        public Actor()
        {
            
        }
        public Actor(string nme, DateTime db)
        {
            Name = nme;
            DOB = db;
        }
        public override string ToString()
        {
            return String.Format("{0} aged {1} yrs",Name,(DateTime.Now-DOB).Days/365);
        }
    }   // end class
}
