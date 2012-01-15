/*
 * Created with SharpDevelop 3.
 * User: F. Phoenix
 * Date: 09.11.2011
 * Time: 18:11
 * 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Wesnoth_PO_Sorter
{
	public partial class MainForm : Form
	{
		Dictionary<string, string> Languages;
		string Language = "ru";
		List<string> MRU;
		const int MAXMRU = 20;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			string file;
			StreamReader sr;
			
			string[] data = new string[0];
			
			#region Загрузка языков
			Languages = new Dictionary<string, string>();
			string sel = string.Empty;
			file = Application.StartupPath + "/Languages.cfg";
			if (File.Exists(file))
			{
				try
				{
					sr = new StreamReader(file);
					while (!sr.EndOfStream)
					{
						data = sr.ReadLine().Split(new char[]{'='}, StringSplitOptions.RemoveEmptyEntries);
						if (data.Length == 2 && (data[0] = data[0].Trim()).Length > 0 && (data[1] = data[1].Trim()).Length > 0
						    && (data[0] == "_selected" || (!Languages.ContainsKey(data[1]) && !Languages.ContainsValue(data[0]))))
						{
							if (data[0] == "_selected")
								sel = data[1];
							else
								Languages.Add(data[1], data[0]);
						}
					}
					sr.Close();
				}
				catch {}
			}
			if (Languages.Count == 0)
				Languages.Add("Русский", "ru");
			data = new string[Languages.Count];
			Languages.Keys.CopyTo(data, 0);
			cbLanguage.Items.AddRange(data);
			cbLanguage.SelectedItem = (cbLanguage.Items.Contains(sel) ? sel : cbLanguage.Items[0]);
			#endregion

			#region Загрузка истории папок
			MRU = new List<string>();
			file = Application.StartupPath + "/MRU.cfg";
			if (File.Exists(file))
			{
				try
				{
					sr = new StreamReader(file);
					while (!sr.EndOfStream)
						MRU.Add(sr.ReadLine());
			    	sr.Close();
			    }
				catch {}
			}
			LoadDirList();
			#endregion
		}

		
		void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			StreamWriter sw;
			
			#region Сохранение языков
			try
			{
				string file = Application.StartupPath + "/Languages.cfg";
				sw = new StreamWriter(file + ".tmp", false);
				foreach (var lang in Languages)
					sw.WriteLine(string.Format("{0} = {1}", lang.Value, lang.Key));
				sw.WriteLine("\n_selected = " + cbLanguage.SelectedItem as string);
				sw.Close();
				if (File.Exists(file))
				{
					File.Replace(file + ".tmp", file, file + ".bak");
					File.Delete(file + ".bak");
				}
				else File.Move(file + ".tmp", file);
			}
			catch {}
			#endregion
			
			#region Сохранение истории папок
			try
			{
				sw = new StreamWriter(Application.StartupPath + "/MRU.cfg", false);
				foreach (string str in MRU)
					sw.WriteLine(str);
				sw.Close();
			}
			catch {}
			#endregion
		}

		
		void bExtract_bInsert_Click(object sender, EventArgs e)
		{
			string dest_path = FormatPath(cbTargetDir.Text);
			if (!Directory.Exists(cbSourceDir.Text))
				{ErrorMessage("Неверно указана исходная папка."); return;}
			var path = new DirectoryInfo(cbSourceDir.Text);
			int pot = 0, po = 0, mo = 0;
			try
			{
				#region Извлечение
				if (sender == bExtract)
				{
					string src_path;
					var dirs = path.GetDirectories();
					foreach (DirectoryInfo dir in dirs)
					{
						src_path = dir.FullName + "/";
						if (chCopyPOT.Checked && CopyFile(src_path + dir.Name + ".pot", dest_path, dir.Name + ".pot"))
							pot ++;
						if (chCopyPO.Checked && CopyFile(src_path + Language + ".po", dest_path, dir.Name + ".po"))
							po ++;
						if (chCopyMO.Checked && CopyFile(src_path + Language + ".mo", dest_path, dir.Name + ".mo"))
							mo ++;
					}
				}
				#endregion
				#region Добавление
				else
				{
					FileInfo[] files;
					if (chCopyPOT.Checked)
					{
						files = path.GetFiles("*.pot");
						foreach (FileInfo file in files)
							if (CopyFile(file.FullName, dest_path + file.Name.Remove(file.Name.Length - 4) + "/", file.Name))
								pot ++;
					}
					if (chCopyPO.Checked)
					{
						files = path.GetFiles("*.po");
						foreach (FileInfo file in files)
							if (CopyFile(file.FullName, dest_path + file.Name.Remove(file.Name.Length - 3) + "/", Language + ".po"))
								po ++;
					}
					if (chCopyMO.Checked)
					{
						files = path.GetFiles("*.mo");
						foreach (FileInfo file in files)
							if (CopyFile(file.FullName, dest_path + file.Name.Remove(file.Name.Length - 3) + "/", Language + ".mo"))
								mo ++;
					}
				}
				#endregion
			}
			catch (Exception)
			{
				ErrorMessage("При копировании файлов возникла ошибка.");
			}
			finally
			{
				if (po == 0 && pot == 0)
					MessageBox.Show("Ни одного файла не скопировано.", "Результат");
				else
				{
					MessageBox.Show(String.Format("Скопировано {0} файлов:\nPOT: {1}\nPO: {2}\nMO: {3}", pot + po + mo, pot, po, mo), "Результат");

					#region Запоминание папок
					if (!MRU.Contains(cbSourceDir.Text))
						MRU.Insert(0, cbSourceDir.Text);
					if (!MRU.Contains(cbTargetDir.Text))
						MRU.Insert(0, cbTargetDir.Text);
					LoadDirList();
					#endregion
				}
			}
		}
		
		
		void bSourceDir_Click(object sender, EventArgs e)
		{
			var browse = new FolderBrowserDialog();
			browse.SelectedPath = SearchPath(cbSourceDir.Text);
			if (browse.ShowDialog() == DialogResult.OK)
				cbSourceDir.Text = browse.SelectedPath;
		}
		
		void bTargetDir_Click(object sender, EventArgs e)
		{
			var browse = new FolderBrowserDialog();
			browse.SelectedPath = SearchPath(cbTargetDir.Text);
			if (browse.ShowDialog() == DialogResult.OK)
				cbTargetDir.Text = browse.SelectedPath;
		}
		
		void cbDirs_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
		}
		
		void cbDirs_DragDrop(object sender, DragEventArgs e)
        {
			((ComboBox)sender).Text = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
        }
		
		void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
		{
			Languages.TryGetValue(cbLanguage.SelectedItem as string, out Language);
		}

	
		void ErrorMessage(string msg)
		{
			MessageBox.Show(msg, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		void LoadDirList()
		{
			if (MRU.Count > MAXMRU)
				MRU.RemoveRange(MAXMRU, MRU.Count - MAXMRU);
			
			string[] arr = new string[MRU.Count];
			MRU.CopyTo(arr);
//			cbSourceDir.BeginUpdate();
//			cbTargetDir.BeginUpdate();
			cbSourceDir.Items.Clear();
			cbSourceDir.Items.AddRange(arr);
			cbTargetDir.Items.Clear();
			cbTargetDir.Items.AddRange(arr);
//			cbSourceDir.EndUpdate();
//			cbTargetDir.EndUpdate();
		}
		
		string SearchPath(string path)
		{
			var slashes = new char[]{'\\', '/'};
			while (path.Length > 0 && !Directory.Exists(path))
				path = path.Remove(Math.Max(0, path.LastIndexOfAny(slashes)));
			
			return path;
		}
		
		string FormatPath(string path)
		{
			if (!path.EndsWith(@"\") && !path.EndsWith("/")) path += "/";
			    return path;
		}
		
		bool CopyFile(string src_path, string dest_dir, string dest_file)
		{
			if (!File.Exists(src_path)) return false;
			if (!Directory.Exists(dest_dir)) Directory.CreateDirectory(dest_dir);
			string dest_path = dest_dir + dest_file;
			if (chReplace.Checked || !File.Exists(dest_path))
			{
				File.Copy(src_path, dest_path, true);
				return true;
			}
			return false;
		}
	}
}
