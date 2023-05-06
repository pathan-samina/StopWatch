﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace My_Stop_Watch
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stopwatch.Start();        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = string.Format("{0:hh\\:mm\\:ss\\.ff}", stopwatch.Elapsed);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
        }
    }
}
