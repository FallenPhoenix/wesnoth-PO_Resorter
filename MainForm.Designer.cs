/*
 * Created with SharpDevelop 3.
 * User: F. Phoenix
 * Date: 09.11.2011
 * Time: 18:11
 * 
 */
namespace Wesnoth_PO_Sorter
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.bSourceDir = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.bTargetDir = new System.Windows.Forms.Button();
			this.bInsert = new System.Windows.Forms.Button();
			this.bExtract = new System.Windows.Forms.Button();
			this.chReplace = new System.Windows.Forms.CheckBox();
			this.chCopyPOT = new System.Windows.Forms.CheckBox();
			this.chCopyPO = new System.Windows.Forms.CheckBox();
			this.chCopyMO = new System.Windows.Forms.CheckBox();
			this.cbLanguage = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbSourceDir = new System.Windows.Forms.ComboBox();
			this.cbTargetDir = new System.Windows.Forms.ComboBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// bSourceDir
			// 
			this.bSourceDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bSourceDir.Location = new System.Drawing.Point(366, 35);
			this.bSourceDir.Name = "bSourceDir";
			this.bSourceDir.Size = new System.Drawing.Size(75, 23);
			this.bSourceDir.TabIndex = 2;
			this.bSourceDir.Text = "Обзор...";
			this.bSourceDir.UseVisualStyleBackColor = true;
			this.bSourceDir.Click += new System.EventHandler(this.bSourceDir_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Исходная папка";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Конечная папка";
			// 
			// bTargetDir
			// 
			this.bTargetDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bTargetDir.Location = new System.Drawing.Point(366, 81);
			this.bTargetDir.Name = "bTargetDir";
			this.bTargetDir.Size = new System.Drawing.Size(75, 23);
			this.bTargetDir.TabIndex = 6;
			this.bTargetDir.Text = "Обзор...";
			this.bTargetDir.UseVisualStyleBackColor = true;
			this.bTargetDir.Click += new System.EventHandler(this.bTargetDir_Click);
			// 
			// bInsert
			// 
			this.bInsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.bInsert.Location = new System.Drawing.Point(224, 268);
			this.bInsert.Name = "bInsert";
			this.bInsert.Size = new System.Drawing.Size(151, 23);
			this.bInsert.TabIndex = 7;
			this.bInsert.Text = "Добавить язык";
			this.bInsert.UseVisualStyleBackColor = true;
			this.bInsert.Click += new System.EventHandler(this.bExtract_bInsert_Click);
			// 
			// bExtract
			// 
			this.bExtract.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.bExtract.Location = new System.Drawing.Point(67, 268);
			this.bExtract.Name = "bExtract";
			this.bExtract.Size = new System.Drawing.Size(151, 23);
			this.bExtract.TabIndex = 8;
			this.bExtract.Text = "Извлечь язык";
			this.bExtract.UseVisualStyleBackColor = true;
			this.bExtract.Click += new System.EventHandler(this.bExtract_bInsert_Click);
			// 
			// chReplace
			// 
			this.chReplace.AutoSize = true;
			this.chReplace.Location = new System.Drawing.Point(209, 65);
			this.chReplace.Name = "chReplace";
			this.chReplace.Size = new System.Drawing.Size(186, 17);
			this.chReplace.TabIndex = 9;
			this.chReplace.Text = "Разрешить перезапись файлов";
			this.chReplace.UseVisualStyleBackColor = true;
			// 
			// chCopyPOT
			// 
			this.chCopyPOT.AutoSize = true;
			this.chCopyPOT.Checked = true;
			this.chCopyPOT.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chCopyPOT.Location = new System.Drawing.Point(18, 19);
			this.chCopyPOT.Name = "chCopyPOT";
			this.chCopyPOT.Size = new System.Drawing.Size(148, 17);
			this.chCopyPOT.TabIndex = 10;
			this.chCopyPOT.Text = "Копировать POT-файлы";
			this.chCopyPOT.UseVisualStyleBackColor = true;
			// 
			// chCopyPO
			// 
			this.chCopyPO.AutoSize = true;
			this.chCopyPO.Checked = true;
			this.chCopyPO.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chCopyPO.Location = new System.Drawing.Point(18, 42);
			this.chCopyPO.Name = "chCopyPO";
			this.chCopyPO.Size = new System.Drawing.Size(141, 17);
			this.chCopyPO.TabIndex = 11;
			this.chCopyPO.Text = "Копировать PO-файлы";
			this.chCopyPO.UseVisualStyleBackColor = true;
			// 
			// chCopyMO
			// 
			this.chCopyMO.AutoSize = true;
			this.chCopyMO.Checked = true;
			this.chCopyMO.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chCopyMO.Location = new System.Drawing.Point(18, 65);
			this.chCopyMO.Name = "chCopyMO";
			this.chCopyMO.Size = new System.Drawing.Size(143, 17);
			this.chCopyMO.TabIndex = 12;
			this.chCopyMO.Text = "Копировать MO-файлы";
			this.chCopyMO.UseVisualStyleBackColor = true;
			// 
			// cbLanguage
			// 
			this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLanguage.FormattingEnabled = true;
			this.cbLanguage.Location = new System.Drawing.Point(245, 19);
			this.cbLanguage.Name = "cbLanguage";
			this.cbLanguage.Size = new System.Drawing.Size(162, 21);
			this.cbLanguage.Sorted = true;
			this.cbLanguage.TabIndex = 13;
			this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.cbLanguage_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(201, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Язык:";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.groupBox1.Controls.Add(this.cbLanguage);
			this.groupBox1.Controls.Add(this.chCopyMO);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.chCopyPO);
			this.groupBox1.Controls.Add(this.chCopyPOT);
			this.groupBox1.Controls.Add(this.chReplace);
			this.groupBox1.Location = new System.Drawing.Point(12, 132);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(429, 99);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Параметры";
			// 
			// cbSourceDir
			// 
			this.cbSourceDir.AllowDrop = true;
			this.cbSourceDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.cbSourceDir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cbSourceDir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbSourceDir.FormattingEnabled = true;
			this.cbSourceDir.Location = new System.Drawing.Point(12, 36);
			this.cbSourceDir.Name = "cbSourceDir";
			this.cbSourceDir.Size = new System.Drawing.Size(348, 21);
			this.cbSourceDir.Sorted = true;
			this.cbSourceDir.TabIndex = 16;
			this.cbSourceDir.DragDrop += new System.Windows.Forms.DragEventHandler(this.cbDirs_DragDrop);
			this.cbSourceDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.cbDirs_DragEnter);
			// 
			// cbTargetDir
			// 
			this.cbTargetDir.AllowDrop = true;
			this.cbTargetDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.cbTargetDir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cbTargetDir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbTargetDir.FormattingEnabled = true;
			this.cbTargetDir.Location = new System.Drawing.Point(12, 82);
			this.cbTargetDir.Name = "cbTargetDir";
			this.cbTargetDir.Size = new System.Drawing.Size(348, 21);
			this.cbTargetDir.Sorted = true;
			this.cbTargetDir.TabIndex = 17;
			this.cbTargetDir.DragDrop += new System.Windows.Forms.DragEventHandler(this.cbDirs_DragDrop);
			this.cbTargetDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.cbDirs_DragEnter);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(453, 303);
			this.Controls.Add(this.cbTargetDir);
			this.Controls.Add(this.cbSourceDir);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.bExtract);
			this.Controls.Add(this.bInsert);
			this.Controls.Add(this.bTargetDir);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bSourceDir);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(700, 337);
			this.MinimumSize = new System.Drawing.Size(461, 337);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "Wesnoth PO Resorter";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ComboBox cbTargetDir;
		private System.Windows.Forms.ComboBox cbSourceDir;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbLanguage;
		private System.Windows.Forms.CheckBox chCopyMO;
		private System.Windows.Forms.CheckBox chCopyPO;
		private System.Windows.Forms.Button bExtract;
		private System.Windows.Forms.Button bInsert;
		private System.Windows.Forms.CheckBox chCopyPOT;
		private System.Windows.Forms.CheckBox chReplace;
		private System.Windows.Forms.Button bSourceDir;
		private System.Windows.Forms.Button bTargetDir;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
