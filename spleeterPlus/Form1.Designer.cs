namespace spleeterPlus
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textInputFile = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio5stems = new System.Windows.Forms.RadioButton();
            this.radio4stems = new System.Windows.Forms.RadioButton();
            this.radio2stems = new System.Windows.Forms.RadioButton();
            this.buttonInputFileDialog = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonExec = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSpleeterPathDialog = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOutputFolder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numSelected = new System.Windows.Forms.NumericUpDown();
            this.textoutputFolder = new System.Windows.Forms.TextBox();
            this.textSpleeterPath = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(19, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "入力ファイル(&I)";
            // 
            // textInputFile
            // 
            this.textInputFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textInputFile.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textInputFile.Location = new System.Drawing.Point(142, 66);
            this.textInputFile.Name = "textInputFile";
            this.textInputFile.Size = new System.Drawing.Size(456, 25);
            this.textInputFile.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio5stems);
            this.groupBox1.Controls.Add(this.radio4stems);
            this.groupBox1.Controls.Add(this.radio2stems);
            this.groupBox1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(22, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分割オプション(&O)";
            // 
            // radio5stems
            // 
            this.radio5stems.AutoSize = true;
            this.radio5stems.Location = new System.Drawing.Point(16, 69);
            this.radio5stems.Name = "radio5stems";
            this.radio5stems.Size = new System.Drawing.Size(255, 22);
            this.radio5stems.TabIndex = 2;
            this.radio5stems.Text = "ボーカル/ドラム/ベース/ピアノ/その他(&5)";
            this.radio5stems.UseVisualStyleBackColor = true;
            this.radio5stems.CheckedChanged += new System.EventHandler(this.radio5stems_CheckedChanged);
            // 
            // radio4stems
            // 
            this.radio4stems.AutoSize = true;
            this.radio4stems.Location = new System.Drawing.Point(16, 46);
            this.radio4stems.Name = "radio4stems";
            this.radio4stems.Size = new System.Drawing.Size(214, 22);
            this.radio4stems.TabIndex = 1;
            this.radio4stems.Text = "ボーカル/ドラム/ベース/その他(&4)";
            this.radio4stems.UseVisualStyleBackColor = true;
            this.radio4stems.CheckedChanged += new System.EventHandler(this.radio4stems_CheckedChanged);
            // 
            // radio2stems
            // 
            this.radio2stems.AutoSize = true;
            this.radio2stems.Checked = true;
            this.radio2stems.Location = new System.Drawing.Point(16, 23);
            this.radio2stems.Name = "radio2stems";
            this.radio2stems.Size = new System.Drawing.Size(120, 22);
            this.radio2stems.TabIndex = 0;
            this.radio2stems.TabStop = true;
            this.radio2stems.Text = "ボーカル/伴奏(&2)";
            this.radio2stems.UseVisualStyleBackColor = true;
            this.radio2stems.CheckedChanged += new System.EventHandler(this.radio2stems_CheckedChanged);
            // 
            // buttonInputFileDialog
            // 
            this.buttonInputFileDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInputFileDialog.AutoSize = true;
            this.buttonInputFileDialog.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonInputFileDialog.Location = new System.Drawing.Point(604, 64);
            this.buttonInputFileDialog.Name = "buttonInputFileDialog";
            this.buttonInputFileDialog.Size = new System.Drawing.Size(62, 28);
            this.buttonInputFileDialog.TabIndex = 5;
            this.buttonInputFileDialog.Text = "参照(&B)";
            this.buttonInputFileDialog.UseVisualStyleBackColor = true;
            this.buttonInputFileDialog.Click += new System.EventHandler(this.buttonInputFileDialog_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_File});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(675, 26);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_File
            // 
            this.ToolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Exit});
            this.ToolStripMenuItem_File.Name = "ToolStripMenuItem_File";
            this.ToolStripMenuItem_File.Size = new System.Drawing.Size(85, 22);
            this.ToolStripMenuItem_File.Text = "ファイル(&F)";
            // 
            // ToolStripMenuItem_Exit
            // 
            this.ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit";
            this.ToolStripMenuItem_Exit.Size = new System.Drawing.Size(117, 22);
            this.ToolStripMenuItem_Exit.Text = "終了(&E)";
            this.ToolStripMenuItem_Exit.Click += new System.EventHandler(this.Exit_ToolStripMenuItem_Click);
            // 
            // buttonExec
            // 
            this.buttonExec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExec.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonExec.Location = new System.Drawing.Point(509, 201);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(75, 31);
            this.buttonExec.TabIndex = 10;
            this.buttonExec.Text = "実行(&R)";
            this.buttonExec.UseVisualStyleBackColor = true;
            this.buttonExec.Click += new System.EventHandler(this.buttonExec_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonClose.Location = new System.Drawing.Point(592, 201);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 31);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "閉じる(&C)";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSpleeterPathDialog
            // 
            this.buttonSpleeterPathDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSpleeterPathDialog.AutoSize = true;
            this.buttonSpleeterPathDialog.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSpleeterPathDialog.Location = new System.Drawing.Point(604, 34);
            this.buttonSpleeterPathDialog.Name = "buttonSpleeterPathDialog";
            this.buttonSpleeterPathDialog.Size = new System.Drawing.Size(62, 28);
            this.buttonSpleeterPathDialog.TabIndex = 2;
            this.buttonSpleeterPathDialog.Text = "参照(&B)";
            this.buttonSpleeterPathDialog.UseVisualStyleBackColor = true;
            this.buttonSpleeterPathDialog.Click += new System.EventHandler(this.buttonSpleeterPathDialog_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(19, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Anacondaのパス(&A)";
            // 
            // buttonOutputFolder
            // 
            this.buttonOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOutputFolder.AutoSize = true;
            this.buttonOutputFolder.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonOutputFolder.Location = new System.Drawing.Point(604, 94);
            this.buttonOutputFolder.Name = "buttonOutputFolder";
            this.buttonOutputFolder.Size = new System.Drawing.Size(62, 28);
            this.buttonOutputFolder.TabIndex = 8;
            this.buttonOutputFolder.Text = "参照(&B)";
            this.buttonOutputFolder.UseVisualStyleBackColor = true;
            this.buttonOutputFolder.Click += new System.EventHandler(this.buttonOutputFolder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(19, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "出力パス(&O)";
            // 
            // numSelected
            // 
            this.numSelected.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::spleeterPlus.Properties.Settings.Default, "DefaultStems", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numSelected.Location = new System.Drawing.Point(347, 208);
            this.numSelected.Name = "numSelected";
            this.numSelected.Size = new System.Drawing.Size(45, 19);
            this.numSelected.TabIndex = 12;
            this.numSelected.Value = global::spleeterPlus.Properties.Settings.Default.DefaultStems;
            this.numSelected.Visible = false;
            // 
            // textoutputFolder
            // 
            this.textoutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textoutputFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::spleeterPlus.Properties.Settings.Default, "OutputFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textoutputFolder.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textoutputFolder.Location = new System.Drawing.Point(142, 96);
            this.textoutputFolder.Name = "textoutputFolder";
            this.textoutputFolder.Size = new System.Drawing.Size(456, 25);
            this.textoutputFolder.TabIndex = 7;
            this.textoutputFolder.Text = global::spleeterPlus.Properties.Settings.Default.OutputFolder;
            // 
            // textSpleeterPath
            // 
            this.textSpleeterPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSpleeterPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::spleeterPlus.Properties.Settings.Default, "SpleeterPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textSpleeterPath.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textSpleeterPath.Location = new System.Drawing.Point(142, 36);
            this.textSpleeterPath.Name = "textSpleeterPath";
            this.textSpleeterPath.Size = new System.Drawing.Size(456, 25);
            this.textSpleeterPath.TabIndex = 1;
            this.textSpleeterPath.Text = global::spleeterPlus.Properties.Settings.Default.SpleeterPath;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 248);
            this.Controls.Add(this.numSelected);
            this.Controls.Add(this.buttonOutputFolder);
            this.Controls.Add(this.textoutputFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSpleeterPathDialog);
            this.Controls.Add(this.textSpleeterPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonExec);
            this.Controls.Add(this.buttonInputFileDialog);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textInputFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1280, 287);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(518, 287);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "spleeterPlus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textInputFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio5stems;
        private System.Windows.Forms.RadioButton radio4stems;
        private System.Windows.Forms.RadioButton radio2stems;
        private System.Windows.Forms.Button buttonInputFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Exit;
        private System.Windows.Forms.Button buttonExec;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSpleeterPathDialog;
        private System.Windows.Forms.TextBox textSpleeterPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOutputFolder;
        private System.Windows.Forms.TextBox textoutputFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numSelected;
    }
}

