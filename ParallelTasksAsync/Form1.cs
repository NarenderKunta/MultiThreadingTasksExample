using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelTasksAsync
{
    public partial class Form1 : Form
    {
        TaskScheduler uiScheduler;        
        private static Queue<Action> MyQueue = new Queue<Action>();
        private static readonly object queuelock = new object();
        private bool FinishedTask1;
        private bool FinishedTask2;
        private bool FinishedTask3;

        public Form1()
        {
            InitializeComponent();
            InitializeComponent2();
        }     

        private void Form1_Load(object sender, EventArgs e)
        {
            uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();
        }


        private void BtnStart_Click(object sender, EventArgs e)
        {
            MyQueue.Enqueue(Task1);
            MyQueue.Enqueue(Task2);
            MyQueue.Enqueue(Task3);
            ExecuteTasks();
        }


        private void Task1()
        {
            if (!FinishedTask1)
            {
                FinishedTask1 = true;
                progressBar1.Value = 0;
                BusinessLayer BL = new BusinessLayer();
                BL.PrepareTask1((message) => UpdateProgressBar1(message));
            }
            //Thread.Sleep(200);
        }

        private  void Task2()
        {
            if (!FinishedTask2)
            {
                FinishedTask2 = true;
                progressBar2.Value = 0;
                BusinessLayer BL = new BusinessLayer();
                BL.PrepareTask2((message) => UpdateProgressBar2(message));
            }
            //FinishedTask2 = true;
        }

        private  void Task3()
        {
            if (!FinishedTask3)
            {
                FinishedTask3 = true;
                progressBar3.Value = 0;
                BusinessLayer BL = new BusinessLayer();
                BL.PrepareTask3((message) => UpdateProgressBar3(message));
            }
            //FinishedTask3 = true;
        }

        private void BtnAddTask_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                if (lblSeq1.Text != string.Empty)
                {
                    if (lblSeq1.Text == "Task1")
                    {
                        MyQueue.Enqueue(Task1);
                    }
                    else if (lblSeq1.Text == "Task2")
                    {
                        MyQueue.Enqueue(Task2);
                    }
                    else if (lblSeq1.Text == "Task3")
                    {
                        MyQueue.Enqueue(Task3);
                    }

                }
                if (lblSeq2.Text != string.Empty)
                {
                    if (lblSeq2.Text == "Task1")
                    {
                        MyQueue.Enqueue(Task1);
                    }
                    else if (lblSeq2.Text == "Task2")
                    {
                        MyQueue.Enqueue(Task2);
                    }
                    else if (lblSeq2.Text == "Task3")
                    {
                        MyQueue.Enqueue(Task3);
                    }

                }
                if (lblSeq3.Text != string.Empty)
                {
                    if (lblSeq3.Text == "Task1")
                    {
                        MyQueue.Enqueue(Task1);
                    }
                    else if (lblSeq3.Text == "Task2")
                    {
                        MyQueue.Enqueue(Task2);
                    }
                    else if (lblSeq3.Text == "Task3")
                    {
                        MyQueue.Enqueue(Task3);
                    }

                }


                ExecuteTasks();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async void ExecuteTasks()
        {
            while (true)
            {
                Action task = null;
                lock (queuelock)
                {
                    if (MyQueue.Count > 0)
                    {
                        task = MyQueue.Dequeue();
                    }
                }

                if (task != null)
                {
                    await Task.Run(() =>
                    {
                        task.Invoke();
                        Thread.Sleep(1000);
                    });
                }
                else
                {
                    return;
                }
            }
        }

        private void UpdateProgressBar1(string statusMessage)
        {
            Task.Factory.StartNew(() =>
            {
                progressBar1.PerformStep();
                btnStart.Enabled = true;
            }, CancellationToken.None, TaskCreationOptions.None, uiScheduler);
        }

        private void UpdateProgressBar2(string statusMessage)
        {
            Task.Factory.StartNew(() =>
            {
                progressBar2.PerformStep();
                // label2.Text = statusMessage;
            }, CancellationToken.None, TaskCreationOptions.None, uiScheduler);
        }

        private void UpdateProgressBar3(string statusMessage)
        {
            Task.Factory.StartNew(() =>
            {
                progressBar3.PerformStep();                
            }, CancellationToken.None, TaskCreationOptions.None, uiScheduler);
        }

        private void ChkTask1_CheckedChanged(object sender, EventArgs e)
        {
            CheckUncheck(((System.Windows.Forms.Control)sender));
        }

        private void ChkTask2_CheckedChanged(object sender, EventArgs e)
        {
            CheckUncheck(((System.Windows.Forms.Control)sender));
        }

        private void ChkTask3_CheckedChanged(object sender, EventArgs e)
        {
            CheckUncheck(((System.Windows.Forms.Control)sender));
        }

        private void CheckUncheck(Control Name)
        {
            if (((System.Windows.Forms.CheckBox)Name).Checked)
            {
                if (lblSeq1.Text == string.Empty)
                {
                    lblSeq1.Text = ((System.Windows.Forms.ButtonBase)Name).Text;
                }
                else if (lblSeq2.Text == string.Empty)
                {
                    lblSeq2.Text = ((System.Windows.Forms.ButtonBase)Name).Text;
                }
                else if (lblSeq3.Text == string.Empty)
                {
                    lblSeq3.Text = ((System.Windows.Forms.ButtonBase)Name).Text;
                }
            }
            else if (!((System.Windows.Forms.CheckBox)Name).Checked)
            {
                if (lblSeq1.Text == ((System.Windows.Forms.ButtonBase)Name).Text)
                {
                    lblSeq1.Text = string.Empty;
                }
                else if (lblSeq2.Text == ((System.Windows.Forms.ButtonBase)Name).Text)
                {
                    lblSeq2.Text = string.Empty;
                }
                else if (lblSeq3.Text == ((System.Windows.Forms.ButtonBase)Name).Text)
                {
                    lblSeq3.Text = string.Empty;
                }

            }
        }

        private void ClearAll()
        {
            chkTask1.Checked = false;
            chkTask2.Checked = false;
            chkTask3.Checked = false;
            FinishedTask1 = false;
            FinishedTask2 = false;
            FinishedTask3 = false;
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
            MyQueue.Clear();
        }

        private void InitializeComponent2()
        {
            progressBar1.Maximum = 100;
            progressBar1.Step = 20;
            progressBar1.Value = 0;
            progressBar1.Style = ProgressBarStyle.Continuous;
            //progressBar1.SetState(1);

            progressBar2.Maximum = 100;
            progressBar2.Step = 20;
            progressBar2.Value = 0;
            progressBar2.Style = ProgressBarStyle.Blocks;
            // progressBar2.SetState(3);

            progressBar3.Maximum = 100;
            progressBar3.Step = 1;
            progressBar3.Value = 0;
            progressBar3.Style = ProgressBarStyle.Continuous;
            //progressBar3.SetState(2);



            //label1.Text = string.Empty;
            //label2.Text = string.Empty;
            //label3.Text = string.Empty;

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

       
    }
}
