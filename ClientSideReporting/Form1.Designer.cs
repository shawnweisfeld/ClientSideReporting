namespace ClientSideReporting
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
            this.btnReportViewer = new System.Windows.Forms.Button();
            this.btnGenerateInCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReportViewer
            // 
            this.btnReportViewer.Location = new System.Drawing.Point(59, 72);
            this.btnReportViewer.Name = "btnReportViewer";
            this.btnReportViewer.Size = new System.Drawing.Size(177, 23);
            this.btnReportViewer.TabIndex = 0;
            this.btnReportViewer.Text = "Report Viewer";
            this.btnReportViewer.UseVisualStyleBackColor = true;
            this.btnReportViewer.Click += new System.EventHandler(this.btnReportViewer_Click);
            // 
            // btnGenerateInCode
            // 
            this.btnGenerateInCode.Location = new System.Drawing.Point(59, 131);
            this.btnGenerateInCode.Name = "btnGenerateInCode";
            this.btnGenerateInCode.Size = new System.Drawing.Size(177, 23);
            this.btnGenerateInCode.TabIndex = 1;
            this.btnGenerateInCode.Text = "Generate In Code";
            this.btnGenerateInCode.UseVisualStyleBackColor = true;
            this.btnGenerateInCode.Click += new System.EventHandler(this.btnGenerateInCode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 398);
            this.Controls.Add(this.btnGenerateInCode);
            this.Controls.Add(this.btnReportViewer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReportViewer;
        private System.Windows.Forms.Button btnGenerateInCode;
    }
}

