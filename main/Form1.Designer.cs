namespace main
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.arhicovToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gestiónDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dashboard = new System.Windows.Forms.Panel();
			this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arhicovToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(876, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// arhicovToolStripMenuItem
			// 
			this.arhicovToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDeProductosToolStripMenuItem,
            this.categoriasToolStripMenuItem});
			this.arhicovToolStripMenuItem.Name = "arhicovToolStripMenuItem";
			this.arhicovToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
			this.arhicovToolStripMenuItem.Text = "Productos";
			this.arhicovToolStripMenuItem.Click += new System.EventHandler(this.arhicovToolStripMenuItem_Click);
			// 
			// gestiónDeProductosToolStripMenuItem
			// 
			this.gestiónDeProductosToolStripMenuItem.Name = "gestiónDeProductosToolStripMenuItem";
			this.gestiónDeProductosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.gestiónDeProductosToolStripMenuItem.Text = "Gestión de productos";
			this.gestiónDeProductosToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeProductosToolStripMenuItem_Click);
			// 
			// dashboard
			// 
			this.dashboard.AccessibleName = "dashboard";
			this.dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dashboard.Location = new System.Drawing.Point(0, 24);
			this.dashboard.Name = "dashboard";
			this.dashboard.Size = new System.Drawing.Size(876, 527);
			this.dashboard.TabIndex = 1;
			// 
			// categoriasToolStripMenuItem
			// 
			this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
			this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.categoriasToolStripMenuItem.Text = "Categorias";
			this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(876, 551);
			this.Controls.Add(this.dashboard);
			this.Controls.Add(this.menuStrip1);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem arhicovToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gestiónDeProductosToolStripMenuItem;
		private System.Windows.Forms.Panel dashboard;
		private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
	}
}

