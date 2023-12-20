namespace Black_Jack_team
{
    partial class Rule_Screen
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
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            Back = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            Rule = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(34, 194);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(153, 70);
            button1.TabIndex = 0;
            button1.Text = "前へ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(975, 194);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(141, 70);
            button2.TabIndex = 1;
            button2.Text = "次へ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Back
            // 
            Back.Location = new System.Drawing.Point(975, 367);
            Back.Name = "Back";
            Back.Size = new System.Drawing.Size(141, 70);
            Back.TabIndex = 1;
            Back.Text = "TOPに戻る";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._9;
            pictureBox1.Location = new System.Drawing.Point(368, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(454, 437);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Rule
            // 
            Rule.AutoSize = true;
            Rule.Font = new System.Drawing.Font("Yu Gothic UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Rule.Location = new System.Drawing.Point(12, 9);
            Rule.Name = "Rule";
            Rule.Size = new System.Drawing.Size(143, 67);
            Rule.TabIndex = 4;
            Rule.Text = "ルール";
            // 
            // Rule_Screen
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.image;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1148, 449);
            Controls.Add(Rule);
            Controls.Add(Back);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "Rule_Screen";
            Text = "Form3_RuleScreen";
            FormClosed += Rule_Screen_FormClosed;
            Load += Rule_Screen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Rule;
    }
}