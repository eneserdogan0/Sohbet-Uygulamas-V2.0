﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sohbet_Uygulaması_V2._0
{
    public partial class Login : Form
    {
        private string ApiKey;
        private string AuthDomain;
        public Login(string apiKey, string authDomain)
        {
            InitializeComponent();
            this.ApiKey = ApiKey;
            this.AuthDomain = AuthDomain;
        }

        private void GirisYapBtn_Click(object sender, EventArgs e)
        {

        }

        private void DENEME_Click(object sender, EventArgs e)
        {
            MessageBox.Show("denemeeeeeeeeee");
        }
    }
}
