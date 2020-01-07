namespace ParallelTasksAsync
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSeq3 = new System.Windows.Forms.Label();
            this.lblSeq2 = new System.Windows.Forms.Label();
            this.lblSeq1 = new System.Windows.Forms.Label();
            this.lblSequence = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.grpTask3 = new System.Windows.Forms.GroupBox();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.grpTask2 = new System.Windows.Forms.GroupBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.grpTask1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.chkTask3 = new System.Windows.Forms.CheckBox();
            this.chkTask2 = new System.Windows.Forms.CheckBox();
            this.chkTask1 = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCustom = new System.Windows.Forms.Label();
            this.lblDefault = new System.Windows.Forms.Label();
            this.lblDfSeq1 = new System.Windows.Forms.Label();
            this.lblDfTask2 = new System.Windows.Forms.Label();
            this.lblDfTask3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpTask3.SuspendLayout();
            this.grpTask2.SuspendLayout();
            this.grpTask1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnAddTask);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.grpTask3);
            this.panel1.Controls.Add(this.grpTask2);
            this.panel1.Controls.Add(this.grpTask1);
            this.panel1.Controls.Add(this.chkTask3);
            this.panel1.Controls.Add(this.chkTask2);
            this.panel1.Controls.Add(this.chkTask1);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 327);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblDfTask3);
            this.panel2.Controls.Add(this.lblDfTask2);
            this.panel2.Controls.Add(this.lblDfSeq1);
            this.panel2.Controls.Add(this.lblDefault);
            this.panel2.Controls.Add(this.lblCustom);
            this.panel2.Controls.Add(this.lblSeq3);
            this.panel2.Controls.Add(this.lblSeq2);
            this.panel2.Controls.Add(this.lblSeq1);
            this.panel2.Controls.Add(this.lblSequence);
            this.panel2.Location = new System.Drawing.Point(320, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 151);
            this.panel2.TabIndex = 4;
            // 
            // lblSeq3
            // 
            this.lblSeq3.AutoSize = true;
            this.lblSeq3.Location = new System.Drawing.Point(120, 123);
            this.lblSeq3.Name = "lblSeq3";
            this.lblSeq3.Size = new System.Drawing.Size(0, 13);
            this.lblSeq3.TabIndex = 3;
            // 
            // lblSeq2
            // 
            this.lblSeq2.AutoSize = true;
            this.lblSeq2.Location = new System.Drawing.Point(120, 97);
            this.lblSeq2.Name = "lblSeq2";
            this.lblSeq2.Size = new System.Drawing.Size(0, 13);
            this.lblSeq2.TabIndex = 2;
            // 
            // lblSeq1
            // 
            this.lblSeq1.AutoSize = true;
            this.lblSeq1.Location = new System.Drawing.Point(120, 73);
            this.lblSeq1.Name = "lblSeq1";
            this.lblSeq1.Size = new System.Drawing.Size(0, 13);
            this.lblSeq1.TabIndex = 1;
            // 
            // lblSequence
            // 
            this.lblSequence.AutoSize = true;
            this.lblSequence.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSequence.Location = new System.Drawing.Point(31, 4);
            this.lblSequence.Name = "lblSequence";
            this.lblSequence.Size = new System.Drawing.Size(151, 23);
            this.lblSequence.TabIndex = 0;
            this.lblSequence.Text = "Task Sequence";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(423, 9);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(97, 25);
            this.btnAddTask.TabIndex = 3;
            this.btnAddTask.Text = "Add Task(s)";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.BtnAddTask_ClickAsync);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(320, 9);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(97, 25);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Task(s)";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // grpTask3
            // 
            this.grpTask3.Controls.Add(this.progressBar3);
            this.grpTask3.Location = new System.Drawing.Point(15, 240);
            this.grpTask3.Name = "grpTask3";
            this.grpTask3.Size = new System.Drawing.Size(298, 78);
            this.grpTask3.TabIndex = 1;
            this.grpTask3.TabStop = false;
            this.grpTask3.Text = "Task 3";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(9, 36);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(230, 23);
            this.progressBar3.TabIndex = 0;
            // 
            // grpTask2
            // 
            this.grpTask2.Controls.Add(this.progressBar2);
            this.grpTask2.Location = new System.Drawing.Point(15, 147);
            this.grpTask2.Name = "grpTask2";
            this.grpTask2.Size = new System.Drawing.Size(298, 78);
            this.grpTask2.TabIndex = 1;
            this.grpTask2.TabStop = false;
            this.grpTask2.Text = "Task 2";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(9, 34);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(230, 23);
            this.progressBar2.TabIndex = 0;
            // 
            // grpTask1
            // 
            this.grpTask1.Controls.Add(this.progressBar1);
            this.grpTask1.Location = new System.Drawing.Point(15, 63);
            this.grpTask1.Name = "grpTask1";
            this.grpTask1.Size = new System.Drawing.Size(298, 78);
            this.grpTask1.TabIndex = 1;
            this.grpTask1.TabStop = false;
            this.grpTask1.Text = "Task 1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 30);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(230, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // chkTask3
            // 
            this.chkTask3.AutoSize = true;
            this.chkTask3.Location = new System.Drawing.Point(244, 26);
            this.chkTask3.Name = "chkTask3";
            this.chkTask3.Size = new System.Drawing.Size(56, 17);
            this.chkTask3.TabIndex = 0;
            this.chkTask3.Text = "Task3";
            this.chkTask3.UseVisualStyleBackColor = true;
            this.chkTask3.CheckedChanged += new System.EventHandler(this.ChkTask3_CheckedChanged);
            // 
            // chkTask2
            // 
            this.chkTask2.AutoSize = true;
            this.chkTask2.Location = new System.Drawing.Point(134, 26);
            this.chkTask2.Name = "chkTask2";
            this.chkTask2.Size = new System.Drawing.Size(56, 17);
            this.chkTask2.TabIndex = 0;
            this.chkTask2.Text = "Task2";
            this.chkTask2.UseVisualStyleBackColor = true;
            this.chkTask2.CheckedChanged += new System.EventHandler(this.ChkTask2_CheckedChanged);
            // 
            // chkTask1
            // 
            this.chkTask1.AutoSize = true;
            this.chkTask1.Location = new System.Drawing.Point(24, 26);
            this.chkTask1.Name = "chkTask1";
            this.chkTask1.Size = new System.Drawing.Size(56, 17);
            this.chkTask1.TabIndex = 0;
            this.chkTask1.Text = "Task1";
            this.chkTask1.UseVisualStyleBackColor = true;
            this.chkTask1.CheckedChanged += new System.EventHandler(this.ChkTask1_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(320, 41);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // lblCustom
            // 
            this.lblCustom.AutoSize = true;
            this.lblCustom.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustom.Location = new System.Drawing.Point(114, 40);
            this.lblCustom.Name = "lblCustom";
            this.lblCustom.Size = new System.Drawing.Size(59, 19);
            this.lblCustom.TabIndex = 4;
            this.lblCustom.Text = "Custom";
            // 
            // lblDefault
            // 
            this.lblDefault.AutoSize = true;
            this.lblDefault.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefault.Location = new System.Drawing.Point(21, 40);
            this.lblDefault.Name = "lblDefault";
            this.lblDefault.Size = new System.Drawing.Size(57, 19);
            this.lblDefault.TabIndex = 4;
            this.lblDefault.Text = "Default";
            // 
            // lblDfSeq1
            // 
            this.lblDfSeq1.AutoSize = true;
            this.lblDfSeq1.Location = new System.Drawing.Point(28, 73);
            this.lblDfSeq1.Name = "lblDfSeq1";
            this.lblDfSeq1.Size = new System.Drawing.Size(37, 13);
            this.lblDfSeq1.TabIndex = 5;
            this.lblDfSeq1.Text = "Task1";
            // 
            // lblDfTask2
            // 
            this.lblDfTask2.AutoSize = true;
            this.lblDfTask2.Location = new System.Drawing.Point(28, 97);
            this.lblDfTask2.Name = "lblDfTask2";
            this.lblDfTask2.Size = new System.Drawing.Size(37, 13);
            this.lblDfTask2.TabIndex = 6;
            this.lblDfTask2.Text = "Task2";
            // 
            // lblDfTask3
            // 
            this.lblDfTask3.AutoSize = true;
            this.lblDfTask3.Location = new System.Drawing.Point(28, 123);
            this.lblDfTask3.Name = "lblDfTask3";
            this.lblDfTask3.Size = new System.Drawing.Size(37, 13);
            this.lblDfTask3.TabIndex = 7;
            this.lblDfTask3.Text = "Task3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 331);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "ParallelAsync";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpTask3.ResumeLayout(false);
            this.grpTask2.ResumeLayout(false);
            this.grpTask1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox grpTask3;
        private System.Windows.Forms.GroupBox grpTask2;
        private System.Windows.Forms.GroupBox grpTask1;
        private System.Windows.Forms.CheckBox chkTask3;
        private System.Windows.Forms.CheckBox chkTask2;
        private System.Windows.Forms.CheckBox chkTask1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSeq3;
        private System.Windows.Forms.Label lblSeq2;
        private System.Windows.Forms.Label lblSeq1;
        private System.Windows.Forms.Label lblSequence;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblDfTask3;
        private System.Windows.Forms.Label lblDfTask2;
        private System.Windows.Forms.Label lblDfSeq1;
        private System.Windows.Forms.Label lblDefault;
        private System.Windows.Forms.Label lblCustom;
    }
}

