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
            this.label1 = new System.Windows.Forms.Label();
            this.populate = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.placeholderPanel = new System.Windows.Forms.Panel();
            this.treeExpand = new System.Windows.Forms.CheckBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.placeholderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Farm Items";
            // 
            // populate
            // 
            this.populate.Location = new System.Drawing.Point(55, 459);
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
            this.treeView.Size = new System.Drawing.Size(212, 282);
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
            this.placeholderPanel.Controls.Add(this.button1);
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
            this.treeExpand.Size = new System.Drawing.Size(87, 17);
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
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Visualization";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 45);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(999, 905);
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
            this.placeholderPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
    }
}

