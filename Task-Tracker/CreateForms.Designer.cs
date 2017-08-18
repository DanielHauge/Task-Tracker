namespace Task_Tracker
{
    partial class CreateForms
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RepeatRadio = new System.Windows.Forms.RadioButton();
            this.EventRadio = new System.Windows.Forms.RadioButton();
            this.ReadyRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RepeatRadio
            // 
            this.RepeatRadio.AutoSize = true;
            this.RepeatRadio.Location = new System.Drawing.Point(48, 19);
            this.RepeatRadio.Name = "RepeatRadio";
            this.RepeatRadio.Size = new System.Drawing.Size(74, 17);
            this.RepeatRadio.TabIndex = 4;
            this.RepeatRadio.TabStop = true;
            this.RepeatRadio.Text = "Repeating";
            this.RepeatRadio.UseVisualStyleBackColor = true;
            this.RepeatRadio.CheckedChanged += new System.EventHandler(this.RepeatRadio_CheckedChanged);
            // 
            // EventRadio
            // 
            this.EventRadio.AutoSize = true;
            this.EventRadio.Location = new System.Drawing.Point(224, 19);
            this.EventRadio.Name = "EventRadio";
            this.EventRadio.Size = new System.Drawing.Size(92, 17);
            this.EventRadio.TabIndex = 6;
            this.EventRadio.TabStop = true;
            this.EventRadio.Text = "Activity/Event";
            this.EventRadio.UseVisualStyleBackColor = true;
            this.EventRadio.CheckedChanged += new System.EventHandler(this.EventRadio_CheckedChanged);
            // 
            // ReadyRadio
            // 
            this.ReadyRadio.AutoSize = true;
            this.ReadyRadio.Location = new System.Drawing.Point(128, 19);
            this.ReadyRadio.Name = "ReadyRadio";
            this.ReadyRadio.Size = new System.Drawing.Size(88, 17);
            this.ReadyRadio.TabIndex = 7;
            this.ReadyRadio.TabStop = true;
            this.ReadyRadio.Text = "When Ready";
            this.ReadyRadio.UseVisualStyleBackColor = true;
            this.ReadyRadio.CheckedChanged += new System.EventHandler(this.ReadyRadio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ReadyRadio);
            this.groupBox1.Controls.Add(this.RepeatRadio);
            this.groupBox1.Controls.Add(this.EventRadio);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 52);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task Type";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(28, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 365);
            this.panel1.TabIndex = 9;
            // 
            // CreateForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 447);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateForms";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton RepeatRadio;
        private System.Windows.Forms.RadioButton EventRadio;
        private System.Windows.Forms.RadioButton ReadyRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
    }
}