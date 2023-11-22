namespace Black_Jack_team
{
    partial class Form3
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
            Deal_screen = new System.Windows.Forms.Button();
            Bet_Screen = new System.Windows.Forms.Button();
            end = new System.Windows.Forms.Button();
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
            // Deal_screen
            // 
            Deal_screen.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Deal_screen.Location = new System.Drawing.Point(503, 244);
            Deal_screen.Name = "Deal_screen";
            Deal_screen.Size = new System.Drawing.Size(143, 66);
            Deal_screen.TabIndex = 1;
            Deal_screen.Text = "Deal";
            Deal_screen.UseVisualStyleBackColor = true;
            Deal_screen.Click += Deal_screen_Click;
            // 
            // Bet_Screen
            // 
            Bet_Screen.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Bet_Screen.Location = new System.Drawing.Point(503, 339);
            Bet_Screen.Name = "Bet_Screen";
            Bet_Screen.Size = new System.Drawing.Size(143, 70);
            Bet_Screen.TabIndex = 1;
            Bet_Screen.Text = "Bet";
            Bet_Screen.UseVisualStyleBackColor = true;
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
            // 
            // Form3
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1107, 497);
            Controls.Add(end);
            Controls.Add(Bet_Screen);
            Controls.Add(Deal_screen);
            Controls.Add(Cash);
            Controls.Add(Bet);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox Bet;
        private System.Windows.Forms.TextBox Cash;
        private System.Windows.Forms.Button Deal_screen;
        private System.Windows.Forms.Button Bet_Screen;
        private System.Windows.Forms.Button end;
    }
}