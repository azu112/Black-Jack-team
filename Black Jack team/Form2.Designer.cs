namespace Black_Jack_team
{
    partial class Form2
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
            textBox1 = new System.Windows.Forms.TextBox();
            left = new System.Windows.Forms.Button();
            right = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Yu Gothic UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox1.Location = new System.Drawing.Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(125, 63);
            textBox1.TabIndex = 0;
            textBox1.Text = "ルール";
            textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // left
            // 
            left.Location = new System.Drawing.Point(32, 219);
            left.Name = "left";
            left.Size = new System.Drawing.Size(94, 29);
            left.TabIndex = 1;
            left.Text = "button1";
            left.UseVisualStyleBackColor = true;
            
            // 
            // right
            // 
            right.Location = new System.Drawing.Point(1042, 219);
            right.Name = "right";
            right.Size = new System.Drawing.Size(94, 29);
            right.TabIndex = 1;
            right.Text = "button1";
            right.UseVisualStyleBackColor = true;
            
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1165, 485);
            Controls.Add(right);
            Controls.Add(left);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button right;
    }
}