/*
 * Criado por SharpDevelop.
 * Usuário: POLIMIG
 * Data: 31/10/2023
 * Hora: 09:16
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace PrjAgenda2023
{
	partial class FRMPRINCIPAL
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.contatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.outrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.relogioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Gray;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.contatosToolStripMenuItem,
									this.outrosToolStripMenuItem,
									this.sobreToolStripMenuItem,
									this.sAIRToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(777, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// contatosToolStripMenuItem
			// 
			this.contatosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.contatosToolStripMenuItem.Name = "contatosToolStripMenuItem";
			this.contatosToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
			this.contatosToolStripMenuItem.Text = "Contatos";
			this.contatosToolStripMenuItem.Click += new System.EventHandler(this.ContatosToolStripMenuItemClick);
			// 
			// outrosToolStripMenuItem
			// 
			this.outrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.relogioToolStripMenuItem,
									this.calculadoraToolStripMenuItem});
			this.outrosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.outrosToolStripMenuItem.Name = "outrosToolStripMenuItem";
			this.outrosToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.outrosToolStripMenuItem.Text = "Outros";
			// 
			// relogioToolStripMenuItem
			// 
			this.relogioToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.relogioToolStripMenuItem.Name = "relogioToolStripMenuItem";
			this.relogioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.relogioToolStripMenuItem.Text = "Relogio";
			this.relogioToolStripMenuItem.Click += new System.EventHandler(this.RelogioToolStripMenuItemClick);
			// 
			// calculadoraToolStripMenuItem
			// 
			this.calculadoraToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
			this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
			this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.calculadoraToolStripMenuItem.Text = "Calculadora";
			this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.CalculadoraToolStripMenuItemClick);
			// 
			// sobreToolStripMenuItem
			// 
			this.sobreToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
			this.sobreToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.sobreToolStripMenuItem.Text = "Sobre";
			this.sobreToolStripMenuItem.Click += new System.EventHandler(this.SobreToolStripMenuItemClick);
			// 
			// sAIRToolStripMenuItem
			// 
			this.sAIRToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
			this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.sAIRToolStripMenuItem.Text = "Sair";
			// 
			// FRMPRINCIPAL
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(777, 410);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FRMPRINCIPAL";
			this.Text = "FRMPRINCIPAL";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem relogioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem outrosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem contatosToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
