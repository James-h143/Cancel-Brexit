namespace Cancel_Brexit
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
            this.Reply = new System.Windows.Forms.TextBox();
            this.Cancel_Brexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Reply
            // 
            this.Reply.Location = new System.Drawing.Point(12, 12);
            this.Reply.Name = "Reply";
            this.Reply.ReadOnly = true;
            this.Reply.Size = new System.Drawing.Size(260, 20);
            this.Reply.TabIndex = 0;
            // 
            // Cancel_Brexit
            // 
            this.Cancel_Brexit.Location = new System.Drawing.Point(90, 38);
            this.Cancel_Brexit.Name = "Cancel_Brexit";
            this.Cancel_Brexit.Size = new System.Drawing.Size(102, 23);
            this.Cancel_Brexit.TabIndex = 1;
            this.Cancel_Brexit.Text = "Cancel Brexit";
            this.Cancel_Brexit.UseVisualStyleBackColor = true;
            this.Cancel_Brexit.Click += new System.EventHandler(this.Cancel_Brexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 70);
            this.Controls.Add(this.Cancel_Brexit);
            this.Controls.Add(this.Reply);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Reply;
        private System.Windows.Forms.Button Cancel_Brexit;
    }
}

