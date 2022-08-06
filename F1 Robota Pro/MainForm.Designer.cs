
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
            this.otwórzFolderZUstawieniamiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.memyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atakujeMnieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mcLarenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numLoops = new System.Windows.Forms.NumericUpDown();
            this.checkDeszcz = new System.Windows.Forms.CheckBox();
            this.output = new System.Windows.Forms.TextBox();
            this.btnExportCsv = new System.Windows.Forms.Button();
            this.csvExportWindow = new System.Windows.Forms.SaveFileDialog();
            this.checkNoDnf = new System.Windows.Forms.CheckBox();
            this.polaStartoweToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zczytajZOutputuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLoops)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKierowca
            // 
            this.buttonKierowca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(20)))));
            this.buttonKierowca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKierowca.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKierowca.ForeColor = System.Drawing.Color.Red;
            this.buttonKierowca.Location = new System.Drawing.Point(12, 35);
            this.buttonKierowca.Name = "buttonKierowca";
            this.buttonKierowca.Size = new System.Drawing.Size(284, 123);
            this.buttonKierowca.TabIndex = 0;
            this.buttonKierowca.Text = "Ustawienia Kierowców";
            this.buttonKierowca.UseVisualStyleBackColor = false;
            this.buttonKierowca.Click += new System.EventHandler(this.buttonKierowca_Click);
            // 
            // buttonZespoły
            // 
            this.buttonZespoły.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(20)))));
            this.buttonZespoły.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZespoły.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZespoły.ForeColor = System.Drawing.Color.Red;
            this.buttonZespoły.Location = new System.Drawing.Point(12, 164);
            this.buttonZespoły.Name = "buttonZespoły";
            this.buttonZespoły.Size = new System.Drawing.Size(284, 123);
            this.buttonZespoły.TabIndex = 1;
            this.buttonZespoły.Text = "Ustawienia Zespołów";
            this.buttonZespoły.UseVisualStyleBackColor = false;
            this.buttonZespoły.Click += new System.EventHandler(this.buttonZespoły_Click);
            // 
            // buttonWyścig
            // 
            this.buttonWyścig.BackColor = System.Drawing.Color.Red;
            this.buttonWyścig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWyścig.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWyścig.Location = new System.Drawing.Point(12, 373);
            this.buttonWyścig.Name = "buttonWyścig";
            this.buttonWyścig.Size = new System.Drawing.Size(776, 65);
            this.buttonWyścig.TabIndex = 2;
            this.buttonWyścig.Text = "WYŚCIG!!!";
            this.buttonWyścig.UseVisualStyleBackColor = false;
            this.buttonWyścig.Click += new System.EventHandler(this.buttonWyścig_Click);
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
            this.opcjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzFolderZUstawieniamiToolStripMenuItem,
            this.toolStripSeparator1,
            this.memyToolStripMenuItem,
            this.polaStartoweToolStripMenuItem});
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.opcjeToolStripMenuItem.Text = "Opcje";
            // 
            // otwórzFolderZUstawieniamiToolStripMenuItem
            // 
            this.otwórzFolderZUstawieniamiToolStripMenuItem.Name = "otwórzFolderZUstawieniamiToolStripMenuItem";
            this.otwórzFolderZUstawieniamiToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.otwórzFolderZUstawieniamiToolStripMenuItem.Text = "Otwórz Folder z Ustawieniami";
            this.otwórzFolderZUstawieniamiToolStripMenuItem.Click += new System.EventHandler(this.otwórzFolderZUstawieniamiToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(227, 6);
            // 
            // memyToolStripMenuItem
            // 
            this.memyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atakujeMnieToolStripMenuItem,
            this.mcLarenToolStripMenuItem});
            this.memyToolStripMenuItem.Name = "memyToolStripMenuItem";
            this.memyToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.memyToolStripMenuItem.Text = "Memy";
            // 
            // atakujeMnieToolStripMenuItem
            // 
            this.atakujeMnieToolStripMenuItem.Name = "atakujeMnieToolStripMenuItem";
            this.atakujeMnieToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.atakujeMnieToolStripMenuItem.Text = "Atakuje mnie";
            this.atakujeMnieToolStripMenuItem.Click += new System.EventHandler(this.atakujeMnieToolStripMenuItem_Click);
            // 
            // mcLarenToolStripMenuItem
            // 
            this.mcLarenToolStripMenuItem.Name = "mcLarenToolStripMenuItem";
            this.mcLarenToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.mcLarenToolStripMenuItem.Text = "McLaren";
            this.mcLarenToolStripMenuItem.Click += new System.EventHandler(this.mcLarenToolStripMenuItem_Click);
            // 
            // numLoops
            // 
            this.numLoops.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(20)))));
            this.numLoops.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numLoops.ForeColor = System.Drawing.Color.Red;
            this.numLoops.Location = new System.Drawing.Point(166, 347);
            this.numLoops.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLoops.Name = "numLoops";
            this.numLoops.Size = new System.Drawing.Size(130, 20);
            this.numLoops.TabIndex = 4;
            this.numLoops.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkDeszcz
            // 
            this.checkDeszcz.AutoSize = true;
            this.checkDeszcz.BackColor = System.Drawing.Color.Transparent;
            this.checkDeszcz.ForeColor = System.Drawing.Color.Red;
            this.checkDeszcz.Location = new System.Drawing.Point(166, 309);
            this.checkDeszcz.Name = "checkDeszcz";
            this.checkDeszcz.Size = new System.Drawing.Size(61, 17);
            this.checkDeszcz.TabIndex = 5;
            this.checkDeszcz.Text = "Deszcz";
            this.checkDeszcz.UseVisualStyleBackColor = false;
            // 
            // output
            // 
            this.output.AcceptsReturn = true;
            this.output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(20)))));
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output.ForeColor = System.Drawing.Color.Red;
            this.output.Location = new System.Drawing.Point(515, 35);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output.Size = new System.Drawing.Size(273, 332);
            this.output.TabIndex = 37;
            // 
            // btnExportCsv
            // 
            this.btnExportCsv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(20)))));
            this.btnExportCsv.Enabled = false;
            this.btnExportCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCsv.ForeColor = System.Drawing.Color.Red;
            this.btnExportCsv.Location = new System.Drawing.Point(12, 293);
            this.btnExportCsv.Name = "btnExportCsv";
            this.btnExportCsv.Size = new System.Drawing.Size(148, 74);
            this.btnExportCsv.TabIndex = 38;
            this.btnExportCsv.Text = "Wyeksportuj do Tabelki";
            this.btnExportCsv.UseVisualStyleBackColor = false;
            this.btnExportCsv.Click += new System.EventHandler(this.btnExportCsv_Click);
            // 
            // csvExportWindow
            // 
            this.csvExportWindow.DefaultExt = "csv";
            this.csvExportWindow.Filter = "Tabela CSV|*.csv";
            this.csvExportWindow.Title = "Zapisz Tabelkę Jako";
            this.csvExportWindow.FileOk += new System.ComponentModel.CancelEventHandler(this.csvExportWindow_FileOk);
            // 
            // checkNoDnf
            // 
            this.checkNoDnf.AutoSize = true;
            this.checkNoDnf.BackColor = System.Drawing.Color.Transparent;
            this.checkNoDnf.ForeColor = System.Drawing.Color.Red;
            this.checkNoDnf.Location = new System.Drawing.Point(166, 293);
            this.checkNoDnf.Name = "checkNoDnf";
            this.checkNoDnf.Size = new System.Drawing.Size(88, 17);
            this.checkNoDnf.TabIndex = 39;
            this.checkNoDnf.Text = "Wyłącz DNF";
            this.checkNoDnf.UseVisualStyleBackColor = false;
            // 
            // polaStartoweToolStripMenuItem
            // 
            this.polaStartoweToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edytujToolStripMenuItem,
            this.zczytajZOutputuToolStripMenuItem,
            this.resetujToolStripMenuItem});
            this.polaStartoweToolStripMenuItem.Name = "polaStartoweToolStripMenuItem";
            this.polaStartoweToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.polaStartoweToolStripMenuItem.Text = "Pola Startowe";
            // 
            // edytujToolStripMenuItem
            // 
            this.edytujToolStripMenuItem.Name = "edytujToolStripMenuItem";
            this.edytujToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.edytujToolStripMenuItem.Text = "Edytuj";
            this.edytujToolStripMenuItem.Click += new System.EventHandler(this.edytujToolStripMenuItem_Click);
            // 
            // zczytajZOutputuToolStripMenuItem
            // 
            this.zczytajZOutputuToolStripMenuItem.Name = "zczytajZOutputuToolStripMenuItem";
            this.zczytajZOutputuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zczytajZOutputuToolStripMenuItem.Text = "Zczytaj z Outputu";
            this.zczytajZOutputuToolStripMenuItem.Click += new System.EventHandler(this.zczytajZOutputuToolStripMenuItem_Click);
            // 
            // resetujToolStripMenuItem
            // 
            this.resetujToolStripMenuItem.Name = "resetujToolStripMenuItem";
            this.resetujToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetujToolStripMenuItem.Text = "Resetuj";
            this.resetujToolStripMenuItem.Click += new System.EventHandler(this.resetujToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::F1_Robota_Pro.Properties.Resources.Tło;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkNoDnf);
            this.Controls.Add(this.btnExportCsv);
            this.Controls.Add(this.output);
            this.Controls.Add(this.checkDeszcz);
            this.Controls.Add(this.numLoops);
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
            ((System.ComponentModel.ISupportInitialize)(this.numLoops)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKierowca;
        private System.Windows.Forms.Button buttonZespoły;
        private System.Windows.Forms.Button buttonWyścig;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzFolderZUstawieniamiToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numLoops;
        private System.Windows.Forms.CheckBox checkDeszcz;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button btnExportCsv;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SaveFileDialog csvExportWindow;
        private System.Windows.Forms.CheckBox checkNoDnf;
        private System.Windows.Forms.ToolStripMenuItem memyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mcLarenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atakujeMnieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polaStartoweToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zczytajZOutputuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetujToolStripMenuItem;
    }
}

