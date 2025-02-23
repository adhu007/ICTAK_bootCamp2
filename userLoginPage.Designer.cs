namespace bootCamp2
{
    partial class userLoginPage
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
            emailTextBox = new TextBox();
            pwTextBox = new TextBox();
            loginButton2 = new Button();
            backButton2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 141);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Email ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(214, 215);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(365, 134);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(204, 27);
            emailTextBox.TabIndex = 2;
            // 
            // pwTextBox
            // 
            pwTextBox.Location = new Point(365, 208);
            pwTextBox.Name = "pwTextBox";
            pwTextBox.Size = new Size(204, 27);
            pwTextBox.TabIndex = 3;
            // 
            // loginButton2
            // 
            loginButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton2.Location = new Point(423, 283);
            loginButton2.Name = "loginButton2";
            loginButton2.Size = new Size(68, 29);
            loginButton2.TabIndex = 4;
            loginButton2.Text = "Login";
            loginButton2.UseVisualStyleBackColor = true;
            loginButton2.Click += loginButton2_Click;
            // 
            // backButton2
            // 
            backButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            backButton2.Location = new Point(38, 390);
            backButton2.Name = "backButton2";
            backButton2.Size = new Size(61, 29);
            backButton2.TabIndex = 5;
            backButton2.Text = "Back";
            backButton2.UseVisualStyleBackColor = true;
            backButton2.Click += backButton2_Click;
            // 
            // userLoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton2);
            Controls.Add(loginButton2);
            Controls.Add(pwTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "userLoginPage";
            Text = "userLoginPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox emailTextBox;
        private TextBox pwTextBox;
        private Button loginButton2;
        private Button backButton2;
    }
}