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
            Rule_Button.Location = new System.Drawing.Point(448, 340);
            Rule_Button.Name = "Rule_Button";
            Rule_Button.Size = new System.Drawing.Size(269, 105);
            Rule_Button.TabIndex = 1;
            Rule_Button.Text = "ルール";
            Rule_Button.UseVisualStyleBackColor = true;
            Rule_Button.Click += Rule_Button_Click;
            // 
            // Top_Screen
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1154, 500);
            Controls.Add(Rule_Button);
            Controls.Add(Start_Button);
            Name = "Top_Screen";
            Text = "Form1";
            FormClosed += Top_Screen_FormClosed;
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Button Rule_Button;
    }
}
