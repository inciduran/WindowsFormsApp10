﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanıcıadım = textBox1.Text;
            string şifre = textBox2.Text;
            if (kullanıcıadım == "ali")
                if (şifre == "123")
                    label3.Text = "giriş başarılı";
                else
                    label3.Text = "şifre hatalı";
            else
                label3.Text = "kullanıcı adı hatalı";
            

           
           
        }
    }
}
