namespace TagBuilder
{
    partial class KepwareTagBuilder
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
            this.btnCreateCSV = new System.Windows.Forms.Button();
            this.btnAddFloatTags = new System.Windows.Forms.Button();
            this.btnAddIntegerTags = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateCSV
            // 
            this.btnCreateCSV.Location = new System.Drawing.Point(12, 32);
            this.btnCreateCSV.Name = "btnCreateCSV";
            this.btnCreateCSV.Size = new System.Drawing.Size(139, 41);
            this.btnCreateCSV.TabIndex = 0;
            this.btnCreateCSV.Text = "Create CSV";
            this.btnCreateCSV.UseVisualStyleBackColor = true;
            this.btnCreateCSV.Click += new System.EventHandler(this.btnCreateCSV_Click);
            // 
            // btnAddFloatTags
            // 
            this.btnAddFloatTags.Location = new System.Drawing.Point(12, 94);
            this.btnAddFloatTags.Name = "btnAddFloatTags";
            this.btnAddFloatTags.Size = new System.Drawing.Size(139, 44);
            this.btnAddFloatTags.TabIndex = 1;
            this.btnAddFloatTags.Text = "Add Float Tags";
            this.btnAddFloatTags.UseVisualStyleBackColor = true;
            this.btnAddFloatTags.Click += new System.EventHandler(this.btnAddFloatTags_Click);
            // 
            // btnAddIntegerTags
            // 
            this.btnAddIntegerTags.Location = new System.Drawing.Point(12, 158);
            this.btnAddIntegerTags.Name = "btnAddIntegerTags";
            this.btnAddIntegerTags.Size = new System.Drawing.Size(139, 50);
            this.btnAddIntegerTags.TabIndex = 2;
            this.btnAddIntegerTags.Text = "Add Integer Tags";
            this.btnAddIntegerTags.UseVisualStyleBackColor = true;
            this.btnAddIntegerTags.Click += new System.EventHandler(this.btnAddIntegerTags_Click);
            // 
            // KepwareTagBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 388);
            this.Controls.Add(this.btnAddIntegerTags);
            this.Controls.Add(this.btnAddFloatTags);
            this.Controls.Add(this.btnCreateCSV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KepwareTagBuilder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KepwareTagBuilder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateCSV;
        private System.Windows.Forms.Button btnAddFloatTags;
        private System.Windows.Forms.Button btnAddIntegerTags;
    }
}