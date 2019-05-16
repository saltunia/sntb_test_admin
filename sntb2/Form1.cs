using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UsSntb;

namespace sntb2
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        int lastRowSelected;
        
        passs ps; // = new passs(Pglobals.ptr, Pglobals.pass, throw);
        public Form1()
        {
           
            InitializeComponent();
            
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            simpleButton1.Visible = false;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.protokol". При необходимости она может быть перемещена или удалена.
           // this.protokolTableAdapter.Fill(this.sntbDataSet.protokol);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.NewTest". При необходимости она может быть перемещена или удалена.
            this.newTestTableAdapter.Fill(this.sntbDataSet.NewTest);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.View_1". При необходимости она может быть перемещена или удалена.
            this.view_1TableAdapter.Fill(this.sntbDataSet.View_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.users". При необходимости она может быть перемещена или удалена.
            //this.usersTableAdapter.Fill(this.sntbDataSet.users);
          //// 
           // Pglobals.ptr2 = (int)((DataRowView)protokolBindingSource.Current).Row["user_id"];
            lastRowSelected = -1;
          
            Pglobals.ptr = (int)((DataRowView)view1BindingSource.Current).Row["user_id"];
            Pglobals.ptr1 = (int)((DataRowView)view1BindingSource.Current).Row["id"];
            Pglobals.dolj = (string)((DataRowView)view1BindingSource.Current).Row["doljn_name"];
            Pglobals.predpr = (string)((DataRowView)view1BindingSource.Current).Row["predpr_name"];
            Pglobals.vrtest = (Int16)((DataRowView)view1BindingSource.Current).Row["test_time"];
            Pglobals.Nametest = (string)((DataRowView)view1BindingSource.Current).Row["Expr1"];
            Pglobals.pass = (string)((DataRowView)view1BindingSource.Current).Row["pass"]; 
            DateTime str;
            if (((DataRowView)view1BindingSource.Current).Row["user_reg_date"]== null)
            {
                str = DateTime.Now;
            }
            else
            {
                str = (DateTime)((DataRowView)view1BindingSource.Current).Row["user_reg_date"];
            }
            DateTime tt;
            tt = DateTime.Today;
          string sss = tt.ToString().Substring(0,10);
            //sss = sss.Replace(".", "-");
          this.view1BindingSource.Filter = "user_reg_date = '" + tt.ToString() + "'";
        }
        



      

        

  

       
        private void view1BindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (view1BindingSource == null)
                {
                    return;
                }
                Pglobals.ptr = (int)((DataRowView)view1BindingSource.Current).Row["user_id"];
                Pglobals.ptr1 = (int)((DataRowView)view1BindingSource.Current).Row["id"];

            }
            catch (Exception) { }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Pglobals.ptr = (int)((DataRowView)view1BindingSource.Current).Row["user_id"];
            //Pglobals.ptr1 = (int)((DataRowView)view1BindingSource.Current).Row["id"];
            Pglobals.pass = (string)((DataRowView)view1BindingSource.Current).Row["pass"];
            passs ps = new passs(Pglobals.ptr, Pglobals.pass, this);
            ps.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (Pglobals.ptr == 0 || Pglobals.ptr1 == 0)
            {
                MessageBox.Show("Не выбраны параметры");
                return;
            }
            if ((int)queriesTableAdapter1.forlockprogr(Pglobals.ptr) > 0)
            {
                MessageBox.Show("Вы уже протестировались, если хотите заново протестироваться пройдите регистрацию");
                Application.Exit();
            }




            //if (ps.IsOK() == 1)
            //{
            MessageBox.Show("Приступаете к выполнению теста " + "\n" + "Желаем ответить на все вопросы правильно.");
            Form2 kama = new Form2(Pglobals.ptr, Pglobals.ptr1);
            Pglobals.ptrNameUser = (string)((DataRowView)view1BindingSource.Current).Row["name"];
            Pglobals.ptr = (int)((DataRowView)view1BindingSource.Current).Row["user_id"];
            Pglobals.ptr1 = (int)((DataRowView)view1BindingSource.Current).Row["id"];
            Pglobals.dolj = (string)((DataRowView)view1BindingSource.Current).Row["doljn_name"];
            Pglobals.predpr = (string)((DataRowView)view1BindingSource.Current).Row["predpr_name"];
            Pglobals.vrtest = (Int16)((DataRowView)view1BindingSource.Current).Row["test_time"];
            Pglobals.Nametest = (string)((DataRowView)view1BindingSource.Current).Row["Expr1"];
            Pglobals.pass = (string)((DataRowView)view1BindingSource.Current).Row["pass"];
            kama.Show();
        }
    }
}
