namespace Parkplatzverwaltung
{
    partial class Parkplatzverwaltung
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
            this.lboCarPool = new System.Windows.Forms.ListBox();
            this.lboParkingLot = new System.Windows.Forms.ListBox();
            this.cmdDriveIn = new System.Windows.Forms.Button();
            this.cmdDriveOut = new System.Windows.Forms.Button();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.cmdAddCar = new System.Windows.Forms.Button();
            this.cmdDeleteCar = new System.Windows.Forms.Button();
            this.cmdDailyEarnings = new System.Windows.Forms.Button();
            this.lblEarnings = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernSchließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lboCarPool
            // 
            this.lboCarPool.FormattingEnabled = true;
            this.lboCarPool.ItemHeight = 25;
            this.lboCarPool.Location = new System.Drawing.Point(67, 90);
            this.lboCarPool.Name = "lboCarPool";
            this.lboCarPool.Size = new System.Drawing.Size(424, 454);
            this.lboCarPool.TabIndex = 0;
            // 
            // lboParkingLot
            // 
            this.lboParkingLot.FormattingEnabled = true;
            this.lboParkingLot.ItemHeight = 25;
            this.lboParkingLot.Location = new System.Drawing.Point(883, 90);
            this.lboParkingLot.Name = "lboParkingLot";
            this.lboParkingLot.Size = new System.Drawing.Size(410, 454);
            this.lboParkingLot.TabIndex = 1;
            // 
            // cmdDriveIn
            // 
            this.cmdDriveIn.Location = new System.Drawing.Point(549, 90);
            this.cmdDriveIn.Name = "cmdDriveIn";
            this.cmdDriveIn.Size = new System.Drawing.Size(289, 79);
            this.cmdDriveIn.TabIndex = 2;
            this.cmdDriveIn.Text = "Einparken";
            this.cmdDriveIn.UseVisualStyleBackColor = true;
            this.cmdDriveIn.Click += new System.EventHandler(this.cmdDriveIn_Click);
            // 
            // cmdDriveOut
            // 
            this.cmdDriveOut.Location = new System.Drawing.Point(549, 200);
            this.cmdDriveOut.Name = "cmdDriveOut";
            this.cmdDriveOut.Size = new System.Drawing.Size(289, 86);
            this.cmdDriveOut.TabIndex = 3;
            this.cmdDriveOut.Text = "Ausparken";
            this.cmdDriveOut.UseVisualStyleBackColor = true;
            this.cmdDriveOut.Click += new System.EventHandler(this.cmdDriveOut_Click);
            // 
            // txtCarName
            // 
            this.txtCarName.Location = new System.Drawing.Point(67, 576);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.Size = new System.Drawing.Size(100, 31);
            this.txtCarName.TabIndex = 4;
            // 
            // cmdAddCar
            // 
            this.cmdAddCar.Location = new System.Drawing.Point(67, 642);
            this.cmdAddCar.Name = "cmdAddCar";
            this.cmdAddCar.Size = new System.Drawing.Size(424, 82);
            this.cmdAddCar.TabIndex = 5;
            this.cmdAddCar.Text = "Auto hinzufügen";
            this.cmdAddCar.UseVisualStyleBackColor = true;
            this.cmdAddCar.Click += new System.EventHandler(this.cmdAddCar_Click);
            // 
            // cmdDeleteCar
            // 
            this.cmdDeleteCar.Location = new System.Drawing.Point(67, 756);
            this.cmdDeleteCar.Name = "cmdDeleteCar";
            this.cmdDeleteCar.Size = new System.Drawing.Size(424, 90);
            this.cmdDeleteCar.TabIndex = 6;
            this.cmdDeleteCar.Text = "Ausgewähltes Auto löschen";
            this.cmdDeleteCar.UseVisualStyleBackColor = true;
            this.cmdDeleteCar.Click += new System.EventHandler(this.cmdDeleteCar_Click);
            // 
            // cmdDailyEarnings
            // 
            this.cmdDailyEarnings.Location = new System.Drawing.Point(883, 642);
            this.cmdDailyEarnings.Name = "cmdDailyEarnings";
            this.cmdDailyEarnings.Size = new System.Drawing.Size(410, 82);
            this.cmdDailyEarnings.TabIndex = 8;
            this.cmdDailyEarnings.Text = "Tageseinnahmen";
            this.cmdDailyEarnings.UseVisualStyleBackColor = true;
            this.cmdDailyEarnings.Click += new System.EventHandler(this.cmdDailyEarnings_Click);
            // 
            // lblEarnings
            // 
            this.lblEarnings.AutoSize = true;
            this.lblEarnings.Location = new System.Drawing.Point(883, 576);
            this.lblEarnings.Name = "lblEarnings";
            this.lblEarnings.Size = new System.Drawing.Size(0, 25);
            this.lblEarnings.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1736, 40);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFile_toolStripMenuItem,
            this.speichernToolStripMenuItem,
            this.speichernSchließenToolStripMenuItem,
            this.schließenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(83, 36);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // OpenFile_toolStripMenuItem
            // 
            this.OpenFile_toolStripMenuItem.Name = "OpenFile_toolStripMenuItem";
            this.OpenFile_toolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.OpenFile_toolStripMenuItem.Text = "Datei öffnen";
            this.OpenFile_toolStripMenuItem.Click += new System.EventHandler(this.OpenFile_toolStripMenuItem_Click);
            // 
            // schließenToolStripMenuItem
            // 
            this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
            this.schließenToolStripMenuItem.Size = new System.Drawing.Size(379, 38);
            this.schließenToolStripMenuItem.Text = "Schließen";
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(379, 38);
            this.speichernToolStripMenuItem.Text = "Speichern";
            // 
            // speichernSchließenToolStripMenuItem
            // 
            this.speichernSchließenToolStripMenuItem.Name = "speichernSchließenToolStripMenuItem";
            this.speichernSchließenToolStripMenuItem.Size = new System.Drawing.Size(379, 38);
            this.speichernSchließenToolStripMenuItem.Text = "Speichern und Schließen";
            // 
            // Parkplatzverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1736, 1094);
            this.Controls.Add(this.lblEarnings);
            this.Controls.Add(this.cmdDailyEarnings);
            this.Controls.Add(this.cmdDeleteCar);
            this.Controls.Add(this.cmdAddCar);
            this.Controls.Add(this.txtCarName);
            this.Controls.Add(this.cmdDriveOut);
            this.Controls.Add(this.cmdDriveIn);
            this.Controls.Add(this.lboParkingLot);
            this.Controls.Add(this.lboCarPool);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Parkplatzverwaltung";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboCarPool;
        private System.Windows.Forms.ListBox lboParkingLot;
        private System.Windows.Forms.Button cmdDriveIn;
        private System.Windows.Forms.Button cmdDriveOut;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.Button cmdAddCar;
        private System.Windows.Forms.Button cmdDeleteCar;
        private System.Windows.Forms.Button cmdDailyEarnings;
        private System.Windows.Forms.Label lblEarnings;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFile_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernSchließenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem;
    }
}

