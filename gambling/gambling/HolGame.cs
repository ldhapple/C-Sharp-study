using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gamblingDLL;
using System.IO;

namespace gambling
{
    class HolGame : GambleGame
    {
        private Random randomNum = new Random();
        private bool betting = false; //금액배팅했는지
        public int level = 1; //레벨
        public int multi = 2;
        public int checkChoice;
        public int goalMoney = 2000000;
        public int sum = 0;

        private Money gold = Money.GetInstance();

        public override void Roll_Click()
        {
            betting = false;
            checkChoice = 0;
            GoldCheck();
            LevelCheck();
        }

        public override void Bet_Click()
        {
        }

        public void LevelUp()
        {
            level++;
            System.Windows.Forms.MessageBox.Show("레벨업!");
            gold.capacity = gold.capacity / 2;
            goalMoney += 500000;
            if (level == 6)
            {
                System.Windows.Forms.MessageBox.Show("홀짝게임 클리어!!");
            }
        }

        public void GoldCheck()
        {
            if (gold.capacity <= 0)
            {
                System.Windows.Forms.MessageBox.Show("실패하셨습니다!");
            }
        }

        public void LevelCheck()
        {
            if (gold.capacity >= goalMoney)
            {
                LevelUp();
            }
        }

    }
}
