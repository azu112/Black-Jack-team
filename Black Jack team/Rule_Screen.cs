using System;
using System.Drawing;
using System.Windows.Forms;

namespace Black_Jack_team
{
    public partial class Rule_Screen : Form
    {
        int page = 1;

        public Rule_Screen()
        {
            InitializeComponent();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            ///次画面を非表示
            this.Visible = false;

            //Top_Screenを表示
            Top_Screen top = new Top_Screen();
            top.Show();
        }

        private void Rule_Screen_Load(object sender, EventArgs e)
        {
            
        }

        private void Rule_Screen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch(page)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources._2;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources._3;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources._4;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources._5;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources._6;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources._1;
                    break;

            }

            if(page < 6)
            {
                page++;
            }
            else
            {
                page = 1;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            switch (page)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources._6;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources._1;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources._2;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources._3;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources._4;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources._5;
                    break;

            }

            if (page > 1)
            {
                page--;
            }
            else
            {
                page = 6;
            }
        }

    }
}
