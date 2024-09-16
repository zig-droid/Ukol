namespace Zkoska
{
    partial class RegisterWindow
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
            txtName = new TextBox();
            txtPrijmeni = new TextBox();
            txtPrezdivka = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            hesloLabel = new Label();
            txtHeslo = new TextBox();
            button1 = new Button();
            btnRegistrrovat = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(64, 89);
            txtName.Name = "txtName";
            txtName.Size = new Size(164, 23);
            txtName.TabIndex = 0;
            // 
            // txtPrijmeni
            // 
            txtPrijmeni.Location = new Point(64, 177);
            txtPrijmeni.Name = "txtPrijmeni";
            txtPrijmeni.Size = new Size(164, 23);
            txtPrijmeni.TabIndex = 1;
            // 
            // txtPrezdivka
            // 
            txtPrezdivka.Location = new Point(64, 264);
            txtPrezdivka.Name = "txtPrezdivka";
            txtPrezdivka.Size = new Size(164, 23);
            txtPrezdivka.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(66, 52);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 3;
            label1.Text = "Zadejte Jméno";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(66, 143);
            label2.Name = "label2";
            label2.Size = new Size(123, 21);
            label2.TabIndex = 4;
            label2.Text = "Zadejte Příjmení";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(66, 230);
            label3.Name = "label3";
            label3.Size = new Size(136, 19);
            label3.TabIndex = 5;
            label3.Text = "Zadej svoji přezdívku";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // hesloLabel
            // 
            hesloLabel.AutoSize = true;
            hesloLabel.Font = new Font("Segoe UI", 10F);
            hesloLabel.Location = new Point(66, 310);
            hesloLabel.Name = "hesloLabel";
            hesloLabel.Size = new Size(90, 19);
            hesloLabel.TabIndex = 6;
            hesloLabel.Text = "Zadejte heslo";
            // 
            // txtHeslo
            // 
            txtHeslo.Location = new Point(64, 343);
            txtHeslo.Name = "txtHeslo";
            txtHeslo.Size = new Size(164, 23);
            txtHeslo.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnRegistrrovat
            // 
            btnRegistrrovat.Location = new Point(89, 392);
            btnRegistrrovat.Name = "btnRegistrrovat";
            btnRegistrrovat.Size = new Size(100, 23);
            btnRegistrrovat.TabIndex = 9;
            btnRegistrrovat.Text = "Registrovat";
            btnRegistrrovat.UseVisualStyleBackColor = true;
            btnRegistrrovat.Click += btnRegistrrovat_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(89, 445);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 23);
            btnExit.TabIndex = 10;
            btnExit.Text = "Zpět";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // RegisterWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 480);
            Controls.Add(btnExit);
            Controls.Add(btnRegistrrovat);
            Controls.Add(button1);
            Controls.Add(txtHeslo);
            Controls.Add(hesloLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrezdivka);
            Controls.Add(txtPrijmeni);
            Controls.Add(txtName);
            Name = "RegisterWindow";
            Text = "RegisterWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtPrijmeni;
        private TextBox txtPrezdivka;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label hesloLabel;
        private TextBox txtHeslo;
        private Button button1;
        private Button btnRegistrrovat;
        private Button btnExit;
    }
}