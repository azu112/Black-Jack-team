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
            Deal_Button = new System.Windows.Forms.Button();
            Bet_Button = new System.Windows.Forms.Button();
            end = new System.Windows.Forms.Button();
            Hit_Button = new System.Windows.Forms.Button();
            Stand_Button = new System.Windows.Forms.Button();
            Double_Button = new System.Windows.Forms.Button();
            Reset_Button = new System.Windows.Forms.Button();
            Confirm_Button = new System.Windows.Forms.Button();
            Bet_display = new System.Windows.Forms.Label();
            Cash_label = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            Bet_label = new System.Windows.Forms.Label();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // Deal_Button
            // 
            Deal_Button.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Deal_Button.Location = new System.Drawing.Point(503, 244);
            Deal_Button.Name = "Deal_Button";
            Deal_Button.Size = new System.Drawing.Size(143, 66);
            Deal_Button.TabIndex = 1;
            Deal_Button.Text = "Deal";
            Deal_Button.UseVisualStyleBackColor = true;
            Deal_Button.Click += Deal_screen_Click;
            // 
            // Bet_Button
            // 
            Bet_Button.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Bet_Button.Location = new System.Drawing.Point(503, 339);
            Bet_Button.Name = "Bet_Button";
            Bet_Button.Size = new System.Drawing.Size(143, 70);
            Bet_Button.TabIndex = 1;
            Bet_Button.Text = "Bet";
            Bet_Button.UseVisualStyleBackColor = true;
            Bet_Button.Click += Bet_Button_Click;
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
            // Hit_Button
            // 
            Hit_Button.Location = new System.Drawing.Point(331, 286);
            Hit_Button.Name = "Hit_Button";
            Hit_Button.Size = new System.Drawing.Size(143, 66);
            Hit_Button.TabIndex = 2;
            Hit_Button.Text = "Hit";
            Hit_Button.UseVisualStyleBackColor = true;
            Hit_Button.Visible = false;
            Hit_Button.Click += Hit_Button_Click;
            // 
            // Stand_Button
            // 
            Stand_Button.Location = new System.Drawing.Point(503, 286);
            Stand_Button.Name = "Stand_Button";
            Stand_Button.Size = new System.Drawing.Size(143, 66);
            Stand_Button.TabIndex = 2;
            Stand_Button.Text = "Stand";
            Stand_Button.UseVisualStyleBackColor = true;
            Stand_Button.Visible = false;
            Stand_Button.Click += button3_Click;
            // 
            // Double_Button
            // 
            Double_Button.Location = new System.Drawing.Point(665, 286);
            Double_Button.Name = "Double_Button";
            Double_Button.Size = new System.Drawing.Size(143, 66);
            Double_Button.TabIndex = 2;
            Double_Button.Text = "Double";
            Double_Button.UseVisualStyleBackColor = true;
            Double_Button.Visible = false;
            Double_Button.Click += button3_Click;
            // 
            // Reset_Button
            // 
            Reset_Button.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Reset_Button.Location = new System.Drawing.Point(688, 26);
            Reset_Button.Name = "Reset_Button";
            Reset_Button.Size = new System.Drawing.Size(189, 67);
            Reset_Button.TabIndex = 3;
            Reset_Button.Text = "リセット";
            Reset_Button.UseVisualStyleBackColor = true;
            Reset_Button.Visible = false;
            Reset_Button.Click += Reset_Button_Click;
            // 
            // Confirm_Button
            // 
            Confirm_Button.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Confirm_Button.Location = new System.Drawing.Point(688, 99);
            Confirm_Button.Name = "Confirm_Button";
            Confirm_Button.Size = new System.Drawing.Size(189, 66);
            Confirm_Button.TabIndex = 4;
            Confirm_Button.Text = "決定";
            Confirm_Button.UseVisualStyleBackColor = true;
            Confirm_Button.Visible = false;
            Confirm_Button.Click += Confirm_Button_Click;
            // 
            // Bet_display
            // 
            Bet_display.AutoSize = true;
            Bet_display.Font = new System.Drawing.Font("Yu Gothic UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Bet_display.Location = new System.Drawing.Point(272, 26);
            Bet_display.Name = "Bet_display";
            Bet_display.Size = new System.Drawing.Size(222, 133);
            Bet_display.TabIndex = 7;
            Bet_display.Text = "Bet:";
            Bet_display.Visible = false;
            Bet_display.Click += label1_Click;
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
            Cash_label.Click += label1_Click;
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
            pictureBox1.Location = new System.Drawing.Point(272, 239);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(180, 180);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            pictureBox1.Click += pictureBox1_Click_1;
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
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = System.Drawing.Color.Transparent;
            pictureBox3.Image = Properties.Resources.chip500;
            pictureBox3.Location = new System.Drawing.Point(470, 239);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(180, 180);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = System.Drawing.Color.Transparent;
            pictureBox4.Image = Properties.Resources.chip1000;
            pictureBox4.Location = new System.Drawing.Point(665, 239);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(180, 180);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            pictureBox4.Visible = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // Play_Screen
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1107, 497);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(Bet_label);
            Controls.Add(pictureBox1);
            Controls.Add(Cash_label);
            Controls.Add(Bet_display);
            Controls.Add(Confirm_Button);
            Controls.Add(Reset_Button);
            Controls.Add(Double_Button);
            Controls.Add(Stand_Button);
            Controls.Add(Hit_Button);
            Controls.Add(end);
            Controls.Add(Bet_Button);
            Controls.Add(Deal_Button);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox Bet;
        private System.Windows.Forms.Button Deal_Button;
        private System.Windows.Forms.Button Bet_Button;
        private System.Windows.Forms.Button end;
        private System.Windows.Forms.Button Hit_Button;
        private System.Windows.Forms.Button Stand_Button;
        private System.Windows.Forms.Button Double_Button;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.Button Confirm_Button;
        private System.Windows.Forms.Label Bet_display;
        private System.Windows.Forms.Label Cash_label;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Bet_label;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}