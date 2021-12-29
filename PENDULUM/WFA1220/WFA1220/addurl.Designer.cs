namespace WFA1220
{
    partial class addurl
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
            this.keszaddurl = new System.Windows.Forms.Button();
            this.megseurl = new System.Windows.Forms.Button();
            this.addurltext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kérlek csak a link utolsó részét másold be!";
            // 
            // keszaddurl
            // 
            this.keszaddurl.Location = new System.Drawing.Point(482, 157);
            this.keszaddurl.Name = "keszaddurl";
            this.keszaddurl.Size = new System.Drawing.Size(149, 38);
            this.keszaddurl.TabIndex = 1;
            this.keszaddurl.Text = "Kész";
            this.keszaddurl.UseVisualStyleBackColor = true;
            this.keszaddurl.Click += new System.EventHandler(this.keszaddurl_Click);
            // 
            // megseurl
            // 
            this.megseurl.Location = new System.Drawing.Point(649, 160);
            this.megseurl.Name = "megseurl";
            this.megseurl.Size = new System.Drawing.Size(136, 34);
            this.megseurl.TabIndex = 2;
            this.megseurl.Text = "Mégse";
            this.megseurl.UseVisualStyleBackColor = true;
            this.megseurl.Click += new System.EventHandler(this.megseurl_Click);
            // 
            // addurltext
            // 
            this.addurltext.Location = new System.Drawing.Point(29, 71);
            this.addurltext.Name = "addurltext";
            this.addurltext.Size = new System.Drawing.Size(341, 26);
            this.addurltext.TabIndex = 3;
            // 
            // addurl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 211);
            this.Controls.Add(this.addurltext);
            this.Controls.Add(this.megseurl);
            this.Controls.Add(this.keszaddurl);
            this.Controls.Add(this.label1);
            this.Name = "addurl";
            this.Text = "addurl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button keszaddurl;
        private System.Windows.Forms.Button megseurl;
        private System.Windows.Forms.TextBox addurltext;
    }
}