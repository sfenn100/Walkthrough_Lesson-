namespace NigelAndSam
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
            this.btn_sam = new System.Windows.Forms.Button();
            this.btn_nigel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_sam
            // 
            this.btn_sam.Location = new System.Drawing.Point(13, 13);
            this.btn_sam.Name = "btn_sam";
            this.btn_sam.Size = new System.Drawing.Size(75, 23);
            this.btn_sam.TabIndex = 0;
            this.btn_sam.Text = "Sam";
            this.btn_sam.UseVisualStyleBackColor = true;
            // 
            // btn_nigel
            // 
            this.btn_nigel.Location = new System.Drawing.Point(13, 43);
            this.btn_nigel.Name = "btn_nigel";
            this.btn_nigel.Size = new System.Drawing.Size(75, 23);
            this.btn_nigel.TabIndex = 1;
            this.btn_nigel.Text = "Nigel";
            this.btn_nigel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_nigel);
            this.Controls.Add(this.btn_sam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sam;
        private System.Windows.Forms.Button btn_nigel;
    }
}

