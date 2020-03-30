namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.memAdd = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.changeSign = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.memSet = new System.Windows.Forms.Button();
            this.memRecall = new System.Windows.Forms.Button();
            this.memClear = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.flip = new System.Windows.Forms.Button();
            this.res = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.clearEntry = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.textBoxMemory = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Location = new System.Drawing.Point(40, 36);
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.ReadOnly = true;
            this.textBoxDisplay.Size = new System.Drawing.Size(302, 20);
            this.textBoxDisplay.TabIndex = 0;
            // 
            // memAdd
            // 
            this.memAdd.Location = new System.Drawing.Point(12, 233);
            this.memAdd.Name = "memAdd";
            this.memAdd.Size = new System.Drawing.Size(47, 34);
            this.memAdd.TabIndex = 1;
            this.memAdd.Text = "M+";
            this.memAdd.UseVisualStyleBackColor = true;
            this.memAdd.Click += new System.EventHandler(this.memAdd_Click);
            // 
            // num0
            // 
            this.num0.Location = new System.Drawing.Point(74, 233);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(47, 34);
            this.num0.TabIndex = 2;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(74, 193);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(47, 34);
            this.num1.TabIndex = 3;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(74, 153);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(47, 34);
            this.num4.TabIndex = 4;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num7
            // 
            this.num7.Location = new System.Drawing.Point(74, 113);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(47, 34);
            this.num7.TabIndex = 5;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num8
            // 
            this.num8.Location = new System.Drawing.Point(127, 113);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(47, 34);
            this.num8.TabIndex = 6;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num9
            // 
            this.num9.Location = new System.Drawing.Point(180, 113);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(47, 34);
            this.num9.TabIndex = 7;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(127, 153);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(47, 34);
            this.num5.TabIndex = 8;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num6
            // 
            this.num6.Location = new System.Drawing.Point(180, 153);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(47, 34);
            this.num6.TabIndex = 9;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(127, 193);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(47, 34);
            this.num2.TabIndex = 10;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(180, 193);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(47, 34);
            this.num3.TabIndex = 11;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // changeSign
            // 
            this.changeSign.Location = new System.Drawing.Point(127, 233);
            this.changeSign.Name = "changeSign";
            this.changeSign.Size = new System.Drawing.Size(47, 34);
            this.changeSign.TabIndex = 12;
            this.changeSign.Text = "+/-";
            this.changeSign.UseVisualStyleBackColor = true;
            this.changeSign.Click += new System.EventHandler(this.changeSign_Click);
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(180, 233);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(47, 34);
            this.dot.TabIndex = 13;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // memSet
            // 
            this.memSet.Location = new System.Drawing.Point(12, 193);
            this.memSet.Name = "memSet";
            this.memSet.Size = new System.Drawing.Size(47, 34);
            this.memSet.TabIndex = 14;
            this.memSet.Text = "MS";
            this.memSet.UseVisualStyleBackColor = true;
            this.memSet.Click += new System.EventHandler(this.memSet_Click);
            // 
            // memRecall
            // 
            this.memRecall.Location = new System.Drawing.Point(12, 153);
            this.memRecall.Name = "memRecall";
            this.memRecall.Size = new System.Drawing.Size(47, 34);
            this.memRecall.TabIndex = 15;
            this.memRecall.Text = "MR";
            this.memRecall.UseVisualStyleBackColor = true;
            this.memRecall.Click += new System.EventHandler(this.memRecall_Click);
            // 
            // memClear
            // 
            this.memClear.Location = new System.Drawing.Point(12, 113);
            this.memClear.Name = "memClear";
            this.memClear.Size = new System.Drawing.Size(47, 34);
            this.memClear.TabIndex = 16;
            this.memClear.Text = "MC";
            this.memClear.UseVisualStyleBackColor = true;
            this.memClear.Click += new System.EventHandler(this.memClear_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(242, 113);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(47, 34);
            this.div.TabIndex = 17;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(242, 153);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(47, 34);
            this.multiply.TabIndex = 18;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(242, 193);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(47, 34);
            this.sub.TabIndex = 19;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(242, 233);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(47, 34);
            this.sum.TabIndex = 20;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // sqrt
            // 
            this.sqrt.Location = new System.Drawing.Point(295, 113);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(47, 34);
            this.sqrt.TabIndex = 21;
            this.sqrt.Text = "sqrt";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // percent
            // 
            this.percent.Location = new System.Drawing.Point(295, 153);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(47, 34);
            this.percent.TabIndex = 22;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = true;
            this.percent.Click += new System.EventHandler(this.percent_Click);
            // 
            // flip
            // 
            this.flip.Location = new System.Drawing.Point(295, 193);
            this.flip.Name = "flip";
            this.flip.Size = new System.Drawing.Size(47, 34);
            this.flip.TabIndex = 23;
            this.flip.Text = "1/x";
            this.flip.UseVisualStyleBackColor = true;
            this.flip.Click += new System.EventHandler(this.flip_Click);
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(295, 233);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(47, 34);
            this.res.TabIndex = 24;
            this.res.Text = "=";
            this.res.UseVisualStyleBackColor = true;
            this.res.Click += new System.EventHandler(this.res_Click);
            // 
            // clearAll
            // 
            this.clearAll.Location = new System.Drawing.Point(242, 73);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(100, 34);
            this.clearAll.TabIndex = 25;
            this.clearAll.Text = "C";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // clearEntry
            // 
            this.clearEntry.Location = new System.Drawing.Point(127, 73);
            this.clearEntry.Name = "clearEntry";
            this.clearEntry.Size = new System.Drawing.Size(100, 34);
            this.clearEntry.TabIndex = 29;
            this.clearEntry.Text = "CE";
            this.clearEntry.UseVisualStyleBackColor = true;
            this.clearEntry.Click += new System.EventHandler(this.clearEntry_Click);
            // 
            // backspace
            // 
            this.backspace.Location = new System.Drawing.Point(12, 73);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(100, 34);
            this.backspace.TabIndex = 30;
            this.backspace.Text = "Backspace";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.правкаToolStripMenuItem,
            this.видToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(358, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // textBoxMemory
            // 
            this.textBoxMemory.Location = new System.Drawing.Point(12, 36);
            this.textBoxMemory.Name = "textBoxMemory";
            this.textBoxMemory.ReadOnly = true;
            this.textBoxMemory.Size = new System.Drawing.Size(22, 20);
            this.textBoxMemory.TabIndex = 31;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 281);
            this.Controls.Add(this.textBoxMemory);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.clearEntry);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.res);
            this.Controls.Add(this.flip);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.div);
            this.Controls.Add(this.memClear);
            this.Controls.Add(this.memRecall);
            this.Controls.Add(this.memSet);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.changeSign);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.memAdd);
            this.Controls.Add(this.textBoxDisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Калькулятор";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Button memAdd;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button changeSign;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button memSet;
        private System.Windows.Forms.Button memRecall;
        private System.Windows.Forms.Button memClear;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button flip;
        private System.Windows.Forms.Button res;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Button clearEntry;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox textBoxMemory;
    }
}