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


using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Net;

namespace WebStressTool
{
    /// <summary>
    /// MainForm of application.
    /// </summary>
    public partial class MainForm : Form
    {
        protected Worker worker;
        
        protected List<string> buffer;
        
        protected int bufferLastSize;
        
        protected bool abort;
        
        protected readonly static string[] localIPs = null;
        
        static MainForm()
        {
            localIPs = new string[] {
                "192.168", 
                "10.", 
                "172.16.", 
                "172.17.", 
                "172.18.", 
                "172.19.", 
                "172.20.", 
                "172.21.", 
                "172.22.", 
                "172.23.", 
                "172.24.", 
                "172.25.", 
                "172.26.", 
                "172.27.", 
                "172.28.", 
                "172.29.", 
                "172.30.", 
                "172.31.", 
            };
        }
        
        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
            comboBoxUrl.SelectedItem = comboBoxUrl.Items[0];
        }
        
        protected void Start()
        {
            abort = false;
            buffer = new List<string>();
            bufferLastSize = buffer.Count;
            
            //TODO: combine and check url
            string url = comboBoxUrl.Text + "://" + textBoxUrl.Text + ":" + numericUpDownUrl.Value;
            int timeout = (int) (1000 * numericUpDownTimeout.Value);
            worker = new Worker(url, timeout);
            worker.onWorkResult += StoreResult;
            
            int iteratesCount = (int) numericUpDownIterates.Value;
            int threadsCount = (int) numericUpDownThreadsMin.Value;
            int threadsMax = (int) numericUpDownThreadsMax.Value;
            int threadsInc = (int) numericUpDownThreadsInc.Value;
            
            for (int i = 1; i <= iteratesCount; i++) {
                if (abort)
                    break;
                worker.DoWork(i, threadsCount);
                AwaitResults();
                threadsCount += threadsInc;
                if (threadsCount > threadsMax)
                    threadsCount = threadsMax;
            }
            Thread.Sleep(timeout);
            AwaitResults();
        }
        
        protected void Stop()
        {
            abort = true;
            if (null != worker) {
                worker.Abort();
                AwaitResults();
            }
        }
        
        protected void AwaitResults()
        {
            while (worker.IsAlive) {
                DisplayResult();
                Application.DoEvents();
            }
            DisplayResult();
            Application.DoEvents();
        }
        
        protected void StoreResult(Worker sender, WorkerResult result)
        {
            string label, data;
            if (null != result.response) {
                label = 
                    "Response " +
                    "[" + result.data.iterateNum + "|" + 
                    result.data.threadNum + "/" + result.data.threadsCount + 
                    "]: ";
                data = result.response.StatusCode.ToString();
            } else {
                label = 
                    "Error " + 
                    "[" + result.data.iterateNum + "|" + 
                    result.data.threadNum + "/" + result.data.threadsCount + 
                    "]: ";
                data = result.error;
            }
            buffer.Add(label + new String(' ', 25 - label.Length) + data);
        }
        
        protected void DisplayResult()
        {
            if (bufferLastSize != buffer.Count) {
                for (int i = bufferLastSize; i < buffer.Count; i++)
                    textBoxResults.Text += buffer[i] + Environment.NewLine;
                bufferLastSize = buffer.Count;
                textBoxResults.Refresh();
            }
        }
        
        void MainFormKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
                Start();
            else if (e.KeyChar == (char) Keys.Escape)
                Stop();
        }
        
        void ButtonStartClick(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            Start();
            buttonStart.Enabled = true;
        }
        
        void ButtonStopClick(object sender, EventArgs e)
        {
            Stop();
            buttonStart.Enabled = true;
        }
        
        void TextBoxResultsTextChanged(object sender, EventArgs e)
        {
            TextBox tbx = (TextBox) sender;
            tbx.SelectionStart = tbx.Text.Length;
            tbx.ScrollToCaret();
        }
        
        void NumericUpDownThreadsMinValueChanged(object sender, EventArgs e)
        {
            NumericUpDown thisElement = (NumericUpDown) sender;
            if (thisElement.Value > numericUpDownThreadsMax.Value)
                numericUpDownThreadsMax.Value = thisElement.Value;
        }
        
        void NumericUpDownThreadsMaxValueChanged(object sender, EventArgs e)
        {
            NumericUpDown thisElement = (NumericUpDown) sender;
            if (thisElement.Value < numericUpDownThreadsMin.Value)
                numericUpDownThreadsMin.Value = thisElement.Value;
        }
        
        void MainFormResize(object sender, EventArgs e)
        {
            textBoxResults.Width = this.Width - groupBox1.Width - 22;
        }
        
        void MainFormFormClosed(object sender, FormClosedEventArgs e)
        {
            Stop();
        }
        
        void ButtonClearClick(object sender, EventArgs e)
        {
            textBoxResults.Text = "";
        }
        
        void TextBoxUrlValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox txt = (TextBox) sender;
            
            if (txt.Text == "") {
                txt.Text = "localhost";
                e.Cancel = true;
            }
            
            bool ipIsLocal = false;
            IPAddress[] ips;
            try {
                ips = Dns.GetHostAddresses(txt.Text);
            } catch (Exception) {
                MessageBox.Show("Host not resolved, correct it or enter another host", "Host not resolved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;
                return;
            }
            foreach (IPAddress ip in ips) {
                if (IPAddress.IsLoopback(ip)) {
                    ipIsLocal = true;
                    break;
                }
                
                string ipStr = ip.ToString();
                foreach (string localIP in localIPs) {
                    if (0 == ipStr.IndexOf(localIP)) {
                        ipIsLocal = true;
                        break;
                    }
                }
                if (ipIsLocal)
                    break;
            }
            
            if (!ipIsLocal) {
                txt.Text = "localhost";
                e.Cancel = true;
            }
        }
        
        void ComboBoxUrlTextChanged(object sender, EventArgs e)
        {
            ComboBox cbx = (ComboBox) sender;
            if ("http" == cbx.Text)
                numericUpDownUrl.Value = 80;
            else if ("https" == cbx.Text)
                numericUpDownUrl.Value = 443;
        }
    }
}
