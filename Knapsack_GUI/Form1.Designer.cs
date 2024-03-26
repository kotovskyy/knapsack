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
            programTextBox = new TextBox();
            resultTextBox = new TextBox();
            seedLabel = new Label();
            capacityLabel = new Label();
            SuspendLayout();
            // 
            // itemsNumTextBox
            // 
            itemsNumTextBox.AccessibleDescription = "Number of Items";
            itemsNumTextBox.AccessibleName = "ItemsNumberBox";
            itemsNumTextBox.Location = new Point(44, 48);
            itemsNumTextBox.Name = "itemsNumTextBox";
            itemsNumTextBox.Size = new Size(222, 27);
            itemsNumTextBox.TabIndex = 0;
            itemsNumTextBox.TextChanged += itemsNumTextBox_TextChanged;
            // 
            // seedTextBox
            // 
            seedTextBox.Location = new Point(44, 119);
            seedTextBox.Name = "seedTextBox";
            seedTextBox.Size = new Size(222, 27);
            seedTextBox.TabIndex = 1;
            seedTextBox.TextChanged += seedTextBox_TextChanged;
            // 
            // capacityTextBox
            // 
            capacityTextBox.Location = new Point(44, 189);
            capacityTextBox.Name = "capacityTextBox";
            capacityTextBox.Size = new Size(222, 27);
            capacityTextBox.TabIndex = 2;
            capacityTextBox.TextChanged += capacityTextBox_TextChanged;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(94, 437);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(125, 36);
            calculateButton.TabIndex = 3;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButtonClick;
            // 
            // itemsNumLabel
            // 
            itemsNumLabel.AutoSize = true;
            itemsNumLabel.Location = new Point(44, 25);
            itemsNumLabel.Name = "itemsNumLabel";
            itemsNumLabel.Size = new Size(121, 20);
            itemsNumLabel.TabIndex = 4;
            itemsNumLabel.Text = "Number of Items";
            // 
            // programTextBox
            // 
            programTextBox.Location = new Point(313, 25);
            programTextBox.Multiline = true;
            programTextBox.Name = "programTextBox";
            programTextBox.ReadOnly = true;
            programTextBox.ScrollBars = ScrollBars.Vertical;
            programTextBox.Size = new Size(454, 448);
            programTextBox.TabIndex = 5;
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(44, 244);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.Size = new Size(218, 155);
            resultTextBox.TabIndex = 6;
            // 
            // seedLabel
            // 
            seedLabel.AutoSize = true;
            seedLabel.Location = new Point(44, 96);
            seedLabel.Name = "seedLabel";
            seedLabel.Size = new Size(42, 20);
            seedLabel.TabIndex = 7;
            seedLabel.Text = "Seed";
            // 
            // capacityLabel
            // 
            capacityLabel.AutoSize = true;
            capacityLabel.Location = new Point(44, 166);
            capacityLabel.Name = "capacityLabel";
            capacityLabel.Size = new Size(66, 20);
            capacityLabel.TabIndex = 8;
            capacityLabel.Text = "Capacity";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 503);
            Controls.Add(capacityLabel);
            Controls.Add(seedLabel);
            Controls.Add(resultTextBox);
            Controls.Add(programTextBox);
            Controls.Add(itemsNumLabel);
            Controls.Add(calculateButton);
            Controls.Add(capacityTextBox);
            Controls.Add(seedTextBox);
            Controls.Add(itemsNumTextBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox itemsNumTextBox;
        private TextBox seedTextBox;
        private TextBox capacityTextBox;
        private Button calculateButton;
        private Label itemsNumLabel;
        private TextBox programTextBox;
        private TextBox resultTextBox;
        private Label seedLabel;
        private Label capacityLabel;
    }
}
