using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morpion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_j1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Nul_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnValider_Click_1(object sender, EventArgs e)
        {
            this.lblj1.Text = this.txtj1.Text;
            this.lblj2.Text = this.txtj2.Text;
            this.lblj1.Visible = true;
            this.lblj2.Visible = true;
            this.lbl_cptj1.Visible = true;
            this.lbl_cptj2.Visible = true;
            this.c1.Visible = true;
            this.c2.Visible = true;
            this.c3.Visible = true;
            this.c4.Visible = true;
            this.c5.Visible = true;
            this.c6.Visible = true;
            this.c7.Visible = true;
            this.c8.Visible = true;
            this.c9.Visible = true;
            this.btn_re.Visible = true;
            this.lbl_cptNul.Visible = false;
            this.lbl_Nul.Visible = false;
            this.lbl_j1.Visible = false;
            this.lbl_j2.Visible = false;
            this.txtj1.Visible = false;
            this.txtj2.Visible = false;
            this.btnValider.Visible = false;
            this.t1.Visible = true;


        }
        private void c1_Click_1(object sender, EventArgs e)
        {
            if (this.t1.Visible == true)
            {
                c1.Text = "X";
                c1.Enabled = false;
                t2.Visible = true;
                t1.Visible = false;
            }
            else
            {
                c1.Text = "O";
                c1.Enabled = false;
                t1.Visible = true;
                t2.Visible = false;
            }
            if (c1.Text == "X" && c2.Text == "X" && c3.Text == "X")
            {
                this.gagnant.Text = "j1 est gagnant";
                this.gagnant.Visible = true;
            }
            if (c1.Text == "X" && c5.Text == "X" && c9.Text == "X")
            {
                this.gagnant.Text = "j1 est gagnant";
                this.gagnant.Visible = true;
            }
            if (c1.Text == "X" && c4.Text == "X" && c7.Text == "X")
            {
                this.gagnant.Text = "j1 est gagnant";
                this.gagnant.Visible = true;
            }
        }
        private void c2_Click_1(object sender, EventArgs e)
        {
            if (this.t1.Visible == true)
            {
                c2.Text = "X";
                c2.Enabled = false;
                t1.Visible = false;
                t2.Visible = true;
            }
            else
            {
                c2.Text = "O";
                c2.Enabled = false;
                t2.Visible = false;
                t1.Visible = true;
            }
            if (c2.Text == "X" && c5.Text == "X" && c8.Text == "X")
            {
                this.gagnant.Text = "j1 est gagnant";
                this.gagnant.Visible = true;
            }
            if (c2.Text == "X" && c1.Text == "X" && c3.Text == "X")
            {
                this.gagnant.Text = "j1 est gagnant";
                this.gagnant.Visible = true;
            }
        }

        private void c3_Click_1(object sender, EventArgs e)
        {
            if (this.t1.Visible == true)
            {
                c3.Text = "X";
                c3.Enabled = false;
                t1.Visible = false;
                t2.Visible = true;
            }
            else
            {
                c3.Text = "O";
                c3.Enabled = false;
                t2.Visible = false;
                t1.Visible = true;
            }
            if (c3.Text == "X" && c2.Text == "X" && c1.Text == "X")
            {
                this.gagnant.Text = "j1 est gagnant";
                this.gagnant.Visible = true;
            }

            if (c3.Text == "X" && c6.Text == "X" && c9.Text == "X")
            {
                this.gagnant.Text = "j1 est gagnant";
                this.gagnant.Visible = true;
            }

            if (c3.Text == "X" && c5.Text == "X" && c7.Text == "X")
            {
                this.gagnant.Text = "j1 est gagnant";
                this.gagnant.Visible = true;
            }

        }
        private void c4_Click_1(object sender, EventArgs e)
        {
            if (this.t1.Visible == true)
            {
                c4.Text = "X";
                c4.Enabled = false;
                t1.Visible = false;
                t2.Visible = true;
            }
            else
            {
                c4.Text = "O";
                c4.Enabled = false;
                t2.Visible = false;
                t1.Visible = true;
            }

            if (c4.Text == "X" && c6.Text == "X" && c5.Text == "X")
            {
                this.gagnant.Text = "j1 est gagnant";
                this.gagnant.Visible = true;
            }

            if (c4.Text == "X" && c1.Text == "X" && c7.Text == "X")
            {
                this.gagnant.Text = "j1 est gagnant";
                this.gagnant.Visible = true;
            }

        }
        private void c5_Click_1(object sender, EventArgs e)
        {
            if (this.t1.Visible == true)
            {
                c5.Text = "X";
                c5.Enabled = false;
                t1.Visible = false;
                t2.Visible = true;
            }
            else
            {
                c5.Text = "O";
                c5.Enabled = false;
                t2.Visible = false;
                t1.Visible = true;
            }

            if (c5.Text == "X" && c6.Text == "X" && c4.Text == "X")
            {
                this.gagnant.Text = "j1 est gagnant";
                this.gagnant.Visible = true;
            }

            if (c5.Text == "X" && c2.Text == "X" && c6.Text == "X")
            {
                this.gagnant.Text = "j1 est gagnant";
                this.gagnant.Visible = true;
            }

            if (c5.Text == "X" && c9.Text == "X" && c1.Text == "X")
            {
                this.gagnant.Text = "j1 est gagnant";
                this.gagnant.Visible = true;
            }

            if (c5.Text == "X" && c7.Text == "X" && c3.Text == "X")
            {
                this.gagnant.Text = "j1 est gagnant";
                this.gagnant.Visible = true;
            }
        }
        private void c6_Click_1(object sender, EventArgs e)
        {
            if (this.t1.Visible == true)
            {
                c6.Text = "X";
                c6.Enabled = false;
                t1.Visible = false;
                t2.Visible = true;
            }
            else
            {
                c6.Text = "O";
                c6.Enabled = false;
                t2.Visible = false;
                t1.Visible = true;
            }
            if (c6.Text == "X" && c4.Text == "X" && c5.Text == "X")
            {
                this.gagnant.Text = "j1 est gagnant";
                this.gagnant.Visible = true;
            }
            if (c6.Text == "X" && c3.Text == "X" && c9.Text == "X")
            {
                this.gagnant.Text = "j1 est gagnant";
                this.gagnant.Visible = true;
            }
        }
        private void c7_Click_1(object sender, EventArgs e)
        {
            if (this.t1.Visible == true)
            {
                c7.Text = "X";
                c7.Enabled = false;
                t1.Visible = false;
                t2.Visible = true;
            }
            else
            {
                c7.Text = "O";
                c7.Enabled = false;
                t2.Visible = false;
                t1.Visible = true;
            }

            if (c7.Text == "X" && c4.Text == "X" && c1.Text == "X")
            {
                this.gagnant.Text = "j1 est gagnant";
                this.gagnant.Visible = true;
            }
            if (c7.Text == "X" && c6.Text == "X" && c9.Text == "X")
            {
                this.gagnant.Text = "j1 est gagnant";
                this.gagnant.Visible = true;
            }
            if (c7.Text == "X" && c5.Text == "X" && c3.Text == "X")
            {
                this.gagnant.Text = "j1 est gagnant";
                this.gagnant.Visible = true;
            }

            if (c7.Text == "O" && c4.Text == "O" && c1.Text == "O")
            {
                this.gagnant.Text = "j1 est gagnant";
                this.gagnant.Visible = true;
            }
            if (c7.Text == "O" && c6.Text == "O" && c9.Text == "O")
            {
                this.gagnant.Text = "j1 est gagnant";
                this.gagnant.Visible = true;
            }
            if (c7.Text == "O" && c5.Text == "O" && c3.Text == "O")
            {
                this.gagnant.Text = "j1 est gagnant";
                this.gagnant.Visible = true;
            }
        }
        private void c8_Click_1(object sender, EventArgs e)
        {
            if (this.t1.Visible == true)
            {
                c8.Text = "X";
                c8.Enabled = false;
                t1.Visible = false;
                t2.Visible = true;
            }
            else
            {
                c8.Text = "O";
                c8.Enabled = false;
                t2.Visible = false;
                t1.Visible = true;
            }
            if (c8.Text == "X" && c7.Text == "X" && c9.Text == "X")
            {
                this.gagnant.Text = "j1 est gagnant";
                this.gagnant.Visible = true;
            }
            if (c8.Text == "X" && c5.Text == "X" && c3.Text == "X")
            {
                this.gagnant.Text = "j1 est gagnant";
                this.gagnant.Visible = true;
            }

            if (c8.Text == "O" && c7.Text == "O" && c9.Text == "O")
            {
                this.gagnant.Text = "j1 est gagnant";
                this.gagnant.Visible = true;
            }
            if (c8.Text == "O" && c5.Text == "O" && c3.Text == "O")
            {
                this.gagnant.Text = "j1 est gagnant";
            }

            }
            private void c9_Click_1(object sender, EventArgs e)
        {
            if (this.t1.Visible == true)
            {
                c9.Text = "X";
                c9.Enabled = false;
                t1.Visible = false;
                t2.Visible = true;
            }
            else
            {
                c9.Text = "O";
                c9.Enabled = false;
                t2.Visible = false;
                t1.Visible = true;
            }

            if (c9.Text == "X" && c5.Text == "X" && c1.Text == "X")
            {
                this.gagnant.Text = "j1 est gagnant";
                this.gagnant.Visible = true;
            }

            if (c9.Text == "X" && c6.Text == "X" && c3.Text == "X")
            {
                this.gagnant.Text = "j1 est gagnant";
                this.gagnant.Visible = true;
            }
            if (c9.Text == "O" && c5.Text == "O" && c1.Text == "O")
            {
                this.gagnant.Text = "j1 est gagnant";
                this.gagnant.Visible = true;
            }

            if (c9.Text == "O" && c6.Text == "O" && c3.Text == "O")
            {
                this.gagnant.Text = "j1 est gagnant";
                this.gagnant.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void gagnant_text(object sender, EventArgs e)
        {
            if ( this.c1.Text == "X") 
            {
                this.gagnant.Visible = true;
                this.gagnant.Text = "j1 est gagnant";
            }
        }
    }
}
