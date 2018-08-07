namespace WinForms_backgroundWorker
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_factorial = new System.Windows.Forms.Panel();
            this.label_elapsed_time = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_fact_cancel = new System.Windows.Forms.Button();
            this.button_fact_start = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownLast = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFirst = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1Result = new System.Windows.Forms.TextBox();
            this.backgroundWorker_factorial = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.развернутьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker_digit = new System.ComponentModel.BackgroundWorker();
            this.panel_factorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirst)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_factorial
            // 
            this.panel_factorial.AutoScroll = true;
            this.panel_factorial.BackColor = System.Drawing.Color.SkyBlue;
            this.panel_factorial.Controls.Add(this.label_elapsed_time);
            this.panel_factorial.Controls.Add(this.label3);
            this.panel_factorial.Controls.Add(this.button_fact_cancel);
            this.panel_factorial.Controls.Add(this.button_fact_start);
            this.panel_factorial.Controls.Add(this.progressBar1);
            this.panel_factorial.Controls.Add(this.numericUpDown1);
            this.panel_factorial.Controls.Add(this.label1);
            this.panel_factorial.Controls.Add(this.label_result);
            this.panel_factorial.Controls.Add(this.label2);
            this.panel_factorial.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_factorial.Location = new System.Drawing.Point(0, 0);
            this.panel_factorial.Name = "panel_factorial";
            this.panel_factorial.Size = new System.Drawing.Size(602, 228);
            this.panel_factorial.TabIndex = 0;
            // 
            // label_elapsed_time
            // 
            this.label_elapsed_time.BackColor = System.Drawing.Color.Azure;
            this.label_elapsed_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_elapsed_time.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_elapsed_time.Location = new System.Drawing.Point(186, 66);
            this.label_elapsed_time.Name = "label_elapsed_time";
            this.label_elapsed_time.Size = new System.Drawing.Size(155, 29);
            this.label_elapsed_time.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(187, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Elapsed time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_fact_cancel
            // 
            this.button_fact_cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_fact_cancel.Location = new System.Drawing.Point(484, 176);
            this.button_fact_cancel.Name = "button_fact_cancel";
            this.button_fact_cancel.Size = new System.Drawing.Size(86, 23);
            this.button_fact_cancel.TabIndex = 7;
            this.button_fact_cancel.Text = "Cancel";
            this.button_fact_cancel.UseVisualStyleBackColor = true;
            this.button_fact_cancel.Click += new System.EventHandler(this.button_fact_cancel_Click);
            // 
            // button_fact_start
            // 
            this.button_fact_start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_fact_start.Location = new System.Drawing.Point(373, 176);
            this.button_fact_start.Name = "button_fact_start";
            this.button_fact_start.Size = new System.Drawing.Size(90, 23);
            this.button_fact_start.TabIndex = 6;
            this.button_fact_start.Text = "Start";
            this.button_fact_start.UseVisualStyleBackColor = true;
            this.button_fact_start.Click += new System.EventHandler(this.button_fact_start_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 116);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(575, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(468, 67);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Result";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_result
            // 
            this.label_result.BackColor = System.Drawing.Color.Azure;
            this.label_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_result.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_result.Location = new System.Drawing.Point(12, 67);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(155, 29);
            this.label_result.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(236, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Factorial";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.numericUpDownLast);
            this.panel1.Controls.Add(this.numericUpDownFirst);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox1Result);
            this.panel1.Location = new System.Drawing.Point(0, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 222);
            this.panel1.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(468, 129);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(97, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(339, 129);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(97, 23);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(215, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 34);
            this.label6.TabIndex = 5;
            this.label6.Text = "Simple Digit";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownLast
            // 
            this.numericUpDownLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownLast.Location = new System.Drawing.Point(468, 69);
            this.numericUpDownLast.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.numericUpDownLast.Name = "numericUpDownLast";
            this.numericUpDownLast.Size = new System.Drawing.Size(77, 22);
            this.numericUpDownLast.TabIndex = 4;
            this.numericUpDownLast.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDownFirst
            // 
            this.numericUpDownFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownFirst.Location = new System.Drawing.Point(339, 69);
            this.numericUpDownFirst.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.numericUpDownFirst.Name = "numericUpDownFirst";
            this.numericUpDownFirst.Size = new System.Drawing.Size(73, 22);
            this.numericUpDownFirst.TabIndex = 3;
            this.numericUpDownFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(465, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Last Digit";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(336, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "First Digit";
            // 
            // textBox1Result
            // 
            this.textBox1Result.Location = new System.Drawing.Point(17, 45);
            this.textBox1Result.Multiline = true;
            this.textBox1Result.Name = "textBox1Result";
            this.textBox1Result.ReadOnly = true;
            this.textBox1Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1Result.Size = new System.Drawing.Size(297, 151);
            this.textBox1Result.TabIndex = 0;
            // 
            // backgroundWorker_factorial
            // 
            this.backgroundWorker_factorial.WorkerReportsProgress = true;
            this.backgroundWorker_factorial.WorkerSupportsCancellation = true;
            this.backgroundWorker_factorial.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_factorial_DoWork);
            this.backgroundWorker_factorial.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_factorial_RunWorkerCompleted);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Multithreading";
            this.notifyIcon1.BalloonTipTitle = "Factorial/SimpleDigit";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Multithreading";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.развернутьToolStripMenuItem,
            this.зToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // развернутьToolStripMenuItem
            // 
            this.развернутьToolStripMenuItem.Name = "развернутьToolStripMenuItem";
            this.развернутьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.развернутьToolStripMenuItem.Text = "Expand";
            this.развернутьToolStripMenuItem.Click += new System.EventHandler(this.развернутьToolStripMenuItem_Click);
            // 
            // зToolStripMenuItem
            // 
            this.зToolStripMenuItem.Name = "зToolStripMenuItem";
            this.зToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.зToolStripMenuItem.Text = "Exit programm";
            this.зToolStripMenuItem.Click += new System.EventHandler(this.зToolStripMenuItem_Click);
            // 
            // backgroundWorker_digit
            // 
            this.backgroundWorker_digit.WorkerReportsProgress = true;
            this.backgroundWorker_digit.WorkerSupportsCancellation = true;
            this.backgroundWorker_digit.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_digit_DoWork);
            this.backgroundWorker_digit.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_digit_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(600, 449);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_factorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Multithreading";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel_factorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirst)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_factorial;
        private System.Windows.Forms.Button button_fact_cancel;
        private System.Windows.Forms.Button button_fact_start;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker_factorial;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem развернутьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зToolStripMenuItem;
        private System.Windows.Forms.Label label_elapsed_time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownLast;
        private System.Windows.Forms.NumericUpDown numericUpDownFirst;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1Result;
        private System.ComponentModel.BackgroundWorker backgroundWorker_digit;
    }
}

