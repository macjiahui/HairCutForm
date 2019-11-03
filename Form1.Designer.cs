namespace lab3b
{
    partial class Form1
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
            this.hairdresserComboBox = new System.Windows.Forms.ComboBox();
            this.serviceListBox = new System.Windows.Forms.ListBox();
            this.hairdresserGroupBox = new System.Windows.Forms.GroupBox();
            this.serviceGroupBox = new System.Windows.Forms.GroupBox();
            this.ItemGroupBox = new System.Windows.Forms.GroupBox();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.priceGroupBox = new System.Windows.Forms.GroupBox();
            this.priceListBox = new System.Windows.Forms.ListBox();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.addServiceButton = new System.Windows.Forms.Button();
            this.calculateTotalPriceButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.hairdresserGroupBox.SuspendLayout();
            this.serviceGroupBox.SuspendLayout();
            this.ItemGroupBox.SuspendLayout();
            this.priceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // hairdresserComboBox
            // 
            this.hairdresserComboBox.FormattingEnabled = true;
            this.hairdresserComboBox.Items.AddRange(new object[] {
            "Jane Samley",
            "Pat Johnson",
            "Ron Chambers",
            "Sue Pallon",
            "Laura Renkins"});
            this.hairdresserComboBox.Location = new System.Drawing.Point(4, 17);
            this.hairdresserComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hairdresserComboBox.Name = "hairdresserComboBox";
            this.hairdresserComboBox.Size = new System.Drawing.Size(135, 21);
            this.hairdresserComboBox.TabIndex = 1;
            this.hairdresserComboBox.Text = "Jane Samley";
            this.hairdresserComboBox.UseWaitCursor = true;
            // 
            // serviceListBox
            // 
            this.serviceListBox.FormattingEnabled = true;
            this.serviceListBox.Items.AddRange(new object[] {
            "Cut",
            "Wash, blow-dry, and style",
            "Colour",
            "Highlights",
            "Extensions",
            "Up-do"});
            this.serviceListBox.Location = new System.Drawing.Point(4, 17);
            this.serviceListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.serviceListBox.Name = "serviceListBox";
            this.serviceListBox.Size = new System.Drawing.Size(142, 95);
            this.serviceListBox.TabIndex = 3;
            // 
            // hairdresserGroupBox
            // 
            this.hairdresserGroupBox.Controls.Add(this.hairdresserComboBox);
            this.hairdresserGroupBox.Location = new System.Drawing.Point(9, 10);
            this.hairdresserGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hairdresserGroupBox.Name = "hairdresserGroupBox";
            this.hairdresserGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hairdresserGroupBox.Size = new System.Drawing.Size(150, 124);
            this.hairdresserGroupBox.TabIndex = 5;
            this.hairdresserGroupBox.TabStop = false;
            this.hairdresserGroupBox.Text = "Select a Hairdresser:";
            // 
            // serviceGroupBox
            // 
            this.serviceGroupBox.Controls.Add(this.serviceListBox);
            this.serviceGroupBox.Location = new System.Drawing.Point(164, 10);
            this.serviceGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.serviceGroupBox.Name = "serviceGroupBox";
            this.serviceGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.serviceGroupBox.Size = new System.Drawing.Size(150, 124);
            this.serviceGroupBox.TabIndex = 6;
            this.serviceGroupBox.TabStop = false;
            this.serviceGroupBox.Text = "Select a Service:";
            // 
            // ItemGroupBox
            // 
            this.ItemGroupBox.Controls.Add(this.itemListBox);
            this.ItemGroupBox.Location = new System.Drawing.Point(318, 11);
            this.ItemGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ItemGroupBox.Name = "ItemGroupBox";
            this.ItemGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ItemGroupBox.Size = new System.Drawing.Size(150, 123);
            this.ItemGroupBox.TabIndex = 7;
            this.ItemGroupBox.TabStop = false;
            this.ItemGroupBox.Text = "Charged Items:";
            // 
            // itemListBox
            // 
            this.itemListBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.Location = new System.Drawing.Point(4, 17);
            this.itemListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(142, 95);
            this.itemListBox.TabIndex = 10;
            // 
            // priceGroupBox
            // 
            this.priceGroupBox.Controls.Add(this.priceListBox);
            this.priceGroupBox.Location = new System.Drawing.Point(472, 11);
            this.priceGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.priceGroupBox.Name = "priceGroupBox";
            this.priceGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.priceGroupBox.Size = new System.Drawing.Size(79, 123);
            this.priceGroupBox.TabIndex = 8;
            this.priceGroupBox.TabStop = false;
            this.priceGroupBox.Text = "Price:";
            // 
            // priceListBox
            // 
            this.priceListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priceListBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.priceListBox.FormattingEnabled = true;
            this.priceListBox.Location = new System.Drawing.Point(4, 17);
            this.priceListBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.priceListBox.Name = "priceListBox";
            this.priceListBox.Size = new System.Drawing.Size(68, 95);
            this.priceListBox.TabIndex = 11;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(389, 152);
            this.totalPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(61, 13);
            this.totalPriceLabel.TabIndex = 0;
            this.totalPriceLabel.Text = "Total Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.priceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceTextBox.Location = new System.Drawing.Point(454, 150);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(98, 20);
            this.priceTextBox.TabIndex = 9;
            this.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addServiceButton
            // 
            this.addServiceButton.Location = new System.Drawing.Point(136, 182);
            this.addServiceButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addServiceButton.Name = "addServiceButton";
            this.addServiceButton.Size = new System.Drawing.Size(100, 19);
            this.addServiceButton.TabIndex = 11;
            this.addServiceButton.Text = "Add Service";
            this.addServiceButton.UseVisualStyleBackColor = true;
            this.addServiceButton.Click += new System.EventHandler(this.addServiceButton_Click);
            // 
            // calculateTotalPriceButton
            // 
            this.calculateTotalPriceButton.Location = new System.Drawing.Point(241, 182);
            this.calculateTotalPriceButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calculateTotalPriceButton.Name = "calculateTotalPriceButton";
            this.calculateTotalPriceButton.Size = new System.Drawing.Size(100, 19);
            this.calculateTotalPriceButton.TabIndex = 12;
            this.calculateTotalPriceButton.Text = "Calculate Total Price";
            this.calculateTotalPriceButton.UseVisualStyleBackColor = true;
            this.calculateTotalPriceButton.Click += new System.EventHandler(this.calculateTotalPriceButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(346, 182);
            this.resetButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(100, 19);
            this.resetButton.TabIndex = 13;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(451, 182);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 19);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 211);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.calculateTotalPriceButton);
            this.Controls.Add(this.addServiceButton);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.priceGroupBox);
            this.Controls.Add(this.ItemGroupBox);
            this.Controls.Add(this.serviceGroupBox);
            this.Controls.Add(this.hairdresserGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Perfect Cut Hair Salon";
            this.hairdresserGroupBox.ResumeLayout(false);
            this.serviceGroupBox.ResumeLayout(false);
            this.ItemGroupBox.ResumeLayout(false);
            this.priceGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox hairdresserComboBox;
        private System.Windows.Forms.ListBox serviceListBox;
        private System.Windows.Forms.GroupBox hairdresserGroupBox;
        private System.Windows.Forms.GroupBox serviceGroupBox;
        private System.Windows.Forms.GroupBox ItemGroupBox;
        private System.Windows.Forms.ListBox itemListBox;
        private System.Windows.Forms.GroupBox priceGroupBox;
        private System.Windows.Forms.ListBox priceListBox;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button addServiceButton;
        private System.Windows.Forms.Button calculateTotalPriceButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
    }
}

