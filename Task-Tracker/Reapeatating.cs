using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Tracker
{
    public partial class Reapeatating : UserControl
    {
        public Reapeatating()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\Animc\onedrive\dokumenter\visual studio 2017\Projects\Task-Tracker\Task-Tracker\TaskDB.mdf'; Integrated Security = True";
            DataConnection db = new DataConnection(connectionstring);
            Task testtask = new Task(NavnBox.Text, Task.TaskType.Chore, new TimeSpan((int.Parse(CritUger.Text)*7)+int.Parse(CritDage.Text), int.Parse(CritTimer.Text), int.Parse(CritMin.Text), 0) , new TimeSpan((int.Parse(MedUger.Text) * 7) + int.Parse(MedDage.Text), int.Parse(MedTimer.Text), int.Parse(MedMin.Text), 0));
            testtask.Status = Task.TaskStatus.Low;
            testtask.LastDone = dateTimePicker1.Value;
            db.CreateData(testtask);
            this.ParentForm.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
