using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UsSntb;
using System.Windows;

namespace sntb2
{


    public partial class Form2 : DevExpress.XtraEditors.XtraForm
    {
        int timeLeft;
        DateTime Time;
        //DateTime seg;
        string fr;
        string strLog;
        //RichTextBox rtb;

        public TimeSpan tt;
        int Tuser = 0;
        int Ttest = 0;
        DateTime startTest;
        FormI[] testNow = new FormI[100];
        int tttt;
        int prOtv;

        public Form2(int u, int u1)
        {
            InitializeComponent();
            Tuser = u;
            Ttest = u1;
            startTest = DateTime.Now;
            panel1.GotFocus += new EventHandler(panel1_Scroll);
            //panel1.GotFocus += new EventHandler(panel1_GotFocus);
        }

        void panel1_Scroll(object sender, EventArgs e)
        {
            //	throw new NotImplementedException();
            panel2.AutoScrollPosition = new Point(panel2.AutoScrollPosition.X, tttt);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Time = DateTime.Now;
            timer1.Start();
            timeLeft = 1;
            textBox1.Text = Pglobals.ptrNameUser;
            textBox3.Text = Pglobals.dolj;
            textBox2.Text = Pglobals.predpr;
            textBox4.Text = Pglobals.Nametest;

            textBox6.Text = DateTime.Now.ToString().Substring(10);
            TimeSpan sp = TimeSpan.FromMinutes(Pglobals.vrtest);
            DateTime pr = DateTime.Now;
            DateTime li = pr + sp;
            textBox7.Text = li.ToString().Substring(10);
            textBox9.Text = Pglobals.vrtest.ToString();
            textBox8.Text = DateTime.Now.ToString().Substring(10);
            this.Text = "Тестирование                                   " + DateTime.Now.ToString().Substring(0, 10);
            this.createTestTableAdapter.Fill(sntbDataSet.CreateTest, Ttest);
            BStest.MoveFirst();
            textBox5.Text = BStest.Count.ToString();
            for (int i = 0; i < BStest.Count; ++i)
            {
                MyWork(i);
                BStest.MoveNext();
            }


        }


        private void MyWork(int nomI)
        {
            int nVopr = (int)((DataRowView)BStest.Current).Row["doc_id"];
            string strVopr = (string)((DataRowView)BStest.Current).Row["number"] + "\n" +
                (string)((DataRowView)BStest.Current).Row["text"];

            testNow[nomI] = new FormI(nVopr, strVopr);
            int i = testNow[nomI].GetMySize();
            panel2.Size = new Size(990, panel2.Size.Height + i + 70);
            testNow[nomI].Location = new Point(0, panel2.Size.Height - i);
            //testNow[nomI].Show();
            panel2.Controls.Add(testNow[nomI]);
            //this.Controls.Add(testNow[nomI]);
        }

        public string FormLog()
        {
            //rtb.Text = strLog + "\n" + "\n";
            //rtb.SelectAll();
            //rtb.SelectionColor = Color.Red;
            prOtv = 0;
            strLog = "";
            strLog = strLog + "\n" + "\n";
            strLog = strLog + "Фамилия И.О.: " + Pglobals.ptrNameUser + "\n";
            strLog = strLog + "Должность: " + Pglobals.dolj + "\n";
            strLog = strLog + "Место работы: " + Pglobals.predpr + "\n";
            strLog = strLog + "Название теста: " + Pglobals.Nametest + "\n";
            strLog = strLog + "Начало тестирования: " + DateTime.Now.ToString().Substring(0, 10) + " " + textBox6.Text + "\n";
            TimeSpan sp = TimeSpan.Parse(fr);
            TimeSpan pr = TimeSpan.Parse(textBox6.Text);
            TimeSpan li = pr + sp;
            strLog = strLog + "Окончание тестирования: " + DateTime.Now.ToString().Substring(0, 10) + " " + li + "\n";
            strLog = strLog + "Тест сдан за: " + fr + "\n";
            strLog = strLog + "Вопросов в тесте: " + textBox5.Text + "\n";
            strLog = strLog + "За один правильно отвеченный вопрос: 1 балл." + "\n";
            strLog = strLog + "За один неправильно отвеченный вопрос: 0 баллов." + "\n";
            int t = panel2.Controls.Count;
            for (int i = 0; i < t; ++i)
            {
                prOtv = prOtv + testNow[i].AmTruth();
            }
            strLog = strLog + "Количество правильных ответов: " + prOtv.ToString() +"\n";
            strLog = strLog + "--------------------------------------------------------------------" + "\n";
            if (prOtv == 1)
            {
                strLog = strLog + "Результат: " + prOtv.ToString() + " балл" + "\n" + "\n" + "\n";
            }
            if (prOtv <= 4 & prOtv != 1)
            {
                strLog = strLog + "Результат: " + prOtv.ToString() + " баллa" + "\n" + "\n" + "\n";
            }
            if (prOtv > 4)
            {
                strLog = strLog + "Результат: " + prOtv.ToString() + " баллов" + "\n" + "\n" + "\n";
            }
            
            //BStest.MoveFirst();


            for (int i = 0; i < t; ++i)
            {
                strLog = strLog + testNow[i].GetMyAnsw();
            }
            strLog = strLog + "\n" + "\n";
            strLog = strLog + "Экзаменатор: " + "_________________________" + "\n" + "\n";
            strLog = strLog + "Дата тестирования: " + DateTime.Now.ToString().Substring(0, 10) + "\n" + "\n";
            strLog = strLog + "Подпись: " + "_________________________" + "\n" + "\n";
            return strLog;
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                int ff;
                ff = Convert.ToInt16(Pglobals.vrtest) * 60;
                if (timeLeft > 0 && timeLeft < ff)
                {
                    // Display the new time left
                    // by updating the Time Left label.
                    //timeLeft = timeLeft - 1;
                    //timeLeft1 = timeLeft1 - 1;
                    tt = DateTime.Now - Time;
                    textBox8.Text = tt.ToString().Substring(0, 8);
                    ++timeLeft;
                }
                else
                {
                    fr = textBox8.Text;
                    string ss = this.FormLog();
                    timer1.Stop();
                    TimeSpan sp = TimeSpan.Parse(fr);
                    TimeSpan pr = TimeSpan.Parse(textBox6.Text);
                    TimeSpan li = pr + sp;
                    this.createProtocolTableAdapter1.Fill(sntbDataSet.CreateProtocol, Pglobals.ptr, Pglobals.ptrNameUser, Pglobals.dolj, Pglobals.predpr, Pglobals.ptr1, Pglobals.Nametest, DateTime.Now.ToString().Substring(0, 10) + " " + textBox6.Text, DateTime.Now.ToString().Substring(0, 10) + " " + li, fr, textBox5.Text, prOtv,
                prOtv.ToString(), strLog);
                    MessageBox.Show("Спасибо! Вы протестировались." + "\n" + "Всего заданий в тесте: " + textBox5.Text + "\n" + "Из них правильно: " + prOtv.ToString() + "\n" + "-----------------------------------------" + "\n" + "Вы набрали:" + prOtv.ToString() + " балла" + "\n" + "\n");
                    this.Close();
                    Application.Exit();

                }

            }

        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
            tttt = e.OldValue;
        }

       

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            fr = textBox8.Text;
            string ss = this.FormLog();
            timer1.Stop();
            TimeSpan sp = TimeSpan.Parse(fr);
            TimeSpan pr = TimeSpan.Parse(textBox6.Text);
            TimeSpan li = pr + sp;
            this.createProtocolTableAdapter1.Fill(sntbDataSet.CreateProtocol, Pglobals.ptr, Pglobals.ptrNameUser, Pglobals.dolj, Pglobals.predpr, Pglobals.ptr1, Pglobals.Nametest, DateTime.Now.ToString().Substring(0, 10) + " " + textBox6.Text, DateTime.Now.ToString().Substring(0, 10) + " " + li, fr, textBox5.Text, prOtv,
        prOtv.ToString(), strLog);
            MessageBox.Show("Спасибо! Вы протестировались." + "\n" + "Всего заданий в тесте: " + textBox5.Text + "\n" + "Из них правильно: " + prOtv.ToString() + "\n" + "-----------------------------------------" + "\n" + "Вы набрали:" + prOtv.ToString() + " балла" + "\n" + "\n");
            this.Close();
            Application.Exit();

        }






    }
}