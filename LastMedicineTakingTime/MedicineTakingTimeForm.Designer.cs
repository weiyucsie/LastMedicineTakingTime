namespace LastMedicineTakingTime
{
    partial class MedicineTakingTimeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LastMedicineTakingTimeTextBlock = new System.Windows.Forms.TextBox();
            this.LogTImeButton = new System.Windows.Forms.Button();
            this.MedicineTakingTimeLogFileTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LastMedicineTakingTimeTextBlock
            // 
            this.LastMedicineTakingTimeTextBlock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastMedicineTakingTimeTextBlock.Location = new System.Drawing.Point(12, 12);
            this.LastMedicineTakingTimeTextBlock.Multiline = true;
            this.LastMedicineTakingTimeTextBlock.Name = "LastMedicineTakingTimeTextBlock";
            this.LastMedicineTakingTimeTextBlock.ReadOnly = true;
            this.LastMedicineTakingTimeTextBlock.Size = new System.Drawing.Size(776, 389);
            this.LastMedicineTakingTimeTextBlock.TabIndex = 0;
            // 
            // LogTImeButton
            // 
            this.LogTImeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LogTImeButton.Location = new System.Drawing.Point(713, 415);
            this.LogTImeButton.Name = "LogTImeButton";
            this.LogTImeButton.Size = new System.Drawing.Size(75, 23);
            this.LogTImeButton.TabIndex = 1;
            this.LogTImeButton.Text = "紀錄時間";
            this.LogTImeButton.UseVisualStyleBackColor = true;
            this.LogTImeButton.Click += new System.EventHandler(this.LogTImeButton_Click);
            // 
            // MedicineTakingTimeLogFileTextBox
            // 
            this.MedicineTakingTimeLogFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MedicineTakingTimeLogFileTextBox.Location = new System.Drawing.Point(13, 415);
            this.MedicineTakingTimeLogFileTextBox.Name = "MedicineTakingTimeLogFileTextBox";
            this.MedicineTakingTimeLogFileTextBox.ReadOnly = true;
            this.MedicineTakingTimeLogFileTextBox.Size = new System.Drawing.Size(694, 23);
            this.MedicineTakingTimeLogFileTextBox.TabIndex = 2;
            // 
            // MedicineTakingTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MedicineTakingTimeLogFileTextBox);
            this.Controls.Add(this.LogTImeButton);
            this.Controls.Add(this.LastMedicineTakingTimeTextBlock);
            this.Name = "MedicineTakingTimeForm";
            this.Text = "最後吃藥時間";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox LastMedicineTakingTimeTextBlock;
        private Button LogTImeButton;
        private TextBox MedicineTakingTimeLogFileTextBox;
    }
}