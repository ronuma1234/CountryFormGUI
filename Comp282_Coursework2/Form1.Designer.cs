
namespace Comp282_Coursework2
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.popLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.popTxtBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.countryListView = new System.Windows.Forms.ListView();
            this.nameColHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.popColHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // popLabel
            // 
            this.popLabel.AutoSize = true;
            this.popLabel.Location = new System.Drawing.Point(186, 13);
            this.popLabel.Name = "popLabel";
            this.popLabel.Size = new System.Drawing.Size(119, 20);
            this.popLabel.TabIndex = 1;
            this.popLabel.Text = "Population Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(13, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 2;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(17, 36);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(167, 26);
            this.nameTxtBox.TabIndex = 3;
            // 
            // popTxtBox
            // 
            this.popTxtBox.Location = new System.Drawing.Point(190, 36);
            this.popTxtBox.Name = "popTxtBox";
            this.popTxtBox.Size = new System.Drawing.Size(115, 26);
            this.popTxtBox.TabIndex = 4;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(17, 80);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 32);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(99, 79);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(85, 33);
            this.removeButton.TabIndex = 6;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(191, 79);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(114, 33);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // countryListView
            // 
            this.countryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColHeader,
            this.popColHeader});
            this.countryListView.FullRowSelect = true;
            this.countryListView.HideSelection = false;
            this.countryListView.Location = new System.Drawing.Point(17, 131);
            this.countryListView.MultiSelect = false;
            this.countryListView.Name = "countryListView";
            this.countryListView.Size = new System.Drawing.Size(288, 187);
            this.countryListView.TabIndex = 8;
            this.countryListView.UseCompatibleStateImageBehavior = false;
            this.countryListView.View = System.Windows.Forms.View.Details;
            this.countryListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.countryListView_ColumnClick_1);
            // 
            // nameColHeader
            // 
            this.nameColHeader.Tag = "";
            this.nameColHeader.Text = "Name↓";
            this.nameColHeader.Width = 134;
            // 
            // popColHeader
            // 
            this.popColHeader.Tag = "";
            this.popColHeader.Text = "Population↓";
            this.popColHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.popColHeader.Width = 154;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(326, 330);
            this.Controls.Add(this.countryListView);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.popTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.popLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "Country App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label popLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox popTxtBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ListView countryListView;
        private System.Windows.Forms.ColumnHeader nameColHeader;
        private System.Windows.Forms.ColumnHeader popColHeader;
    }
}

