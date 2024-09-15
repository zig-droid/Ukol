namespace CenaProdanychAut
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
            BtnVybratSoubor = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // BtnVybratSoubor
            // 
            BtnVybratSoubor.Location = new Point(31, 25);
            BtnVybratSoubor.Name = "BtnVybratSoubor";
            BtnVybratSoubor.Size = new Size(172, 32);
            BtnVybratSoubor.TabIndex = 1;
            BtnVybratSoubor.Text = "Vybrat soubor";
            BtnVybratSoubor.UseVisualStyleBackColor = true;
            BtnVybratSoubor.Click += BtnVybratSoubor_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(447, 455);
            dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(540, 92);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(434, 349);
            dataGridView2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(540, 42);
            label1.Name = "label1";
            label1.Size = new Size(169, 15);
            label1.TabIndex = 7;
            label1.Text = "Cena aut prodaných o víkendu";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 594);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(BtnVybratSoubor);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnVybratSoubor;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label1;
    }
}
