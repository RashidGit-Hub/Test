namespace RestService_Test
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtgrpid = new System.Windows.Forms.TextBox();
            this.txtfnm = new System.Windows.Forms.TextBox();
            this.txtverno = new System.Windows.Forms.TextBox();
            this.btngetdata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "GroupId";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "FileName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Version";
            // 
            // txtgrpid
            // 
            this.txtgrpid.Location = new System.Drawing.Point(121, 44);
            this.txtgrpid.Name = "txtgrpid";
            this.txtgrpid.Size = new System.Drawing.Size(100, 20);
            this.txtgrpid.TabIndex = 3;
            // 
            // txtfnm
            // 
            this.txtfnm.Location = new System.Drawing.Point(121, 72);
            this.txtfnm.Name = "txtfnm";
            this.txtfnm.Size = new System.Drawing.Size(100, 20);
            this.txtfnm.TabIndex = 4;
            // 
            // txtverno
            // 
            this.txtverno.Location = new System.Drawing.Point(121, 98);
            this.txtverno.Name = "txtverno";
            this.txtverno.Size = new System.Drawing.Size(100, 20);
            this.txtverno.TabIndex = 5;
            // 
            // btngetdata
            // 
            this.btngetdata.Location = new System.Drawing.Point(121, 146);
            this.btngetdata.Name = "btngetdata";
            this.btngetdata.Size = new System.Drawing.Size(75, 23);
            this.btngetdata.TabIndex = 6;
            this.btngetdata.Text = "Getdata";
            this.btngetdata.UseVisualStyleBackColor = true;
            this.btngetdata.Click += new System.EventHandler(this.btngetdata_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btngetdata);
            this.Controls.Add(this.txtverno);
            this.Controls.Add(this.txtfnm);
            this.Controls.Add(this.txtgrpid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtgroupid;
        private System.Windows.Forms.TextBox txtfilename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtversion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtgrpid;
        private System.Windows.Forms.TextBox txtfnm;
        private System.Windows.Forms.TextBox txtverno;
        private System.Windows.Forms.Button btngetdata;
    }
}

