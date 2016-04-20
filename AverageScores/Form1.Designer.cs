namespace AverageScores
{
    partial class frmMain
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.FirstScores = new System.Windows.Forms.ListBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Average";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.BackColor = System.Drawing.Color.White;
            this.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAverage.Location = new System.Drawing.Point(212, 12);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(15, 15);
            this.lblAverage.TabIndex = 2;
            this.lblAverage.Text = "0";
            // 
            // FirstScores
            // 
            this.FirstScores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstScores.FormattingEnabled = true;
            this.FirstScores.Location = new System.Drawing.Point(12, 49);
            this.FirstScores.Name = "FirstScores";
            this.FirstScores.Size = new System.Drawing.Size(260, 186);
            this.FirstScores.TabIndex = 3;
            // 
            // ofd
            // 
            this.ofd.Filter = "Text (.txt)|*.txt|All (*.*)|*.*";
            this.ofd.Title = "Open Scores File";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.FirstScores);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpen);
            this.Name = "frmMain";
            this.Text = "Average Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.ListBox FirstScores;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}

