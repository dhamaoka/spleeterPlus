using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            this.textSpleeterPath.Text = Properties.Settings.Default["spleeterPath"].ToString();
            this.textoutputFolder.Text = Properties.Settings.Default["outputFolder"].ToString();
        }

        private void 終了EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSpleeterPathDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog spleeterDialog = new OpenFileDialog();

            spleeterDialog.Title = "Spleeter.exeのパスを指定してください。";
            spleeterDialog.Filter = "実行ファイル(*.exe)|*.exe|すべてのファイル(*.*)|*.*";
            spleeterDialog.FileName = "spleeter.exe";
            spleeterDialog.InitialDirectory = @"C:\";
            spleeterDialog.RestoreDirectory = true;

            if (spleeterDialog.ShowDialog() == DialogResult.OK)
            {
                if (!(string.IsNullOrEmpty(spleeterDialog.FileName)))
                {
                    textSpleeterPath.Text = spleeterDialog.FileName;
                }
            }
        }
    }
}
