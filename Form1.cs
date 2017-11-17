using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Searcher
{
    public partial class Form1 : Form
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable("SearchResult");
        private int lookinFiles = 0;

        public Form1()
        {
            InitializeComponent();
            var lines = File.ReadAllLines("Path.ini");
            tbWhere.Text = lines[0];//@"D:\Projects\mis-oda-pba-su-3\WebUI\Views";
            label4.Text = @"0";
            label6.Text = @"0";
            dt.Columns.Add(new DataColumn("ID", typeof(int)));
            dt.Columns.Add(new DataColumn("RowNumber", typeof(int)));
            dt.Columns.Add(new DataColumn("RowValue", typeof(string)));
            dt.Columns.Add(new DataColumn("FileName", typeof(string)));
            ds.Tables.Add(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbWhat.Text == String.Empty)
            {
                MessageBox.Show(this, @"Что искать?", @"Searcher", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            List<string> extentionList = new List<string>();
            foreach (Control control in this.gbExtensions.Controls)
            {
                if(control.GetType() == typeof(CheckBox) && ((CheckBox)control).Checked)
                {
                    extentionList.Add(control.Text);
                }
            }

            if (extentionList.Count == 0)
            {
                MessageBox.Show(this, @"Тип файла", @"Searcher", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            label4.Text = @"0";
            label6.Text = @"0";

            lookinFiles = 0;

            String searchFolder = tbWhere.Text;
            if (searchFolder != String.Empty)
            {
                dt.Rows.Clear();
                Search(searchFolder, extentionList);
            }
            else
            {
                MessageBox.Show(this, @"Область поиска пуста!", @"Searcher", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Search(string folder, List<string> extList)
        {
            List<string> files = Directory.EnumerateFiles(folder).ToList();
            foreach (var file in files)
            {
                if (extList.Contains(GetExtension(file)))
                {
                    lookinFiles++;
                    using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
                    using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                    {
                        string line;
                        int rowCounter = 0;
                        while ((line = sr.ReadLine()) != null)
                        {
                            rowCounter++;
                            if (line.Trim().ToLower().Contains(tbWhat.Text.Trim().ToLower()))
                            {
                                int rowsCount = dt.Rows.Count;
                                DataRow row = dt.NewRow();
                                row["ID"] = rowsCount + 1;
                                row["RowNumber"] = rowCounter;
                                row["RowValue"] = line.Trim();
                                row["FileName"] = file;
                                dt.Rows.Add(row);
                                label4.Text = dt.Rows.Count.ToString();
                                
                            }
                        }
                    }
                    label6.Text = lookinFiles.ToString();
                }
            }

            List<string> folders = Directory.EnumerateDirectories(folder)//.Where(x => !x.Contains("\\obj"))
                .ToList();
            if (folders.Count > 0)
            {
                foreach (string f in folders)
                {
                    Search(f, extList);
                }
            }
        }

        private string GetExtension(string name)
        {
            string result = String.Empty;

            int lastPointIndex = name.LastIndexOf('.');
            result = lastPointIndex > 0 ? name.Substring(lastPointIndex).ToLower() : "";

            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if(Directory.Exists(tbWhere.Text))
                folderBrowserDialog.SelectedPath = tbWhere.Text;
            else
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;

            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                tbWhere.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
