﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIOM_ALYSSAR
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void enrollFingerprintsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Enrolment ee = new Enrolment();
            ee.Show();

        }

        private void attendanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            this.Hide();
            ClockIn clock = new ClockIn();
            clock.Show();

        }

        private void attendanceTimeOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            ClockOut clock = new ClockOut();
            clock.Show();

        }
    }
}
