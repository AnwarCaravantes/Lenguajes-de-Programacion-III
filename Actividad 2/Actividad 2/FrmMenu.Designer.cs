namespace Actividad_2
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saludoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosPersonalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesBasicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saludoToolStripMenuItem,
            this.datosPersonalesToolStripMenuItem,
            this.operacionesBasicasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(583, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saludoToolStripMenuItem
            // 
            this.saludoToolStripMenuItem.Name = "saludoToolStripMenuItem";
            this.saludoToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.saludoToolStripMenuItem.Text = "Saludo";
            this.saludoToolStripMenuItem.Click += new System.EventHandler(this.saludoToolStripMenuItem_Click);
            // 
            // datosPersonalesToolStripMenuItem
            // 
            this.datosPersonalesToolStripMenuItem.Name = "datosPersonalesToolStripMenuItem";
            this.datosPersonalesToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.datosPersonalesToolStripMenuItem.Text = "Datos Personales";
            this.datosPersonalesToolStripMenuItem.Click += new System.EventHandler(this.datosPersonalesToolStripMenuItem_Click);
            // 
            // operacionesBasicasToolStripMenuItem
            // 
            this.operacionesBasicasToolStripMenuItem.Name = "operacionesBasicasToolStripMenuItem";
            this.operacionesBasicasToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.operacionesBasicasToolStripMenuItem.Text = "Operaciones Basicas";
            this.operacionesBasicasToolStripMenuItem.Click += new System.EventHandler(this.operacionesBasicasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 389);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 432);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Menú";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saludoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosPersonalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesBasicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}