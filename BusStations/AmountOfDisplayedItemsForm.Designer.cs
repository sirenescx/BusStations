namespace BusStations
{
    partial class AmountOfDisplayedItemsForm
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
            this.changeAmountButton = new System.Windows.Forms.Button();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // changeAmountButton
            // 
            this.changeAmountButton.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold);
            this.changeAmountButton.ForeColor = System.Drawing.Color.Maroon;
            this.changeAmountButton.Location = new System.Drawing.Point(106, 108);
            this.changeAmountButton.Name = "changeAmountButton";
            this.changeAmountButton.Size = new System.Drawing.Size(87, 35);
            this.changeAmountButton.TabIndex = 5;
            this.changeAmountButton.Text = "OK";
            this.changeAmountButton.UseVisualStyleBackColor = true;
            this.changeAmountButton.Click += new System.EventHandler(this.ChangeAmountButton_Click);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold);
            this.amountLabel.ForeColor = System.Drawing.Color.DimGray;
            this.amountLabel.Location = new System.Drawing.Point(63, 20);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(176, 44);
            this.amountLabel.TabIndex = 4;
            this.amountLabel.Text = "enter amount of \r\ndisplayed items";
            this.amountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(65, 73);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(170, 22);
            this.amountTextBox.TabIndex = 3;
            // 
            // AmountOfDisplayedItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(300, 157);
            this.Controls.Add(this.changeAmountButton);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AmountOfDisplayedItemsForm";
            this.Text = "Change amount of displayed items";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeAmountButton;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox amountTextBox;
    }
}