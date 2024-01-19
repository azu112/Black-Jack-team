using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Black_Jack_team
{
    internal class Game_processing_class
    {
        public Chip_Variation_Class chip = new Chip_Variation_Class();
        public Deck_card_class Card = new Deck_card_class();
        int my;
        public string myhiitano="C_5";
        public string[] deelhiitano = new string[11];
        public  void BetDecision()
        {
            myhiitano = "D_8";
            deelhiitano[0] = "H_1";
        }

        public void DoubleDecision(int bet, int my, int deel)
        {
            //カードを引く
            myhiitano = Card.IllGiveYouOneInMyHand();
            //合計値を何とかするメソッド
            //ディーラーがカードを引いたりする
            //合計値を何とかするメソッド
            if (Judge(my, deel))
            {
                chip.IncreaseInPossessions(bet * 2 * 2);
            }
            //ディーラーや自分が引いたカードをFoomに伝える方法を考える
        }
        public void HitDecision()
        {

        }

        public void Cardhiki()
        {

            return;
        }

        public void StandDecision(int bet, int my, int deel)
        {
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

    }
}

