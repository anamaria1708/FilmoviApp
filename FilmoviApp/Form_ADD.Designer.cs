﻿namespace FilmoviApp
{
    partial class Form_ADD
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
            this.titlebox = new System.Windows.Forms.TextBox();
            this.labeltitle = new System.Windows.Forms.Label();
            this.categoriesbox = new System.Windows.Forms.TextBox();
            this.summarybox = new System.Windows.Forms.TextBox();
            this.labelcategories = new System.Windows.Forms.Label();
            this.labelsummary = new System.Windows.Forms.Label();
            this.descriptionbox = new System.Windows.Forms.TextBox();
            this.labeldescription = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titlebox
            // 
            this.titlebox.Location = new System.Drawing.Point(755, 119);
            this.titlebox.Name = "titlebox";
            this.titlebox.Size = new System.Drawing.Size(100, 20);
            this.titlebox.TabIndex = 0;
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.Location = new System.Drawing.Point(644, 119);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(69, 21);
            this.labeltitle.TabIndex = 1;
            this.labeltitle.Text = "TITLE";
            // 
            // categoriesbox
            // 
            this.categoriesbox.Location = new System.Drawing.Point(755, 168);
            this.categoriesbox.Name = "categoriesbox";
            this.categoriesbox.Size = new System.Drawing.Size(100, 20);
            this.categoriesbox.TabIndex = 2;
            // 
            // summarybox
            // 
            this.summarybox.Location = new System.Drawing.Point(755, 237);
            this.summarybox.Multiline = true;
            this.summarybox.Name = "summarybox";
            this.summarybox.Size = new System.Drawing.Size(193, 37);
            this.summarybox.TabIndex = 3;
            // 
            // labelcategories
            // 
            this.labelcategories.AutoSize = true;
            this.labelcategories.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcategories.Location = new System.Drawing.Point(600, 168);
            this.labelcategories.Name = "labelcategories";
            this.labelcategories.Size = new System.Drawing.Size(134, 21);
            this.labelcategories.TabIndex = 4;
            this.labelcategories.Text = "CATEGORIES";
            // 
            // labelsummary
            // 
            this.labelsummary.AutoSize = true;
            this.labelsummary.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsummary.Location = new System.Drawing.Point(606, 237);
            this.labelsummary.Name = "labelsummary";
            this.labelsummary.Size = new System.Drawing.Size(117, 21);
            this.labelsummary.TabIndex = 5;
            this.labelsummary.Text = "SUMMARY";
            // 
            // descriptionbox
            // 
            this.descriptionbox.Location = new System.Drawing.Point(755, 295);
            this.descriptionbox.Name = "descriptionbox";
            this.descriptionbox.Size = new System.Drawing.Size(193, 20);
            this.descriptionbox.TabIndex = 6;
            // 
            // labeldescription
            // 
            this.labeldescription.AutoSize = true;
            this.labeldescription.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldescription.Location = new System.Drawing.Point(582, 295);
            this.labeldescription.Name = "labeldescription";
            this.labeldescription.Size = new System.Drawing.Size(141, 21);
            this.labeldescription.TabIndex = 7;
            this.labeldescription.Text = "DESCRIPTION";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(780, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 638);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labeldescription);
            this.Controls.Add(this.descriptionbox);
            this.Controls.Add(this.labelsummary);
            this.Controls.Add(this.labelcategories);
            this.Controls.Add(this.summarybox);
            this.Controls.Add(this.categoriesbox);
            this.Controls.Add(this.labeltitle);
            this.Controls.Add(this.titlebox);
            this.Name = "Form_ADD";
            this.Text = "Form_ADD";
            this.Load += new System.EventHandler(this.Form_ADD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titlebox;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.TextBox categoriesbox;
        private System.Windows.Forms.TextBox summarybox;
        private System.Windows.Forms.Label labelcategories;
        private System.Windows.Forms.Label labelsummary;
        private System.Windows.Forms.TextBox descriptionbox;
        private System.Windows.Forms.Label labeldescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}