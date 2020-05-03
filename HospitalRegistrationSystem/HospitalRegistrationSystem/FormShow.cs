using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalRegistrationSystem
{
    public partial class FormShow : Form
    {
        enum WeekDay { 星期日, 星期一, 星期二, 星期三, 星期四, 星期五, 星期六 };    //日期显示的文本
        string year = "";                                            //年份
        string month = "";                                        //月份
        string day = "";                                            //日期
        string week = "";                                          //星期
        string hour = "";                                           //时
        string minute = "";                                       //分
        string second = "";                                      //秒
        int imgIndex = 0;                                         //图片切换索引
        int voiceIndex = 0;                                       //语音播报索引
        DataTable PatientDT = new DataTable();      //挂号数据表

        public FormShow()
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
            //显示指定行数
            for (int i = 0; i < 12; i++)
            {
                dataGridViewShow.Rows.Add(PatientDT.Rows[i].ItemArray);
            }
        }

        #endregion

        #region 朗读文本方法

        SpeechSynthesizer speech = new SpeechSynthesizer();
        SoundPlayer play = new SoundPlayer();

        public void spVoice()
        {
            string name = dataGridViewShow.Rows[0].Cells[1].Value.ToString();
            string roomID = dataGridViewShow.Rows[0].Cells[3].Value.ToString();

            //加载资源文件并播放
            speech = new SpeechSynthesizer();
            //设置语速  介于-10于10之间
            speech.Rate = int.Parse("-2");
            speech.SpeakAsync("请、" + name + "、到、" + roomID + "、号门诊室就诊");

            //play = new SoundPlayer(ResourceApp.请 + name + ResourceApp.到 + roomID + ResourceApp.号 + "门诊室就诊");
            //play.Play();

            //请
            play = new SoundPlayer(ResourceApp.请);
            play.Play();
            //姓名
            speech = new SpeechSynthesizer();
            speech.SpeakAsync(name);
            //到
            play = new SoundPlayer(ResourceApp.到);
            play.Play();
            //门诊室号
            speech = new SpeechSynthesizer();
            speech.SpeakAsync(roomID);
            //号
            play = new SoundPlayer(ResourceApp.号);
            play.Play();
            //门诊室就诊
            speech = new SpeechSynthesizer();
            speech.SpeakAsync(ResourceApp.请 + "门诊室就诊");
        }

        /// <summary>
        /// 语音播报事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TimerVoice_Tick(object sender, EventArgs e)
        {
            string name = dataGridViewShow.Rows[0].Cells[1].Value.ToString();
            string roomID = dataGridViewShow.Rows[0].Cells[3].Value.ToString();

            voiceIndex++;
            if (voiceIndex == 1)
            {
                //请
                play = new SoundPlayer(ResourceApp.请);
                play.Play();
            }
            else if (voiceIndex == 2)
            {
                //姓名
                speech = new SpeechSynthesizer();
                speech.SpeakAsync(name);
            }
            else if (voiceIndex == 3)
            {
                //到
                play = new SoundPlayer(ResourceApp.到);
                play.Play();
            }
            else if (voiceIndex == 4)
            {
                //门诊室号
                speech = new SpeechSynthesizer();
                speech.SpeakAsync(roomID);
            }
            else if (voiceIndex == 5)
            {
                //号
                play = new SoundPlayer(ResourceApp.号);
                play.Play();
            }
            else if (voiceIndex == 6)
            {
                //门诊室就诊
                speech = new SpeechSynthesizer();
                speech.SpeakAsync("门诊室就诊");
            }
            else
            {
                //播放完成 结束计时事件
                timerVoice.Enabled = false;
                voiceIndex = 0;
            }
        }

        #endregion

        #region 设置日期时间方法

        /// <summary>
        /// 获取当前日期时间
        /// </summary>
        public void GetThisDateTime()
        {
            year = DateTime.Now.Year.ToString();
            month = DateTime.Now.Month.ToString();
            if (month.Length == 1)
            {
                month = "0" + DateTime.Now.Month.ToString();
            }
            day = DateTime.Now.Day.ToString();
            if (day.Length == 1)
            {
                day = "0" + DateTime.Now.Day.ToString();
            }
            WeekDay wd = (WeekDay)DateTime.Now.DayOfWeek;
            week = wd.ToString();
            hour = DateTime.Now.Hour.ToString();
            if (hour.Length == 1)
            {
                hour = "0" + DateTime.Now.Day.ToString();
            }
            minute = DateTime.Now.Minute.ToString();
            if (minute.Length == 1)
            {
                minute = "0" + DateTime.Now.Day.ToString();
            }
            second = DateTime.Now.Second.ToString();
            if (second.Length == 1)
            {
                second = "0" + DateTime.Now.Day.ToString();
            }
        }

        #endregion

        private void FormShow_Load(object sender, EventArgs e)
        {
            readData(); //读取数据
            //设置当前日期时间并显示
            GetThisDateTime();
            this.labelThisYHD.Text = year + "年" + month + "月" + day + "日";
            this.labelThisWeek.Text = week;
            this.labelThisTime.Text = hour + ":" + minute + ":" + second;
            //默认选中第一行
            this.dataGridViewShow.Rows[0].Selected = true;
        }

        private void TimerImg_Tick(object sender, EventArgs e)
        {
            //判断图片索引是否超出
            if (imgIndex > 3)
            {
                imgIndex = 1;
            }
            else
            {
                imgIndex++;
            }
            //定时切换LOGO图片
            if (imgIndex == 1)
            {
                pictureBoxLogo.Image = ResourceApp.医院1;
            }
            if (imgIndex == 2)
            {
                pictureBoxLogo.Image = ResourceApp.医院2;
            }
            if (imgIndex == 3)
            {
                pictureBoxLogo.Image = ResourceApp.医院3;
            }
        }

        /// <summary>
        /// 获取当前时间并刷新显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerThisTime_Tick(object sender, EventArgs e)
        {
            //设置当前日期时间并显示
            GetThisDateTime();
            this.labelThisYHD.Text = year + "年" + month + "月" + day + "日";
            this.labelThisWeek.Text = week;
            this.labelThisTime.Text = hour + ":" + minute + ":" + second;
        }

        private void DataGridViewShow_MouseClick(object sender, MouseEventArgs e)
        {
            //清除选中状态
            this.dataGridViewShow.ClearSelection();
        }
    }
}
