using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spleeterPlus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            switch (Properties.Settings.Default.DefaultStems)
            {
                case 2:
                    numSelected.Value = 2;
                    radio2stems.Checked = true;
                    break;
                case 4:
                    numSelected.Value = 4;
                    radio4stems.Checked = true;
                    break;
                case 5:
                    numSelected.Value = 5;
                    radio5stems.Checked = true;
                    break;
                default:
                    numSelected.Value = 2;
                    radio2stems.Checked = true;
                    break;
            }
        }

        private void Exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSpleeterPathDialog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = "Anacondaのパスを指定してください";
            dlg.RootFolder = Environment.SpecialFolder.Desktop;
            if (!string.IsNullOrEmpty(textSpleeterPath.Text))
            {
                dlg.SelectedPath = textSpleeterPath.Text;
            }

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (!(string.IsNullOrEmpty(dlg.SelectedPath)))
                {
                    textSpleeterPath.Text = dlg.SelectedPath;
                }
            }
        }

        private void buttonInputFileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "ファイルを選択";
            dlg.Filter = "mp3(*.mp3)|*.mp3|すべてのファイル(*.*)|*.*";
            dlg.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (!(string.IsNullOrEmpty(dlg.FileName)))
                {
                    textInputFile.Text = dlg.FileName;
                }
            }
        }

        private void buttonOutputFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = "出力フォルダの選択";
            dlg.RootFolder = Environment.SpecialFolder.Desktop;
            if (!string.IsNullOrEmpty(textoutputFolder.Text))
            {
                dlg.SelectedPath = textoutputFolder.Text;
            }

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (!(string.IsNullOrEmpty(dlg.SelectedPath)))
                {
                    textoutputFolder.Text = dlg.SelectedPath;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void radio2stems_CheckedChanged(object sender, EventArgs e)
        {
            if (radio2stems.Checked)
            {
                numSelected.Value = 2;
            }
        }

        private void radio4stems_CheckedChanged(object sender, EventArgs e)
        {
            if (radio4stems.Checked)
            {
                numSelected.Value = 4;
            }
        }

        private void radio5stems_CheckedChanged(object sender, EventArgs e)
        {
            if (radio5stems.Checked)
            {
                numSelected.Value = 5;
            }
        }

        private void buttonExec_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textSpleeterPath.Text))
            {
                MessageBox.Show("Anacondaのインストールパスが選択されていません。", "EXEファイルエラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textSpleeterPath.Focus();
                return;
            }

            if (!(System.IO.Directory.Exists(textSpleeterPath.Text)))
            {
                MessageBox.Show("Anacondaのインストールパスが存在しません。", "EXEファイルエラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textSpleeterPath.Focus();
                return;
            }

            if (string.IsNullOrEmpty(textInputFile.Text))
            {
                MessageBox.Show("入力ファイルの場所が選択されていません。", "入力ファイルエラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textInputFile.Focus();
                return;
            }

            if (!(System.IO.File.Exists(textInputFile.Text)))
            {
                MessageBox.Show("入力ファイルが存在しません。", "入力ファイルエラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textInputFile.Focus();
                return;
            }

            if (string.IsNullOrEmpty(textoutputFolder.Text))
            {
                MessageBox.Show("出力パスが指定されていません。", "出力パスエラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textoutputFolder.Focus();
                return;
            }

            if (!(System.IO.Directory.Exists(textoutputFolder.Text)))
            {
                MessageBox.Show("出力パスが存在しません。", "出力パスエラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textoutputFolder.Focus();
                return;
            }

            bool AddOutput = false;
            string[] pathArray = textoutputFolder.Text.Split(System.IO.Path.DirectorySeparatorChar);
            if (pathArray[(pathArray.Length - 1)].ToLower() != "output")
            {
                if (MessageBox.Show("末尾がOutputではありませんが、よろしいですか？\n\r自動でOutputフォルダを作成する場合は、いいえを選んでください。", "出力パスの調整", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    AddOutput = true;
                }
            }

            string TempOutputPath = "";
            if (AddOutput)
            {
                TempOutputPath = System.IO.Path.Combine(textoutputFolder.Text, "Output");
            }
            else
            {
                TempOutputPath = textoutputFolder.Text;
            }

            string stems = "";
            stems = numSelected.Value.ToString() + "stems";

            if (!(System.IO.Directory.Exists(TempOutputPath)))
            {
                System.IO.Directory.CreateDirectory(TempOutputPath);
            }

            string cmd = $"spleeter separate -i '{@textInputFile.Text}' -p spleeter:{stems} -o '{@TempOutputPath}'";
            string spleeterPath = "";
            spleeterPath = System.IO.Path.Combine(textSpleeterPath.Text, @"shell\condabin\conda-hook.ps1");
            if (!(System.IO.File.Exists(spleeterPath)))
            {
                MessageBox.Show("spleeterの実行パスが見つかりません。", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string psCommand = $"& '{@spleeterPath}' ; conda activate '{@textSpleeterPath.Text}'; start-sleep -m 2000  ; conda activate spleeter-cpu ; {cmd}";

            this.Enabled = false;
            this.UseWaitCursor = true; 
            OpenWithArguments(psCommand);
            this.Enabled = true;
            this.UseWaitCursor = false;

            //ここは最後だな。
            if (AddOutput)
            {
                textoutputFolder.Text = TempOutputPath;
            }
            MessageBox.Show("終了しました。", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start(TempOutputPath);
        }

        //PowerShellの実行メソッド
        static void OpenWithArguments(string options)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = "PowerShell.exe";
            //PowerShellのWindowを立ち上げずに実行。
            //cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            // 引数optionsをShellのコマンドとして渡す。
            proc.StartInfo.Arguments = options;
            proc.Start();
            proc.WaitForExit();
        }
    }
}
