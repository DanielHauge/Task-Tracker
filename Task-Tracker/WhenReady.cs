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
    public partial class WhenReady : UserControl
    {
        public WhenReady()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\Animc\onedrive\dokumenter\visual studio 2017\Projects\Task-Tracker\Task-Tracker\TaskDB.mdf'; Integrated Security = True";
            DataConnection db = new DataConnection(connectionstring);
            Task testtask = new Task(NavnBox.Text, Task.TaskType.ChoreWhenReady, new TimeSpan(0,0,0,0), new TimeSpan(0,0,0,0));
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
