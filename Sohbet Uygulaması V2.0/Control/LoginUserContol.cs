﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sohbet_Uygulaması_V2._0.Control
{
    public partial class LoginUserContol : UserControl
    {
        public LoginUserContol()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GosterCB1_CheckedChanged(object sender, EventArgs e)
        {
            if(GosterCB1.Checked) 
            {
                SifreTB.PasswordChar = '\0';
            }
            else
            {
                SifreTB.PasswordChar = '?';
            }
        }
    }
}
