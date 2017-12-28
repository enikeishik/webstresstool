/**
 * WebStressTool
 * Web Stress Tool, testing hiload sites
 * 
 * Created by SharpDevelop.
 * User: Enikeishik
 * Date: 26.12.2017
 * Time: 10:00
 * 
 * @copyright   Copyright (C) 2005 - 2017 Enikeishik <enikeishik@gmail.com>. All rights reserved.
 * @author      Enikeishik <enikeishik@gmail.com>
 * @license     GNU General Public License version 2 or later; see LICENSE.txt
 */


namespace WebStressTool
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxResults;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.NumericUpDown numericUpDownThreadsInc;
        private System.Windows.Forms.NumericUpDown numericUpDownThreadsMax;
        private System.Windows.Forms.NumericUpDown numericUpDownThreadsMin;
        private System.Windows.Forms.NumericUpDown numericUpDownIterates;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxUrl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownTimeout;
        private System.Windows.Forms.NumericUpDown numericUpDownUrl;
        
        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        
        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBoxResults = new System.Windows.Forms.TextBox();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.numericUpDownIterates = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownThreadsMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownThreadsMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownThreadsInc = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownUrl = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownTimeout = new System.Windows.Forms.NumericUpDown();
            this.comboBoxUrl = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreadsMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreadsMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreadsInc)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxResults
            // 
            this.textBoxResults.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxResults.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResults.Location = new System.Drawing.Point(0, 0);
            this.textBoxResults.MinimumSize = new System.Drawing.Size(200, 4);
            this.textBoxResults.Multiline = true;
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.ReadOnly = true;
            this.textBoxResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResults.Size = new System.Drawing.Size(318, 262);
            this.textBoxResults.TabIndex = 0;
            this.textBoxResults.WordWrap = false;
            this.textBoxResults.TextChanged += new System.EventHandler(this.TextBoxResultsTextChanged);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(74, 19);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(120, 20);
            this.textBoxUrl.TabIndex = 0;
            this.textBoxUrl.Text = "localhost";
            this.textBoxUrl.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxUrlValidating);
            // 
            // numericUpDownIterates
            // 
            this.numericUpDownIterates.Location = new System.Drawing.Point(74, 71);
            this.numericUpDownIterates.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownIterates.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIterates.Name = "numericUpDownIterates";
            this.numericUpDownIterates.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownIterates.TabIndex = 1;
            this.numericUpDownIterates.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownThreadsMin
            // 
            this.numericUpDownThreadsMin.Location = new System.Drawing.Point(74, 137);
            this.numericUpDownThreadsMin.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownThreadsMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownThreadsMin.Name = "numericUpDownThreadsMin";
            this.numericUpDownThreadsMin.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownThreadsMin.TabIndex = 2;
            this.numericUpDownThreadsMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownThreadsMin.ValueChanged += new System.EventHandler(this.NumericUpDownThreadsMinValueChanged);
            // 
            // numericUpDownThreadsMax
            // 
            this.numericUpDownThreadsMax.Location = new System.Drawing.Point(74, 163);
            this.numericUpDownThreadsMax.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownThreadsMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownThreadsMax.Name = "numericUpDownThreadsMax";
            this.numericUpDownThreadsMax.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownThreadsMax.TabIndex = 3;
            this.numericUpDownThreadsMax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownThreadsMax.ValueChanged += new System.EventHandler(this.NumericUpDownThreadsMaxValueChanged);
            // 
            // numericUpDownThreadsInc
            // 
            this.numericUpDownThreadsInc.Location = new System.Drawing.Point(74, 189);
            this.numericUpDownThreadsInc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownThreadsInc.Name = "numericUpDownThreadsInc";
            this.numericUpDownThreadsInc.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownThreadsInc.TabIndex = 4;
            this.numericUpDownThreadsInc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(92, 233);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStartClick);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(173, 233);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.ButtonStopClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownUrl);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDownTimeout);
            this.groupBox1.Controls.Add(this.comboBoxUrl);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonStop);
            this.groupBox1.Controls.Add(this.buttonStart);
            this.groupBox1.Controls.Add(this.numericUpDownThreadsInc);
            this.groupBox1.Controls.Add(this.numericUpDownThreadsMax);
            this.groupBox1.Controls.Add(this.numericUpDownThreadsMin);
            this.groupBox1.Controls.Add(this.numericUpDownIterates);
            this.groupBox1.Controls.Add(this.textBoxUrl);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(324, 0);
            this.groupBox1.MinimumSize = new System.Drawing.Size(260, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 262);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Params";
            // 
            // numericUpDownUrl
            // 
            this.numericUpDownUrl.Location = new System.Drawing.Point(200, 19);
            this.numericUpDownUrl.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.numericUpDownUrl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownUrl.Name = "numericUpDownUrl";
            this.numericUpDownUrl.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownUrl.TabIndex = 16;
            this.numericUpDownUrl.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Timeout";
            // 
            // numericUpDownTimeout
            // 
            this.numericUpDownTimeout.DecimalPlaces = 2;
            this.numericUpDownTimeout.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownTimeout.Location = new System.Drawing.Point(74, 45);
            this.numericUpDownTimeout.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownTimeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownTimeout.Name = "numericUpDownTimeout";
            this.numericUpDownTimeout.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTimeout.TabIndex = 14;
            this.numericUpDownTimeout.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // comboBoxUrl
            // 
            this.comboBoxUrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUrl.FormattingEnabled = true;
            this.comboBoxUrl.Items.AddRange(new object[] {
            "http",
            "https"});
            this.comboBoxUrl.Location = new System.Drawing.Point(6, 18);
            this.comboBoxUrl.Name = "comboBoxUrl";
            this.comboBoxUrl.Size = new System.Drawing.Size(62, 21);
            this.comboBoxUrl.Sorted = true;
            this.comboBoxUrl.TabIndex = 13;
            this.comboBoxUrl.TextChanged += new System.EventHandler(this.ComboBoxUrlTextChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(6, 233);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClearClick);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Threads";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Inc";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Max";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Min";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Iterates";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxResults);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "MainForm";
            this.Text = "WebStressTool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
            this.Resize += new System.EventHandler(this.MainFormResize);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreadsMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreadsMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreadsInc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
