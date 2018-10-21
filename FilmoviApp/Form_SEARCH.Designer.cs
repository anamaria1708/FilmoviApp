namespace FilmoviApp
{
    partial class Form_SEARCH
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.radiobuttonAND = new System.Windows.Forms.RadioButton();
            this.radiobuttonOR = new System.Windows.Forms.RadioButton();
            this.textBox_SQLQUERY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_documentsRang = new System.Windows.Forms.DataGridView();
            this.buttonback = new System.Windows.Forms.Button();
            this.label_count = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_documentsRang)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "source"});
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Location = new System.Drawing.Point(627, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(327, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(1063, 36);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 1;
            this.button_search.Text = "search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // radiobuttonAND
            // 
            this.radiobuttonAND.AutoSize = true;
            this.radiobuttonAND.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobuttonAND.Location = new System.Drawing.Point(704, 77);
            this.radiobuttonAND.Name = "radiobuttonAND";
            this.radiobuttonAND.Size = new System.Drawing.Size(67, 25);
            this.radiobuttonAND.TabIndex = 2;
            this.radiobuttonAND.TabStop = true;
            this.radiobuttonAND.Text = "AND";
            this.radiobuttonAND.UseVisualStyleBackColor = true;
            // 
            // radiobuttonOR
            // 
            this.radiobuttonOR.AutoSize = true;
            this.radiobuttonOR.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobuttonOR.Location = new System.Drawing.Point(872, 77);
            this.radiobuttonOR.Name = "radiobuttonOR";
            this.radiobuttonOR.Size = new System.Drawing.Size(58, 26);
            this.radiobuttonOR.TabIndex = 3;
            this.radiobuttonOR.TabStop = true;
            this.radiobuttonOR.Text = "OR";
            this.radiobuttonOR.UseVisualStyleBackColor = true;
            // 
            // textBox_SQLQUERY
            // 
            this.textBox_SQLQUERY.Location = new System.Drawing.Point(721, 151);
            this.textBox_SQLQUERY.Multiline = true;
            this.textBox_SQLQUERY.Name = "textBox_SQLQUERY";
            this.textBox_SQLQUERY.Size = new System.Drawing.Size(470, 164);
            this.textBox_SQLQUERY.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(624, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "SQL QUERY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "NUMBER OF DOCUMENTS RECEIVED";
            // 
            // dataGridView_documentsRang
            // 
            this.dataGridView_documentsRang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_documentsRang.Location = new System.Drawing.Point(704, 415);
            this.dataGridView_documentsRang.Name = "dataGridView_documentsRang";
            this.dataGridView_documentsRang.Size = new System.Drawing.Size(561, 305);
            this.dataGridView_documentsRang.TabIndex = 8;
            // 
            // buttonback
            // 
            this.buttonback.Location = new System.Drawing.Point(53, 36);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(75, 23);
            this.buttonback.TabIndex = 9;
            this.buttonback.Text = "BACK";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Location = new System.Drawing.Point(811, 366);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(49, 13);
            this.label_count.TabIndex = 10;
            this.label_count.Text = "_______";
            // 
            // Form_SEARCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 750);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.dataGridView_documentsRang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_SQLQUERY);
            this.Controls.Add(this.radiobuttonOR);
            this.Controls.Add(this.radiobuttonAND);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox1);
            this.Name = "Form_SEARCH";
            this.Text = "Form_SEARCH";
            this.Load += new System.EventHandler(this.Form_SEARCH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_documentsRang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.RadioButton radiobuttonAND;
        private System.Windows.Forms.RadioButton radiobuttonOR;
        private System.Windows.Forms.TextBox textBox_SQLQUERY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_documentsRang;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.Label label_count;
    }
}