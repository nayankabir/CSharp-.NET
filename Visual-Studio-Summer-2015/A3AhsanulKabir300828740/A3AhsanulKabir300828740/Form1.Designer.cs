﻿namespace A3AhsanulKabir300828740
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
            this.label_LogName = new System.Windows.Forms.Label();
            this.label_LogItem = new System.Windows.Forms.Label();
            this.label_LogContent = new System.Windows.Forms.Label();
            this.radiobtn_Add = new System.Windows.Forms.RadioButton();
            this.radiobtn_Remove = new System.Windows.Forms.RadioButton();
            this.listbox_LogContent = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label_LogName
            // 
            this.label_LogName.AutoSize = true;
            this.label_LogName.Location = new System.Drawing.Point(51, 73);
            this.label_LogName.Name = "label_LogName";
            this.label_LogName.Size = new System.Drawing.Size(56, 13);
            this.label_LogName.TabIndex = 0;
            this.label_LogName.Text = "Log Name";
            this.label_LogName.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_LogItem
            // 
            this.label_LogItem.AutoSize = true;
            this.label_LogItem.Location = new System.Drawing.Point(51, 116);
            this.label_LogItem.Name = "label_LogItem";
            this.label_LogItem.Size = new System.Drawing.Size(48, 13);
            this.label_LogItem.TabIndex = 1;
            this.label_LogItem.Text = "Log Item";
            // 
            // label_LogContent
            // 
            this.label_LogContent.AutoSize = true;
            this.label_LogContent.Location = new System.Drawing.Point(51, 183);
            this.label_LogContent.Name = "label_LogContent";
            this.label_LogContent.Size = new System.Drawing.Size(65, 13);
            this.label_LogContent.TabIndex = 2;
            this.label_LogContent.Text = "Log Content";
            // 
            // radiobtn_Add
            // 
            this.radiobtn_Add.AutoSize = true;
            this.radiobtn_Add.Location = new System.Drawing.Point(160, 133);
            this.radiobtn_Add.Name = "radiobtn_Add";
            this.radiobtn_Add.Size = new System.Drawing.Size(44, 17);
            this.radiobtn_Add.TabIndex = 3;
            this.radiobtn_Add.TabStop = true;
            this.radiobtn_Add.Text = "Add";
            this.radiobtn_Add.UseVisualStyleBackColor = true;
            // 
            // radiobtn_Remove
            // 
            this.radiobtn_Remove.AutoSize = true;
            this.radiobtn_Remove.Location = new System.Drawing.Point(280, 133);
            this.radiobtn_Remove.Name = "radiobtn_Remove";
            this.radiobtn_Remove.Size = new System.Drawing.Size(65, 17);
            this.radiobtn_Remove.TabIndex = 4;
            this.radiobtn_Remove.TabStop = true;
            this.radiobtn_Remove.Text = "Remove";
            this.radiobtn_Remove.UseVisualStyleBackColor = true;
            // 
            // listbox_LogContent
            // 
            this.listbox_LogContent.FormattingEnabled = true;
            this.listbox_LogContent.Items.AddRange(new object[] {
            "Test1",
            "Test2"});
            this.listbox_LogContent.Location = new System.Drawing.Point(171, 183);
            this.listbox_LogContent.Name = "listbox_LogContent";
            this.listbox_LogContent.Size = new System.Drawing.Size(120, 95);
            this.listbox_LogContent.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 303);
            this.Controls.Add(this.listbox_LogContent);
            this.Controls.Add(this.radiobtn_Remove);
            this.Controls.Add(this.radiobtn_Add);
            this.Controls.Add(this.label_LogContent);
            this.Controls.Add(this.label_LogItem);
            this.Controls.Add(this.label_LogName);
            this.Name = "Form1";
            this.Text = "String Log Handler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_LogName;
        private System.Windows.Forms.Label label_LogItem;
        private System.Windows.Forms.Label label_LogContent;
        private System.Windows.Forms.RadioButton radiobtn_Add;
        private System.Windows.Forms.RadioButton radiobtn_Remove;
        private System.Windows.Forms.ListBox listbox_LogContent;
    }
}
