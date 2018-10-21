namespace FilmoviApp
{
    partial class Form_ANALIZA
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
            this.dateTimePickerDAYSTART = new System.Windows.Forms.DateTimePicker();
            this.npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            this.npgsqlDataAdapter2 = new Npgsql.NpgsqlDataAdapter();
            this.dateTimePickerDAYFINISH = new System.Windows.Forms.DateTimePicker();
            this.labelDAYSTART = new System.Windows.Forms.Label();
            this.labelDAYFINISH = new System.Windows.Forms.Label();
            this.radioButtonPOSATIMA = new System.Windows.Forms.RadioButton();
            this.radioButtonPODANIMA = new System.Windows.Forms.RadioButton();
            this.analizaGrid = new System.Windows.Forms.DataGridView();
            this.buttonANALIZIRAJ = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.analizaGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerDAYSTART
            // 
            this.dateTimePickerDAYSTART.Location = new System.Drawing.Point(748, 32);
            this.dateTimePickerDAYSTART.Name = "dateTimePickerDAYSTART";
            this.dateTimePickerDAYSTART.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDAYSTART.TabIndex = 0;
            // 
            // npgsqlDataAdapter1
            // 
            this.npgsqlDataAdapter1.DeleteCommand = null;
            this.npgsqlDataAdapter1.InsertCommand = null;
            this.npgsqlDataAdapter1.SelectCommand = null;
            this.npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // npgsqlDataAdapter2
            // 
            this.npgsqlDataAdapter2.DeleteCommand = null;
            this.npgsqlDataAdapter2.InsertCommand = null;
            this.npgsqlDataAdapter2.SelectCommand = null;
            this.npgsqlDataAdapter2.UpdateCommand = null;
            // 
            // dateTimePickerDAYFINISH
            // 
            this.dateTimePickerDAYFINISH.Location = new System.Drawing.Point(748, 105);
            this.dateTimePickerDAYFINISH.Name = "dateTimePickerDAYFINISH";
            this.dateTimePickerDAYFINISH.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDAYFINISH.TabIndex = 1;
            // 
            // labelDAYSTART
            // 
            this.labelDAYSTART.AutoSize = true;
            this.labelDAYSTART.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDAYSTART.Location = new System.Drawing.Point(599, 27);
            this.labelDAYSTART.Name = "labelDAYSTART";
            this.labelDAYSTART.Size = new System.Drawing.Size(132, 22);
            this.labelDAYSTART.TabIndex = 3;
            this.labelDAYSTART.Text = "DAY START";
            // 
            // labelDAYFINISH
            // 
            this.labelDAYFINISH.AutoSize = true;
            this.labelDAYFINISH.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDAYFINISH.Location = new System.Drawing.Point(599, 103);
            this.labelDAYFINISH.Name = "labelDAYFINISH";
            this.labelDAYFINISH.Size = new System.Drawing.Size(127, 22);
            this.labelDAYFINISH.TabIndex = 4;
            this.labelDAYFINISH.Text = "DAY FINISH";
            // 
            // radioButtonPOSATIMA
            // 
            this.radioButtonPOSATIMA.AutoSize = true;
            this.radioButtonPOSATIMA.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPOSATIMA.ForeColor = System.Drawing.Color.DarkRed;
            this.radioButtonPOSATIMA.Location = new System.Drawing.Point(406, 150);
            this.radioButtonPOSATIMA.Name = "radioButtonPOSATIMA";
            this.radioButtonPOSATIMA.Size = new System.Drawing.Size(140, 38);
            this.radioButtonPOSATIMA.TabIndex = 6;
            this.radioButtonPOSATIMA.TabStop = true;
            this.radioButtonPOSATIMA.Text = "HOURS";
            this.radioButtonPOSATIMA.UseVisualStyleBackColor = true;
           
            // 
            // radioButtonPODANIMA
            // 
            this.radioButtonPODANIMA.AutoSize = true;
            this.radioButtonPODANIMA.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPODANIMA.ForeColor = System.Drawing.Color.DarkRed;
            this.radioButtonPODANIMA.Location = new System.Drawing.Point(406, 43);
            this.radioButtonPODANIMA.Name = "radioButtonPODANIMA";
            this.radioButtonPODANIMA.Size = new System.Drawing.Size(116, 38);
            this.radioButtonPODANIMA.TabIndex = 7;
            this.radioButtonPODANIMA.TabStop = true;
            this.radioButtonPODANIMA.Text = "DAYS";
            this.radioButtonPODANIMA.UseVisualStyleBackColor = true;
            
            // 
            // analizaGrid
            // 
            this.analizaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.analizaGrid.Location = new System.Drawing.Point(682, 313);
            this.analizaGrid.Name = "analizaGrid";
            this.analizaGrid.Size = new System.Drawing.Size(458, 263);
            this.analizaGrid.TabIndex = 8;
            // 
            // buttonANALIZIRAJ
            // 
            this.buttonANALIZIRAJ.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonANALIZIRAJ.Location = new System.Drawing.Point(794, 179);
            this.buttonANALIZIRAJ.Name = "buttonANALIZIRAJ";
            this.buttonANALIZIRAJ.Size = new System.Drawing.Size(154, 73);
            this.buttonANALIZIRAJ.TabIndex = 10;
            this.buttonANALIZIRAJ.Text = "ANALIZE";
            this.buttonANALIZIRAJ.UseVisualStyleBackColor = true;
            this.buttonANALIZIRAJ.Click += new System.EventHandler(this.buttonANALIZIRAJ_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buttonback
            // 
            this.buttonback.Location = new System.Drawing.Point(42, 29);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(75, 23);
            this.buttonback.TabIndex = 11;
            this.buttonback.Text = "BACK";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // Form_ANALIZA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 750);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.buttonANALIZIRAJ);
            this.Controls.Add(this.analizaGrid);
            this.Controls.Add(this.radioButtonPODANIMA);
            this.Controls.Add(this.radioButtonPOSATIMA);
            this.Controls.Add(this.labelDAYFINISH);
            this.Controls.Add(this.labelDAYSTART);
            this.Controls.Add(this.dateTimePickerDAYFINISH);
            this.Controls.Add(this.dateTimePickerDAYSTART);
            this.Name = "Form_ANALIZA";
            this.Text = "Form_ANALIZA";
            this.Load += new System.EventHandler(this.Form_ANALIZA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.analizaGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDAYSTART;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDAYFINISH;
        private System.Windows.Forms.Label labelDAYSTART;
        private System.Windows.Forms.Label labelDAYFINISH;
        private System.Windows.Forms.RadioButton radioButtonPOSATIMA;
        private System.Windows.Forms.RadioButton radioButtonPODANIMA;
        private System.Windows.Forms.DataGridView analizaGrid;
        private System.Windows.Forms.Button buttonANALIZIRAJ;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button buttonback;
    }
}