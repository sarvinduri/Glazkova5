using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glazkova5.Classes
{
    internal class ClassSpors
    {
        string fullname;
        string place;

        public string FullName { get { return fullname; } set { fullname = value; } }
        public string Place { get { return place; } set { place = value; } }

        public ClassSpors()
        {
            fullname= string.Empty;
            place= string.Empty;
        }
        public ClassSpors(string fname, string pl)
        {
            FullName = fname;
            Place = pl;
        }
    }
}
