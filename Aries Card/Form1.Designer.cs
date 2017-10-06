namespace Aries_Card
{
    partial class backScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(backScreen));
            this.conGratz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // conGratz
            // 
            this.conGratz.BackColor = System.Drawing.Color.MidnightBlue;
            this.conGratz.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.conGratz.Location = new System.Drawing.Point(14, 69);
            this.conGratz.Name = "conGratz";
            this.conGratz.Size = new System.Drawing.Size(411, 189);
            this.conGratz.TabIndex = 0;
            this.conGratz.Text = "Congratstellations on the Promotion!!!";
            this.conGratz.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.conGratz.Click += new System.EventHandler(this.label1_Click);
            // 
            // backScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(437, 416);
            this.Controls.Add(this.conGratz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "backScreen";
            this.Text = "Congratulations from Aries";
            this.Click += new System.EventHandler(this.formatBack_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label conGratz;
    }
}

