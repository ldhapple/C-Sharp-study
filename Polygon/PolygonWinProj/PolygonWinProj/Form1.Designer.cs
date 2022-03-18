namespace PolygonWinProj
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.polygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.Circle = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RectangleColor = new System.Windows.Forms.ToolStripMenuItem();
            this.CircleColor = new System.Windows.Forms.ToolStripMenuItem();
            this.MyPanel = new System.Windows.Forms.Panel();
            this.Triangle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.polygonToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(914, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // polygonToolStripMenuItem
            // 
            this.polygonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Rectangle,
            this.Circle,
            this.Triangle});
            this.polygonToolStripMenuItem.Name = "polygonToolStripMenuItem";
            this.polygonToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.polygonToolStripMenuItem.Text = "Polygon";
            // 
            // Rectangle
            // 
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(216, 26);
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // Circle
            // 
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(216, 26);
            this.Circle.Text = "Circle";
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RectangleColor,
            this.CircleColor});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // RectangleColor
            // 
            this.RectangleColor.Name = "RectangleColor";
            this.RectangleColor.Size = new System.Drawing.Size(216, 26);
            this.RectangleColor.Text = "RectangleColor";
            this.RectangleColor.Click += new System.EventHandler(this.RectangleColor_Click);
            // 
            // CircleColor
            // 
            this.CircleColor.Name = "CircleColor";
            this.CircleColor.Size = new System.Drawing.Size(216, 26);
            this.CircleColor.Text = "CircleColor";
            this.CircleColor.Click += new System.EventHandler(this.CircleColor_Click);
            // 
            // MyPanel
            // 
            this.MyPanel.Location = new System.Drawing.Point(0, 34);
            this.MyPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MyPanel.Name = "MyPanel";
            this.MyPanel.Size = new System.Drawing.Size(914, 529);
            this.MyPanel.TabIndex = 1;
            this.MyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MyPanel_Paint);
            this.MyPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Click);
            this.MyPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Click);
            this.MyPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_Click);
            // 
            // Triangle
            // 
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(216, 26);
            this.Triangle.Text = "Triangle";
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.MyPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem polygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Rectangle;
        private System.Windows.Forms.ToolStripMenuItem Circle;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RectangleColor;
        private System.Windows.Forms.ToolStripMenuItem CircleColor;
        private System.Windows.Forms.Panel MyPanel;
        private System.Windows.Forms.ToolStripMenuItem Triangle;
    }
}

