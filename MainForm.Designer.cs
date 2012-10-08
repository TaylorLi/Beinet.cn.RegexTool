namespace Beinet.cn.RegexTool
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.split1 = new System.Windows.Forms.SplitContainer();
            this.btnGroupBy0 = new System.Windows.Forms.Button();
            this.btnGroupBy1 = new System.Windows.Forms.Button();
            this.btnGroupBy = new System.Windows.Forms.Button();
            this.btnExeOne = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.chkSplit = new System.Windows.Forms.CheckBox();
            this.chkReplace = new System.Windows.Forms.CheckBox();
            this.chkCompiled = new System.Windows.Forms.CheckBox();
            this.chkMultiLine = new System.Windows.Forms.CheckBox();
            this.chkSingle = new System.Windows.Forms.CheckBox();
            this.chkIgnoreCase = new System.Windows.Forms.CheckBox();
            this.txtReg = new System.Windows.Forms.RichTextBox();
            this.menuReg = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuRegCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRegCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRegParse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRegDel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuRegCommon = new System.Windows.Forms.ToolStripMenuItem();
            this.txtOld = new System.Windows.Forms.RichTextBox();
            this.split2 = new System.Windows.Forms.SplitContainer();
            this.txtReplace = new System.Windows.Forms.RichTextBox();
            this.splitResult = new System.Windows.Forms.SplitContainer();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.group0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.split1.Panel1.SuspendLayout();
            this.split1.Panel2.SuspendLayout();
            this.split1.SuspendLayout();
            this.menuReg.SuspendLayout();
            this.split2.Panel1.SuspendLayout();
            this.split2.Panel2.SuspendLayout();
            this.split2.SuspendLayout();
            this.splitResult.Panel1.SuspendLayout();
            this.splitResult.Panel2.SuspendLayout();
            this.splitResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            this.splitMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.split1);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.split2);
            this.splitMain.Size = new System.Drawing.Size(926, 702);
            this.splitMain.SplitterDistance = 333;
            this.splitMain.SplitterWidth = 1;
            this.splitMain.TabIndex = 0;
            this.splitMain.TabStop = false;
            // 
            // split1
            // 
            this.split1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split1.Location = new System.Drawing.Point(0, 0);
            this.split1.Name = "split1";
            this.split1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // split1.Panel1
            // 
            this.split1.Panel1.Controls.Add(this.btnGroupBy0);
            this.split1.Panel1.Controls.Add(this.btnGroupBy1);
            this.split1.Panel1.Controls.Add(this.btnGroupBy);
            this.split1.Panel1.Controls.Add(this.btnExeOne);
            this.split1.Panel1.Controls.Add(this.btnExecute);
            this.split1.Panel1.Controls.Add(this.chkSplit);
            this.split1.Panel1.Controls.Add(this.chkReplace);
            this.split1.Panel1.Controls.Add(this.chkCompiled);
            this.split1.Panel1.Controls.Add(this.chkMultiLine);
            this.split1.Panel1.Controls.Add(this.chkSingle);
            this.split1.Panel1.Controls.Add(this.chkIgnoreCase);
            this.split1.Panel1.Controls.Add(this.txtReg);
            // 
            // split1.Panel2
            // 
            this.split1.Panel2.Controls.Add(this.txtOld);
            this.split1.Size = new System.Drawing.Size(926, 333);
            this.split1.SplitterDistance = 120;
            this.split1.SplitterWidth = 1;
            this.split1.TabIndex = 0;
            this.split1.TabStop = false;
            // 
            // btnGroupBy0
            // 
            this.btnGroupBy0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGroupBy0.Location = new System.Drawing.Point(647, 97);
            this.btnGroupBy0.Name = "btnGroupBy0";
            this.btnGroupBy0.Size = new System.Drawing.Size(91, 23);
            this.btnGroupBy0.TabIndex = 2;
            this.btnGroupBy0.Text = "统计整个匹配";
            this.btnGroupBy0.UseVisualStyleBackColor = true;
            this.btnGroupBy0.Click += new System.EventHandler(this.btnGroupBy_Click);
            // 
            // btnGroupBy1
            // 
            this.btnGroupBy1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGroupBy1.Location = new System.Drawing.Point(744, 97);
            this.btnGroupBy1.Name = "btnGroupBy1";
            this.btnGroupBy1.Size = new System.Drawing.Size(67, 23);
            this.btnGroupBy1.TabIndex = 3;
            this.btnGroupBy1.Text = "统计分组1";
            this.btnGroupBy1.UseVisualStyleBackColor = true;
            this.btnGroupBy1.Click += new System.EventHandler(this.btnGroupBy_Click);
            // 
            // btnGroupBy
            // 
            this.btnGroupBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGroupBy.Location = new System.Drawing.Point(817, 97);
            this.btnGroupBy.Name = "btnGroupBy";
            this.btnGroupBy.Size = new System.Drawing.Size(106, 23);
            this.btnGroupBy.TabIndex = 4;
            this.btnGroupBy.Text = "选择分组并统计";
            this.btnGroupBy.UseVisualStyleBackColor = true;
            this.btnGroupBy.Click += new System.EventHandler(this.btnGroupBy_Click);
            // 
            // btnExeOne
            // 
            this.btnExeOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExeOne.Location = new System.Drawing.Point(475, 97);
            this.btnExeOne.Name = "btnExeOne";
            this.btnExeOne.Size = new System.Drawing.Size(80, 23);
            this.btnExeOne.TabIndex = 0;
            this.btnExeOne.Text = "逐一匹配";
            this.btnExeOne.UseVisualStyleBackColor = true;
            this.btnExeOne.Click += new System.EventHandler(this.btnExeOne_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.Location = new System.Drawing.Point(561, 97);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(80, 23);
            this.btnExecute.TabIndex = 1;
            this.btnExecute.Text = "全部匹配";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // chkSplit
            // 
            this.chkSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkSplit.AutoSize = true;
            this.chkSplit.Location = new System.Drawing.Point(397, 98);
            this.chkSplit.Name = "chkSplit";
            this.chkSplit.Size = new System.Drawing.Size(72, 16);
            this.chkSplit.TabIndex = 0;
            this.chkSplit.TabStop = false;
            this.chkSplit.Text = "分割模式";
            this.chkSplit.UseVisualStyleBackColor = true;
            this.chkSplit.CheckedChanged += new System.EventHandler(this.chkReplace_CheckedChanged);
            // 
            // chkReplace
            // 
            this.chkReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkReplace.AutoSize = true;
            this.chkReplace.Location = new System.Drawing.Point(327, 98);
            this.chkReplace.Name = "chkReplace";
            this.chkReplace.Size = new System.Drawing.Size(72, 16);
            this.chkReplace.TabIndex = 0;
            this.chkReplace.TabStop = false;
            this.chkReplace.Text = "替换模式";
            this.chkReplace.UseVisualStyleBackColor = true;
            this.chkReplace.CheckedChanged += new System.EventHandler(this.chkReplace_CheckedChanged);
            // 
            // chkCompiled
            // 
            this.chkCompiled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkCompiled.AutoSize = true;
            this.chkCompiled.Checked = true;
            this.chkCompiled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCompiled.Location = new System.Drawing.Point(249, 98);
            this.chkCompiled.Name = "chkCompiled";
            this.chkCompiled.Size = new System.Drawing.Size(72, 16);
            this.chkCompiled.TabIndex = 0;
            this.chkCompiled.TabStop = false;
            this.chkCompiled.Text = "编译模式";
            this.chkCompiled.UseVisualStyleBackColor = true;
            this.chkCompiled.CheckedChanged += new System.EventHandler(this.EnvironmentChanged);
            // 
            // chkMultiLine
            // 
            this.chkMultiLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkMultiLine.AutoSize = true;
            this.chkMultiLine.Location = new System.Drawing.Point(171, 98);
            this.chkMultiLine.Name = "chkMultiLine";
            this.chkMultiLine.Size = new System.Drawing.Size(72, 16);
            this.chkMultiLine.TabIndex = 0;
            this.chkMultiLine.TabStop = false;
            this.chkMultiLine.Text = "多行模式";
            this.chkMultiLine.UseVisualStyleBackColor = true;
            this.chkMultiLine.CheckedChanged += new System.EventHandler(this.EnvironmentChanged);
            // 
            // chkSingle
            // 
            this.chkSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkSingle.AutoSize = true;
            this.chkSingle.Location = new System.Drawing.Point(93, 98);
            this.chkSingle.Name = "chkSingle";
            this.chkSingle.Size = new System.Drawing.Size(72, 16);
            this.chkSingle.TabIndex = 0;
            this.chkSingle.TabStop = false;
            this.chkSingle.Text = "单行模式";
            this.chkSingle.UseVisualStyleBackColor = true;
            this.chkSingle.CheckedChanged += new System.EventHandler(this.EnvironmentChanged);
            // 
            // chkIgnoreCase
            // 
            this.chkIgnoreCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkIgnoreCase.AutoSize = true;
            this.chkIgnoreCase.Location = new System.Drawing.Point(3, 98);
            this.chkIgnoreCase.Name = "chkIgnoreCase";
            this.chkIgnoreCase.Size = new System.Drawing.Size(84, 16);
            this.chkIgnoreCase.TabIndex = 0;
            this.chkIgnoreCase.TabStop = false;
            this.chkIgnoreCase.Text = "忽略大小写";
            this.chkIgnoreCase.UseVisualStyleBackColor = true;
            this.chkIgnoreCase.CheckedChanged += new System.EventHandler(this.EnvironmentChanged);
            // 
            // txtReg
            // 
            this.txtReg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReg.CausesValidation = false;
            this.txtReg.ContextMenuStrip = this.menuReg;
            this.txtReg.DetectUrls = false;
            this.txtReg.HideSelection = false;
            this.txtReg.Location = new System.Drawing.Point(3, 3);
            this.txtReg.Name = "txtReg";
            this.txtReg.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtReg.ShowSelectionMargin = true;
            this.txtReg.Size = new System.Drawing.Size(920, 88);
            this.txtReg.TabIndex = 5;
            this.txtReg.Text = "";
            this.txtReg.WordWrap = false;
            this.txtReg.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.txtReg.Enter += new System.EventHandler(this.txt_Enter);
            this.txtReg.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // menuReg
            // 
            this.menuReg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRegCut,
            this.menuRegCopy,
            this.menuRegParse,
            this.menuRegDel,
            this.toolStripSeparator1,
            this.menuRegCommon});
            this.menuReg.Name = "menuReg";
            this.menuReg.Size = new System.Drawing.Size(143, 120);
            // 
            // menuRegCut
            // 
            this.menuRegCut.Name = "menuRegCut";
            this.menuRegCut.Size = new System.Drawing.Size(142, 22);
            this.menuRegCut.Text = "剪切";
            this.menuRegCut.Click += new System.EventHandler(this.menuReg_Click);
            // 
            // menuRegCopy
            // 
            this.menuRegCopy.Name = "menuRegCopy";
            this.menuRegCopy.Size = new System.Drawing.Size(142, 22);
            this.menuRegCopy.Text = "复制";
            this.menuRegCopy.Click += new System.EventHandler(this.menuReg_Click);
            // 
            // menuRegParse
            // 
            this.menuRegParse.Name = "menuRegParse";
            this.menuRegParse.Size = new System.Drawing.Size(142, 22);
            this.menuRegParse.Text = "粘贴";
            this.menuRegParse.Click += new System.EventHandler(this.menuReg_Click);
            // 
            // menuRegDel
            // 
            this.menuRegDel.Name = "menuRegDel";
            this.menuRegDel.Size = new System.Drawing.Size(142, 22);
            this.menuRegDel.Text = "删除";
            this.menuRegDel.Click += new System.EventHandler(this.menuReg_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(139, 6);
            // 
            // menuRegCommon
            // 
            this.menuRegCommon.Name = "menuRegCommon";
            this.menuRegCommon.Size = new System.Drawing.Size(142, 22);
            this.menuRegCommon.Text = "插入常用正则";
            // 
            // txtOld
            // 
            this.txtOld.ContextMenuStrip = this.menuReg;
            this.txtOld.DetectUrls = false;
            this.txtOld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOld.EnableAutoDragDrop = true;
            this.txtOld.HideSelection = false;
            this.txtOld.Location = new System.Drawing.Point(0, 0);
            this.txtOld.Name = "txtOld";
            this.txtOld.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtOld.ShowSelectionMargin = true;
            this.txtOld.Size = new System.Drawing.Size(926, 212);
            this.txtOld.TabIndex = 6;
            this.txtOld.Text = "";
            this.txtOld.WordWrap = false;
            this.txtOld.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.txtOld.Enter += new System.EventHandler(this.txt_Enter);
            this.txtOld.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // split2
            // 
            this.split2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split2.IsSplitterFixed = true;
            this.split2.Location = new System.Drawing.Point(0, 0);
            this.split2.Name = "split2";
            this.split2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // split2.Panel1
            // 
            this.split2.Panel1.Controls.Add(this.txtReplace);
            this.split2.Panel1MinSize = 0;
            // 
            // split2.Panel2
            // 
            this.split2.Panel2.Controls.Add(this.splitResult);
            this.split2.Size = new System.Drawing.Size(926, 368);
            this.split2.SplitterDistance = 0;
            this.split2.SplitterWidth = 1;
            this.split2.TabIndex = 0;
            this.split2.TabStop = false;
            // 
            // txtReplace
            // 
            this.txtReplace.ContextMenuStrip = this.menuReg;
            this.txtReplace.DetectUrls = false;
            this.txtReplace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReplace.EnableAutoDragDrop = true;
            this.txtReplace.HideSelection = false;
            this.txtReplace.Location = new System.Drawing.Point(0, 0);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtReplace.ShowSelectionMargin = true;
            this.txtReplace.Size = new System.Drawing.Size(926, 0);
            this.txtReplace.TabIndex = 0;
            this.txtReplace.TabStop = false;
            this.txtReplace.Text = "";
            this.txtReplace.WordWrap = false;
            this.txtReplace.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.txtReplace.Enter += new System.EventHandler(this.txt_Enter);
            this.txtReplace.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // splitResult
            // 
            this.splitResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitResult.Location = new System.Drawing.Point(0, 0);
            this.splitResult.Name = "splitResult";
            this.splitResult.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitResult.Panel1
            // 
            this.splitResult.Panel1.Controls.Add(this.dgvResult);
            this.splitResult.Panel1.Controls.Add(this.txtResult);
            // 
            // splitResult.Panel2
            // 
            this.splitResult.Panel2.Controls.Add(this.txtStatus);
            this.splitResult.Panel2MinSize = 15;
            this.splitResult.Size = new System.Drawing.Size(926, 367);
            this.splitResult.SplitterDistance = 348;
            this.splitResult.SplitterWidth = 1;
            this.splitResult.TabIndex = 0;
            this.splitResult.TabStop = false;
            // 
            // dgvResult
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(245)))), ((int)(((byte)(178)))));
            this.dgvResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.group0});
            this.dgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResult.Location = new System.Drawing.Point(0, 0);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowHeadersWidth = 60;
            this.dgvResult.RowTemplate.Height = 23;
            this.dgvResult.Size = new System.Drawing.Size(926, 348);
            this.dgvResult.TabIndex = 0;
            this.dgvResult.TabStop = false;
            this.dgvResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResult_CellClick);
            this.dgvResult.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvResult_ColumnHeaderMouseClick);
            this.dgvResult.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvResult_RowsAdded);
            this.dgvResult.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // group0
            // 
            this.group0.HeaderText = "匹配值";
            this.group0.Name = "group0";
            this.group0.Width = 800;
            // 
            // txtResult
            // 
            this.txtResult.ContextMenuStrip = this.menuReg;
            this.txtResult.DetectUrls = false;
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.EnableAutoDragDrop = true;
            this.txtResult.HideSelection = false;
            this.txtResult.Location = new System.Drawing.Point(0, 0);
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtResult.ShowSelectionMargin = true;
            this.txtResult.Size = new System.Drawing.Size(926, 348);
            this.txtResult.TabIndex = 0;
            this.txtResult.TabStop = false;
            this.txtResult.Text = "";
            this.txtResult.WordWrap = false;
            this.txtResult.Enter += new System.EventHandler(this.txt_Enter);
            this.txtResult.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStatus.Location = new System.Drawing.Point(0, 0);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(926, 14);
            this.txtStatus.TabIndex = 0;
            this.txtStatus.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 702);
            this.Controls.Add(this.splitMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "正则工具";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            this.splitMain.ResumeLayout(false);
            this.split1.Panel1.ResumeLayout(false);
            this.split1.Panel1.PerformLayout();
            this.split1.Panel2.ResumeLayout(false);
            this.split1.ResumeLayout(false);
            this.menuReg.ResumeLayout(false);
            this.split2.Panel1.ResumeLayout(false);
            this.split2.Panel2.ResumeLayout(false);
            this.split2.ResumeLayout(false);
            this.splitResult.Panel1.ResumeLayout(false);
            this.splitResult.Panel2.ResumeLayout(false);
            this.splitResult.Panel2.PerformLayout();
            this.splitResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.SplitContainer split2;
        private System.Windows.Forms.RichTextBox txtReplace;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.SplitContainer split1;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.CheckBox chkReplace;
        private System.Windows.Forms.CheckBox chkCompiled;
        private System.Windows.Forms.CheckBox chkMultiLine;
        private System.Windows.Forms.CheckBox chkSingle;
        private System.Windows.Forms.CheckBox chkIgnoreCase;
        private System.Windows.Forms.RichTextBox txtReg;
        private System.Windows.Forms.Button btnGroupBy;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn group0;
        private System.Windows.Forms.RichTextBox txtOld;
        private System.Windows.Forms.SplitContainer splitResult;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.ContextMenuStrip menuReg;
        private System.Windows.Forms.ToolStripMenuItem menuRegCut;
        private System.Windows.Forms.ToolStripMenuItem menuRegCopy;
        private System.Windows.Forms.ToolStripMenuItem menuRegParse;
        private System.Windows.Forms.ToolStripMenuItem menuRegDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuRegCommon;
        private System.Windows.Forms.Button btnGroupBy0;
        private System.Windows.Forms.Button btnGroupBy1;
        private System.Windows.Forms.Button btnExeOne;
        private System.Windows.Forms.CheckBox chkSplit;
    }
}

