using System;
using System.Collections.Generic;
using System.Text;

namespace Black_Jack_team
{
    internal class Deck_card_class
    {

        List<string> tora = new List<string>();
        List<string> tora2 = new List<string>();
        List<string> tefuda = new List<string>();
        List<string> dere = new List<string>();
        string[] sert = { "スペド", "ハート", "クロバ", "ダイア" };
        string[] suuji = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13" };


        //今の段階だとエラーになるのでいったんこの状態にします。
        public Deck_card_class()
        {


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    string kari = sert[i] + suuji[j];
                    tora.Add(kari);
                }
            }
        }
        //カード山札に戻す
        public void ResettingADeck()
        {

            int su = tora2.Count;
            for (int i = 0; i < su; i++)
            {
                tora.Add(tora2[0]);
                tora2.Remove(tora2[0]);
            }

        }
        //手札引く処理
        public string IllGiveYouOneInMyHand()
        {

            string returnCard = "";
            int ss = tora.Count;

            Random r = new System.Random();
            int ran = r.Next(0, ss);

            returnCard = tora[ran];
            tora2.Add(tora[ran]);
            tora.Remove(tora[ran]);

            return returnCard;

        }




    }
}
