
namespace F1_Robota_Pro
{
    partial class ZespołyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZespołyForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbZespoły = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbLoopTime = new System.Windows.Forms.TextBox();
            this.numDnf = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obecnyKierowcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńNazwęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopiujDoNowegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.usuńWszystkichToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cofnijWszystkieOstatnieZmianyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.SetButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDnf)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel1.Controls.Add(this.cmbZespoły, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txbLoopTime, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numDnf, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(516, 56);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cmbZespoły
            // 
            this.cmbZespoły.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbZespoły.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZespoły.FormattingEnabled = true;
            this.cmbZespoły.Location = new System.Drawing.Point(3, 23);
            this.cmbZespoły.Name = "cmbZespoły";
            this.cmbZespoły.Size = new System.Drawing.Size(181, 21);
            this.cmbZespoły.TabIndex = 0;
            this.cmbZespoły.SelectedIndexChanged += new System.EventHandler(this.cmbKierowcy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zespół";
            // 
            // txbLoopTime
            // 
            this.txbLoopTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbLoopTime.Location = new System.Drawing.Point(190, 23);
            this.txbLoopTime.Name = "txbLoopTime";
            this.txbLoopTime.Size = new System.Drawing.Size(181, 20);
            this.txbLoopTime.TabIndex = 3;
            // 
            // numDnf
            // 
            this.numDnf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numDnf.Location = new System.Drawing.Point(377, 23);
            this.numDnf.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numDnf.Name = "numDnf";
            this.numDnf.Size = new System.Drawing.Size(136, 20);
            this.numDnf.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(408, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wytrzymałość";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(262, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Osiągi";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(541, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obecnyKierowcaToolStripMenuItem,
            this.toolStripSeparator1,
            this.usuńWszystkichToolStripMenuItem,
            this.cofnijWszystkieOstatnieZmianyToolStripMenuItem});
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.opcjeToolStripMenuItem.Text = "Opcje";
            // 
            // obecnyKierowcaToolStripMenuItem
            // 
            this.obecnyKierowcaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zmieńNazwęToolStripMenuItem,
            this.kopiujDoNowegoToolStripMenuItem,
            this.usuńToolStripMenuItem});
            this.obecnyKierowcaToolStripMenuItem.Name = "obecnyKierowcaToolStripMenuItem";
            this.obecnyKierowcaToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.obecnyKierowcaToolStripMenuItem.Text = "Obecny Kierowca";
            // 
            // zmieńNazwęToolStripMenuItem
            // 
            this.zmieńNazwęToolStripMenuItem.Name = "zmieńNazwęToolStripMenuItem";
            this.zmieńNazwęToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.zmieńNazwęToolStripMenuItem.Text = "Zmień nazwę";
            this.zmieńNazwęToolStripMenuItem.Click += new System.EventHandler(this.zmieńNazwęToolStripMenuItem_Click);
            // 
            // kopiujDoNowegoToolStripMenuItem
            // 
            this.kopiujDoNowegoToolStripMenuItem.Name = "kopiujDoNowegoToolStripMenuItem";
            this.kopiujDoNowegoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.kopiujDoNowegoToolStripMenuItem.Text = "Kopiuj do Nowego";
            this.kopiujDoNowegoToolStripMenuItem.Click += new System.EventHandler(this.kopiujDoNowegoToolStripMenuItem_Click);
            // 
            // usuńToolStripMenuItem
            // 
            this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            this.usuńToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.usuńToolStripMenuItem.Text = "Usuń";
            this.usuńToolStripMenuItem.Click += new System.EventHandler(this.usuńToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(247, 6);
            // 
            // usuńWszystkichToolStripMenuItem
            // 
            this.usuńWszystkichToolStripMenuItem.Name = "usuńWszystkichToolStripMenuItem";
            this.usuńWszystkichToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.usuńWszystkichToolStripMenuItem.Text = "Usuń Wszystkich";
            this.usuńWszystkichToolStripMenuItem.Click += new System.EventHandler(this.usuńWszystkichToolStripMenuItem_Click);
            // 
            // cofnijWszystkieOstatnieZmianyToolStripMenuItem
            // 
            this.cofnijWszystkieOstatnieZmianyToolStripMenuItem.Name = "cofnijWszystkieOstatnieZmianyToolStripMenuItem";
            this.cofnijWszystkieOstatnieZmianyToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.cofnijWszystkieOstatnieZmianyToolStripMenuItem.Text = "Cofnij Wszystkie Ostatnie Zmiany";
            this.cofnijWszystkieOstatnieZmianyToolStripMenuItem.Click += new System.EventHandler(this.cofnijWszystkieOstatnieZmianyToolStripMenuItem_Click);
            // 
            // AddNewButton
            // 
            this.AddNewButton.Location = new System.Drawing.Point(12, 89);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(75, 42);
            this.AddNewButton.TabIndex = 3;
            this.AddNewButton.Text = "Dodaj Nowego";
            this.AddNewButton.UseVisualStyleBackColor = true;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(235, 89);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(75, 42);
            this.SetButton.TabIndex = 4;
            this.SetButton.Text = "Zatwierdź";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // ZespołyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(541, 140);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ZespołyForm";
            this.Text = "Zespoły";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KierowcyForm_FormClosing);
            this.Load += new System.EventHandler(this.KierowcyForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDnf)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cmbZespoły;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.ToolStripMenuItem obecnyKierowcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmieńNazwęToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopiujDoNowegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem usuńWszystkichToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cofnijWszystkieOstatnieZmianyToolStripMenuItem;
        private System.Windows.Forms.TextBox txbLoopTime;
        private System.Windows.Forms.NumericUpDown numDnf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}