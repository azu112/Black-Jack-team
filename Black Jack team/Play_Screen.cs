using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;


namespace Black_Jack_team
{
    public partial class Play_Screen : Form
    {
        public Play_Screen()
        {
            InitializeComponent();
        }

        private void Bet_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cash_TextChanged(object sender, EventArgs e)
        {

        }

        private void Deal_screen_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Visible == false)
            {

            }
            else
            {
                //ボタン非表示
                Deal_Button.Visible = false;
                Bet_Button.Visible = false;
            }

            //Dealボタンが押された場合、表示する
            Hit_Button.Visible = true;
            Stand_Button.Visible = true;
            Double_Button.Visible = true;
            if (btn.Text == "Deal")
            {
                //Dealボタンに反応
            }
            else
            {
                //Betボタンに反応
            }
        }

        private void Play_Screen_Load(object sender, EventArgs e)
        {

            pictureBox1.Parent = pictureBox2;
            pictureBox3.Parent = pictureBox2;
            pictureBox4.Parent = pictureBox2;
        }

        private void end_Click(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;

            //Top_Screenを表示
            Top_Screen top = new Top_Screen();
            top.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Hit_Button_Click(object sender, EventArgs e)
        {

        }

        private void Play_Screen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Bet_Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Visible == false)
            {

            }
            else
            {
                //ボタン非表示
                Deal_Button.Visible = false;
                Bet_Button.Visible = false;
            }

            //Dealボタンが押された場合、表示する
            Bet_display.Visible = true;
            Reset_Button.Visible = true;
            Confirm_Button.Visible = true;
            pictureBox1.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            if (btn.Text == "Bet")
            {
                //Dealボタンに反応
            }
            else
            {
                //Betボタンに反応
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {

        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pictureBox2.Parent = pictureBox1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox2.Parent = pictureBox3;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox2.Parent = pictureBox4;
        }
    }
}
