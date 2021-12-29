namespace WFA1220
{
    partial class addD
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
            this.tall = new System.Windows.Forms.Button();
            this.ment = new System.Windows.Forms.Button();
            this.megse = new System.Windows.Forms.Button();
            this.bekeres = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tall
            // 
            this.tall.Location = new System.Drawing.Point(414, 40);
            this.tall.Name = "tall";
            this.tall.Size = new System.Drawing.Size(151, 35);
            this.tall.TabIndex = 0;
            this.tall.Text = "Talllózás";
            this.tall.UseVisualStyleBackColor = true;
            // 
            // ment
            // 
            this.ment.Location = new System.Drawing.Point(242, 94);
            this.ment.Name = "ment";
            this.ment.Size = new System.Drawing.Size(154, 39);
            this.ment.TabIndex = 1;
            this.ment.Text = "Mentés";
            this.ment.UseVisualStyleBackColor = true;
            // 
            // megse
            // 
            this.megse.Location = new System.Drawing.Point(414, 94);
            this.megse.Name = "megse";
            this.megse.Size = new System.Drawing.Size(151, 39);
            this.megse.TabIndex = 2;
            this.megse.Text = "Mégse";
            this.megse.UseVisualStyleBackColor = true;
            // 
            // bekeres
            // 
            this.bekeres.Location = new System.Drawing.Point(32, 44);
            this.bekeres.Name = "bekeres";
            this.bekeres.Size = new System.Drawing.Size(364, 26);
            this.bekeres.TabIndex = 3;
            // 
            // addD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bekeres);
            this.Controls.Add(this.megse);
            this.Controls.Add(this.ment);
            this.Controls.Add(this.tall);
            this.Name = "addD";
            this.Text = "addD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tall;
        private System.Windows.Forms.Button ment;
        private System.Windows.Forms.Button megse;
        private System.Windows.Forms.TextBox bekeres;
    }
}