using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompetencePlus
{
    public partial class UserControltime : UserControl
    {
        public UserControltime()
        {
            InitializeComponent();
        }
        private string hour;

        public string Hour
        {
            get {
                return hour;
            }
            set {
                textBox1.Text = value + "";
            }
        }
        private string min;

        public string Min
        {
            get
            {
                return min;
            }
            set
            {
                textBox2.Text = value + "";
            }
           
        }
        private string hm;

        public string Hm
        {
            get
            {

                return textBox1.Text + ':' + textBox2.Text;

            }
            set
            {
                value  = textBox1.Text + ':' + textBox2.Text;
            }

        }
      

        public void sethour(string hour,string min,string hm)
        {
            this.hour = hour;
            this.min = min;
            this.hm = hm;
        }




        private void UserControltime_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
