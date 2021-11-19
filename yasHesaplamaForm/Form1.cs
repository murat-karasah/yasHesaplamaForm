using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yasHesaplamaForm
{
    public partial class Form1 : Form
    {
        DateTime nowtime = DateTime.Now;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
         int yil = dateTimePicker1.Value.Year;

          int sonuc =nowtime.Year - yil;
           


            int ay = Convert.ToInt32(dateTimePicker1.Value.Month);
            int ayhesap = Convert.ToInt32(nowtime.Month) - ay;
            int son = 12- Convert.ToInt32(nowtime.Month) + ay;

            if (son >=12 )
            {
                son = 1;
            }
            
            label3.Text = "Yaşınız : "+ sonuc.ToString()+",\n"+ son + " ay sonra "+ sonuc+ " yaşınız dolacak \n ve " + (++sonuc) + " yaşında  olacaksınız";


        }
    }
}
