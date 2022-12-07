namespace WindowsFormsGyumolcs {
    partial class AUForm {
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
            this.mennyisegCont = new System.Windows.Forms.NumericUpDown();
            this.egysegarCont = new System.Windows.Forms.NumericUpDown();
            this.idCont = new System.Windows.Forms.NumericUpDown();
            this.nameCont = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mennyisegCont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egysegarCont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idCont)).BeginInit();
            this.SuspendLayout();
            // 
            // mennyisegCont
            // 
            this.mennyisegCont.DecimalPlaces = 2;
            this.mennyisegCont.Location = new System.Drawing.Point(122, 126);
            this.mennyisegCont.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.mennyisegCont.Name = "mennyisegCont";
            this.mennyisegCont.Size = new System.Drawing.Size(75, 20);
            this.mennyisegCont.TabIndex = 21;
            // 
            // egysegarCont
            // 
            this.egysegarCont.DecimalPlaces = 2;
            this.egysegarCont.Location = new System.Drawing.Point(122, 88);
            this.egysegarCont.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.egysegarCont.Name = "egysegarCont";
            this.egysegarCont.Size = new System.Drawing.Size(75, 20);
            this.egysegarCont.TabIndex = 20;
            // 
            // idCont
            // 
            this.idCont.Enabled = false;
            this.idCont.Location = new System.Drawing.Point(122, 12);
            this.idCont.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.idCont.Name = "idCont";
            this.idCont.Size = new System.Drawing.Size(75, 20);
            this.idCont.TabIndex = 19;
            // 
            // nameCont
            // 
            this.nameCont.Location = new System.Drawing.Point(122, 50);
            this.nameCont.Name = "nameCont";
            this.nameCont.Size = new System.Drawing.Size(100, 20);
            this.nameCont.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.label4.Location = new System.Drawing.Point(13, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "mennyiség:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.label3.Location = new System.Drawing.Point(27, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "egységár:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.label2.Location = new System.Drawing.Point(72, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "név:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.label1.Location = new System.Drawing.Point(86, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "id:";
            // 
            // OK
            // 
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK.ForeColor = System.Drawing.Color.White;
            this.OK.Location = new System.Drawing.Point(66, 173);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(106, 32);
            this.OK.TabIndex = 22;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // AUForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(238, 217);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.mennyisegCont);
            this.Controls.Add(this.egysegarCont);
            this.Controls.Add(this.idCont);
            this.Controls.Add(this.nameCont);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AUForm";
            this.Text = "AUMForm";
            this.Load += new System.EventHandler(this.AUMForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mennyisegCont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egysegarCont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idCont)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown mennyisegCont;
        private System.Windows.Forms.NumericUpDown egysegarCont;
        private System.Windows.Forms.NumericUpDown idCont;
        private System.Windows.Forms.TextBox nameCont;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OK;
    }
}