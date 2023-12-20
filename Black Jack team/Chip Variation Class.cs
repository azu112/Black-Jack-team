using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;

namespace Black_Jack_team
{
    class Chip_Variation_Class
    {
        public int meny = 1000;
        public void IncreaseInPossessions(int num) //所持金の増加
        {

            meny += num;

        }
        public void DecreaseInPossessions(int num) //所持金の減少
        {
            meny -= num;
        }
    }
}
