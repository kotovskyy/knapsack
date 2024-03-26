namespace Knapsack_GUI
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
            itemsNumTextBox = new TextBox();
            seedTextBox = new TextBox();
            capacityTextBox = new TextBox();
            calculateButton = new Button();
            itemsNumLabel = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            itemsNumTextBox.AccessibleDescription = "Number of Items";
            itemsNumTextBox.AccessibleName = "ItemsNumberBox";
            itemsNumTextBox.Location = new Point(44, 48);
            itemsNumTextBox.Name = "textBox1";
            itemsNumTextBox.Size = new Size(125, 27);
            itemsNumTextBox.TabIndex = 0;
            // 
            // textBox2
            // 
            seedTextBox.Location = new Point(44, 130);
            seedTextBox.Name = "textBox2";
            seedTextBox.Size = new Size(125, 27);
            seedTextBox.TabIndex = 1;
            // 
            // textBox3
            // 
            capacityTextBox.Location = new Point(44, 211);
            capacityTextBox.Name = "textBox3";
            capacityTextBox.Size = new Size(125, 27);
            capacityTextBox.TabIndex = 2;
            // 
            // button1
            // 
            calculateButton.Location = new Point(44, 405);
            calculateButton.Name = "CalculateButton";
            calculateButton.Size = new Size(125, 36);
            calculateButton.TabIndex = 3;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += button1_Click;
            // 
            // label1
            // 
            itemsNumLabel.AutoSize = true;
            itemsNumLabel.Location = new Point(44, 25);
            itemsNumLabel.Name = "NumOfItemsLabel";
            itemsNumLabel.Size = new Size(50, 20);
            itemsNumLabel.TabIndex = 4;
            itemsNumLabel.Text = "Number of Items";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 503);
            Controls.Add(itemsNumLabel);
            Controls.Add(calculateButton);
            Controls.Add(capacityTextBox);
            Controls.Add(seedTextBox);
            Controls.Add(itemsNumTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox itemsNumTextBox;
        private TextBox seedTextBox;
        private TextBox capacityTextBox;
        private Button calculateButton;
        private Label itemsNumLabel;
    }
}
