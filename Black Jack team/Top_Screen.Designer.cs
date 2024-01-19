namespace Black_Jack_team
{
    partial class Top_Screen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Start_Button = new System.Windows.Forms.Button();
            Rule_Button = new System.Windows.Forms.Button();
            Title = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // Start_Button
            // 
            Start_Button.Font = new System.Drawing.Font("Yu Gothic UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Start_Button.Location = new System.Drawing.Point(448, 196);
            Start_Button.Name = "Start_Button";
            Start_Button.Size = new System.Drawing.Size(269, 116);
            Start_Button.TabIndex = 1;
            Start_Button.Text = "スタート";
            Start_Button.UseVisualStyleBackColor = true;
            Start_Button.Click += Start_Button_Click;
            // 
            // Rule_Button
            // 
            Rule_Button.Font = new System.Drawing.Font("Yu Gothic UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Rule_Button.Location = new System.Drawing.Point(448, 343);
            Rule_Button.Name = "Rule_Button";
            Rule_Button.Size = new System.Drawing.Size(269, 105);
            Rule_Button.TabIndex = 1;
            Rule_Button.Text = "ルール";
            Rule_Button.UseVisualStyleBackColor = true;
            Rule_Button.Click += Rule_Button_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new System.Drawing.Font("Yu Gothic UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Title.Location = new System.Drawing.Point(193, 34);
            Title.Name = "Title";
            Title.Size = new System.Drawing.Size(803, 112);
            Title.TabIndex = 2;
            Title.Text = "ＢＬＡＣＫＪＡＣＫ";
            Title.Click += label1_Click;
            // 
            // Top_Screen
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.image;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1183, 500);
            Controls.Add(Title);
            Controls.Add(Rule_Button);
            Controls.Add(Start_Button);
            DoubleBuffered = true;
            Name = "Top_Screen";
            Text = "Form1";
            FormClosed += Top_Screen_FormClosed;
            Load += Top_Screen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Button Rule_Button;
        private System.Windows.Forms.Label Title;
    }
}
