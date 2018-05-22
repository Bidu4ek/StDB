using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StDB
{
    class Student
    {
        String name;
        ushort sex;
        DateTime birthday;
        String department;

        public string Name { get => name; set => name = value; }
        public ushort Sex { get => sex; set => sex = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public string Department { get => department; set => department = value; }

        public Student()
        {

        }

        public Student(string name, ushort sex, DateTime birthday, string department)
        {
            this.name = name;
            this.sex = sex;
            this.birthday = birthday;
            this.department = department;
        }
    }
}

