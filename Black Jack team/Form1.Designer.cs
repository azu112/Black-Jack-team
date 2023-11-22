namespace Black_Jack_team
{
    partial class Form1
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
            start = new System.Windows.Forms.Button();
            rule = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // start
            // 
            start.Location = new System.Drawing.Point(454, 197);
            start.Name = "start";
            start.Size = new System.Drawing.Size(228, 79);
            start.TabIndex = 0;
            start.Text = "スタート";
            start.UseVisualStyleBackColor = true;
            start.Click += button1_Click;
            // 
            // rule
            // 
            rule.Location = new System.Drawing.Point(454, 320);
            rule.Name = "rule";
            rule.Size = new System.Drawing.Size(228, 76);
            rule.TabIndex = 0;
            rule.Text = "ルール";
            rule.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(343, 100);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(434, 47);
            textBox1.TabIndex = 1;
            textBox1.Text = "ＢＬＡＣＫＪＡＣＫ";
            textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1107, 450);
            Controls.Add(textBox1);
            Controls.Add(rule);
            Controls.Add(start);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button rule;
        private System.Windows.Forms.TextBox textBox1;
    }
}
