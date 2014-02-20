namespace Dota2Pricechecker
{
    partial class Pricechecker
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pricechecker));
            this.backgroundWorkerCurrency = new System.ComponentModel.BackgroundWorker();
            this.groupBoxWarehouse = new System.Windows.Forms.GroupBox();
            this.labelGold = new System.Windows.Forms.Label();
            this.labelItemname = new System.Windows.Forms.LinkLabel();
            this.groupBoxMarket = new System.Windows.Forms.GroupBox();
            this.textBoxMarketQuotes = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crawlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lookUpItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.checkBoxTopMost = new System.Windows.Forms.CheckBox();
            this.backgroundWorkerPricecheck = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxWarehouse.SuspendLayout();
            this.groupBoxMarket.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorkerCurrency
            // 
            this.backgroundWorkerCurrency.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCurrency_DoWork);
            // 
            // groupBoxWarehouse
            // 
            this.groupBoxWarehouse.AutoSize = true;
            this.groupBoxWarehouse.Controls.Add(this.labelGold);
            this.groupBoxWarehouse.Controls.Add(this.labelItemname);
            this.groupBoxWarehouse.Location = new System.Drawing.Point(12, 73);
            this.groupBoxWarehouse.Name = "groupBoxWarehouse";
            this.groupBoxWarehouse.Size = new System.Drawing.Size(200, 72);
            this.groupBoxWarehouse.TabIndex = 0;
            this.groupBoxWarehouse.TabStop = false;
            this.groupBoxWarehouse.Text = "Dota 2 Warehouse";
            // 
            // labelGold
            // 
            this.labelGold.AutoSize = true;
            this.labelGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGold.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelGold.Location = new System.Drawing.Point(7, 40);
            this.labelGold.Name = "labelGold";
            this.labelGold.Size = new System.Drawing.Size(124, 16);
            this.labelGold.TabIndex = 1;
            this.labelGold.Text = "-- Gold Amount --";
            // 
            // labelItemname
            // 
            this.labelItemname.AutoSize = true;
            this.labelItemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemname.LinkColor = System.Drawing.Color.Black;
            this.labelItemname.Location = new System.Drawing.Point(7, 20);
            this.labelItemname.Name = "labelItemname";
            this.labelItemname.Size = new System.Drawing.Size(110, 16);
            this.labelItemname.TabIndex = 0;
            this.labelItemname.TabStop = true;
            this.labelItemname.Text = "-- Item Name --";
            this.labelItemname.VisitedLinkColor = System.Drawing.Color.Black;
            this.labelItemname.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelItemname_LinkClicked);
            // 
            // groupBoxMarket
            // 
            this.groupBoxMarket.Controls.Add(this.textBoxMarketQuotes);
            this.groupBoxMarket.Location = new System.Drawing.Point(12, 151);
            this.groupBoxMarket.Name = "groupBoxMarket";
            this.groupBoxMarket.Size = new System.Drawing.Size(131, 223);
            this.groupBoxMarket.TabIndex = 1;
            this.groupBoxMarket.TabStop = false;
            this.groupBoxMarket.Text = "Dota 2 Marketplace";
            // 
            // textBoxMarketQuotes
            // 
            this.textBoxMarketQuotes.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxMarketQuotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMarketQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMarketQuotes.Location = new System.Drawing.Point(8, 20);
            this.textBoxMarketQuotes.Multiline = true;
            this.textBoxMarketQuotes.Name = "textBoxMarketQuotes";
            this.textBoxMarketQuotes.ReadOnly = true;
            this.textBoxMarketQuotes.Size = new System.Drawing.Size(115, 197);
            this.textBoxMarketQuotes.TabIndex = 0;
            this.textBoxMarketQuotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(221, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crawlerToolStripMenuItem,
            this.lookUpItemToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // crawlerToolStripMenuItem
            // 
            this.crawlerToolStripMenuItem.Name = "crawlerToolStripMenuItem";
            this.crawlerToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.crawlerToolStripMenuItem.Text = "Crawler";
            // 
            // lookUpItemToolStripMenuItem
            // 
            this.lookUpItemToolStripMenuItem.Name = "lookUpItemToolStripMenuItem";
            this.lookUpItemToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.lookUpItemToolStripMenuItem.Text = "Item Lookup";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.checkBoxTopMost);
            this.groupBoxOptions.Location = new System.Drawing.Point(12, 28);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(200, 39);
            this.groupBoxOptions.TabIndex = 3;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // checkBoxTopMost
            // 
            this.checkBoxTopMost.AutoSize = true;
            this.checkBoxTopMost.Location = new System.Drawing.Point(10, 16);
            this.checkBoxTopMost.Name = "checkBoxTopMost";
            this.checkBoxTopMost.Size = new System.Drawing.Size(71, 17);
            this.checkBoxTopMost.TabIndex = 0;
            this.checkBoxTopMost.Text = "Top Most";
            this.checkBoxTopMost.UseVisualStyleBackColor = true;
            this.checkBoxTopMost.CheckedChanged += new System.EventHandler(this.checkBoxTopMost_CheckedChanged);
            // 
            // backgroundWorkerPricecheck
            // 
            this.backgroundWorkerPricecheck.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerPricecheck_DoWork);
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Pricechecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 386);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.groupBoxMarket);
            this.Controls.Add(this.groupBoxWarehouse);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Pricechecker";
            this.Text = "Dota 2 Pricechecker";
            this.groupBoxWarehouse.ResumeLayout(false);
            this.groupBoxWarehouse.PerformLayout();
            this.groupBoxMarket.ResumeLayout(false);
            this.groupBoxMarket.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorkerCurrency;
        private System.Windows.Forms.GroupBox groupBoxWarehouse;
        private System.Windows.Forms.GroupBox groupBoxMarket;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crawlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lookUpItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label labelGold;
        private System.Windows.Forms.LinkLabel labelItemname;
        private System.Windows.Forms.TextBox textBoxMarketQuotes;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.CheckBox checkBoxTopMost;
        private System.ComponentModel.BackgroundWorker backgroundWorkerPricecheck;
        private System.Windows.Forms.Timer timer1;
    }
}

