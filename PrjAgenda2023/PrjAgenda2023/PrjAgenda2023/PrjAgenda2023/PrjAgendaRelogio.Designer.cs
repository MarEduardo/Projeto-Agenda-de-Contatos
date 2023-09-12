/*
 * Criado por SharpDevelop.
 * Usuário: POLIMIG
 * Data: 12/09/2023
 * Hora: 09:05
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace PrjAgenda2023
{
	partial class FrmRelogio
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelogio));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.TmrRelogio = new System.Windows.Forms.Timer(this.components);
			this.LblHora = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(97, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(258, 218);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// TmrRelogio
			// 
			this.TmrRelogio.Enabled = true;
			this.TmrRelogio.Interval = 1000;
			this.TmrRelogio.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// LblHora
			// 
			this.LblHora.BackColor = System.Drawing.Color.Silver;
			this.LblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LblHora.Location = new System.Drawing.Point(141, 111);
			this.LblHora.Name = "LblHora";
			this.LblHora.Size = new System.Drawing.Size(169, 49);
			this.LblHora.TabIndex = 1;
			// 
			// FrmRelogio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(467, 262);
			this.Controls.Add(this.LblHora);
			this.Controls.Add(this.pictureBox1);
			this.Name = "FrmRelogio";
			this.Text = "PrjAgendaRelogio";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label LblHora;
		private System.Windows.Forms.Timer TmrRelogio;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
