namespace bootCamp2
{
    partial class userRegistration
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            backButton1 = new Button();
            registerButton2 = new Button();
            userNameTextBox = new TextBox();
            emailTextBox = new TextBox();
            pwTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(226, 113);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(226, 173);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "Email ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(226, 237);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // backButton1
            // 
            backButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            backButton1.Location = new Point(41, 389);
            backButton1.Name = "backButton1";
            backButton1.Size = new Size(66, 29);
            backButton1.TabIndex = 3;
            backButton1.Text = "Back";
            backButton1.UseVisualStyleBackColor = true;
            backButton1.Click += backButton1_Click;
            // 
            // registerButton2
            // 
            registerButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerButton2.Location = new Point(420, 304);
            registerButton2.Name = "registerButton2";
            registerButton2.Size = new Size(86, 29);
            registerButton2.TabIndex = 4;
            registerButton2.Text = "Register";
            registerButton2.UseVisualStyleBackColor = true;
            registerButton2.Click += registerButton2_Click;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(376, 106);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(176, 27);
            userNameTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(376, 166);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(176, 27);
            emailTextBox.TabIndex = 6;
            // 
            // pwTextBox
            // 
            pwTextBox.Location = new Point(376, 230);
            pwTextBox.Name = "pwTextBox";
            pwTextBox.Size = new Size(176, 27);
            pwTextBox.TabIndex = 7;
            // 
            // userRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(800, 450);
            Controls.Add(pwTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(registerButton2);
            Controls.Add(backButton1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "userRegistration";
            Text = "userRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button backButton1;
        private Button registerButton2;
        private TextBox userNameTextBox;
        private TextBox emailTextBox;
        private TextBox pwTextBox;
    }
}