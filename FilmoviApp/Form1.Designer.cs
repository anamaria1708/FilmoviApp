namespace FilmoviApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.Player1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menulabel = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.button_analisys = new System.Windows.Forms.Button();
            this.allmovies_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Player1
            // 
            this.Player1.Enabled = true;
            this.Player1.Location = new System.Drawing.Point(12, 715);
            this.Player1.Name = "Player1";
            this.Player1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player1.OcxState")));
            this.Player1.Size = new System.Drawing.Size(75, 23);
            this.Player1.TabIndex = 2;
            // 
            // menulabel
            // 
            this.menulabel.AutoSize = true;
            this.menulabel.Font = new System.Drawing.Font("Ravie", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menulabel.Location = new System.Drawing.Point(327, 22);
            this.menulabel.Name = "menulabel";
            this.menulabel.Size = new System.Drawing.Size(421, 129);
            this.menulabel.TabIndex = 3;
            this.menulabel.Text = "MENU";
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(507, 182);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(189, 68);
            this.button_add.TabIndex = 4;
            this.button_add.Text = "ADD";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_search
            // 
            this.button_search.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.Location = new System.Drawing.Point(626, 298);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(310, 76);
            this.button_search.TabIndex = 5;
            this.button_search.Text = "SEARCH";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_analisys
            // 
            this.button_analisys.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_analisys.Location = new System.Drawing.Point(766, 425);
            this.button_analisys.Name = "button_analisys";
            this.button_analisys.Size = new System.Drawing.Size(404, 77);
            this.button_analisys.TabIndex = 6;
            this.button_analisys.Text = "ANALISYS";
            this.button_analisys.UseVisualStyleBackColor = true;
            this.button_analisys.Click += new System.EventHandler(this.button_analisys_Click);
            // 
            // allmovies_button
            // 
            this.allmovies_button.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allmovies_button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.allmovies_button.Location = new System.Drawing.Point(869, 607);
            this.allmovies_button.Name = "allmovies_button";
            this.allmovies_button.Size = new System.Drawing.Size(475, 131);
            this.allmovies_button.TabIndex = 7;
            this.allmovies_button.Text = "See all of the movies! ";
            this.allmovies_button.UseVisualStyleBackColor = true;
            this.allmovies_button.Click += new System.EventHandler(this.allmovies_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 750);
            this.Controls.Add(this.allmovies_button);
            this.Controls.Add(this.button_analisys);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.menulabel);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private AxWMPLib.AxWindowsMediaPlayer Player1;
        private System.Windows.Forms.Label menulabel;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_analisys;
        private System.Windows.Forms.Button allmovies_button;
    }
}

