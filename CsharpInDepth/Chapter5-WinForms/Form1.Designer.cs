namespace Chapter5_WinForms
{
    partial class AsyncIntro
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
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonLoadPage = new System.Windows.Forms.Button();
            this.richTextBoxPageContents = new System.Windows.Forms.RichTextBox();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.checkBoxHEADRequest = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(108, 40);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 13);
            this.labelStatus.TabIndex = 0;
            // 
            // buttonLoadPage
            // 
            this.buttonLoadPage.Location = new System.Drawing.Point(16, 35);
            this.buttonLoadPage.Name = "buttonLoadPage";
            this.buttonLoadPage.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadPage.TabIndex = 1;
            this.buttonLoadPage.Text = "Load Page";
            this.buttonLoadPage.UseVisualStyleBackColor = true;
            this.buttonLoadPage.Click += new System.EventHandler(this.DisplayWebPage);
            // 
            // richTextBoxPageContents
            // 
            this.richTextBoxPageContents.Location = new System.Drawing.Point(16, 74);
            this.richTextBoxPageContents.Name = "richTextBoxPageContents";
            this.richTextBoxPageContents.Size = new System.Drawing.Size(1172, 814);
            this.richTextBoxPageContents.TabIndex = 2;
            this.richTextBoxPageContents.Text = "";
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(16, 9);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(496, 20);
            this.textBoxUrl.TabIndex = 3;
            // 
            // checkBoxHEADRequest
            // 
            this.checkBoxHEADRequest.AutoSize = true;
            this.checkBoxHEADRequest.Location = new System.Drawing.Point(555, 12);
            this.checkBoxHEADRequest.Name = "checkBoxHEADRequest";
            this.checkBoxHEADRequest.Size = new System.Drawing.Size(94, 17);
            this.checkBoxHEADRequest.TabIndex = 4;
            this.checkBoxHEADRequest.Text = "HEAD request";
            this.checkBoxHEADRequest.UseVisualStyleBackColor = true;
            // 
            // AsyncIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 900);
            this.Controls.Add(this.checkBoxHEADRequest);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.richTextBoxPageContents);
            this.Controls.Add(this.buttonLoadPage);
            this.Controls.Add(this.labelStatus);
            this.Name = "AsyncIntro";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonLoadPage;
        private System.Windows.Forms.RichTextBox richTextBoxPageContents;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.CheckBox checkBoxHEADRequest;
    }
}

