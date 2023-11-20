namespace FarmInterface
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.populate = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.placeholderPanel = new System.Windows.Forms.Panel();
            this.treeExpand = new System.Windows.Forms.CheckBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.inspectButton = new System.Windows.Forms.Button();
            this.scanButton = new System.Windows.Forms.Button();
            this.inspectLabel = new System.Windows.Forms.Label();
            this.scanLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Farm Items";
            // 
            // populate
            // 
            this.populate.Location = new System.Drawing.Point(70, 461);
            this.populate.Name = "populate";
            this.populate.Size = new System.Drawing.Size(114, 32);
            this.populate.TabIndex = 9;
            this.populate.Text = "Populate Test";
            this.populate.UseVisualStyleBackColor = true;
            this.populate.Click += new System.EventHandler(this.populate_Click);
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(26, 68);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(239, 282);
            this.treeView.TabIndex = 10;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(190, 379);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Delete";
            this.deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(109, 379);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 12;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // placeholderPanel
            // 
            this.placeholderPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.placeholderPanel.Location = new System.Drawing.Point(304, 65);
            this.placeholderPanel.Name = "placeholderPanel";
            this.placeholderPanel.Size = new System.Drawing.Size(600, 800);
            this.placeholderPanel.TabIndex = 13;
            // 
            // treeExpand
            // 
            this.treeExpand.AutoSize = true;
            this.treeExpand.Location = new System.Drawing.Point(26, 353);
            this.treeExpand.Name = "treeExpand";
            this.treeExpand.Size = new System.Drawing.Size(107, 20);
            this.treeExpand.TabIndex = 14;
            this.treeExpand.Text = "Expand Tree";
            this.treeExpand.UseVisualStyleBackColor = true;
            this.treeExpand.CheckedChanged += new System.EventHandler(this.treeExpand_CheckedChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(26, 379);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Visualization";
            // 
            // animationTimer
            // 
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.scanLabel);
            this.panel1.Controls.Add(this.inspectLabel);
            this.panel1.Controls.Add(this.scanButton);
            this.panel1.Controls.Add(this.inspectButton);
            this.panel1.Location = new System.Drawing.Point(12, 573);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 160);
            this.panel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 545);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Inspection";
            // 
            // inspectButton
            // 
            this.inspectButton.Location = new System.Drawing.Point(13, 13);
            this.inspectButton.Name = "inspectButton";
            this.inspectButton.Size = new System.Drawing.Size(75, 23);
            this.inspectButton.TabIndex = 0;
            this.inspectButton.Text = "Inspect";
            this.inspectButton.UseVisualStyleBackColor = true;
            this.inspectButton.Click += new System.EventHandler(this.inspectButton_Click);
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(13, 83);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(75, 23);
            this.scanButton.TabIndex = 1;
            this.scanButton.Text = "Scan";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // inspectLabel
            // 
            this.inspectLabel.AutoSize = true;
            this.inspectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inspectLabel.Location = new System.Drawing.Point(117, 13);
            this.inspectLabel.Name = "inspectLabel";
            this.inspectLabel.Size = new System.Drawing.Size(135, 40);
            this.inspectLabel.TabIndex = 2;
            this.inspectLabel.Text = "Send Drone to \r\nselected location";
            // 
            // scanLabel
            // 
            this.scanLabel.AutoSize = true;
            this.scanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanLabel.Location = new System.Drawing.Point(117, 83);
            this.scanLabel.Name = "scanLabel";
            this.scanLabel.Size = new System.Drawing.Size(122, 40);
            this.scanLabel.TabIndex = 3;
            this.scanLabel.Text = "Scan the entire\r\nproperty\r\n";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(999, 905);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.treeExpand);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.populate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.placeholderPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button populate;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Panel placeholderPanel;
        private System.Windows.Forms.CheckBox treeExpand;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.Button inspectButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label scanLabel;
        private System.Windows.Forms.Label inspectLabel;
    }
}

