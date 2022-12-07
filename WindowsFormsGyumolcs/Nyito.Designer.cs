namespace WindowsFormsGyumolcs {
    partial class Nyito {
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
            this.gyumolcsList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Modify = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gyumolcsList
            // 
            this.gyumolcsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.gyumolcsList.Dock = System.Windows.Forms.DockStyle.Left;
            this.gyumolcsList.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gyumolcsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.gyumolcsList.FormattingEnabled = true;
            this.gyumolcsList.ItemHeight = 18;
            this.gyumolcsList.Location = new System.Drawing.Point(0, 0);
            this.gyumolcsList.Name = "gyumolcsList";
            this.gyumolcsList.Size = new System.Drawing.Size(326, 291);
            this.gyumolcsList.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Delete);
            this.groupBox1.Controls.Add(this.Modify);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.groupBox1.Location = new System.Drawing.Point(326, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 291);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gyümölcs";
            // 
            // Delete
            // 
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(6, 77);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(85, 23);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Törlés";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Modify
            // 
            this.Modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modify.ForeColor = System.Drawing.Color.White;
            this.Modify.Location = new System.Drawing.Point(6, 48);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(85, 23);
            this.Modify.TabIndex = 10;
            this.Modify.Text = "Módosítás";
            this.Modify.UseVisualStyleBackColor = true;
            this.Modify.Click += new System.EventHandler(this.Modify_Click);
            // 
            // Add
            // 
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(6, 19);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(85, 23);
            this.Add.TabIndex = 9;
            this.Add.Text = "Új gyümölcs";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(423, 291);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gyumolcsList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox gyumolcsList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Modify;
        private System.Windows.Forms.Button Add;
    }
}

