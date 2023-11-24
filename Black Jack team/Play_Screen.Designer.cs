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
            Bet = new System.Windows.Forms.TextBox();
            Cash = new System.Windows.Forms.TextBox();
            Deal_Button = new System.Windows.Forms.Button();
            Bet_Button = new System.Windows.Forms.Button();
            end = new System.Windows.Forms.Button();
            Hit_Button = new System.Windows.Forms.Button();
            Stand_Button = new System.Windows.Forms.Button();
            Double_Button = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // Bet
            // 
            Bet.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Bet.Location = new System.Drawing.Point(12, 294);
            Bet.Multiline = true;
            Bet.Name = "Bet";
            Bet.Size = new System.Drawing.Size(165, 69);
            Bet.TabIndex = 0;
            Bet.Text = "Bet:";
            Bet.TextChanged += Bet_TextChanged;
            // 
            // Cash
            // 
            Cash.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Cash.Location = new System.Drawing.Point(12, 383);
            Cash.Multiline = true;
            Cash.Name = "Cash";
            Cash.Size = new System.Drawing.Size(165, 68);
            Cash.TabIndex = 0;
            Cash.Text = "Cash:";
            Cash.TextChanged += Cash_TextChanged;
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
            Bet_Button.Click += Deal_screen_Click;
            // 
            // end
            // 
            end.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            end.Location = new System.Drawing.Point(975, 425);
            end.Name = "end";
            end.Size = new System.Drawing.Size(114, 60);
            end.TabIndex = 1;
            end.Text = "終了";
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
            // Play_Screen
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1107, 497);
            Controls.Add(Double_Button);
            Controls.Add(Stand_Button);
            Controls.Add(Hit_Button);
            Controls.Add(end);
            Controls.Add(Bet_Button);
            Controls.Add(Deal_Button);
            Controls.Add(Cash);
            Controls.Add(Bet);
            Name = "Play_Screen";
            Text = "Form3";
            FormClosed += Play_Screen_FormClosed;
            Load += Play_Screen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox Bet;
        private System.Windows.Forms.TextBox Cash;
        private System.Windows.Forms.Button Deal_Button;
        private System.Windows.Forms.Button Bet_Button;
        private System.Windows.Forms.Button end;
        private System.Windows.Forms.Button Hit_Button;
        private System.Windows.Forms.Button Stand_Button;
        private System.Windows.Forms.Button Double_Button;
    }
}