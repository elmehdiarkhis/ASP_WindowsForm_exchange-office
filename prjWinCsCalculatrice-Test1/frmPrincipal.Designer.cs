namespace prjWinCsCalculatrice_Test1
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatricesMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.standardMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.scientifiqueMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.bureauDeChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromToEuroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currencyToCurrencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quittezMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statutBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manuelUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CalculatriceStandard = new System.Windows.Forms.ToolStripButton();
            this.CalculatriceScientifique = new System.Windows.Forms.ToolStripButton();
            this.BureaudeChangeEuro = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BureaudeChangeCurrencyToCurrency = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmesToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2884, 48);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programmesToolStripMenuItem
            // 
            this.programmesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatricesMnu,
            this.bureauDeChangeToolStripMenuItem,
            this.quittezMnu});
            this.programmesToolStripMenuItem.Name = "programmesToolStripMenuItem";
            this.programmesToolStripMenuItem.Size = new System.Drawing.Size(168, 38);
            this.programmesToolStripMenuItem.Text = "Programmes";
            // 
            // calculatricesMnu
            // 
            this.calculatricesMnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardMnu,
            this.scientifiqueMnu});
            this.calculatricesMnu.Name = "calculatricesMnu";
            this.calculatricesMnu.Size = new System.Drawing.Size(437, 44);
            this.calculatricesMnu.Text = "Calculatrices";
            this.calculatricesMnu.Click += new System.EventHandler(this.calculatricesToolStripMenuItem_Click);
            // 
            // standardMnu
            // 
            this.standardMnu.Name = "standardMnu";
            this.standardMnu.Size = new System.Drawing.Size(358, 44);
            this.standardMnu.Text = "Version Standard";
            this.standardMnu.Click += new System.EventHandler(this.standardMnu_Click);
            // 
            // scientifiqueMnu
            // 
            this.scientifiqueMnu.Name = "scientifiqueMnu";
            this.scientifiqueMnu.Size = new System.Drawing.Size(358, 44);
            this.scientifiqueMnu.Text = "Version Scientifique";
            this.scientifiqueMnu.Click += new System.EventHandler(this.scientifiqueMnu_Click);
            // 
            // bureauDeChangeToolStripMenuItem
            // 
            this.bureauDeChangeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromToEuroToolStripMenuItem,
            this.currencyToCurrencyToolStripMenuItem});
            this.bureauDeChangeToolStripMenuItem.Name = "bureauDeChangeToolStripMenuItem";
            this.bureauDeChangeToolStripMenuItem.Size = new System.Drawing.Size(437, 44);
            this.bureauDeChangeToolStripMenuItem.Text = "Bureau de Change";
            // 
            // fromToEuroToolStripMenuItem
            // 
            this.fromToEuroToolStripMenuItem.Name = "fromToEuroToolStripMenuItem";
            this.fromToEuroToolStripMenuItem.Size = new System.Drawing.Size(618, 44);
            this.fromToEuroToolStripMenuItem.Text = "Version Local - From Currency To (Dollar)";
            this.fromToEuroToolStripMenuItem.Click += new System.EventHandler(this.fromToEuroToolStripMenuItem_Click);
            // 
            // currencyToCurrencyToolStripMenuItem
            // 
            this.currencyToCurrencyToolStripMenuItem.Name = "currencyToCurrencyToolStripMenuItem";
            this.currencyToCurrencyToolStripMenuItem.Size = new System.Drawing.Size(618, 44);
            this.currencyToCurrencyToolStripMenuItem.Text = "Version Online - From Currency To Currency";
            this.currencyToCurrencyToolStripMenuItem.Click += new System.EventHandler(this.currencyToCurrencyToolStripMenuItem_Click);
            // 
            // quittezMnu
            // 
            this.quittezMnu.Name = "quittezMnu";
            this.quittezMnu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.quittezMnu.Size = new System.Drawing.Size(437, 44);
            this.quittezMnu.Text = "Quittez Programme";
            this.quittezMnu.Click += new System.EventHandler(this.quittezMnu_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolToolStripMenuItem,
            this.statutBarToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(85, 44);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(252, 44);
            this.toolToolStripMenuItem.Text = "ToolBar";
            this.toolToolStripMenuItem.Click += new System.EventHandler(this.toolToolStripMenuItem_Click);
            // 
            // statutBarToolStripMenuItem
            // 
            this.statutBarToolStripMenuItem.Name = "statutBarToolStripMenuItem";
            this.statutBarToolStripMenuItem.Size = new System.Drawing.Size(252, 44);
            this.statutBarToolStripMenuItem.Text = "Status Bar";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manuelUtilisateurToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(82, 44);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // manuelUtilisateurToolStripMenuItem
            // 
            this.manuelUtilisateurToolStripMenuItem.Name = "manuelUtilisateurToolStripMenuItem";
            this.manuelUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(342, 44);
            this.manuelUtilisateurToolStripMenuItem.Text = "Manuel Utilisateur";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(342, 44);
            this.aProposToolStripMenuItem.Text = "A Propos ... ...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CalculatriceStandard,
            this.CalculatriceScientifique,
            this.BureaudeChangeEuro,
            this.toolStripSeparator2,
            this.toolStripSeparator1,
            this.BureaudeChangeCurrencyToCurrency});
            this.toolStrip1.Location = new System.Drawing.Point(0, 48);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(2884, 50);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // CalculatriceStandard
            // 
            this.CalculatriceStandard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CalculatriceStandard.Image = global::prjWinCsCalculatrice_Test1.Properties.Resources.calculatrice;
            this.CalculatriceStandard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CalculatriceStandard.Name = "CalculatriceStandard";
            this.CalculatriceStandard.Size = new System.Drawing.Size(46, 44);
            this.CalculatriceStandard.Text = "Calculatrice Standard";
            this.CalculatriceStandard.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // CalculatriceScientifique
            // 
            this.CalculatriceScientifique.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CalculatriceScientifique.Image = global::prjWinCsCalculatrice_Test1.Properties.Resources.calculatrice__1_;
            this.CalculatriceScientifique.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CalculatriceScientifique.Name = "CalculatriceScientifique";
            this.CalculatriceScientifique.Size = new System.Drawing.Size(46, 44);
            this.CalculatriceScientifique.Text = "Calculatrice Scientifique";
            this.CalculatriceScientifique.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // BureaudeChangeEuro
            // 
            this.BureaudeChangeEuro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BureaudeChangeEuro.Image = global::prjWinCsCalculatrice_Test1.Properties.Resources.dollar;
            this.BureaudeChangeEuro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BureaudeChangeEuro.Name = "BureaudeChangeEuro";
            this.BureaudeChangeEuro.Size = new System.Drawing.Size(46, 44);
            this.BureaudeChangeEuro.Text = "Version Local - From Currency To (Dollar)";
            this.BureaudeChangeEuro.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // BureaudeChangeCurrencyToCurrency
            // 
            this.BureaudeChangeCurrencyToCurrency.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BureaudeChangeCurrencyToCurrency.Image = global::prjWinCsCalculatrice_Test1.Properties.Resources.money;
            this.BureaudeChangeCurrencyToCurrency.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BureaudeChangeCurrencyToCurrency.Name = "BureaudeChangeCurrencyToCurrency";
            this.BureaudeChangeCurrencyToCurrency.Size = new System.Drawing.Size(46, 44);
            this.BureaudeChangeCurrencyToCurrency.Text = "Version Online - From Currency To Currency";
            this.BureaudeChangeCurrencyToCurrency.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2884, 1759);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programmesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatricesMnu;
        private System.Windows.Forms.ToolStripMenuItem standardMnu;
        private System.Windows.Forms.ToolStripMenuItem scientifiqueMnu;
        private System.Windows.Forms.ToolStripMenuItem quittezMnu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton CalculatriceStandard;
        private System.Windows.Forms.ToolStripButton CalculatriceScientifique;
        private System.Windows.Forms.ToolStripButton BureaudeChangeEuro;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BureaudeChangeCurrencyToCurrency;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statutBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manuelUtilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bureauDeChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromToEuroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currencyToCurrencyToolStripMenuItem;
    }
}