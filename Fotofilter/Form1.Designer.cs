namespace Fotofilter
{
    partial class Form1
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avslutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skiftaFärgkanalerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skiftaFärgerGråskalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inverteraFärgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaBildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tillbaksTillStartbildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.LightBlue;
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnOpen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOpen.FlatAppearance.BorderSize = 2;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(12, 141);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(179, 99);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Öppna bild...";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.White;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pbImage.Location = new System.Drawing.Point(318, 12);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(110, 56);
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.bildToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1481, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avslutaToolStripMenuItem});
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.arkivToolStripMenuItem.Text = "Arkiv";
            // 
            // avslutaToolStripMenuItem
            // 
            this.avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            this.avslutaToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.avslutaToolStripMenuItem.Text = "Avsluta";
            this.avslutaToolStripMenuItem.Click += new System.EventHandler(this.avslutaToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skiftaFärgkanalerToolStripMenuItem,
            this.skiftaFärgerGråskalaToolStripMenuItem,
            this.inverteraFärgerToolStripMenuItem,
            this.tillbaksTillStartbildToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // skiftaFärgkanalerToolStripMenuItem
            // 
            this.skiftaFärgkanalerToolStripMenuItem.Name = "skiftaFärgkanalerToolStripMenuItem";
            this.skiftaFärgkanalerToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.skiftaFärgkanalerToolStripMenuItem.Text = "Skifta Färgkanaler RGB";
            this.skiftaFärgkanalerToolStripMenuItem.Click += new System.EventHandler(this.skiftaFärgkanalerToolStripMenuItem_Click);
            // 
            // skiftaFärgerGråskalaToolStripMenuItem
            // 
            this.skiftaFärgerGråskalaToolStripMenuItem.Name = "skiftaFärgerGråskalaToolStripMenuItem";
            this.skiftaFärgerGråskalaToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.skiftaFärgerGråskalaToolStripMenuItem.Text = "Skifta Färger: Gråskala";
            this.skiftaFärgerGråskalaToolStripMenuItem.Click += new System.EventHandler(this.skiftaFärgerGråskalaToolStripMenuItem_Click);
            // 
            // inverteraFärgerToolStripMenuItem
            // 
            this.inverteraFärgerToolStripMenuItem.Name = "inverteraFärgerToolStripMenuItem";
            this.inverteraFärgerToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.inverteraFärgerToolStripMenuItem.Text = "Invertera Färger";
            this.inverteraFärgerToolStripMenuItem.Click += new System.EventHandler(this.inverteraFärgerToolStripMenuItem_Click);
            // 
            // bildToolStripMenuItem
            // 
            this.bildToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.bildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sparaBildToolStripMenuItem});
            this.bildToolStripMenuItem.Name = "bildToolStripMenuItem";
            this.bildToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.bildToolStripMenuItem.Text = "Bild";
            // 
            // sparaBildToolStripMenuItem
            // 
            this.sparaBildToolStripMenuItem.Name = "sparaBildToolStripMenuItem";
            this.sparaBildToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.sparaBildToolStripMenuItem.Text = "Spara Bild";
            this.sparaBildToolStripMenuItem.Click += new System.EventHandler(this.sparaBildToolStripMenuItem_Click);
            // 
            // tillbaksTillStartbildToolStripMenuItem
            // 
            this.tillbaksTillStartbildToolStripMenuItem.Name = "tillbaksTillStartbildToolStripMenuItem";
            this.tillbaksTillStartbildToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.tillbaksTillStartbildToolStripMenuItem.Text = "Tillbaks Till Startbild";
            this.tillbaksTillStartbildToolStripMenuItem.Click += new System.EventHandler(this.tillbaksTillStartbildToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 684);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skiftaFärgkanalerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaBildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skiftaFärgerGråskalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inverteraFärgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tillbaksTillStartbildToolStripMenuItem;
    }
}

