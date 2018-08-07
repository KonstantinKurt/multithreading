using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace WinForms_backgroundWorker
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
            notifyIcon1.Visible = false;
        }
        #region Factorial
        private void backgroundWorker_factorial_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            e.Result = Factorial(worker, e);
            
        }
        private void backgroundWorker_factorial_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled)
            {
                label_result.Text = "Cancelled!";
                
            }
            else
            {
                label_result.Text = e.Result.ToString();
            }
            if(notifyIcon1.Visible)
            {
                notifyIcon1.ShowBalloonTip(100,"" ,"Calculation ended!",ToolTipIcon.Info);
            }
            stopwatch.Stop();
            label_elapsed_time.Text = stopwatch.Elapsed.ToString();
            numericUpDown1.Enabled = true;
            button_fact_start.Enabled = true;
            button_fact_cancel.Enabled = false;

        }
        private void button_fact_cancel_Click(object sender, EventArgs e)
        {
            backgroundWorker_factorial.CancelAsync();
            stopwatch.Stop();
        }
        private void button_fact_start_Click(object sender, EventArgs e)
        {
            
            stopwatch.Reset();
            stopwatch.Start();
            button_fact_start.Enabled = false;
            button_fact_cancel.Enabled = true;
            numericUpDown1.Enabled = false;
            backgroundWorker_factorial.RunWorkerAsync((int)numericUpDown1.Value);
           
        }
        long Factorial(BackgroundWorker worker,DoWorkEventArgs e)
        {
            progressBar1.Value = 0;  
            progressBar1.Step = 1;  
            progressBar1.Maximum = (int)numericUpDown1.Value;  
            long result = 1;
            
            for (int i = 1; i <=(int)numericUpDown1.Value; i++)
            {
                result *= i;
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                progressBar1.PerformStep();  
                Thread.Sleep(500);  
            }
            return result;
        }
        #endregion
        #region notifyIcon
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
               notifyIcon1.ShowBalloonTip(200);
            }
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Visible = true;
            WindowState = FormWindowState.Normal;
        }

        private void развернутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Visible = true;
            WindowState = FormWindowState.Normal;
        }

        private void зToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region Simple_digit
        private static bool isSimple(long N)   
        {
            for (long i = 2; i < N - 1; i++)
            {
                if (N % i == 0)
                    return false;
            }
            return true;
        }
        private void backgroundWorker_digit_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            e.Result = Digit(worker, e);
        }
        long Digit(BackgroundWorker worker2, DoWorkEventArgs e)
        {
          

            long i = (long)numericUpDownFirst.Value;
            while(i<=(long)numericUpDownLast.Value)
            {
                if(isSimple(i))
                {
                    textBox1Result.Text += i + " ";
                    if (worker2.CancellationPending)  
                    {
                        e.Cancel = true;
                        break;
                    }
                }
                i++;
            }
            return i;
        }
        private void backgroundWorker_digit_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled)
            {
                textBox1Result.Text += "Canceled";
            }
            if (notifyIcon1.Visible)
            {
                notifyIcon1.ShowBalloonTip(100, "", "Calculation ended!", ToolTipIcon.Info);
            }

        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            textBox1Result.Clear();
            backgroundWorker_digit.RunWorkerAsync(numericUpDownFirst.Value);
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            backgroundWorker_digit.CancelAsync();
        }




        #endregion


    }

}

