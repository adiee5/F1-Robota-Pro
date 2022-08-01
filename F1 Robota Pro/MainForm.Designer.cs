
namespace F1_Robota_Pro
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonKierowca = new System.Windows.Forms.Button();
            this.buttonZespoły = new System.Windows.Forms.Button();
            this.buttonWyścig = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonKierowca
            // 
            this.buttonKierowca.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKierowca.Location = new System.Drawing.Point(12, 53);
            this.buttonKierowca.Name = "buttonKierowca";
            this.buttonKierowca.Size = new System.Drawing.Size(284, 123);
            this.buttonKierowca.TabIndex = 0;
            this.buttonKierowca.Text = "Ustawienia Kierowców";
            this.buttonKierowca.UseVisualStyleBackColor = true;
            this.buttonKierowca.Click += new System.EventHandler(this.buttonKierowca_Click);
            // 
            // buttonZespoły
            // 
            this.buttonZespoły.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZespoły.Location = new System.Drawing.Point(12, 182);
            this.buttonZespoły.Name = "buttonZespoły";
            this.buttonZespoły.Size = new System.Drawing.Size(284, 123);
            this.buttonZespoły.TabIndex = 1;
            this.buttonZespoły.Text = "Ustawienia Zespołów";
            this.buttonZespoły.UseVisualStyleBackColor = true;
            this.buttonZespoły.Click += new System.EventHandler(this.buttonZespoły_Click);
            // 
            // buttonWyścig
            // 
            this.buttonWyścig.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWyścig.Location = new System.Drawing.Point(12, 373);
            this.buttonWyścig.Name = "buttonWyścig";
            this.buttonWyścig.Size = new System.Drawing.Size(776, 65);
            this.buttonWyścig.TabIndex = 2;
            this.buttonWyścig.Text = "WYŚCIG!!!";
            this.buttonWyścig.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.opcjeToolStripMenuItem.Text = "Opcje";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::F1_Robota_Pro.Properties.Resources.Tło;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonWyścig);
            this.Controls.Add(this.buttonZespoły);
            this.Controls.Add(this.buttonKierowca);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = " F1 Robota Pro";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKierowca;
        private System.Windows.Forms.Button buttonZespoły;
        private System.Windows.Forms.Button buttonWyścig;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
    }
}

