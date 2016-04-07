using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProcessNote
{
    public partial class ProcessNote : Form
    {
        Process[] proc;
        List<CommentedTask> commentedTaskList = new List<CommentedTask>();
        int selectedIndex;

        public ProcessNote()
        {
            InitializeComponent();
        }

        private void GetProcesses()
        {
            proc = Process.GetProcesses();
        }



        private void GetProcessDetails(ListViewItem item)
        {
            try
            {

                PerformanceCounter cpuCounter;
                PerformanceCounter total_cpu = new PerformanceCounter("Processor", "% Processor Time", "_Total");
                cpuCounter = new PerformanceCounter("Process", "% Processor Time", proc[selectedIndex].ProcessName);
                dynamic firstValue = cpuCounter.NextValue();
                System.Threading.Thread.Sleep(1000);
                float secondValue = cpuCounter.NextValue();


                item.SubItems[2].Text = secondValue.ToString("n2");

                PerformanceCounter PC = new PerformanceCounter();
                PC.CategoryName = "Process";
                PC.CounterName = "Working Set - Private";
                PC.InstanceName = proc[selectedIndex].ProcessName;
                double memsize = Convert.ToDouble(PC.NextValue()) / (1024 * 1024);
                memsize = Math.Round(memsize, 2);

                item.SubItems[3].Text = memsize.ToString() + " MB";

                DateTime startTime = DateTime.Now;
                string startTimeString = "";
                try
                {
                    startTime = proc[selectedIndex].StartTime;
                    startTimeString = startTime.ToString();
                }
                catch
                {
                    startTimeString = "Time not found";
                }

                item.SubItems[4].Text = startTimeString;

                TimeSpan runningTime = new TimeSpan();
                if (startTimeString != "Time not found")
                {
                    runningTime = DateTime.Now - startTime;
                    item.SubItems[5].Text = runningTime.ToString(@"hh\:mm\:ss");
                }
                else
                    item.SubItems[5].Text = "Not available";

                threadListBox.Items.Clear();
                ProcessThreadCollection currentThreads;
                currentThreads = proc[selectedIndex].Threads;
                foreach (ProcessThread thread in currentThreads)
                {
                    threadListBox.Items.Add(thread.Id.ToString());
                }


            }
            catch
            {
                item.SubItems[0].Text = "Process ";
                item.SubItems[1].Text = "closed!";
                return;
            }
        }

        private void ProcessNote_Load(object sender, EventArgs e)
        {
            GetProcesses();



            listViewProcesses.View = View.Details;
            listViewProcesses.GridLines = true;
            listViewProcesses.FullRowSelect = true;

            listViewProcesses.Items.Clear();
            for (int i = 0; i < proc.Length; i++)
            {
                listViewProcesses.Items.Add(proc[i].ProcessName).SubItems.AddRange(new string[] { proc[i].Id.ToString(), "", "", "", "" });
            }

        }



        private void listViewProcesses_DoubleClick(object sender, EventArgs e)
        {
            richTextBoxComment.Clear();
            ListViewItem item = new ListViewItem();
            item = this.listViewProcesses.SelectedItems[0];
            var indexes = listViewProcesses.SelectedIndices;
            selectedIndex = 0;
            foreach (int number in indexes)
            {
                selectedIndex = number;
            }
            int processId = proc[selectedIndex].Id;
            foreach (CommentedTask process in commentedTaskList)
            {
                if (process.getId() == processId)
                {
                    richTextBoxComment.Text = process.getComment();
                }
            }
            GetProcessDetails(item);
        }

        private void listViewProcesses_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBoxComment.Clear();
            ListViewItem item = new ListViewItem();
            item = this.listViewProcesses.SelectedItems[0];

            var indexes = listViewProcesses.SelectedIndices;
            selectedIndex = 0;
            foreach (int number in indexes)
            {
                selectedIndex = number;
            }
            int processId = proc[selectedIndex].Id;
            foreach (CommentedTask process in commentedTaskList)
            {
                if (process.getId() == processId)
                {
                    richTextBoxComment.Text = process.getComment();
                }
            }
            if (item.SubItems[2].Text != "")
                return;
            GetProcessDetails(item);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetProcesses();

            listViewProcesses.View = View.Details;
            listViewProcesses.GridLines = true;
            listViewProcesses.FullRowSelect = true;

            listViewProcesses.Items.Clear();
            for (int i = 0; i < proc.Length; i++)
            {
                listViewProcesses.Items.Add(proc[i].ProcessName).SubItems.AddRange(new string[] { proc[i].Id.ToString(), "", "", "", "" });
            }
        }

        private void alwaysOnTopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (alwaysOnTopCheckBox.Checked)
                this.TopMost = true;
            else
                this.TopMost = false;
        }



        private void richTextBoxComment_Leave(object sender, EventArgs e)
        {
            int processId = proc[selectedIndex].Id;
            bool found = false;

            foreach (CommentedTask process in commentedTaskList)
            {
                if (process.getId() == processId)
                {
                    found = true;
                    process.setComment(richTextBoxComment.Text);
                }

            }
            if (!found)
            {
                CommentedTask newCommentedProcess = new CommentedTask(processId);
                newCommentedProcess.setComment(richTextBoxComment.Text);
                commentedTaskList.Add(newCommentedProcess);

            }
        }


        private void ProcessNote_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Your comments won't be saved! Sure about quit?", "My Application",
        MessageBoxButtons.YesNo) == DialogResult.No)
            {
                // Cancel the Closing event from closing the form.
                e.Cancel = true;
                // Call method to save file...
            }
        }
    }
}
