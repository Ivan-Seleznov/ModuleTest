namespace ModuleTest
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
            this.KnightCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DragonsCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ArcherCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AverageSpeed = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.TotalGirls = new System.Windows.Forms.Label();
            this.TotalGold = new System.Windows.Forms.Label();
            this.TotalFeed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalArrow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KnightCount
            // 
            this.KnightCount.Location = new System.Drawing.Point(251, 35);
            this.KnightCount.Name = "KnightCount";
            this.KnightCount.Size = new System.Drawing.Size(100, 22);
            this.KnightCount.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кількість рейтарів у важкій броні";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Кількість драконів";
            // 
            // DragonsCount
            // 
            this.DragonsCount.Location = new System.Drawing.Point(251, 82);
            this.DragonsCount.Name = "DragonsCount";
            this.DragonsCount.Size = new System.Drawing.Size(100, 22);
            this.DragonsCount.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Кількість лучників";
            // 
            // ArcherCount
            // 
            this.ArcherCount.Location = new System.Drawing.Point(251, 131);
            this.ArcherCount.Name = "ArcherCount";
            this.ArcherCount.Size = new System.Drawing.Size(100, 22);
            this.ArcherCount.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Швідкість військ";
            // 
            // AverageSpeed
            // 
            this.AverageSpeed.AutoSize = true;
            this.AverageSpeed.Location = new System.Drawing.Point(129, 253);
            this.AverageSpeed.Name = "AverageSpeed";
            this.AverageSpeed.Size = new System.Drawing.Size(14, 16);
            this.AverageSpeed.TabIndex = 8;
            this.AverageSpeed.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Вартість утримання";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Злотих";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Дівчин";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Кг корму";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(404, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(510, 404);
            this.listBox1.TabIndex = 13;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(12, 199);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(131, 23);
            this.CalculateButton.TabIndex = 14;
            this.CalculateButton.Text = "Розрахувати";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // TotalGirls
            // 
            this.TotalGirls.AutoSize = true;
            this.TotalGirls.Location = new System.Drawing.Point(72, 345);
            this.TotalGirls.Name = "TotalGirls";
            this.TotalGirls.Size = new System.Drawing.Size(14, 16);
            this.TotalGirls.TabIndex = 15;
            this.TotalGirls.Text = "0";
            // 
            // TotalGold
            // 
            this.TotalGold.AutoSize = true;
            this.TotalGold.Location = new System.Drawing.Point(72, 314);
            this.TotalGold.Name = "TotalGold";
            this.TotalGold.Size = new System.Drawing.Size(14, 16);
            this.TotalGold.TabIndex = 16;
            this.TotalGold.Text = "0";
            // 
            // TotalFeed
            // 
            this.TotalFeed.AutoSize = true;
            this.TotalFeed.Location = new System.Drawing.Point(82, 377);
            this.TotalFeed.Name = "TotalFeed";
            this.TotalFeed.Size = new System.Drawing.Size(14, 16);
            this.TotalFeed.TabIndex = 17;
            this.TotalFeed.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Кількість стріл";
            // 
            // TotalArrow
            // 
            this.TotalArrow.AutoSize = true;
            this.TotalArrow.Location = new System.Drawing.Point(118, 414);
            this.TotalArrow.Name = "TotalArrow";
            this.TotalArrow.Size = new System.Drawing.Size(14, 16);
            this.TotalArrow.TabIndex = 19;
            this.TotalArrow.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.TotalArrow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TotalFeed);
            this.Controls.Add(this.TotalGold);
            this.Controls.Add(this.TotalGirls);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AverageSpeed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ArcherCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DragonsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KnightCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox KnightCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DragonsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ArcherCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label AverageSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label TotalGirls;
        private System.Windows.Forms.Label TotalGold;
        private System.Windows.Forms.Label TotalFeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TotalArrow;
    }
}

