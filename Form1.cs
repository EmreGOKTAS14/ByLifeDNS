﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace network_dns
{
    public partial class DNS : Form
    {
        public DNS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tr = textBox1.Text;
            IPHostEntry hostadi = Dns.GetHostByName(tr);
            listBox1.Items.Add(hostadi.HostName);

            IPAddress[] numbers = hostadi.AddressList;
            for (int i = 0; i < numbers.Length; i++)
            {
                listBox1.Items.Add(numbers[i]);
            }
                       

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string mycomputer = Dns.GetHostName();
            label2.Text = "Bilgisayar Adım: " + mycomputer;

            IPAddress ip = Dns.GetHostByName(mycomputer).AddressList[0];
            label3.Text = "IP Adresim: " + ip.ToString();

            label4.Text = "ByLife";
        }
    }
}
