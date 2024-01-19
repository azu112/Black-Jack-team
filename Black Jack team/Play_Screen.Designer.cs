namespace Black_Jack_team
{
    partial class Play_Screen
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
            end = new System.Windows.Forms.Button();
            Reset_Button = new System.Windows.Forms.Button();
            start_Button = new System.Windows.Forms.Button();
            Bet_display = new System.Windows.Forms.Label();
            Cash_label = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            Bet_label = new System.Windows.Forms.Label();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            Stand_Button = new System.Windows.Forms.Button();
            Double_Button = new System.Windows.Forms.Button();
            Hit_Button = new System.Windows.Forms.Button();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            pictureBox6 = new System.Windows.Forms.PictureBox();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // end
            // 
            end.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            end.Location = new System.Drawing.Point(943, 425);
            end.Name = "end";
            end.Size = new System.Drawing.Size(146, 60);
            end.TabIndex = 1;
            end.Text = "TOPに戻る";
            end.UseVisualStyleBackColor = true;
            end.Click += end_Click;
            // 
            // Reset_Button
            // 
            Reset_Button.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Reset_Button.Location = new System.Drawing.Point(812, 26);
            Reset_Button.Name = "Reset_Button";
            Reset_Button.Size = new System.Drawing.Size(189, 67);
            Reset_Button.TabIndex = 3;
            Reset_Button.Text = "リセット";
            Reset_Button.UseVisualStyleBackColor = true;
            Reset_Button.Click += Reset_Button_Click;
            // 
            // start_Button
            // 
            start_Button.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            start_Button.Location = new System.Drawing.Point(812, 99);
            start_Button.Name = "start_Button";
            start_Button.Size = new System.Drawing.Size(189, 66);
            start_Button.TabIndex = 4;
            start_Button.Text = "スタート";
            start_Button.UseVisualStyleBackColor = true;
            start_Button.Click += Confirm_Button_Click;
            // 
            // Bet_display
            // 
            Bet_display.AutoSize = true;
            Bet_display.Font = new System.Drawing.Font("Yu Gothic UI", 63F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Bet_display.Location = new System.Drawing.Point(173, 25);
            Bet_display.Name = "Bet_display";
            Bet_display.Size = new System.Drawing.Size(233, 140);
            Bet_display.TabIndex = 7;
            Bet_display.Text = "Bet:";
            Bet_display.Click += Bet_display_Click;
            // 
            // Cash_label
            // 
            Cash_label.AutoSize = true;
            Cash_label.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Cash_label.Location = new System.Drawing.Point(22, 411);
            Cash_label.Name = "Cash_label";
            Cash_label.Size = new System.Drawing.Size(98, 46);
            Cash_label.TabIndex = 7;
            Cash_label.Text = "Cash:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.image;
            pictureBox2.Location = new System.Drawing.Point(1, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(1106, 510);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = Properties.Resources.chip_100;
            pictureBox1.Location = new System.Drawing.Point(282, 218);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(180, 180);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Bet_label
            // 
            Bet_label.AutoSize = true;
            Bet_label.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Bet_label.Location = new System.Drawing.Point(22, 352);
            Bet_label.Name = "Bet_label";
            Bet_label.Size = new System.Drawing.Size(94, 46);
            Bet_label.TabIndex = 10;
            Bet_label.Text = "  Bet:";
            Bet_label.Click += Bet_label_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = System.Drawing.Color.Transparent;
            pictureBox3.Image = Properties.Resources.chip500;
            pictureBox3.Location = new System.Drawing.Point(503, 218);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(180, 180);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = System.Drawing.Color.Transparent;
            pictureBox4.Image = Properties.Resources.chip1000;
            pictureBox4.Location = new System.Drawing.Point(720, 218);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(180, 180);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // Stand_Button
            // 
            Stand_Button.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Stand_Button.Location = new System.Drawing.Point(494, 268);
            Stand_Button.Name = "Stand_Button";
            Stand_Button.Size = new System.Drawing.Size(199, 77);
            Stand_Button.TabIndex = 12;
            Stand_Button.Text = "STAND";
            Stand_Button.UseVisualStyleBackColor = true;
            Stand_Button.Visible = false;
            Stand_Button.Click += Stand_Button_Click;
            // 
            // Double_Button
            // 
            Double_Button.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Double_Button.Location = new System.Drawing.Point(720, 268);
            Double_Button.Name = "Double_Button";
            Double_Button.Size = new System.Drawing.Size(193, 77);
            Double_Button.TabIndex = 12;
            Double_Button.Text = "DOUBLE";
            Double_Button.UseVisualStyleBackColor = true;
            Double_Button.Visible = false;
            // 
            // Hit_Button
            // 
            Hit_Button.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Hit_Button.Location = new System.Drawing.Point(265, 268);
            Hit_Button.Name = "Hit_Button";
            Hit_Button.Size = new System.Drawing.Size(197, 77);
            Hit_Button.TabIndex = 13;
            Hit_Button.Text = "HIT";
            Hit_Button.UseVisualStyleBackColor = true;
            Hit_Button.Visible = false;
            Hit_Button.Click += Hit_Button_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = System.Drawing.Color.Transparent;
            pictureBox5.Image = Properties.Resources.H_1;
            pictureBox5.Location = new System.Drawing.Point(518, 26);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(101, 139);
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = System.Drawing.Color.Transparent;
            pictureBox6.Image = Properties.Resources.H_1;
            pictureBox6.Location = new System.Drawing.Point(518, 301);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new System.Drawing.Size(101, 139);
            pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(625, 411);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(275, 72);
            button1.TabIndex = 1;
            button1.Text = "テスト用button";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Play_Screen
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1109, 497);
            Controls.Add(button1);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(Hit_Button);
            Controls.Add(Double_Button);
            Controls.Add(Stand_Button);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(Bet_label);
            Controls.Add(pictureBox1);
            Controls.Add(Cash_label);
            Controls.Add(Bet_display);
            Controls.Add(start_Button);
            Controls.Add(Reset_Button);
            Controls.Add(end);
            Controls.Add(pictureBox2);
            DoubleBuffered = true;
            Name = "Play_Screen";
            Text = "Form3";
            FormClosed += Play_Screen_FormClosed;
            Load += Play_Screen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox Bet;
        private System.Windows.Forms.Button end;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.Button start_Button;
        private System.Windows.Forms.Label Bet_display;
        private System.Windows.Forms.Label Cash_label;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Bet_label;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button Hit_Button;
        private System.Windows.Forms.Button Stand_Button;
        private System.Windows.Forms.Button Double_Button;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button button1;
    }
}