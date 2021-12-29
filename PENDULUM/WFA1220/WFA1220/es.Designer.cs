namespace WFA1220
{
    partial class es
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
            this.titlebe = new System.Windows.Forms.TextBox();
            this.lengbe = new System.Windows.Forms.TextBox();
            this.mentes = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title szerkeztése:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Length szerkeztése:";
            // 
            // titlebe
            // 
            this.titlebe.Location = new System.Drawing.Point(37, 69);
            this.titlebe.Name = "titlebe";
            this.titlebe.Size = new System.Drawing.Size(184, 26);
            this.titlebe.TabIndex = 2;
            // 
            // lengbe
            // 
            this.lengbe.Location = new System.Drawing.Point(273, 69);
            this.lengbe.Name = "lengbe";
            this.lengbe.Size = new System.Drawing.Size(184, 26);
            this.lengbe.TabIndex = 3;
            // 
            // mentes
            // 
            this.mentes.Location = new System.Drawing.Point(32, 120);
            this.mentes.Name = "mentes";
            this.mentes.Size = new System.Drawing.Size(188, 33);
            this.mentes.TabIndex = 4;
            this.mentes.Text = "Mentés";
            this.mentes.UseVisualStyleBackColor = true;
            this.mentes.Click += new System.EventHandler(this.mentes_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // es
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 197);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mentes);
            this.Controls.Add(this.lengbe);
            this.Controls.Add(this.titlebe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "es";
            this.Text = "szerkeztés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titlebe;
        private System.Windows.Forms.TextBox lengbe;
        private System.Windows.Forms.Button mentes;
        private System.Windows.Forms.Button button2;
    }
}