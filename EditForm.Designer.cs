namespace FarmInterface
{
    partial class EditForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.currentpLabel = new System.Windows.Forms.Label();
            this.locationXLabel = new System.Windows.Forms.Label();
            this.locationYLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.currentpText = new System.Windows.Forms.TextBox();
            this.xLocText = new System.Windows.Forms.TextBox();
            this.yLocText = new System.Windows.Forms.TextBox();
            this.lengthText = new System.Windows.Forms.TextBox();
            this.widthText = new System.Windows.Forms.TextBox();
            this.heightText = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.itemRadio = new System.Windows.Forms.RadioButton();
            this.itemContainerRadio = new System.Windows.Forms.RadioButton();
            this.purchasepText = new System.Windows.Forms.TextBox();
            this.purchasepLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(76, 70);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(47, 16);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(146, 67);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(176, 22);
            this.nameText.TabIndex = 1;
            // 
            // currentpLabel
            // 
            this.currentpLabel.AutoSize = true;
            this.currentpLabel.Location = new System.Drawing.Point(53, 154);
            this.currentpLabel.Name = "currentpLabel";
            this.currentpLabel.Size = new System.Drawing.Size(86, 16);
            this.currentpLabel.TabIndex = 2;
            this.currentpLabel.Text = "Current Price:";
            // 
            // locationXLabel
            // 
            this.locationXLabel.AutoSize = true;
            this.locationXLabel.Location = new System.Drawing.Point(58, 200);
            this.locationXLabel.Name = "locationXLabel";
            this.locationXLabel.Size = new System.Drawing.Size(71, 16);
            this.locationXLabel.TabIndex = 3;
            this.locationXLabel.Text = "x-Location:";
            // 
            // locationYLabel
            // 
            this.locationYLabel.AutoSize = true;
            this.locationYLabel.Location = new System.Drawing.Point(58, 248);
            this.locationYLabel.Name = "locationYLabel";
            this.locationYLabel.Size = new System.Drawing.Size(72, 16);
            this.locationYLabel.TabIndex = 4;
            this.locationYLabel.Text = "y-Location:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(75, 293);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(50, 16);
            this.lengthLabel.TabIndex = 5;
            this.lengthLabel.Text = "Length:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(75, 336);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(44, 16);
            this.widthLabel.TabIndex = 6;
            this.widthLabel.Text = "Width:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(75, 371);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(49, 16);
            this.heightLabel.TabIndex = 7;
            this.heightLabel.Text = "Height:";
            // 
            // currentpText
            // 
            this.currentpText.Location = new System.Drawing.Point(146, 152);
            this.currentpText.Name = "currentpText";
            this.currentpText.Size = new System.Drawing.Size(176, 22);
            this.currentpText.TabIndex = 8;
            // 
            // xLocText
            // 
            this.xLocText.Location = new System.Drawing.Point(146, 194);
            this.xLocText.Name = "xLocText";
            this.xLocText.Size = new System.Drawing.Size(176, 22);
            this.xLocText.TabIndex = 9;
            // 
            // yLocText
            // 
            this.yLocText.Location = new System.Drawing.Point(146, 242);
            this.yLocText.Name = "yLocText";
            this.yLocText.Size = new System.Drawing.Size(176, 22);
            this.yLocText.TabIndex = 10;
            // 
            // lengthText
            // 
            this.lengthText.Location = new System.Drawing.Point(146, 287);
            this.lengthText.Name = "lengthText";
            this.lengthText.Size = new System.Drawing.Size(176, 22);
            this.lengthText.TabIndex = 11;
            // 
            // widthText
            // 
            this.widthText.Location = new System.Drawing.Point(146, 330);
            this.widthText.Name = "widthText";
            this.widthText.Size = new System.Drawing.Size(176, 22);
            this.widthText.TabIndex = 12;
            // 
            // heightText
            // 
            this.heightText.Location = new System.Drawing.Point(146, 371);
            this.heightText.Name = "heightText";
            this.heightText.Size = new System.Drawing.Size(176, 22);
            this.heightText.TabIndex = 13;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(186, 419);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // itemRadio
            // 
            this.itemRadio.AutoSize = true;
            this.itemRadio.Location = new System.Drawing.Point(110, 12);
            this.itemRadio.Name = "itemRadio";
            this.itemRadio.Size = new System.Drawing.Size(81, 20);
            this.itemRadio.TabIndex = 15;
            this.itemRadio.TabStop = true;
            this.itemRadio.Text = "Add Item";
            this.itemRadio.UseVisualStyleBackColor = true;
            this.itemRadio.Visible = false;
            // 
            // itemContainerRadio
            // 
            this.itemContainerRadio.AutoSize = true;
            this.itemContainerRadio.Location = new System.Drawing.Point(270, 12);
            this.itemContainerRadio.Name = "itemContainerRadio";
            this.itemContainerRadio.Size = new System.Drawing.Size(113, 20);
            this.itemContainerRadio.TabIndex = 16;
            this.itemContainerRadio.TabStop = true;
            this.itemContainerRadio.Text = "Add Container";
            this.itemContainerRadio.UseVisualStyleBackColor = true;
            this.itemContainerRadio.Visible = false;
            // 
            // purchasepText
            // 
            this.purchasepText.Location = new System.Drawing.Point(145, 110);
            this.purchasepText.Name = "purchasepText";
            this.purchasepText.Size = new System.Drawing.Size(176, 22);
            this.purchasepText.TabIndex = 18;
            // 
            // purchasepLabel
            // 
            this.purchasepLabel.AutoSize = true;
            this.purchasepLabel.Location = new System.Drawing.Point(38, 113);
            this.purchasepLabel.Name = "purchasepLabel";
            this.purchasepLabel.Size = new System.Drawing.Size(101, 16);
            this.purchasepLabel.TabIndex = 17;
            this.purchasepLabel.Text = "Purchase Price:";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 477);
            this.Controls.Add(this.purchasepText);
            this.Controls.Add(this.purchasepLabel);
            this.Controls.Add(this.itemContainerRadio);
            this.Controls.Add(this.itemRadio);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.heightText);
            this.Controls.Add(this.widthText);
            this.Controls.Add(this.lengthText);
            this.Controls.Add(this.yLocText);
            this.Controls.Add(this.xLocText);
            this.Controls.Add(this.currentpText);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.locationYLabel);
            this.Controls.Add(this.locationXLabel);
            this.Controls.Add(this.currentpLabel);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.nameLabel);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label currentpLabel;
        private System.Windows.Forms.Label locationXLabel;
        private System.Windows.Forms.Label locationYLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox currentpText;
        private System.Windows.Forms.TextBox xLocText;
        private System.Windows.Forms.TextBox yLocText;
        private System.Windows.Forms.TextBox lengthText;
        private System.Windows.Forms.TextBox widthText;
        private System.Windows.Forms.TextBox heightText;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RadioButton itemRadio;
        private System.Windows.Forms.RadioButton itemContainerRadio;
        private System.Windows.Forms.TextBox purchasepText;
        private System.Windows.Forms.Label purchasepLabel;
    }
}