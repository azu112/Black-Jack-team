using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;


namespace Black_Jack_team
{
    public partial class Play_Screen : Form
    {
        Game_processing_class game = new Game_processing_class();
        PictureBox[] deelCards = new PictureBox[11];
        PictureBox[] myCards = new PictureBox[11];


        public Play_Screen()
        {
            InitializeComponent();
            deelCards[0] = deelCard1;
            deelCards[1]= deelCard2;
            deelCards[2]= deelCard3;
            deelCards[3]= deelCard4;
            deelCards[4]= deelCard5;
            deelCards[5]= deelCard6;
            deelCards[6]= deelCard7;
            deelCards[7]= deelCard8;
            deelCards[8]= deelCard9;
            deelCards[9]= deelCard10;
            deelCards[10]= deelCard11;

            myCards[0]= myCard1;
            myCards[1]= myCard2;
            myCards[2]= myCard3;
            myCards[3]= myCard4;
            myCards[4]= myCard5;
            myCards[5]= myCard6;
            myCards[6]= myCard7;
            myCards[7]= myCard8;
            myCards[8]= myCard9;
            myCards[9]= myCard10;
            myCards[10]= myCard11;

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
            SetBetAmount(0);
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
                deelCard1.Visible = true;
                myCard1.Visible = true;
            }
            game.BetDecision();
            ChangeCard(myCard1, game.myhiitano);
            ChangeCard(deelCard1, game.deelhiitano[0]);

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
            Bet_display.Text = $"Bet: ${betAmount}";
            Bet_label.Text = $"Bet: ${betAmount}";
        }



        private void Hit_Button_Click(object sender, EventArgs e)
        {
            game.HitDecision();

            ChangeCard(deelCard1, game.myhiitano);

        }



        private void ChangeCard(PictureBox picture, string str)
        {
            switch (str)
            {
                case "C_1":
                    picture.Image = Properties.Resources.C_1;

                    break;
                case "C_2":
                    picture.Image = Properties.Resources.C_2;

                    break;
                case "C_3":
                    picture.Image = Properties.Resources.C_3;

                    break;
                case "C_4":
                    picture.Image = Properties.Resources.C_4;

                    break;
                case "C_5":
                    picture.Image = Properties.Resources.C_5;

                    break;
                case "C_6":
                    picture.Image = Properties.Resources.C_6;

                    break;
                case "C_7":
                    picture.Image = Properties.Resources.C_7;

                    break;
                case "C_8":
                    picture.Image = Properties.Resources.C_8;

                    break;
                case "C_9":
                    picture.Image = Properties.Resources.C_9;

                    break;
                case "C_10":
                    picture.Image = Properties.Resources.C_10;

                    break;
                case "C_11":
                    picture.Image = Properties.Resources.C_11;

                    break;
                case "C_12":
                    picture.Image = Properties.Resources.C_12;

                    break;
                case "C_13":
                    picture.Image = Properties.Resources.C_13;

                    break;
                case "D_1":
                    picture.Image = Properties.Resources.D_1;

                    break;
                case "D_2":
                    picture.Image = Properties.Resources.D_2;

                    break;
                case "D_3":
                    picture.Image = Properties.Resources.D_3;

                    break;
                case "D_4":
                    picture.Image = Properties.Resources.D_4;

                    break;
                case "D_5":
                    picture.Image = Properties.Resources.D_5;

                    break;
                case "D_6":
                    picture.Image = Properties.Resources.D_6;

                    break;
                case "D_7":
                    picture.Image = Properties.Resources.D_7;

                    break;
                case "D_8":
                    picture.Image = Properties.Resources.D_8;

                    break;
                case "D_9":
                    picture.Image = Properties.Resources.D_9;

                    break;
                case "D_10":
                    picture.Image = Properties.Resources.D_10;

                    break;
                case "D_11":
                    picture.Image = Properties.Resources.D_11;

                    break;
                case "D_12":
                    picture.Image = Properties.Resources.D_12;

                    break;
                case "D_13":
                    picture.Image = Properties.Resources.D_13;

                    break;
                case "H_1":
                    picture.Image = Properties.Resources.H_1;

                    break;
                case "H_2":
                    picture.Image = Properties.Resources.H_2;

                    break;
                case "H_3":
                    picture.Image = Properties.Resources.H_3;

                    break;
                case "H_4":
                    picture.Image = Properties.Resources.H_4;

                    break;
                case "H_5":
                    picture.Image = Properties.Resources.H_5;

                    break;
                case "H_6":
                    picture.Image = Properties.Resources.H_6;

                    break;
                case "H_7":
                    picture.Image = Properties.Resources.H_7;

                    break;
                case "H_8":
                    picture.Image = Properties.Resources.H_8;

                    break;
                case "H_9":
                    picture.Image = Properties.Resources.H_9;

                    break;
                case "H_10":
                    picture.Image = Properties.Resources.H_10;

                    break;
                case "H_11":
                    picture.Image = Properties.Resources.H_11;

                    break;
                case "H_12":
                    picture.Image = Properties.Resources.H_12;

                    break;
                case "H_13":
                    picture.Image = Properties.Resources.H_13;

                    break;
                case "S_1":
                    picture.Image = Properties.Resources.S_1;

                    break;
                case "S_2":
                    picture.Image = Properties.Resources.S_2;

                    break;
                case "S_3":
                    picture.Image = Properties.Resources.S_3;

                    break;
                case "S_4":
                    picture.Image = Properties.Resources.S_4;

                    break;
                case "S_5":
                    picture.Image = Properties.Resources.S_5;

                    break;
                case "S_6":
                    picture.Image = Properties.Resources.S_6;

                    break;
                case "S_7":
                    picture.Image = Properties.Resources.S_7;

                    break;
                case "S_8":
                    picture.Image = Properties.Resources.S_8;

                    break;
                case "S_9":
                    picture.Image = Properties.Resources.S_9;

                    break;
                case "S_10":
                    picture.Image = Properties.Resources.S_10;

                    break;
                case "S_11":
                    picture.Image = Properties.Resources.S_11;

                    break;
                case "S_12":
                    picture.Image = Properties.Resources.S_12;

                    break;
                case "S_13":
                    picture.Image = Properties.Resources.S_13;

                    break;
                default:
                    MessageBox.Show("Card表示でエラーが起きました");
                    break;


            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeCard(deelCard1, "H_13");
        }

        private void Stand_Button_Click(object sender, EventArgs e)
        {
            //game.StandDecision(betAmount, 20,18);
            game.deelhiitano[1] = "H_7";
            for(int i = 1;i<game.deelhiitano.Length;i++)
            {
                if (game.deelhiitano[i] != null)
                {
                    deelCards[i].Visible = true;
                    ChangeCard(deelCards[i], game.deelhiitano[i]);
                }
                
            }
            
        }

        private void Double_Button_Click(object sender, EventArgs e)
        {
            game.DoubleDecision(betAmount,15,13);

            ChangeCard(deelCard1, game.myhiitano);
        }

        //private void motoTest_Click(object sender, EventArgs e)
        //{
        //    game.BetDecision(2500);
        //    game.DoubleDecision(1000);
        //}
    }








}


