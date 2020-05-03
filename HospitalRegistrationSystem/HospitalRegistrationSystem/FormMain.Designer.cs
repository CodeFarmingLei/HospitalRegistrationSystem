namespace HospitalRegistrationSystem
{
    partial class FormMain
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonCall = new System.Windows.Forms.Button();
            this.statusStripTip = new System.Windows.Forms.StatusStrip();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.使用帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBoxQueueStatus = new System.Windows.Forms.GroupBox();
            this.dataGridViewShow = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.radioButtonVisiting = new System.Windows.Forms.RadioButton();
            this.radioButtonReady = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStripMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.groupBoxQueueStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).BeginInit();
            this.groupBoxEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCall
            // 
            this.buttonCall.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCall.Location = new System.Drawing.Point(807, 492);
            this.buttonCall.Name = "buttonCall";
            this.buttonCall.Size = new System.Drawing.Size(103, 34);
            this.buttonCall.TabIndex = 0;
            this.buttonCall.Text = "叫号";
            this.buttonCall.UseVisualStyleBackColor = true;
            this.buttonCall.Click += new System.EventHandler(this.ButtonCall_Click);
            // 
            // statusStripTip
            // 
            this.statusStripTip.Location = new System.Drawing.Point(0, 539);
            this.statusStripTip.Name = "statusStripTip";
            this.statusStripTip.Size = new System.Drawing.Size(919, 22);
            this.statusStripTip.TabIndex = 1;
            this.statusStripTip.Text = "statusStrip1";
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.使用帮助ToolStripMenuItem,
            this.关于程序ToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(919, 25);
            this.menuStripMain.TabIndex = 2;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStripMain.Location = new System.Drawing.Point(0, 25);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(919, 25);
            this.toolStripMain.TabIndex = 3;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.toolStripMenuItem1.Text = "程序功能";
            // 
            // 使用帮助ToolStripMenuItem
            // 
            this.使用帮助ToolStripMenuItem.Name = "使用帮助ToolStripMenuItem";
            this.使用帮助ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.使用帮助ToolStripMenuItem.Text = "使用帮助";
            // 
            // 关于程序ToolStripMenuItem
            // 
            this.关于程序ToolStripMenuItem.Name = "关于程序ToolStripMenuItem";
            this.关于程序ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.关于程序ToolStripMenuItem.Text = "关于程序";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(84, 22);
            this.toolStripButton1.Text = "查看大厅公屏";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // groupBoxQueueStatus
            // 
            this.groupBoxQueueStatus.Controls.Add(this.dataGridViewShow);
            this.groupBoxQueueStatus.Location = new System.Drawing.Point(5, 53);
            this.groupBoxQueueStatus.Name = "groupBoxQueueStatus";
            this.groupBoxQueueStatus.Size = new System.Drawing.Size(905, 413);
            this.groupBoxQueueStatus.TabIndex = 4;
            this.groupBoxQueueStatus.TabStop = false;
            this.groupBoxQueueStatus.Text = "患者排队状态";
            // 
            // dataGridViewShow
            // 
            this.dataGridViewShow.AllowUserToAddRows = false;
            this.dataGridViewShow.AllowUserToResizeColumns = false;
            this.dataGridViewShow.AllowUserToResizeRows = false;
            this.dataGridViewShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewShow.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewShow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewShow.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewShow.ColumnHeadersHeight = 25;
            this.dataGridViewShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewShow.EnableHeadersVisualStyles = false;
            this.dataGridViewShow.Location = new System.Drawing.Point(6, 20);
            this.dataGridViewShow.MultiSelect = false;
            this.dataGridViewShow.Name = "dataGridViewShow";
            this.dataGridViewShow.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShow.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewShow.RowTemplate.Height = 23;
            this.dataGridViewShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewShow.Size = new System.Drawing.Size(893, 387);
            this.dataGridViewShow.TabIndex = 1;
            this.dataGridViewShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewShow_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "号码";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 135;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "name";
            this.Column2.HeaderText = "姓名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 136;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "type";
            this.Column3.HeaderText = "类别";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 136;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "roomID";
            this.Column4.HeaderText = "诊室号码";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 134;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "doctorName";
            this.Column5.HeaderText = "医生姓名";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 135;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "state";
            this.Column6.HeaderText = "会诊状态";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 136;
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.button1);
            this.groupBoxEdit.Controls.Add(this.radioButtonReady);
            this.groupBoxEdit.Controls.Add(this.radioButtonVisiting);
            this.groupBoxEdit.Location = new System.Drawing.Point(5, 472);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(293, 61);
            this.groupBoxEdit.TabIndex = 5;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "设置选中患者就诊状态";
            // 
            // radioButtonVisiting
            // 
            this.radioButtonVisiting.AutoSize = true;
            this.radioButtonVisiting.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonVisiting.Location = new System.Drawing.Point(13, 28);
            this.radioButtonVisiting.Name = "radioButtonVisiting";
            this.radioButtonVisiting.Size = new System.Drawing.Size(67, 18);
            this.radioButtonVisiting.TabIndex = 0;
            this.radioButtonVisiting.TabStop = true;
            this.radioButtonVisiting.Text = "会诊中";
            this.radioButtonVisiting.UseVisualStyleBackColor = true;
            // 
            // radioButtonReady
            // 
            this.radioButtonReady.AutoSize = true;
            this.radioButtonReady.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonReady.Location = new System.Drawing.Point(86, 28);
            this.radioButtonReady.Name = "radioButtonReady";
            this.radioButtonReady.Size = new System.Drawing.Size(81, 18);
            this.radioButtonReady.TabIndex = 1;
            this.radioButtonReady.TabStop = true;
            this.radioButtonReady.Text = "等待会诊";
            this.radioButtonReady.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(173, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "提交更改";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 561);
            this.Controls.Add(this.groupBoxEdit);
            this.Controls.Add(this.groupBoxQueueStatus);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.statusStripTip);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.buttonCall);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.menuStripMain;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "医院挂号模拟程序 ---- 版本：v1.0";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.groupBoxQueueStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).EndInit();
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCall;
        private System.Windows.Forms.StatusStrip statusStripTip;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 使用帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox groupBoxQueueStatus;
        private System.Windows.Forms.DataGridView dataGridViewShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButtonReady;
        private System.Windows.Forms.RadioButton radioButtonVisiting;
    }
}

