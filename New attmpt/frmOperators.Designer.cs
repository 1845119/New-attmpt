namespace New_attmpt
{
    partial class frmOperators
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSolveQuad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtc = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txta = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.LblRes = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblRes);
            this.groupBox1.Controls.Add(this.btnSolveQuad);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtc);
            this.groupBox1.Controls.Add(this.txtb);
            this.groupBox1.Controls.Add(this.txta);
            this.groupBox1.Controls.Add(this.c);
            this.groupBox1.Controls.Add(this.b);
            this.groupBox1.Controls.Add(this.a);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Valuse";
            // 
            // btnSolveQuad
            // 
            this.btnSolveQuad.Location = new System.Drawing.Point(118, 158);
            this.btnSolveQuad.Name = "btnSolveQuad";
            this.btnSolveQuad.Size = new System.Drawing.Size(75, 23);
            this.btnSolveQuad.TabIndex = 7;
            this.btnSolveQuad.Text = "Solve Quad";
            this.btnSolveQuad.UseVisualStyleBackColor = true;
            this.btnSolveQuad.Click += new System.EventHandler(this.btnSolveQuad_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Solve";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(62, 101);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(100, 20);
            this.txtc.TabIndex = 5;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(62, 68);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 20);
            this.txtb.TabIndex = 4;
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(62, 41);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 20);
            this.txta.TabIndex = 3;
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(10, 104);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(12, 13);
            this.c.TabIndex = 2;
            this.c.Text = "c";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(10, 71);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(13, 13);
            this.b.TabIndex = 1;
            this.b.Text = "b";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(10, 41);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(13, 13);
            this.a.TabIndex = 0;
            this.a.Text = "a";
            // 
            // LblRes
            // 
            this.LblRes.AutoSize = true;
            this.LblRes.Location = new System.Drawing.Point(241, 41);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(35, 13);
            this.LblRes.TabIndex = 8;
            this.LblRes.Text = "label1";
            // 
            // frmOperators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOperators";
            this.Text = "frmOperators";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Button btnSolveQuad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblRes;
    }
}