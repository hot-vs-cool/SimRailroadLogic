﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace testsim
{
    
    public partial class Form3 : Form
    {
        public Form3()
        {
            
            InitializeComponent();
            

        }
        
        public int track;

        public static int trkw = 0;
        int i = 0;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           trkw = 45;
            
            Label sel = new Label();
            sel.Text = "Component added ";
            var selLocX = sel.Location.X;
            var selLocY = sel.Location.Y;
            selLocX = 0;
            selLocY = 0;
            sel.ForeColor = Color.Red;
            this.Controls.Add(sel);
            /* Form4 f4 = new Form4();
            f4.Show();*/


            if (i >= 1)
            {
                this.Controls.Remove(sel);
                sel.Dispose();    // no problem if already disposed
                sel = null;
            }
            i++;    
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            trkw = 135;
            Label sel = new Label();
            sel.Text = "Component added";
            var selLocX = sel.Location.X;
            var selLocY = sel.Location.Y;
            selLocX = 0;
            selLocY = 0;
            sel.ForeColor = Color.Red;
            this.Controls.Add(sel);

            if (i >= 1)
            {
                this.Controls.Remove(sel);
                sel.Dispose();    // no problem if already disposed
                sel = null;
            }
            i++;
            


            //  Form2 f2 = new Form2();
            // f2.Show();

            //  f2.ShowDialog(ref trk);

            //  this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            trkw = 90;

            TextBox sel = new TextBox();
            sel.Text = "Your component has been added to the simulator";
            var selLocX = sel.Location.X;
            var selLocY = sel.Location.Y;
            selLocX = 0;
            selLocY = 0;
            this.Controls.Add(sel);
            if (i >= 1)
            {
                this.Controls.Remove(sel);
                sel.Dispose();    // no problem if already disposed
                sel = null;
            }
            i++;

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    

}