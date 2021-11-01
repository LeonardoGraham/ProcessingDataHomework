
namespace ProcessingDataHomework
{
    partial class EstimatorForm
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
            this.EstimateButton = new System.Windows.Forms.Button();
            this.WallSpaceSizeLabel = new System.Windows.Forms.Label();
            this.WallSpaceSizeTextBox = new System.Windows.Forms.TextBox();
            this.SqFtLabel = new System.Windows.Forms.Label();
            this.PaintPriceLabel = new System.Windows.Forms.Label();
            this.PaintPriceTextBox = new System.Windows.Forms.TextBox();
            this.PerGalLabel = new System.Windows.Forms.Label();
            this.PaintRequiredLabel = new System.Windows.Forms.Label();
            this.LaborRequiredLabel = new System.Windows.Forms.Label();
            this.PaintCostLabel = new System.Windows.Forms.Label();
            this.LaborChargesLabel = new System.Windows.Forms.Label();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EstimateButton
            // 
            this.EstimateButton.Location = new System.Drawing.Point(225, 77);
            this.EstimateButton.Name = "EstimateButton";
            this.EstimateButton.Size = new System.Drawing.Size(80, 30);
            this.EstimateButton.TabIndex = 0;
            this.EstimateButton.Text = "Estimate";
            this.EstimateButton.UseVisualStyleBackColor = true;
            this.EstimateButton.Click += new System.EventHandler(this.EstimateButton_Click);
            // 
            // WallSpaceSizeLabel
            // 
            this.WallSpaceSizeLabel.AutoSize = true;
            this.WallSpaceSizeLabel.Location = new System.Drawing.Point(100, 9);
            this.WallSpaceSizeLabel.Name = "WallSpaceSizeLabel";
            this.WallSpaceSizeLabel.Size = new System.Drawing.Size(123, 15);
            this.WallSpaceSizeLabel.TabIndex = 1;
            this.WallSpaceSizeLabel.Text = "Enter Wall Space Size: ";
            // 
            // WallSpaceSizeTextBox
            // 
            this.WallSpaceSizeTextBox.Location = new System.Drawing.Point(225, 6);
            this.WallSpaceSizeTextBox.Name = "WallSpaceSizeTextBox";
            this.WallSpaceSizeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WallSpaceSizeTextBox.Size = new System.Drawing.Size(100, 23);
            this.WallSpaceSizeTextBox.TabIndex = 2;
            // 
            // SqFtLabel
            // 
            this.SqFtLabel.AutoSize = true;
            this.SqFtLabel.Location = new System.Drawing.Point(331, 9);
            this.SqFtLabel.Name = "SqFtLabel";
            this.SqFtLabel.Size = new System.Drawing.Size(36, 15);
            this.SqFtLabel.TabIndex = 3;
            this.SqFtLabel.Text = "sq. ft.";
            // 
            // PaintPriceLabel
            // 
            this.PaintPriceLabel.AutoSize = true;
            this.PaintPriceLabel.Location = new System.Drawing.Point(115, 41);
            this.PaintPriceLabel.Name = "PaintPriceLabel";
            this.PaintPriceLabel.Size = new System.Drawing.Size(108, 15);
            this.PaintPriceLabel.TabIndex = 4;
            this.PaintPriceLabel.Text = "Enter Paint Price:  $";
            // 
            // PaintPriceTextBox
            // 
            this.PaintPriceTextBox.Location = new System.Drawing.Point(225, 38);
            this.PaintPriceTextBox.Name = "PaintPriceTextBox";
            this.PaintPriceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PaintPriceTextBox.Size = new System.Drawing.Size(100, 23);
            this.PaintPriceTextBox.TabIndex = 5;
            // 
            // PerGalLabel
            // 
            this.PerGalLabel.AutoSize = true;
            this.PerGalLabel.Location = new System.Drawing.Point(331, 38);
            this.PerGalLabel.Name = "PerGalLabel";
            this.PerGalLabel.Size = new System.Drawing.Size(43, 15);
            this.PerGalLabel.TabIndex = 6;
            this.PerGalLabel.Text = "per gal";
            // 
            // PaintRequiredLabel
            // 
            this.PaintRequiredLabel.AutoSize = true;
            this.PaintRequiredLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PaintRequiredLabel.Location = new System.Drawing.Point(229, 128);
            this.PaintRequiredLabel.Name = "PaintRequiredLabel";
            this.PaintRequiredLabel.Size = new System.Drawing.Size(0, 15);
            this.PaintRequiredLabel.TabIndex = 7;
            // 
            // LaborRequiredLabel
            // 
            this.LaborRequiredLabel.AutoSize = true;
            this.LaborRequiredLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LaborRequiredLabel.Location = new System.Drawing.Point(229, 147);
            this.LaborRequiredLabel.Name = "LaborRequiredLabel";
            this.LaborRequiredLabel.Size = new System.Drawing.Size(0, 15);
            this.LaborRequiredLabel.TabIndex = 8;
            // 
            // PaintCostLabel
            // 
            this.PaintCostLabel.AutoSize = true;
            this.PaintCostLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PaintCostLabel.Location = new System.Drawing.Point(229, 166);
            this.PaintCostLabel.Name = "PaintCostLabel";
            this.PaintCostLabel.Size = new System.Drawing.Size(0, 15);
            this.PaintCostLabel.TabIndex = 9;
            // 
            // LaborChargesLabel
            // 
            this.LaborChargesLabel.AutoSize = true;
            this.LaborChargesLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LaborChargesLabel.Location = new System.Drawing.Point(229, 185);
            this.LaborChargesLabel.Name = "LaborChargesLabel";
            this.LaborChargesLabel.Size = new System.Drawing.Size(0, 15);
            this.LaborChargesLabel.TabIndex = 10;
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalCostLabel.Location = new System.Drawing.Point(229, 204);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(0, 15);
            this.TotalCostLabel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Number of gallons of paint required: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Hours of labor required: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cost of paint: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Labor charges: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total Cost: ";
            // 
            // EstimatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 231);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalCostLabel);
            this.Controls.Add(this.LaborChargesLabel);
            this.Controls.Add(this.PaintCostLabel);
            this.Controls.Add(this.LaborRequiredLabel);
            this.Controls.Add(this.PaintRequiredLabel);
            this.Controls.Add(this.PerGalLabel);
            this.Controls.Add(this.PaintPriceTextBox);
            this.Controls.Add(this.PaintPriceLabel);
            this.Controls.Add(this.SqFtLabel);
            this.Controls.Add(this.WallSpaceSizeTextBox);
            this.Controls.Add(this.WallSpaceSizeLabel);
            this.Controls.Add(this.EstimateButton);
            this.Name = "EstimatorForm";
            this.Text = "Paint Job Estimator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EstimateButton;
        private System.Windows.Forms.Label WallSpaceSizeLabel;
        private System.Windows.Forms.TextBox WallSpaceSizeTextBox;
        private System.Windows.Forms.Label SqFtLabel;
        private System.Windows.Forms.Label PaintPriceLabel;
        private System.Windows.Forms.TextBox PaintPriceTextBox;
        private System.Windows.Forms.Label PerGalLabel;
        private System.Windows.Forms.Label PaintRequiredLabel;
        private System.Windows.Forms.Label LaborRequiredLabel;
        private System.Windows.Forms.Label PaintCostLabel;
        private System.Windows.Forms.Label LaborChargesLabel;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

