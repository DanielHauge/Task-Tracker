using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GlacialComponents.Controls;
using EXControls;
using System.Threading;

namespace Task_Tracker
{
    
    
    public partial class Panel : Form
    {
        public bool pinned;
        public bool sizestatus;
        public bool DropDownChanged;
        public int TotalLows;
        public int TotalMeds;
        public int TotalCrits;
        EXListView lsv;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        protected override void OnPaint(PaintEventArgs e)
        {
            
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Outset);
        }

        public Panel()
        {
            InitializeComponent();
            this.ResizeRedraw = true;
            
            
            
        }
        
        private void Panel_Load(object sender, EventArgs e)
        {
            Location = new Point(Screen.AllScreens[0].WorkingArea.Right-Width, Screen.AllScreens[0].WorkingArea.Top);
            
            pinned = true;
            sizestatus = false;
            DropDownChanged = false;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            InitTasks();
            
        }


        private void InitTasks()
        {
            panel1.Controls.Clear();
            Console.WriteLine("INITING");
            #region Listview Init -------  Initializing Listview
            lsv = new EXListView();
            lsv.MultiSelect = false;
            panel1.Controls.Add(lsv);
            lsv.Dock = DockStyle.Fill;
            lsv.AllowColumnReorder = false;
            lsv.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            lsv.BackColor = SystemColors.ActiveCaption;
            lsv.HeaderStyle = ColumnHeaderStyle.None;
            #endregion 
            #region Headers Init -------  Initializing Headers
            EXColumnHeader imgHeader = new EXColumnHeader(" ", 0);
            EXColumnHeader ButtonHeader = new EXColumnHeader("", 25);
            EXColumnHeader NavnHeader = new EXColumnHeader("Navn", 150);
            EXEditableColumnHeader CustomHeader = new EXEditableColumnHeader("Custom", 80);
            EXColumnHeader TimeHeader = new EXColumnHeader("Tid");
            lsv.Columns.Add(imgHeader);
            lsv.Columns.Add(ButtonHeader);
            lsv.Columns.Add(NavnHeader);
            lsv.Columns.Add(CustomHeader);
            lsv.Columns.Add(TimeHeader);
            #endregion
            #region Groups Init -------  Initializing Groups (Crit,Med,low)
            ListViewGroup CriticalGroup = new ListViewGroup("Critical");
            ListViewGroup MediumGroup = new ListViewGroup("Medium");
            ListViewGroup LowGroup = new ListViewGroup("Low");
            lsv.Groups.Add(CriticalGroup);
            lsv.Groups.Add(MediumGroup);
            lsv.Groups.Add(LowGroup);
            #endregion
            #region Init Items -------  Initializing Data to lists

            string connectionstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\Animc\onedrive\dokumenter\visual studio 2017\Projects\Task-Tracker\Task-Tracker\TaskDB.mdf'; Integrated Security = True";
            DataConnection DB = new DataConnection(connectionstring);
            List<Task> TaskToInit = DB.GetAllTasks();



            TotalCrits = 0;
            TotalMeds = 0;
            TotalLows = 0;
            Console.WriteLine(DateTime.Now);
            foreach (Task t in TaskToInit)
            {
                
                EXImageListViewItem temp = new EXImageListViewItem("IMAGE");
                temp.Name = t.ID.ToString();
                EXControlListViewSubItem TempButtonControll = new EXControlListViewSubItem();
                Button btn = new Button();
                btn.Height = 10;
                btn.Text = "";
                btn.Name = t.ID.ToString();
                lsv.AddControlToSubItem(btn, TempButtonControll);
                EXListViewSubItem TempNavn = new EXListViewSubItem();
                TempNavn.Text = t.navn;
                EXListViewSubItem TempTid = new EXListViewSubItem();
                double tids = ((((t.LastDone.Add(t.CritTime)-DateTime.Now).TotalDays)));
                int tids2 = (int)tids;
                TempTid.Text = tids2.ToString() + " Dage";
                EXControlListViewSubItem TempControll = new EXControlListViewSubItem();
                temp.SubItems.Add(TempButtonControll);
                temp.SubItems.Add(TempNavn);

                if (t.Type == Task.TaskType.Chore)
                {
                    btn.Click += new System.EventHandler(ChoreClick);
                    ProgressBar progress = new ProgressBar();
                    progress.Minimum = 0;
                    progress.Maximum = 1000;
                    progress.Step = 1;
                    double PromileValue = t.CritTime.TotalMinutes / 1000;
                    double ValueForProgress = (DateTime.Now - t.LastDone).TotalMinutes / PromileValue;
                    if (ValueForProgress > 1000)
                    {
                        progress.Value = 1000;
                    }
                    else
                    {
                        progress.Value = (int)ValueForProgress;
                    }
                    
                    lsv.AddControlToSubItem(progress, TempControll);

                    if (DateTime.Now >= t.LastDone.Add(t.CritTime))
                    {
                        // ADD AS CRIT
                        temp.BackColor = Color.OrangeRed;
                        TempButtonControll.BackColor = Color.OrangeRed;
                        TempNavn.BackColor = Color.OrangeRed;
                        TempTid.BackColor = Color.OrangeRed;
                        TempControll.BackColor = Color.OrangeRed;
                        temp.Group = CriticalGroup;
                        TotalCrits++;
                    }
                    else if (DateTime.Now >= t.LastDone.Add(t.MedTime))
                    {
                        // ADD AS MED
                        temp.BackColor = Color.Yellow;
                        TempButtonControll.BackColor = Color.Yellow;
                        TempNavn.BackColor = Color.Yellow;
                        TempTid.BackColor = Color.Yellow;
                        TempControll.BackColor = Color.Yellow;
                        temp.Group = MediumGroup;
                        TotalMeds++;
                    }
                    else
                    {
                        // ADD AS LOW
                        temp.BackColor = Color.SteelBlue;
                        TempButtonControll.BackColor = Color.SteelBlue;
                        TempNavn.BackColor = Color.SteelBlue;
                        TempTid.BackColor = Color.SteelBlue;
                        TempControll.BackColor = Color.SteelBlue;
                        temp.Group = LowGroup;
                        TotalLows++;
                    }




                }
                else if (t.Type == Task.TaskType.ChoreWhenReady)
                {
                    btn.Click += new System.EventHandler(ReadyClick);
                    int tids3 = (int)((DateTime.Now - t.LastDone).TotalDays);
                    TempTid.Text = tids3.ToString() + " Dage";
                    ComboBox Comb = new ComboBox();
                    Comb.Items.Add("Not ready");
                    Comb.Items.Add("Doable");
                    Comb.Items.Add("Need to");
                    Comb.Name = t.ID.ToString();
                    Comb.ItemHeight = 6;
                    Comb.DropDownStyle = ComboBoxStyle.DropDownList;
                    Comb.Font = new System.Drawing.Font("Arial", 6, System.Drawing.FontStyle.Bold);
                    Comb.Height = Comb.PreferredHeight;
                    lsv.AddControlToSubItem(Comb, TempControll);
                    Comb.Click += new System.EventHandler(ComboClicked);
                    Comb.SelectedIndexChanged += new System.EventHandler(CombSelectedChanged);
                    ///Drop Down

                    if (t.Status == Task.TaskStatus.Critical)
                    {
                        // ADD AS CRIT
                        temp.BackColor = Color.OrangeRed;
                        TempButtonControll.BackColor = Color.OrangeRed;
                        TempNavn.BackColor = Color.OrangeRed;
                        TempTid.BackColor = Color.OrangeRed;
                        TempControll.BackColor = Color.OrangeRed;
                        temp.Group = CriticalGroup;
                        Comb.SelectedItem = Comb.Items[2];
                        TotalCrits++;
                    }
                    else if (t.Status == Task.TaskStatus.Medium)
                    {
                        // ADD AS MED
                        temp.BackColor = Color.Yellow;
                        TempButtonControll.BackColor = Color.Yellow;
                        TempNavn.BackColor = Color.Yellow;
                        TempTid.BackColor = Color.Yellow;
                        TempControll.BackColor = Color.Yellow;
                        temp.Group = MediumGroup;
                        Comb.SelectedItem = Comb.Items[1];
                        TotalMeds++;
                    }
                    else
                    {
                        // ADD AS LOW
                        temp.BackColor = Color.SteelBlue;
                        TempButtonControll.BackColor = Color.SteelBlue;
                        TempNavn.BackColor = Color.SteelBlue;
                        TempTid.BackColor = Color.SteelBlue;
                        TempControll.BackColor = Color.SteelBlue;
                        temp.Group = LowGroup;
                        Comb.SelectedItem = Comb.Items[0];
                        TotalLows++;
                    }
                }
                else if (t.Type == Task.TaskType.Activity_Event)
                {
                    btn.Click += new System.EventHandler(EventClick);
                    ProgressBar progress = new ProgressBar();
                    progress.Minimum = 0;
                    progress.Maximum = 1000;
                    progress.Step = 1;
                    double PromileValue = t.CritTime.TotalMinutes / 1000;
                    double ValueForProgress = (DateTime.Now - t.LastDone).TotalMinutes / PromileValue;
                    if (ValueForProgress > 1000)
                    {
                        progress.Value = 1000;
                    }
                    else
                    {
                        progress.Value = (int)ValueForProgress;
                    }

                    lsv.AddControlToSubItem(progress, TempControll);

                    if (DateTime.Now  >= t.LastDone.Add(t.CritTime))
                    {
                        // ADD AS CRIT
                        temp.BackColor = Color.OrangeRed;
                        TempButtonControll.BackColor = Color.OrangeRed;
                        TempNavn.BackColor = Color.OrangeRed;
                        TempTid.BackColor = Color.OrangeRed;
                        TempControll.BackColor = Color.OrangeRed;
                        temp.Group = CriticalGroup;
                        TotalCrits++;
                    }
                    else if (DateTime.Now >= t.LastDone.Add(t.MedTime))
                    {
                        // ADD AS MED
                        temp.BackColor = Color.Yellow;
                        TempButtonControll.BackColor = Color.Yellow;
                        TempNavn.BackColor = Color.Yellow;
                        TempTid.BackColor = Color.Yellow;
                        TempControll.BackColor = Color.Yellow;
                        temp.Group = MediumGroup;
                        TotalMeds++;
                    }
                    else
                    {
                        // ADD AS LOW
                        temp.BackColor = Color.SteelBlue;
                        TempButtonControll.BackColor = Color.SteelBlue;
                        TempNavn.BackColor = Color.SteelBlue;
                        TempTid.BackColor = Color.SteelBlue;
                        TempControll.BackColor = Color.SteelBlue;
                        temp.Group = LowGroup;
                        TotalLows++;
                    }
                }
                temp.SubItems.Add(TempControll);
                temp.SubItems.Add(TempTid);
                lsv.Items.Add(temp);
                

            }

            CritLabel.Text = TotalCrits.ToString();
            MedLabel.Text = TotalMeds.ToString();
            LowLabel.Text = TotalLows.ToString();

            #endregion









            #region Example Init
            /*
            EXImageListViewItem TestItem = new EXImageListViewItem();
            TestItem.Group = CriticalGroup;
            TestItem.BackColor = Color.Red;
            EXListViewSubItem TestsubItem = new EXListViewSubItem("Test Subitem");
            TestsubItem.Text = "Tes VASKETØJ";
            TestsubItem.BackColor = Color.Red;
            TestItem.SubItems.Add(TestsubItem);
            EXControlListViewSubItem Progressbar = new EXControlListViewSubItem();
            Progressbar.BackColor = Color.Red;
            ProgressBar b = new ProgressBar();
            b.Minimum = 0;
            b.Maximum = 1000;
            b.Step = 1;
            TestItem.SubItems.Add(Progressbar);
            lsv.Items.Add(TestItem);
            lsv.AddControlToSubItem(b, Progressbar);
            EXListViewSubItem TestsubItems = new EXListViewSubItem("Test Subitem");
            TestsubItems.Text = "13 Dage";
            TestsubItems.BackColor = Color.Red;
            TestItem.SubItems.Add(TestsubItems);


            //2

            EXImageListViewItem TestItem2 = new EXImageListViewItem();
            TestItem2.Group = MediumGroup;
            TestItem2.BackColor = Color.Red;

            EXListViewSubItem TestsubItem2 = new EXListViewSubItem("Test Subitem");
            TestsubItem2.Text = "Test432";
            TestsubItem2.BackColor = Color.Red;
            TestItem2.SubItems.Add(TestsubItem2);
            EXControlListViewSubItem Progressbar2 = new EXControlListViewSubItem();
            Progressbar2.BackColor = Color.Red;
            ProgressBar b2 = new ProgressBar();
            b2.Minimum = 0;
            b2.Maximum = 1000;
            b2.Step = 1;
            TestItem2.SubItems.Add(Progressbar2);
            lsv.Items.Add(TestItem2);
            lsv.AddControlToSubItem(b2, Progressbar2);
            */
            #endregion
        }


        #region EventsMethods

        private void ComboClicked(object sender, EventArgs e)
        {
            DropDownChanged = true;
            
        }

        private void EventClick(object sender, EventArgs e)
        {
            Console.WriteLine("Clicked");

            DialogResult dialogResult = MessageBox.Show("Sikker på ændring?", "Done!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Button btn = (Button)sender;
                Console.WriteLine(btn.Name);
                string connectionstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\Animc\onedrive\dokumenter\visual studio 2017\Projects\Task-Tracker\Task-Tracker\TaskDB.mdf'; Integrated Security = True";
                DataConnection db = new DataConnection(connectionstring);
                db.DeleteTask(int.Parse(btn.Name));
                
                InitTasks();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }


            
        }

        private void ReadyClick(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Sikker på ændring?", "Done!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Console.WriteLine("Clicked");
                Button btn = (Button)sender;
                Console.WriteLine(btn.Name);
                string connectionstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\Animc\onedrive\dokumenter\visual studio 2017\Projects\Task-Tracker\Task-Tracker\TaskDB.mdf'; Integrated Security = True";
                DataConnection db = new DataConnection(connectionstring);
                Task Updating = db.GetTask(int.Parse(btn.Name));
                Updating.LastDone = DateTime.Now;
                db.UpdateTask(Updating);
                InitTasks();
            }
            else if (dialogResult == DialogResult.No)
            {
                InitTasks();
            }

            
        }

        private void ChoreClick(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Sikker på ændring?", "Done!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Console.WriteLine("Clicked");
                Button btn = (Button)sender;
                Console.WriteLine(btn.Name);
                string connectionstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\Animc\onedrive\dokumenter\visual studio 2017\Projects\Task-Tracker\Task-Tracker\TaskDB.mdf'; Integrated Security = True";
                DataConnection db = new DataConnection(connectionstring);
                Task Updating = db.GetTask(int.Parse(btn.Name));
                Updating.LastDone = DateTime.Now;
                db.UpdateTask(Updating);
                InitTasks();
            }
            else if (dialogResult == DialogResult.No)
            {
                InitTasks();
            }

            
        }

        private void CombSelectedChanged(object sender, EventArgs e)
        {
            if (DropDownChanged)
            {
                
                Console.WriteLine("ComboChanged");
                ComboBox combo = (ComboBox)sender;
                Console.WriteLine(combo.Name);
                string connectionstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\Animc\onedrive\dokumenter\visual studio 2017\Projects\Task-Tracker\Task-Tracker\TaskDB.mdf'; Integrated Security = True";
                DataConnection db = new DataConnection(connectionstring);
                Task Updating = db.GetTask(int.Parse(combo.Name));
                if (combo.SelectedIndex == 0)
                {
                    Updating.Status = Task.TaskStatus.Low;
                }
                else if (combo.SelectedIndex == 1)
                {
                    Updating.Status = Task.TaskStatus.Medium;
                }
                else if (combo.SelectedIndex == 2)
                {
                    Updating.Status = Task.TaskStatus.Critical;
                }

                db.UpdateTask(Updating);
                
                DropDownChanged = false;
                panel1.Controls.Clear();
                InitTasks();
            }
        }

        private void PanelClick(Object sender, EventArgs e)
        {
            Console.WriteLine("CLICKED");
            this.tm.Enabled = true;
            sizestatus = !sizestatus;
            
        }

        private void PanelLeave(Object sender, EventArgs e)
        {
            Console.WriteLine("LEAVE");
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("TRYING");
            if (!sizestatus)
            {
                if (this.Height >= 500)
                {
                    tm.Enabled = false;
                }
                else
                {
                    this.Height += 10;
                        }
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            }
            else
            {
                if (this.Height <= 50) tm.Enabled = false;
                else this.Height -= 10;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            #region Testing Creation
            /*
            string connectionstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\Animc\onedrive\dokumenter\visual studio 2017\Projects\Task-Tracker\Task-Tracker\TaskDB.mdf'; Integrated Security = True";
            DataConnection db = new DataConnection(connectionstring);

            Task testtask = new Task("TEST1", Task.TaskType.ChoreWhenReady, new TimeSpan(10, 1, 10, 10), new TimeSpan(2, 1, 10, 10));
            testtask.Status = Task.TaskStatus.Low;

            testtask.LastDone = DateTime.Parse("7/1/17 9:44:27 PM");
            
            db.CreateData(testtask);
            #endregion 
             */
            //// Create Task!
            #endregion

            CreateForms CreateNew = new CreateForms();
            CreateNew.Show();

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                lsv.SelectedItems[0].Name.ToString();
                
                Console.WriteLine(lsv.SelectedItems[0].Name.ToString());


                DialogResult dialogResult = MessageBox.Show("Sikker på Sletning af: " + lsv.SelectedItems[0].SubItems[2].Text+ " ?", "Done!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Console.WriteLine("Clicked");
                    Button btn = (Button)sender;
                    Console.WriteLine(btn.Name);
                    string connectionstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\Animc\onedrive\dokumenter\visual studio 2017\Projects\Task-Tracker\Task-Tracker\TaskDB.mdf'; Integrated Security = True";
                    DataConnection db = new DataConnection(connectionstring);
                    db.DeleteTask(int.Parse(lsv.SelectedItems[0].Name.ToString()));
                    InitTasks();
                }
                else if (dialogResult == DialogResult.No)
                {
                    InitTasks();
                }
            }

            catch (Exception error)
            {
                Console.WriteLine("{0} Exception caught.", error);
            }
            }
        #endregion

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            InitTasks();
        }
    }
}
