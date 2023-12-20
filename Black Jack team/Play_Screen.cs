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

        private void Play_Screen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Bet_Button_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {

        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            if (start_Button.Visible == false)
            {
                //ボタン表示
                //start_Button.Visible = true;
                //Hit_Button.Visible = false;
                //Stand_Button.Visible = false;
                //Double_Button.Visible = false;
            }
            else
            {
                //ボタン非表示
                start_Button.Visible = false;
                Reset_Button.Visible = false;
                Bet_display.Visible = false;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                Hit_Button.Visible = true;
                Stand_Button.Visible = true;
                Double_Button.Visible = true;
            }

        }





        private void Bet_display_Click(object sender, EventArgs e)
        {

        }

        // 選択された掛け金
        private int betAmount = 0;


        // 100円のボタンがクリックされたときの処理
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SetBetAmount(betAmount + 100);
        }

        // 500円のボタンがクリックされたときの処理
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SetBetAmount(betAmount + 500);
        }

        // 1000円のボタンがクリックされたときの処理
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SetBetAmount(betAmount + 1000);
        }

        // 掛け金を設定するメソッド
        private void SetBetAmount(int amount)
        {
            betAmount = amount;
            UpdateBetDisplay();
        }

        // Bet_displayを更新するメソッド
        private void UpdateBetDisplay()
        {
            Bet_display.Text = $"Bet:$ {betAmount}";
        }

        private void Bet_label_Click(object sender, EventArgs e)
        {

        }



        private void Hit_Button_Click(object sender, EventArgs e)
        {

        }

        private void Hit_Button_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Stand_Button_Click(object sender, EventArgs e)
        {
            ;
        }
    }








}


