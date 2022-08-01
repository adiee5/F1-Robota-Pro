
namespace F1_Robota_Pro
{
    partial class DodajForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajForm));
            this.NazwaBox = new System.Windows.Forms.TextBox();
            this.DoneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NazwaBox
            // 
            this.NazwaBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NazwaBox.Location = new System.Drawing.Point(13, 13);
            this.NazwaBox.Name = "NazwaBox";
            this.NazwaBox.Size = new System.Drawing.Size(291, 20);
            this.NazwaBox.TabIndex = 0;
            // 
            // DoneButton
            // 
            this.DoneButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DoneButton.Location = new System.Drawing.Point(120, 39);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 23);
            this.DoneButton.TabIndex = 1;
            this.DoneButton.Text = "OK";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // DodajForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 72);
            this.ControlBox = false;
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.NazwaBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajForm";
            this.Text = "DodajKierowceForm";
            this.Load += new System.EventHandler(this.DodajForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NazwaBox;
        private System.Windows.Forms.Button DoneButton;
    }
}