namespace ProcessNote
{
	partial class ProcessNote
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
			this.threadListBox = new System.Windows.Forms.ListBox();
			this.alwaysOnTopCheckBox = new System.Windows.Forms.CheckBox();
			this.listViewProcesses = new System.Windows.Forms.ListView();
			this.columnHeaderProcessName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderCPUUsage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderMemoryUsage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderThreads = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// threadListBox
			// 
			this.threadListBox.FormattingEnabled = true;
			this.threadListBox.Location = new System.Drawing.Point(12, 219);
			this.threadListBox.Name = "threadListBox";
			this.threadListBox.Size = new System.Drawing.Size(166, 108);
			this.threadListBox.Sorted = true;
			this.threadListBox.TabIndex = 2;
			// 
			// alwaysOnTopCheckBox
			// 
			this.alwaysOnTopCheckBox.AutoSize = true;
			this.alwaysOnTopCheckBox.Location = new System.Drawing.Point(43, 332);
			this.alwaysOnTopCheckBox.Name = "alwaysOnTopCheckBox";
			this.alwaysOnTopCheckBox.Size = new System.Drawing.Size(98, 17);
			this.alwaysOnTopCheckBox.TabIndex = 6;
			this.alwaysOnTopCheckBox.Text = "Always On Top";
			this.alwaysOnTopCheckBox.UseVisualStyleBackColor = true;
			// 
			// listViewProcesses
			// 
			this.listViewProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderProcessName,
            this.columnHeaderCPUUsage,
            this.columnHeaderMemoryUsage,
            this.columnHeaderStartTime,
            this.columnHeaderThreads});
			this.listViewProcesses.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listViewProcesses.Location = new System.Drawing.Point(12, 11);
			this.listViewProcesses.Name = "listViewProcesses";
			this.listViewProcesses.Size = new System.Drawing.Size(510, 176);
			this.listViewProcesses.TabIndex = 9;
			this.listViewProcesses.UseCompatibleStateImageBehavior = false;
			this.listViewProcesses.View = System.Windows.Forms.View.Details;
			// 
			// columnHeaderProcessName
			// 
			this.columnHeaderProcessName.Text = "Process Name";
			this.columnHeaderProcessName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeaderProcessName.Width = 100;
			// 
			// columnHeaderCPUUsage
			// 
			this.columnHeaderCPUUsage.Text = "CPU usage";
			this.columnHeaderCPUUsage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeaderCPUUsage.Width = 100;
			// 
			// columnHeaderMemoryUsage
			// 
			this.columnHeaderMemoryUsage.Text = "Memory Usage";
			this.columnHeaderMemoryUsage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeaderMemoryUsage.Width = 100;
			// 
			// columnHeaderStartTime
			// 
			this.columnHeaderStartTime.Text = "StartTime";
			this.columnHeaderStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeaderStartTime.Width = 100;
			// 
			// columnHeaderThreads
			// 
			this.columnHeaderThreads.Text = "Threads";
			this.columnHeaderThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeaderThreads.Width = 100;
			// 
			// richTextBoxComment
			// 
			this.richTextBoxComment.Location = new System.Drawing.Point(184, 219);
			this.richTextBoxComment.Name = "richTextBoxComment";
			this.richTextBoxComment.Size = new System.Drawing.Size(338, 108);
			this.richTextBoxComment.TabIndex = 10;
			this.richTextBoxComment.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.Location = new System.Drawing.Point(52, 199);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 17);
			this.label1.TabIndex = 11;
			this.label1.Text = "ID of threads";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label2.Location = new System.Drawing.Point(273, 199);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(166, 17);
			this.label2.TabIndex = 12;
			this.label2.Text = "Comment for the process";
			// 
			// ProcessNote
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 361);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.richTextBoxComment);
			this.Controls.Add(this.listViewProcesses);
			this.Controls.Add(this.alwaysOnTopCheckBox);
			this.Controls.Add(this.threadListBox);
			this.Name = "ProcessNote";
			this.Text = "ProcessNote";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ListBox threadListBox;
		private System.Windows.Forms.CheckBox alwaysOnTopCheckBox;
		private System.Windows.Forms.ListView listViewProcesses;
		private System.Windows.Forms.ColumnHeader columnHeaderCPUUsage;
		private System.Windows.Forms.ColumnHeader columnHeaderProcessName;
		private System.Windows.Forms.ColumnHeader columnHeaderMemoryUsage;
		private System.Windows.Forms.ColumnHeader columnHeaderStartTime;
		private System.Windows.Forms.ColumnHeader columnHeaderThreads;
		private System.Windows.Forms.RichTextBox richTextBoxComment;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

