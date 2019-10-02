using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace AppOOP
{
    class Student
    {
        public Student()
        {

        }

        public Student(string name)
        {
            this.name = name;
        }

        private string name;

        public string StudentName { get => name; set => name = value; }

        public void Talk()
        {
            MessageBox.Show(StudentName);
        }
    }
}
