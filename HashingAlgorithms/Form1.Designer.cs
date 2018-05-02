namespace HashingAlgorithms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMD5 = new System.Windows.Forms.Label();
            this.lblSHA1 = new System.Windows.Forms.Label();
            this.lblSHA256 = new System.Windows.Forms.Label();
            this.lblSHA512 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your password in MD5:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Your password in SHA1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Your password in SHA256:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Your password in SHA512:";
            // 
            // lblMD5
            // 
            this.lblMD5.AutoSize = true;
            this.lblMD5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMD5.Location = new System.Drawing.Point(226, 111);
            this.lblMD5.Name = "lblMD5";
            this.lblMD5.Size = new System.Drawing.Size(117, 13);
            this.lblMD5.TabIndex = 5;
            this.lblMD5.Text = "Your password in MD5:";
            // 
            // lblSHA1
            // 
            this.lblSHA1.AutoSize = true;
            this.lblSHA1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSHA1.Location = new System.Drawing.Point(226, 143);
            this.lblSHA1.Name = "lblSHA1";
            this.lblSHA1.Size = new System.Drawing.Size(117, 13);
            this.lblSHA1.TabIndex = 6;
            this.lblSHA1.Text = "Your password in MD5:";
            // 
            // lblSHA256
            // 
            this.lblSHA256.AutoSize = true;
            this.lblSHA256.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSHA256.Location = new System.Drawing.Point(226, 186);
            this.lblSHA256.Name = "lblSHA256";
            this.lblSHA256.Size = new System.Drawing.Size(117, 13);
            this.lblSHA256.TabIndex = 7;
            this.lblSHA256.Text = "Your password in MD5:";
            // 
            // lblSHA512
            // 
            this.lblSHA512.AutoSize = true;
            this.lblSHA512.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSHA512.Location = new System.Drawing.Point(226, 225);
            this.lblSHA512.Name = "lblSHA512";
            this.lblSHA512.Size = new System.Drawing.Size(117, 13);
            this.lblSHA512.TabIndex = 8;
            this.lblSHA512.Text = "Your password in MD5:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(179, 42);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(155, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(340, 38);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 10;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 274);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblSHA512);
            this.Controls.Add(this.lblSHA256);
            this.Controls.Add(this.lblSHA1);
            this.Controls.Add(this.lblMD5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMD5;
        private System.Windows.Forms.Label lblSHA1;
        private System.Windows.Forms.Label lblSHA256;
        private System.Windows.Forms.Label lblSHA512;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnConvert;
    }
}

