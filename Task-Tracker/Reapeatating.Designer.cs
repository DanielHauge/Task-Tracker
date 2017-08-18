namespace Task_Tracker
{
    partial class Reapeatating
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.NavnBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MedMin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MedTimer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MedDage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MedUger = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CritMin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CritTimer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CritDage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CritUger = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.NavnBox);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 331);
            this.panel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Navn / Beskrivelse:";
            // 
            // NavnBox
            // 
            this.NavnBox.Location = new System.Drawing.Point(111, 10);
            this.NavnBox.Name = "NavnBox";
            this.NavnBox.Size = new System.Drawing.Size(277, 20);
            this.NavnBox.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 62);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 62);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MedMin);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.MedTimer);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.MedDage);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.MedUger);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(0, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 82);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medium Time";
            // 
            // MedMin
            // 
            this.MedMin.Location = new System.Drawing.Point(322, 32);
            this.MedMin.Name = "MedMin";
            this.MedMin.Size = new System.Drawing.Size(41, 20);
            this.MedMin.TabIndex = 7;
            this.MedMin.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Min";
            // 
            // MedTimer
            // 
            this.MedTimer.Location = new System.Drawing.Point(236, 32);
            this.MedTimer.Name = "MedTimer";
            this.MedTimer.Size = new System.Drawing.Size(41, 20);
            this.MedTimer.TabIndex = 5;
            this.MedTimer.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Timer";
            // 
            // MedDage
            // 
            this.MedDage.Location = new System.Drawing.Point(150, 32);
            this.MedDage.Name = "MedDage";
            this.MedDage.Size = new System.Drawing.Size(41, 20);
            this.MedDage.TabIndex = 3;
            this.MedDage.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(111, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Dage";
            // 
            // MedUger
            // 
            this.MedUger.Location = new System.Drawing.Point(64, 32);
            this.MedUger.Name = "MedUger";
            this.MedUger.Size = new System.Drawing.Size(41, 20);
            this.MedUger.TabIndex = 1;
            this.MedUger.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Uger";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CritMin);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CritTimer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CritDage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CritUger);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 82);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Critical Time";
            // 
            // CritMin
            // 
            this.CritMin.Location = new System.Drawing.Point(322, 32);
            this.CritMin.Name = "CritMin";
            this.CritMin.Size = new System.Drawing.Size(41, 20);
            this.CritMin.TabIndex = 7;
            this.CritMin.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Min";
            // 
            // CritTimer
            // 
            this.CritTimer.Location = new System.Drawing.Point(236, 32);
            this.CritTimer.Name = "CritTimer";
            this.CritTimer.Size = new System.Drawing.Size(41, 20);
            this.CritTimer.TabIndex = 5;
            this.CritTimer.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Timer";
            // 
            // CritDage
            // 
            this.CritDage.Location = new System.Drawing.Point(150, 32);
            this.CritDage.Name = "CritDage";
            this.CritDage.Size = new System.Drawing.Size(41, 20);
            this.CritDage.TabIndex = 3;
            this.CritDage.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dage";
            // 
            // CritUger
            // 
            this.CritUger.Location = new System.Drawing.Point(64, 32);
            this.CritUger.Name = "CritUger";
            this.CritUger.Size = new System.Drawing.Size(41, 20);
            this.CritUger.TabIndex = 1;
            this.CritUger.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Uger";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Last Done";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(111, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(187, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // Reapeatating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Reapeatating";
            this.Size = new System.Drawing.Size(400, 347);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox MedMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MedTimer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MedDage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MedUger;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CritMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CritTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CritDage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CritUger;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox NavnBox;
    }
}
