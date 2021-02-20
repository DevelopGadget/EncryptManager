
namespace Decrypt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.hashLbl = new System.Windows.Forms.Label();
            this.saltLbl = new System.Windows.Forms.Label();
            this.hashTxb = new System.Windows.Forms.TextBox();
            this.saltTxb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(486, 23);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input To Encrypt";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hashLbl
            // 
            this.hashLbl.AutoSize = true;
            this.hashLbl.Location = new System.Drawing.Point(12, 210);
            this.hashLbl.Name = "hashLbl";
            this.hashLbl.Size = new System.Drawing.Size(40, 15);
            this.hashLbl.TabIndex = 3;
            this.hashLbl.Text = "Hash: ";
            // 
            // saltLbl
            // 
            this.saltLbl.AutoSize = true;
            this.saltLbl.Location = new System.Drawing.Point(12, 242);
            this.saltLbl.Name = "saltLbl";
            this.saltLbl.Size = new System.Drawing.Size(32, 15);
            this.saltLbl.TabIndex = 4;
            this.saltLbl.Text = "Salt: ";
            // 
            // hashTxb
            // 
            this.hashTxb.Location = new System.Drawing.Point(59, 210);
            this.hashTxb.Name = "hashTxb";
            this.hashTxb.Size = new System.Drawing.Size(569, 23);
            this.hashTxb.TabIndex = 5;
            // 
            // saltTxb
            // 
            this.saltTxb.Location = new System.Drawing.Point(59, 239);
            this.saltTxb.Name = "saltTxb";
            this.saltTxb.Size = new System.Drawing.Size(569, 23);
            this.saltTxb.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 349);
            this.Controls.Add(this.saltTxb);
            this.Controls.Add(this.hashTxb);
            this.Controls.Add(this.saltLbl);
            this.Controls.Add(this.hashLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Encrypt Module";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label hashLbl;
        private System.Windows.Forms.Label saltLbl;
        private System.Windows.Forms.TextBox hashTxb;
        private System.Windows.Forms.TextBox saltTxb;
    }
}

