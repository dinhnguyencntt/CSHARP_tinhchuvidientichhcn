namespace CSHARP_tinhchuvidientichhcn
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
            this.V = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.lblkq = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.S = new System.Windows.Forms.Button();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbchuvi = new System.Windows.Forms.RadioButton();
            this.rdbdientich = new System.Windows.Forms.RadioButton();
            this.btntinh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // V
            // 
            this.V.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V.Location = new System.Drawing.Point(12, 274);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(133, 56);
            this.V.TabIndex = 0;
            this.V.Text = "chu vi";
            this.V.UseVisualStyleBackColor = true;
            this.V.Click += new System.EventHandler(this.V_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(319, 112);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 1;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(115, 115);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(61, 19);
            this.lblA.TabIndex = 2;
            this.lblA.Text = "nhập a";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblb.Location = new System.Drawing.Point(115, 164);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(58, 20);
            this.lblb.TabIndex = 3;
            this.lblb.Text = "nhập b";
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkq.Location = new System.Drawing.Point(115, 219);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(62, 20);
            this.lblkq.TabIndex = 4;
            this.lblkq.Text = "kết quả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "TÍNH HCN";
            // 
            // S
            // 
            this.S.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S.Location = new System.Drawing.Point(231, 274);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(147, 56);
            this.S.TabIndex = 6;
            this.S.Text = "diện tích";
            this.S.UseVisualStyleBackColor = true;
            this.S.Click += new System.EventHandler(this.S_Click);
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(319, 219);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(100, 20);
            this.txtkq.TabIndex = 7;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(319, 164);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(185, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 55);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbdientich);
            this.groupBox1.Controls.Add(this.rdbchuvi);
            this.groupBox1.Location = new System.Drawing.Point(505, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 208);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdbchuvi
            // 
            this.rdbchuvi.AutoSize = true;
            this.rdbchuvi.Location = new System.Drawing.Point(41, 42);
            this.rdbchuvi.Name = "rdbchuvi";
            this.rdbchuvi.Size = new System.Drawing.Size(55, 17);
            this.rdbchuvi.TabIndex = 0;
            this.rdbchuvi.TabStop = true;
            this.rdbchuvi.Text = "Chu vi";
            this.rdbchuvi.UseVisualStyleBackColor = true;
            this.rdbchuvi.CheckedChanged += new System.EventHandler(this.rdbchuvi_CheckedChanged);
            // 
            // rdbdientich
            // 
            this.rdbdientich.AutoSize = true;
            this.rdbdientich.Location = new System.Drawing.Point(41, 98);
            this.rdbdientich.Name = "rdbdientich";
            this.rdbdientich.Size = new System.Drawing.Size(69, 17);
            this.rdbdientich.TabIndex = 0;
            this.rdbdientich.TabStop = true;
            this.rdbdientich.Text = "Diện tích";
            this.rdbdientich.UseVisualStyleBackColor = true;
            // 
            // btntinh
            // 
            this.btntinh.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntinh.Location = new System.Drawing.Point(532, 287);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(147, 56);
            this.btntinh.TabIndex = 6;
            this.btntinh.Text = "Tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.S_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.S);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.V);
            this.Name = "Form1";
            this.Text = "tính chu vi dien tich hcn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button V;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button S;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbdientich;
        private System.Windows.Forms.RadioButton rdbchuvi;
        private System.Windows.Forms.Button btntinh;
    }
}

