namespace bootCamp2
{
    partial class ProductManagement
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
            nameTextBox = new TextBox();
            priceTextBox = new TextBox();
            quantityTextBox = new TextBox();
            addProductButton = new Button();
            logoutButton = new Button();
            viewProductsButton = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 120);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 183);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 1;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(58, 242);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 2;
            label3.Text = "Quantity";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(180, 113);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(149, 27);
            nameTextBox.TabIndex = 3;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(180, 176);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(149, 27);
            priceTextBox.TabIndex = 4;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(180, 239);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(149, 27);
            quantityTextBox.TabIndex = 5;
            // 
            // addProductButton
            // 
            addProductButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addProductButton.Location = new Point(216, 315);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(65, 29);
            addProductButton.TabIndex = 6;
            addProductButton.Text = "Add product";
            addProductButton.UseVisualStyleBackColor = true;
            addProductButton.Click += addProductButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            logoutButton.Location = new Point(33, 396);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(74, 29);
            logoutButton.TabIndex = 7;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // viewProductsButton
            // 
            viewProductsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewProductsButton.Location = new Point(514, 315);
            viewProductsButton.Name = "viewProductsButton";
            viewProductsButton.Size = new Size(119, 29);
            viewProductsButton.TabIndex = 8;
            viewProductsButton.Text = "View products";
            viewProductsButton.UseVisualStyleBackColor = true;
            viewProductsButton.Click += viewProductsButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Azure;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(398, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(343, 153);
            dataGridView1.TabIndex = 9;
            // 
            // ProductManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(viewProductsButton);
            Controls.Add(logoutButton);
            Controls.Add(addProductButton);
            Controls.Add(quantityTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "ProductManagement";
            Text = "ProductManagement";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox nameTextBox;
        private TextBox priceTextBox;
        private TextBox quantityTextBox;
        private Button addProductButton;
        private Button logoutButton;
        private Button viewProductsButton;
        private DataGridView dataGridView1;
    }
}