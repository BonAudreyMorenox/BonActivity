namespace BonActivity
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
            this.items = new System.Windows.Forms.ListBox();
            this.changeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // items
            // 
            this.items.FormattingEnabled = true;
            this.items.ItemHeight = 20;
            this.items.Location = new System.Drawing.Point(187, 72);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(401, 204);
            this.items.TabIndex = 0;
            // 
            // changeBtn
            // 
            this.changeBtn.Location = new System.Drawing.Point(477, 282);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(111, 42);
            this.changeBtn.TabIndex = 1;
            this.changeBtn.Text = "change";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.items);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox items;
        private System.Windows.Forms.Button changeBtn;
    }
}

