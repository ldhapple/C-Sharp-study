using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using gamblingDLL;
using System.Collections;


namespace gambling
{
    public partial class Form1 : Form
    {
        private Random randomNum = new Random();
        private HolGame holGame = new HolGame();
        private Charge charge = new Charge();
        private Money gold = Money.GetInstance();
        private bool betting = false; //금액배팅했는지
        private int betMoney; //배팅금액
        private bool checkHol = false;
        private bool checkCharge = false;
        private int eyes;
        private int charge_opportunity = 3;
        public delegate void gameSelect();
        
        public Form1()
        {
            InitializeComponent();
            multiple.Text = holGame.multi.ToString();
            myMoney.Text = gold.capacity.ToString();
            levelText.Text = holGame.level.ToString();
            goal.Text = holGame.goalMoney.ToString();
            opportunity.Text = charge_opportunity.ToString();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            if(betting==true && checkHol == true)
            {
                dieLabel1.Text = "";
                dieLabel2.Text = "";

                DisplayDie(dieLabel1);
                DisplayDie(dieLabel2);
            }
            else if(checkCharge == true)
            {
                dieLabel1.Text = "";
                dieLabel2.Text = "";

                DisplayDie(dieLabel1);
                DisplayDie(dieLabel2);
            }

            if (checkHol == true && betting == true)
            {
                Roll();
            }

            else if(checkCharge == true)
            {
                Charge();
            }
            
            else if(checkHol == false && checkCharge == false)
            {
                MessageBox.Show("충전메뉴를 체크해주세요!");
            }

        }

        public void Roll()
        {
            holGame.multi = randomNum.Next(2, 5);
            if (holGame.sum % 2 == 0 && holGame.checkChoice == 2)
            {
                gold.capacity += betMoney * holGame.multi;
            }
            else if (holGame.sum % 2 != 0 && holGame.checkChoice == 1)
            {
                gold.capacity += betMoney * holGame.multi;
            }
            holGame.Roll_Click();
            multiple.Text = holGame.multi.ToString();
            myMoney.Text = gold.capacity.ToString();
            levelText.Text = holGame.level.ToString();
            goal.Text = holGame.goalMoney.ToString();

            resultBox.AppendText("결과: " + holGame.sum + "\t" + "배팅금액: " + betMoney + "\t" + "배당금: " + betMoney * holGame.multi + "\n");

            holGame.sum = 0;
        }

        public void Charge()
        {
            int correctNum = Int32.Parse(rightNumText.Text);

            if(charge_opportunity > 0 && eyes == correctNum)
            {
                gold.capacity += 1000000;
                resultBox.AppendText("추가충전금액: 1,000,000");
                charge_opportunity--;
                opportunity.Text = charge_opportunity.ToString();
            }
            else if(charge_opportunity > 0)
            {
                charge_opportunity--;
                resultBox.AppendText("충전실패!");
                opportunity.Text = charge_opportunity.ToString();
            }
            
            else if(charge_opportunity == 0)
            {
                MessageBox.Show("충전기회가 없습니다.");
            }
        }

        private void BetButton_Click(object sender, EventArgs e)
        {
            if(checkHol == true)
            {
                Bet();
                checkChoose();
            }
            else
            {
                MessageBox.Show("메뉴에서 홀짝게임을 체크해주세요");
            }
        }

        public void Bet()
        {
            betting = true;
            betMoney = Int32.Parse(BetMoneyText.Text);
            BetMoneyText.Text = "";
            if(gold.capacity - betMoney >= 0)
            {
                gold.capacity -= betMoney;
            }
            else
            {
                MessageBox.Show("배팅금액이 현재금액보다 높습니다.");
            }
            myMoney.Text = gold.capacity.ToString();
        }

        public void checkChoose()
        {
            if (chooseBox.Text == "홀")
            {
                holGame.checkChoice = 1;
            }
            else if (chooseBox.Text == "짝")
            {
                holGame.checkChoice = 2;
            }
        }

        public void DisplayDie(Label dieLabel)
        {
            int face = randomNum.Next(1, 7);
            dieLabel.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\die" + face + ".gif");
            holGame.sum += face;
            eyes += face;
        }

        private void holGameMenu_Click(object sender, EventArgs e)
        {
            holGameMenu.Checked = !holGameMenu.Checked;
            if (holGameMenu.Checked == true)
            {
                checkHol = true;
            }
            else
                checkHol = false;
        }

        private void chargeMenu_Click(object sender, EventArgs e)
        {
            chargeMenu.Checked = !chargeMenu.Checked;
            if (chargeMenu.Checked == true)
            {
                checkCharge = true;
            }
            else
                checkCharge = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
