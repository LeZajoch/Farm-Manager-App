using System.ComponentModel;

namespace Farm_Manager
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.EconomyMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EconomyMenuButton
            // 
            this.EconomyMenuButton.Location = new System.Drawing.Point(47, 43);
            this.EconomyMenuButton.Name = "EconomyMenuButton";
            this.EconomyMenuButton.Size = new System.Drawing.Size(110, 35);
            this.EconomyMenuButton.TabIndex = 11;
            this.EconomyMenuButton.Text = "Economy\r\n";
            this.EconomyMenuButton.UseVisualStyleBackColor = true;
            this.EconomyMenuButton.Click += new System.EventHandler(this.EconomyMenuButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 582);
            this.Controls.Add(this.EconomyMenuButton);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button EconomyMenuButton;

        #endregion
    }
}