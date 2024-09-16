namespace Zkoska
{
    partial class Pojistovna
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
            btnRegistrace = new Button();
            SuspendLayout();
            // 
            // btnRegistrace
            // 
            btnRegistrace.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRegistrace.BackColor = SystemColors.Highlight;
            btnRegistrace.BackgroundImageLayout = ImageLayout.Center;
            btnRegistrace.Font = new Font("Segoe UI", 12F);
            btnRegistrace.Location = new Point(665, 29);
            btnRegistrace.Name = "btnRegistrace";
            btnRegistrace.Padding = new Padding(0, 5, 0, 5);
            btnRegistrace.Size = new Size(106, 40);
            btnRegistrace.TabIndex = 0;
            btnRegistrace.Text = "Registrace";
            btnRegistrace.UseVisualStyleBackColor = false;
            btnRegistrace.Click += btnRegistrace_Click;
            // 
            // Pojistovna
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 603);
            Controls.Add(btnRegistrace);
            Font = new Font("Segoe UI", 9F);
            ForeColor = SystemColors.Desktop;
            Name = "Pojistovna";
            RightToLeft = RightToLeft.No;
            RightToLeftLayout = true;
            Text = "Pojišťovna";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistrace;
    }
}
