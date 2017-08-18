using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Tracker
{
    public partial class CreateForms : Form
    {
        public CreateForms()
        {
            InitializeComponent();
            

        }

        private void CreateBut_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RepeatRadio_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new Reapeatating());
        }



        private void ReadyRadio_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new WhenReady());
        }

        private void EventRadio_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new ActivityEvent());
        }
    }
}
