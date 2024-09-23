namespace binary_digit_helper
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
            chk1 = new CheckBox();
            chk2 = new CheckBox();
            chk4 = new CheckBox();
            chk8 = new CheckBox();
            chk16 = new CheckBox();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl4 = new Label();
            lbl8 = new Label();
            lbl16 = new Label();
            lbldecvalue = new Label();
            SuspendLayout();
            // 
            // chk1
            // 
            chk1.AutoSize = true;
            chk1.CheckAlign = ContentAlignment.TopCenter;
            chk1.Font = new Font("Segoe UI", 15F);
            chk1.Location = new Point(427, 256);
            chk1.Name = "chk1";
            chk1.Size = new Size(27, 46);
            chk1.TabIndex = 0;
            chk1.Text = "0";
            chk1.TextAlign = ContentAlignment.MiddleCenter;
            chk1.UseVisualStyleBackColor = true;
            chk1.CheckedChanged += chk1_CheckedChanged;
            chk1.CheckStateChanged += chk1_CheckStateChanged;
            // 
            // chk2
            // 
            chk2.AccessibleRole = AccessibleRole.None;
            chk2.AutoSize = true;
            chk2.CheckAlign = ContentAlignment.TopCenter;
            chk2.Font = new Font("Segoe UI", 15F);
            chk2.Location = new Point(397, 256);
            chk2.Name = "chk2";
            chk2.Size = new Size(27, 46);
            chk2.TabIndex = 1;
            chk2.Text = "0";
            chk2.TextAlign = ContentAlignment.MiddleCenter;
            chk2.UseVisualStyleBackColor = true;
            chk2.CheckedChanged += chk2_CheckedChanged;
            // 
            // chk4
            // 
            chk4.AccessibleRole = AccessibleRole.None;
            chk4.AutoSize = true;
            chk4.CheckAlign = ContentAlignment.TopCenter;
            chk4.Font = new Font("Segoe UI", 15F);
            chk4.Location = new Point(364, 256);
            chk4.Name = "chk4";
            chk4.Size = new Size(27, 46);
            chk4.TabIndex = 2;
            chk4.Text = "0";
            chk4.TextAlign = ContentAlignment.MiddleCenter;
            chk4.UseVisualStyleBackColor = true;
            // 
            // chk8
            // 
            chk8.AccessibleRole = AccessibleRole.None;
            chk8.AutoSize = true;
            chk8.CheckAlign = ContentAlignment.TopCenter;
            chk8.Font = new Font("Segoe UI", 15F);
            chk8.Location = new Point(331, 256);
            chk8.Name = "chk8";
            chk8.Size = new Size(27, 46);
            chk8.TabIndex = 3;
            chk8.Text = "0";
            chk8.TextAlign = ContentAlignment.MiddleCenter;
            chk8.UseVisualStyleBackColor = true;
            // 
            // chk16
            // 
            chk16.AccessibleRole = AccessibleRole.None;
            chk16.AutoSize = true;
            chk16.CheckAlign = ContentAlignment.TopCenter;
            chk16.Font = new Font("Segoe UI", 15F);
            chk16.Location = new Point(298, 256);
            chk16.Name = "chk16";
            chk16.Size = new Size(27, 46);
            chk16.TabIndex = 4;
            chk16.Text = "0";
            chk16.TextAlign = ContentAlignment.MiddleCenter;
            chk16.UseVisualStyleBackColor = true;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 15F);
            lbl1.Location = new Point(427, 225);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(23, 28);
            lbl1.TabIndex = 5;
            lbl1.Text = "1";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI", 15F);
            lbl2.Location = new Point(397, 225);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(23, 28);
            lbl2.TabIndex = 6;
            lbl2.Text = "2";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Segoe UI", 15F);
            lbl4.Location = new Point(364, 225);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(23, 28);
            lbl4.TabIndex = 7;
            lbl4.Text = "4";
            // 
            // lbl8
            // 
            lbl8.AutoSize = true;
            lbl8.Font = new Font("Segoe UI", 15F);
            lbl8.Location = new Point(331, 225);
            lbl8.Name = "lbl8";
            lbl8.Size = new Size(23, 28);
            lbl8.TabIndex = 8;
            lbl8.Text = "8";
            // 
            // lbl16
            // 
            lbl16.AutoSize = true;
            lbl16.Font = new Font("Segoe UI", 15F);
            lbl16.Location = new Point(298, 225);
            lbl16.Name = "lbl16";
            lbl16.Size = new Size(34, 28);
            lbl16.TabIndex = 9;
            lbl16.Text = "16";
            // 
            // lbldecvalue
            // 
            lbldecvalue.AutoSize = true;
            lbldecvalue.Font = new Font("Segoe UI", 15F);
            lbldecvalue.Location = new Point(354, 164);
            lbldecvalue.Name = "lbldecvalue";
            lbldecvalue.Size = new Size(23, 28);
            lbldecvalue.TabIndex = 10;
            lbldecvalue.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbldecvalue);
            Controls.Add(lbl16);
            Controls.Add(lbl8);
            Controls.Add(lbl4);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(chk16);
            Controls.Add(chk8);
            Controls.Add(chk4);
            Controls.Add(chk2);
            Controls.Add(chk1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chk1;
        private CheckBox chk2;
        private CheckBox chk4;
        private CheckBox chk8;
        private CheckBox chk16;
        private Label lbl1;
        private Label lbl2;
        private Label lbl4;
        private Label lbl8;
        private Label lbl16;
        private Label lbldecvalue;
    }
}
