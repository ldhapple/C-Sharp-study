namespace gambling
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.BetButton = new System.Windows.Forms.Button();
            this.rollButton = new System.Windows.Forms.Button();
            this.BetMoneyText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dieLabel1 = new System.Windows.Forms.Label();
            this.dieLabel2 = new System.Windows.Forms.Label();
            this.myMoney = new System.Windows.Forms.Label();
            this.multiple = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chooseBox = new System.Windows.Forms.ComboBox();
            this.levelText = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.goal = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.홀짝게임ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.holGameMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.chargeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.rightNum = new System.Windows.Forms.Label();
            this.rightNumText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.opportunity = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BetButton
            // 
            this.BetButton.Location = new System.Drawing.Point(603, 74);
            this.BetButton.Name = "BetButton";
            this.BetButton.Size = new System.Drawing.Size(75, 23);
            this.BetButton.TabIndex = 0;
            this.BetButton.Text = "Betting";
            this.BetButton.UseVisualStyleBackColor = true;
            this.BetButton.Click += new System.EventHandler(this.BetButton_Click);
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(188, 431);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(75, 23);
            this.rollButton.TabIndex = 1;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // BetMoneyText
            // 
            this.BetMoneyText.Location = new System.Drawing.Point(489, 74);
            this.BetMoneyText.Name = "BetMoneyText";
            this.BetMoneyText.Size = new System.Drawing.Size(108, 25);
            this.BetMoneyText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "BetMoney";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(489, 291);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(477, 194);
            this.resultBox.TabIndex = 4;
            this.resultBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "보유한 돈";
            // 
            // dieLabel1
            // 
            this.dieLabel1.Location = new System.Drawing.Point(119, 145);
            this.dieLabel1.Name = "dieLabel1";
            this.dieLabel1.Size = new System.Drawing.Size(60, 60);
            this.dieLabel1.TabIndex = 6;
            // 
            // dieLabel2
            // 
            this.dieLabel2.Location = new System.Drawing.Point(281, 145);
            this.dieLabel2.Name = "dieLabel2";
            this.dieLabel2.Size = new System.Drawing.Size(60, 60);
            this.dieLabel2.TabIndex = 7;
            // 
            // myMoney
            // 
            this.myMoney.AutoSize = true;
            this.myMoney.Location = new System.Drawing.Point(589, 186);
            this.myMoney.Name = "myMoney";
            this.myMoney.Size = new System.Drawing.Size(51, 15);
            this.myMoney.TabIndex = 8;
            this.myMoney.Text = "money";
            // 
            // multiple
            // 
            this.multiple.AutoSize = true;
            this.multiple.Location = new System.Drawing.Point(196, 305);
            this.multiple.Name = "multiple";
            this.multiple.Size = new System.Drawing.Size(55, 15);
            this.multiple.TabIndex = 9;
            this.multiple.Text = "multiple";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Next";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "배";
            // 
            // chooseBox
            // 
            this.chooseBox.FormattingEnabled = true;
            this.chooseBox.Items.AddRange(new object[] {
            "홀",
            "짝"});
            this.chooseBox.Location = new System.Drawing.Point(489, 105);
            this.chooseBox.Name = "chooseBox";
            this.chooseBox.Size = new System.Drawing.Size(108, 23);
            this.chooseBox.TabIndex = 12;
            // 
            // levelText
            // 
            this.levelText.AutoSize = true;
            this.levelText.Location = new System.Drawing.Point(589, 243);
            this.levelText.Name = "levelText";
            this.levelText.Size = new System.Drawing.Size(0, 15);
            this.levelText.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(486, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(693, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "목표금액";
            // 
            // goal
            // 
            this.goal.AutoSize = true;
            this.goal.Location = new System.Drawing.Point(814, 243);
            this.goal.Name = "goal";
            this.goal.Size = new System.Drawing.Size(0, 15);
            this.goal.TabIndex = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.홀짝게임ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1009, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 홀짝게임ToolStripMenuItem
            // 
            this.홀짝게임ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.holGameMenu,
            this.chargeMenu});
            this.홀짝게임ToolStripMenuItem.Name = "홀짝게임ToolStripMenuItem";
            this.홀짝게임ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.홀짝게임ToolStripMenuItem.Text = "메뉴";
            // 
            // holGameMenu
            // 
            this.holGameMenu.Name = "holGameMenu";
            this.holGameMenu.Size = new System.Drawing.Size(216, 26);
            this.holGameMenu.Text = "홀짝게임";
            this.holGameMenu.Click += new System.EventHandler(this.holGameMenu_Click);
            // 
            // chargeMenu
            // 
            this.chargeMenu.Name = "chargeMenu";
            this.chargeMenu.Size = new System.Drawing.Size(216, 26);
            this.chargeMenu.Text = "충전";
            this.chargeMenu.Click += new System.EventHandler(this.chargeMenu_Click);
            // 
            // rightNum
            // 
            this.rightNum.AutoSize = true;
            this.rightNum.Location = new System.Drawing.Point(783, 56);
            this.rightNum.Name = "rightNum";
            this.rightNum.Size = new System.Drawing.Size(132, 15);
            this.rightNum.TabIndex = 18;
            this.rightNum.Text = "충전용 숫자맞추기";
            // 
            // rightNumText
            // 
            this.rightNumText.Location = new System.Drawing.Point(795, 75);
            this.rightNumText.Name = "rightNumText";
            this.rightNumText.Size = new System.Drawing.Size(100, 25);
            this.rightNumText.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(783, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "남은기회";
            // 
            // opportunity
            // 
            this.opportunity.AutoSize = true;
            this.opportunity.Location = new System.Drawing.Point(870, 127);
            this.opportunity.Name = "opportunity";
            this.opportunity.Size = new System.Drawing.Size(80, 15);
            this.opportunity.TabIndex = 21;
            this.opportunity.Text = "opportunity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 497);
            this.Controls.Add(this.opportunity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rightNumText);
            this.Controls.Add(this.rightNum);
            this.Controls.Add(this.goal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.levelText);
            this.Controls.Add(this.chooseBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.multiple);
            this.Controls.Add(this.myMoney);
            this.Controls.Add(this.dieLabel2);
            this.Controls.Add(this.dieLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BetMoneyText);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.BetButton);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Gambling";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BetButton;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.TextBox BetMoneyText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox resultBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dieLabel1;
        private System.Windows.Forms.Label dieLabel2;
        private System.Windows.Forms.Label myMoney;
        private System.Windows.Forms.Label multiple;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox chooseBox;
        private System.Windows.Forms.Label levelText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label goal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 홀짝게임ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem holGameMenu;
        private System.Windows.Forms.ToolStripMenuItem chargeMenu;
        private System.Windows.Forms.Label rightNum;
        private System.Windows.Forms.TextBox rightNumText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label opportunity;
    }
}

