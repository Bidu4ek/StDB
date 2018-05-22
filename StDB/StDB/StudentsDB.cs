using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StDB
{
    class StudentsDB
    {
        List<Student> db;
        public StudentsDB()
        {
            Db = new List<Student>();
        }

        internal List<Student> Db { get => db; set => db = value; }
    }
}
