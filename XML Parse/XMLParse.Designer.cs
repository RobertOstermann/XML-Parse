namespace XML_Parse
{
    partial class XMLParse
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
            this.uxParse = new System.Windows.Forms.Button();
            this.uxParseTerm = new System.Windows.Forms.TextBox();
            this.uxList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // uxParse
            // 
            this.uxParse.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxParse.Location = new System.Drawing.Point(12, 444);
            this.uxParse.Name = "uxParse";
            this.uxParse.Size = new System.Drawing.Size(776, 46);
            this.uxParse.TabIndex = 1;
            this.uxParse.Text = "Parse";
            this.uxParse.UseVisualStyleBackColor = true;
            this.uxParse.Click += new System.EventHandler(this.uxParse_Click);
            // 
            // uxParseTerm
            // 
            this.uxParseTerm.Location = new System.Drawing.Point(687, 13);
            this.uxParseTerm.Name = "uxParseTerm";
            this.uxParseTerm.Size = new System.Drawing.Size(100, 22);
            this.uxParseTerm.TabIndex = 2;
            // 
            // uxList
            // 
            this.uxList.Location = new System.Drawing.Point(12, 41);
            this.uxList.Name = "uxList";
            this.uxList.Size = new System.Drawing.Size(775, 397);
            this.uxList.TabIndex = 3;
            this.uxList.UseCompatibleStateImageBehavior = false;
            this.uxList.View = System.Windows.Forms.View.List;
            // 
            // XMLParse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.uxList);
            this.Controls.Add(this.uxParseTerm);
            this.Controls.Add(this.uxParse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "XMLParse";
            this.Text = "XML Parse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button uxParse;
        private System.Windows.Forms.TextBox uxParseTerm;
        private System.Windows.Forms.ListView uxList;
    }
}

