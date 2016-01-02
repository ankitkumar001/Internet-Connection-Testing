using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//
using System.Runtime.InteropServices;

namespace CheckInternetConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("wininet.dll")]
       private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
       bool IsConnectedToInternet()
       {
           bool a;
           int xs;
           a = InternetGetConnectedState(out xs, 0);
           return a;
       }

       private void Form1_Load(object sender, EventArgs e)
       {
           
           
       }

       private void button1_Click(object sender, EventArgs e)
       {
           if (IsConnectedToInternet() == true) { MessageBox.Show("Internet Is Working\r\n You willbe Redirecred To Developer Facebook Page..");
           System.Diagnostics.Process.Start("https://www.facebook.com/UserQuery/");
           }
           if (IsConnectedToInternet() == false) MessageBox.Show("Internet Is Not Working");
       }
    }
}
