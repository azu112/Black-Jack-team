using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Black_Jack_team
{
    internal class Game_processing_class
    {
        public Chip_Variation_Class chip = new Chip_Variation_Class();
        public Deck_card_class Card = new Deck_card_class();
        int mydata, deeldata,Akakuni;
        public string mydraw = "";
        public string[] deeldraw = new string[11];
        private int Acunt = 0;

        //betを押したら行われるメソッド　
        public  void BetDecision(int meny)
        {
            //所持金を減らす
            chip.DecreaseInPossessions(meny);
            //自分が1枚引く
            mydraw = Card.IllGiveYouOneInMyHand();

            mydata = GetCardNum(mydraw);
            //ディーラーも引く
            deeldraw[0] = Card.IllGiveYouOneInMyHand();
            deeldata = GetCardNum(deeldraw[0]);

            //MessageBox.Show(mydraw + "\n" + mydata + "\n" + chip.meny + "\n" + deeldata + "\n" + deeldraw + "\n" +"-------------");
        }
        public void Goukeiti()
        {

        } 

        //ダブルを押すと行われるメソッド
        public void DoubleDecision(int bet)
        {
            //カードを引く
            mydraw = Card.IllGiveYouOneInMyHand();
            AChecker(mydraw);
            //合計値を何とかするメソッド
            mydata += GetCardNum(mydraw);
            ABurst(mydata);
            //ディーラーがカードを引いたりする
            deeldraw[1] = Card.IllGiveYouOneInMyHand();
            AChecker(mydraw);
            //合計値を何とかするメソッド
            deeldata += GetCardNum(deeldraw[1]);
            ABurst(deeldata);
            //ディーラー17になるまでループ
            for (int i = 2; deeldata < 17; i++)
            {
                deeldraw[i] = Card.IllGiveYouOneInMyHand();
                deeldata += GetCardNum(deeldraw[i]);
                AChecker(mydraw);
            }
            if (Judge(mydata, deeldata))
            {
                chip.IncreaseInPossessions(bet * 2 * 2);
            }
            //MessageBox.Show(mydraw + "\n" + mydata + "\n" + chip.meny+"\n"+ deeldata + "\n" +deeldraw);
            //ディーラーや自分が引いたカードをFoomに伝える方法を考える
        }

        //Hitを押すと行われるメソッド
        public void HitDecision()
        {
            //カードを引く
            mydraw = Card.IllGiveYouOneInMyHand();
            AChecker(mydraw);
            //合計値を何とかするメソッド
            mydata += GetCardNum(mydraw);
            ABurst(mydata);
            //MessageBox.Show(mydraw+"\n"+mydata+"\n"+ chip.meny);
        }

        //カードの取得
        public int GetCardNum(string dada)
        {
            int data;
            string[] split = dada.Split('_');
            data= int.Parse(split[1]);

            if (data > 10)
            {
                data=10;
            }else if (data == 1)
            {
                data=11;
            }


             return data;
        }


        //スタンドを押したときのメソッド
        public void StandDecision(int bet)
        {
            //ディーラーがカードを引いたりする
            deeldraw[1] = Card.IllGiveYouOneInMyHand();
            AChecker(mydraw);
            //合計値を何とかするメソッド
            deeldata += GetCardNum(deeldraw[1]);
            ABurst(deeldata);
            //ディーラー17になるまでループ
            for (int i = 2; deeldata < 17; i++)
            {
                deeldraw[i] = Card.IllGiveYouOneInMyHand();
                deeldata += GetCardNum(deeldraw[i]);
                AChecker(mydraw);
            }
            //ディーラーがカードを引いたり
            if (Judge(mydata, deeldata))
            {
                chip.IncreaseInPossessions(bet * 2);
            }

        }
        //勝敗勝ち負けもこれ使う
        public bool Judge(int mynum, int deelnum)
        {
            if (mynum > deelnum)
            {
                if (mynum <= 21)
                {
                    return true;
                }
            }
            return false;
        }
        //Aを取った時の処理 IFで確認　AがでたらAチェッカー変数を1にする　ゲームオーバー処理にAチェッカーを0にする処理を作る
        //Aチェッカーを0にするメソッド必要かも？

        //1を11にする処理
        public void AChecker(string card)
        {
            string[] split = card.Split('_');
            if (split[1] == "1")
            {
                Acunt++;
            }
        }


        //Aが11の時バーストしたら1になる処理
        public void ABurst(int data)
        {
            if (data > 21 && Acunt > 0)
            {
                data -= 10;
                Acunt--;
                return;
            }
        }
        public void risetto()
        {

        }
        public void decision()
        {
            if (Judge(mydata, deeldata))
            {
                MessageBox.Show("あなたの勝利です。"+ "\n" +"所持金が"+ chip.meny+"増えました。");
            }
            else
            {
                MessageBox.Show("You lose");
            }


        }

        internal bool EndGame()
        {
            if (mydata >= 21)
            {
                return true;
            }
            return false;
        }
    }
}

