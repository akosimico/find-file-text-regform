using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp24
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string fullFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), StudentNo.Text + ".txt");

            using (FileStream fs = new FileStream(fullFilePath, FileMode.Create, FileAccess.Write))
            using (StreamWriter writer = new StreamWriter(fs))
            {
                string studentNo = StudentNo.Text;
                string fullName = $"{LastName.Text}, {FirstName.Text}, {Middle.Text}";
                string program = Course.SelectedItem.ToString();
                string gender = Gender.SelectedItem.ToString();
                string age = Age.Text;
                string birthday = dateTimePicker1.Value.ToShortDateString();
                string contactNo = ContactNo.Text;

                writer.WriteLine($"Student No.: {studentNo}");
                writer.WriteLine($"FUll Name: {fullName}");
                writer.WriteLine($"Program: {program}");
                writer.WriteLine($"Gender: {gender}");
                writer.WriteLine($"Age: {age}");
                writer.WriteLine($"Birthday: {birthday}");
                writer.WriteLine($"Contact No.: {contactNo}");
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
