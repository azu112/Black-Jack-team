using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Black_Jack_team
{
    internal class Game_processing_class
    {
        public Chip_Variation_Class chip = new Chip_Variation_Class();
        public Deck_card_class Card = new Deck_card_class();
        int mydata, deeldata;
        public string mydraw = "";
        public string deeldraw = "";
        public  void BetDecision(int meny)
        {
            //所持金を減らす
            chip.DecreaseInPossessions(meny);
            //自分が1枚引く
            mydraw = Card.IllGiveYouOneInMyHand();
            mydata = GetCardNum(mydraw);
            //ディーラーも引く
            deeldraw = Card.IllGiveYouOneInMyHand();
            deeldata = GetCardNum(deeldraw);
            

        }
        public void Goukeiti()
        {

        } 
        public void DoubleDecision(int bet, int my, int deel)
        {
            //カードを引く
            mydraw = Card.IllGiveYouOneInMyHand();

            //合計値を何とかするメソッド
            mydata += GetCardNum(mydraw);

            //ディーラーがカードを引いたりする
            deeldraw = Card.IllGiveYouOneInMyHand();
            //合計値を何とかするメソッド
            deeldata += GetCardNum(deeldraw);
            //ディーラー17になるまでループ？
            for(int i = 0; deeldata < 17; i++)
            {
                deeldraw = Card.IllGiveYouOneInMyHand();
                deeldata += GetCardNum(deeldraw);
            }
            if (Judge(my, deel))
            {
                chip.IncreaseInPossessions(bet * 2 * 2);
            }

            //ディーラーや自分が引いたカードをFoomに伝える方法を考える
        }
        public void HitDecision()
        {

        }

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

        public void StandDecision(int bet, int my, int deel)
        {
            for (int i = 0; deeldata < 17; i++)
            {
                deeldraw = Card.IllGiveYouOneInMyHand();
                deeldata += GetCardNum(deeldraw);
            }
            //ディーラーがカードを引いたり
            if (Judge(my, deel))
            {
                chip.IncreaseInPossessions(bet * 2);
            }

        }
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

    }
}

