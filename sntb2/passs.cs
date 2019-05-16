using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sntb2
{
    public partial class passs : DevExpress.XtraEditors.XtraForm
    {
        int isok = 0;
        int Ptr =  0;
        string Pass = "";
        Form1 F1 = null;

        public passs(int ptr, string pass, Form1 f1)
        {
            InitializeComponent();
            F1 = f1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void passs_Load(object sender, EventArgs e)
        {


        }

        public int IsOK()
        {
            if (isok == 1)
            {
                F1.simpleButton1.Enabled = true;
                F1.Refresh();
                return 1;
            }
            else
                return 0;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton1_Click(null, null);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string Pass = Pglobals.pass;
            if ((Pass.Trim() == textBox1.Text.Trim()))
            {
                isok = 1;
                F1.simpleButton1.Visible = true;
                F1.Refresh();
                this.Close();
            }
            else
                MessageBox.Show("Вы ввели неправильный пароль, проверьте и введите заново!");
        }
    }
}
