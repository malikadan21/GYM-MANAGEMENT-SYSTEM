﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Trainer_Dp : Form
    {
        private int trainerid;
        public Trainer_Dp(int trainerid)
        {
            InitializeComponent();
            this.trainerid = trainerid;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close(); Trainer_Interface trainer_Interface = new Trainer_Interface(trainerid);
            trainer_Interface.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Trainer_Creates_DP a = new Trainer_Creates_DP(trainerid);
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Trainer_Views_DP a = new Trainer_Views_DP(trainerid);
            a.Show();
        }
    }
}
