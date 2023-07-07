﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_LAB_1_WinForms
{/// <summary>
/// ппп
/// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Properties.Settings setings = Properties.Settings.Default;
            string message = Properties.Resources.ResHello + ", " + setings.Name;
            MessageBox.Show(message);
            label1.Text = message;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings setings = Properties.Settings.Default;
            string message = Properties.Resources.ResGoodbye + ", " + setings.Name;
            label1.Text = message;
            MessageBox.Show(message);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Properties.Settings setings = Properties.Settings.Default;
            string message = Properties.Resources.ResGoodbye + ", " + setings.Name;
            label1.Text = message;
            MessageBox.Show(message);
        }
    }
}