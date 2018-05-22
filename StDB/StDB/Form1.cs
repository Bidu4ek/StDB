using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StDB
{
    public partial class Form1 : Form
    {
        StudentsDB students;
        int currentStudentNumber = -1;
        int helpcurr = 1;

        public Form1()
        {
            InitializeComponent();
            students = new StudentsDB();
            tabControl1.SelectedIndex = 1;

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            students = new StudentsDB();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxNameIn.Text = null;
                textBoxNameEd.Text = null;
                textBoxNameV.Text = null;
                MaleV.Checked = true;
                MaleEd.Checked = true;
                MaleIn.Checked = true;
                textBoxBirthdayIn.Text = null;
                textBoxBirthdayEd.Text = null;
                textBoxBirthdayV.Text = null;
                comboBoxDepartmentIn.Text = null;
                comboBoxDepartmentV.Text = null;
                comboBoxDepartmentEd.Text = null;
                textBoxStudentN.Text = null;
                textBoxStudentNE.Text = null;
            }
            catch
            {
                MessageBox.Show("List is empty");
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                students.Db.RemoveAt(currentStudentNumber);
                if (currentStudentNumber >= 0)
                {
                    currentStudentNumber--;
                }
            }
            catch
            {
                MessageBox.Show("List is empty");

            }
        }
        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            students.Db.Clear();
            currentStudentNumber = -1;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Students database ©\n 2018");
        }

        private void textBoxBirthdayInEnter_Enter(object sender, EventArgs e)
        {
            monthCalendarIn.Visible = true;
            monthCalendarEd.Visible = true;
        }

        private void monthCalendar_Leave(object sender, EventArgs e)
        {
            if (!textBoxBirthdayIn.Focused)
                monthCalendarIn.Visible = false;
            textBoxBirthdayIn.Text = monthCalendarIn.SelectionStart.ToShortDateString();

            if (!textBoxBirthdayEd.Focused)
                monthCalendarEd.Visible = false;
            textBoxBirthdayEd.Text = monthCalendarEd.SelectionStart.ToShortDateString();
        }

        private void textBoxBirthday_Leave(object sender, EventArgs e)
        {
            if (!monthCalendarIn.Focused)
                monthCalendarIn.Visible = false;

            if (!monthCalendarEd.Focused)
                monthCalendarEd.Visible = false;
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            String name = textBoxNameIn.Text;
            ushort sex = (ushort)(MaleIn.Checked ? 1 : 2);
            DateTime birthday = monthCalendarIn.SelectionStart;
            String department = comboBoxDepartmentIn.Text;
            Student student = new Student(name, sex, birthday, department);

            students.Db.Add(student);
            currentStudentNumber++;
            ActiveForm.Text = students.Db.Count.ToString();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                if (students.Db.Count > 0)
                {
                    showStudentInfo();

                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNameEd.Text != students.Db.ElementAt(helpcurr).Name)
                    students.Db.ElementAt(helpcurr).Name = textBoxNameEd.Text;
                if (MaleEd.Checked == true)
                    students.Db.ElementAt(helpcurr).Sex = 1;
                else students.Db.ElementAt(helpcurr).Sex = 0;

                if (students.Db.ElementAt(helpcurr).Birthday.ToShortDateString() != textBoxBirthdayEd.Text)
                    students.Db.ElementAt(helpcurr).Birthday = monthCalendarEd.SelectionStart;

                if (students.Db.ElementAt(helpcurr).Department != comboBoxDepartmentEd.Text)
                    students.Db.ElementAt(helpcurr).Department = comboBoxDepartmentEd.Text;
            }
            catch
            {
                MessageBox.Show("List is empty");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (students.Db.Count > 0)
            {
                currentStudentNumber--;
                if (currentStudentNumber < 0)
                    currentStudentNumber = students.Db.Count - 1;
                showStudentInfo();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (students.Db.Count > 0)
            {
                currentStudentNumber++;
                if (currentStudentNumber == students.Db.Count)
                    currentStudentNumber = 0;
                showStudentInfo();
            }
        }

        private void showStudentInfo()
        {
            // --||--V - View,  --||--Ed - Edit
            try
            {
                textBoxNameV.Text = students.Db.ElementAt(currentStudentNumber).Name;
                textBoxNameEd.Text = students.Db.ElementAt(currentStudentNumber).Name;
                if (students.Db.ElementAt(currentStudentNumber).Sex == 1)
                {
                    MaleV.Checked = true;
                    MaleEd.Checked = true;
                }
                else
                {
                    FemaleV.Checked = true;
                    FemaleEd.Checked = true;
                }
                textBoxBirthdayV.Text = students.Db.ElementAt(currentStudentNumber).Birthday.ToShortDateString();
                textBoxBirthdayEd.Text = students.Db.ElementAt(currentStudentNumber).Birthday.ToShortDateString();
                comboBoxDepartmentV.Text = students.Db.ElementAt(currentStudentNumber).Department;
                comboBoxDepartmentEd.Text = students.Db.ElementAt(currentStudentNumber).Department;
                textBoxStudentN.Text = (currentStudentNumber + 1).ToString();
                textBoxStudentNE.Text = (currentStudentNumber + 1).ToString();
                helpcurr = currentStudentNumber;
            }
            catch
            {
                MessageBox.Show("List is empty");
            }
        }

    }
}
