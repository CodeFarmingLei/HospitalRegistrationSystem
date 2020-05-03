namespace HospitalRegistrationSystem
{
    partial class FormShow
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShow));
            this.dataGridViewShow = new System.Windows.Forms.DataGridView();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTipTile = new System.Windows.Forms.Label();
            this.labelTip = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.timerImg = new System.Windows.Forms.Timer(this.components);
            this.timerVoice = new System.Windows.Forms.Timer(this.components);
            this.labelThisYHD = new System.Windows.Forms.Label();
            this.labelThisWeek = new System.Windows.Forms.Label();
            this.labelThisTime = new System.Windows.Forms.Label();
            this.timerThisTime = new System.Windows.Forms.Timer(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShow
            // 
            this.dataGridViewShow.AllowUserToAddRows = false;
            this.dataGridViewShow.AllowUserToResizeColumns = false;
            this.dataGridViewShow.AllowUserToResizeRows = false;
            this.dataGridViewShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShow.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewShow.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dataGridViewShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewShow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewShow.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewShow.ColumnHeadersHeight = 40;
            this.dataGridViewShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewShow.EnableHeadersVisualStyles = false;
            this.dataGridViewShow.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewShow.Location = new System.Drawing.Point(315, 55);
            this.dataGridViewShow.MultiSelect = false;
            this.dataGridViewShow.Name = "dataGridViewShow";
            this.dataGridViewShow.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShow.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewShow.RowHeadersVisible = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShow.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewShow.RowTemplate.Height = 23;
            this.dataGridViewShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewShow.Size = new System.Drawing.Size(865, 546);
            this.dataGridViewShow.TabIndex = 0;
            this.dataGridViewShow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridViewShow_MouseClick);
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.ForeColor = System.Drawing.Color.Yellow;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1184, 52);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "第一市中心医院 ------ 外科门诊";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTipTile
            // 
            this.labelTipTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTipTile.BackColor = System.Drawing.Color.Transparent;
            this.labelTipTile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTipTile.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTipTile.ForeColor = System.Drawing.Color.Yellow;
            this.labelTipTile.Location = new System.Drawing.Point(4, 328);
            this.labelTipTile.Name = "labelTipTile";
            this.labelTipTile.Size = new System.Drawing.Size(305, 48);
            this.labelTipTile.TabIndex = 2;
            this.labelTipTile.Text = "---- 温馨提示 ----";
            this.labelTipTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTip
            // 
            this.labelTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTip.BackColor = System.Drawing.Color.Transparent;
            this.labelTip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTip.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTip.ForeColor = System.Drawing.Color.Yellow;
            this.labelTip.Location = new System.Drawing.Point(4, 376);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(305, 225);
            this.labelTip.TabIndex = 3;
            this.labelTip.Text = "各位患者，请按照右边列表显示的挂号信息到对应的诊室医生处就诊。\r\n\r\n为了节省您的等待时间并尽快进行会诊，请多留意您的会诊状态。";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(4, 55);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(305, 270);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            // 
            // timerImg
            // 
            this.timerImg.Enabled = true;
            this.timerImg.Interval = 5000;
            this.timerImg.Tick += new System.EventHandler(this.TimerImg_Tick);
            // 
            // timerVoice
            // 
            this.timerVoice.Interval = 1000;
            this.timerVoice.Tick += new System.EventHandler(this.TimerVoice_Tick);
            // 
            // labelThisYHD
            // 
            this.labelThisYHD.BackColor = System.Drawing.Color.MidnightBlue;
            this.labelThisYHD.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelThisYHD.ForeColor = System.Drawing.Color.White;
            this.labelThisYHD.Location = new System.Drawing.Point(1036, 0);
            this.labelThisYHD.Name = "labelThisYHD";
            this.labelThisYHD.Size = new System.Drawing.Size(136, 27);
            this.labelThisYHD.TabIndex = 5;
            this.labelThisYHD.Text = "2020年01月01日";
            this.labelThisYHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelThisWeek
            // 
            this.labelThisWeek.BackColor = System.Drawing.Color.MidnightBlue;
            this.labelThisWeek.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelThisWeek.ForeColor = System.Drawing.Color.White;
            this.labelThisWeek.Location = new System.Drawing.Point(1036, 25);
            this.labelThisWeek.Name = "labelThisWeek";
            this.labelThisWeek.Size = new System.Drawing.Size(62, 27);
            this.labelThisWeek.TabIndex = 6;
            this.labelThisWeek.Text = "星期一";
            this.labelThisWeek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelThisTime
            // 
            this.labelThisTime.BackColor = System.Drawing.Color.MidnightBlue;
            this.labelThisTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelThisTime.ForeColor = System.Drawing.Color.White;
            this.labelThisTime.Location = new System.Drawing.Point(1096, 25);
            this.labelThisTime.Name = "labelThisTime";
            this.labelThisTime.Size = new System.Drawing.Size(72, 27);
            this.labelThisTime.TabIndex = 7;
            this.labelThisTime.Text = "00:00:00";
            this.labelThisTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerThisTime
            // 
            this.timerThisTime.Enabled = true;
            this.timerThisTime.Interval = 1000;
            this.timerThisTime.Tick += new System.EventHandler(this.TimerThisTime_Tick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "号码";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "name";
            this.Column2.HeaderText = "姓名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "type";
            this.Column3.HeaderText = "类别";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "roomID";
            this.Column4.HeaderText = "诊室号码";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "doctorName";
            this.Column5.HeaderText = "医生姓名";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "state";
            this.Column6.HeaderText = "会诊状态";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // FormShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1184, 613);
            this.Controls.Add(this.labelThisTime);
            this.Controls.Add(this.labelThisWeek);
            this.Controls.Add(this.labelThisYHD);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.labelTipTile);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.dataGridViewShow);
            this.MaximizeBox = false;
            this.Name = "FormShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "模拟医院大厅公屏显示界面 Demo";
            this.Load += new System.EventHandler(this.FormShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShow;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTipTile;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Timer timerImg;
        private System.Windows.Forms.Timer timerVoice;
        private System.Windows.Forms.Label labelThisYHD;
        private System.Windows.Forms.Label labelThisWeek;
        private System.Windows.Forms.Label labelThisTime;
        private System.Windows.Forms.Timer timerThisTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}