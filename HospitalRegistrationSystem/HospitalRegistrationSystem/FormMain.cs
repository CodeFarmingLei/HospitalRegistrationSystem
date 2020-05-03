using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalRegistrationSystem
{
    public partial class FormMain : Form
    {
        string state = "";          //就诊状态
        DataTable PatientDT = new DataTable();      //挂号数据表

        public FormMain()
        {
            InitializeComponent();
        }

        #region 加载数据方法

        /// <summary>
        /// 加载数据方法
        /// </summary>
        public void readData()
        {
            DataSet ds = new DataSet();
            ds.ReadXml("RegistrationForm.xml");
            PatientDT = ds.Tables[0];
            this.dataGridViewShow.DataSource = PatientDT;
        }

        #endregion

        private void FormMain_Load(object sender, EventArgs e)
        {
            readData();
            FormShow FormShow = new FormShow();
            FormShow.Show();
        }

        /// <summary>
        /// 叫号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCall_Click(object sender, EventArgs e)
        {
            FormShow FormShow = new FormShow();
            FormShow.TimerVoice_Tick(null, null);
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            FormShow FormShow = new FormShow();
            FormShow.Show();
        }

        /// <summary>
        /// 单击单元格数据事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //设置用户就诊状态
            state = this.dataGridViewShow.SelectedRows[0].Cells[5].Value.ToString();
            if (state == "会诊中")
            {
                this.radioButtonVisiting.Checked = true;
            }
            else if (state == "等待会诊")
            {
                this.radioButtonReady.Checked = true;
            }
        }
    }
}
