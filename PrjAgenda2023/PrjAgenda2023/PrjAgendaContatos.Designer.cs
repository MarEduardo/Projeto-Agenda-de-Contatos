/*
 * Criado por SharpDevelop.
 * Usuário: POLIMIG
 * Data: 19/09/2023
 * Hora: 08:46
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace PrjAgenda2023
{
	partial class FrmContatos
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
			this.BTNNovo = new System.Windows.Forms.Button();
			this.BTNSalvar = new System.Windows.Forms.Button();
			this.BTNCancelar = new System.Windows.Forms.Button();
			this.BTNExcluir = new System.Windows.Forms.Button();
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.TCDDados = new System.Windows.Forms.TabPage();
			this.DVGDados = new System.Windows.Forms.DataGridView();
			this.BTNPesquisar = new System.Windows.Forms.Button();
			this.TXTValor = new System.Windows.Forms.TextBox();
			this.MSKTelefone = new System.Windows.Forms.MaskedTextBox();
			this.TXTEmail = new System.Windows.Forms.TextBox();
			this.TXTNome = new System.Windows.Forms.TextBox();
			this.TXTCodigo = new System.Windows.Forms.TextBox();
			this.CMBOperador = new System.Windows.Forms.ComboBox();
			this.CMBCampo = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.TabControl1.SuspendLayout();
			this.TCDDados.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DVGDados)).BeginInit();
			this.SuspendLayout();
			// 
			// BTNNovo
			// 
			this.BTNNovo.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.BTNNovo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.BTNNovo.FlatAppearance.BorderSize = 2;
			this.BTNNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BTNNovo.ForeColor = System.Drawing.Color.Black;
			this.BTNNovo.Location = new System.Drawing.Point(109, 12);
			this.BTNNovo.Name = "BTNNovo";
			this.BTNNovo.Size = new System.Drawing.Size(132, 57);
			this.BTNNovo.TabIndex = 0;
			this.BTNNovo.Text = "Inserir";
			this.BTNNovo.UseVisualStyleBackColor = false;
			// 
			// BTNSalvar
			// 
			this.BTNSalvar.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.BTNSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.BTNSalvar.FlatAppearance.BorderSize = 2;
			this.BTNSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BTNSalvar.Location = new System.Drawing.Point(269, 12);
			this.BTNSalvar.Name = "BTNSalvar";
			this.BTNSalvar.Size = new System.Drawing.Size(132, 57);
			this.BTNSalvar.TabIndex = 1;
			this.BTNSalvar.Text = "Salvar";
			this.BTNSalvar.UseVisualStyleBackColor = false;
			// 
			// BTNCancelar
			// 
			this.BTNCancelar.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.BTNCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.BTNCancelar.FlatAppearance.BorderSize = 2;
			this.BTNCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BTNCancelar.Location = new System.Drawing.Point(431, 12);
			this.BTNCancelar.Name = "BTNCancelar";
			this.BTNCancelar.Size = new System.Drawing.Size(132, 57);
			this.BTNCancelar.TabIndex = 2;
			this.BTNCancelar.Text = "Cancelar";
			this.BTNCancelar.UseVisualStyleBackColor = false;
			// 
			// BTNExcluir
			// 
			this.BTNExcluir.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.BTNExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.BTNExcluir.FlatAppearance.BorderSize = 2;
			this.BTNExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BTNExcluir.Location = new System.Drawing.Point(592, 12);
			this.BTNExcluir.Name = "BTNExcluir";
			this.BTNExcluir.Size = new System.Drawing.Size(132, 57);
			this.BTNExcluir.TabIndex = 3;
			this.BTNExcluir.Text = "Excluir";
			this.BTNExcluir.UseVisualStyleBackColor = false;
			// 
			// TabControl1
			// 
			this.TabControl1.Controls.Add(this.TCDDados);
			this.TabControl1.Controls.Add(this.tabPage2);
			this.TabControl1.Location = new System.Drawing.Point(12, 87);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(842, 452);
			this.TabControl1.TabIndex = 4;
			// 
			// TCDDados
			// 
			this.TCDDados.BackColor = System.Drawing.Color.DimGray;
			this.TCDDados.Controls.Add(this.DVGDados);
			this.TCDDados.Controls.Add(this.BTNPesquisar);
			this.TCDDados.Controls.Add(this.TXTValor);
			this.TCDDados.Controls.Add(this.MSKTelefone);
			this.TCDDados.Controls.Add(this.TXTEmail);
			this.TCDDados.Controls.Add(this.TXTNome);
			this.TCDDados.Controls.Add(this.TXTCodigo);
			this.TCDDados.Controls.Add(this.CMBOperador);
			this.TCDDados.Controls.Add(this.CMBCampo);
			this.TCDDados.Controls.Add(this.label4);
			this.TCDDados.Controls.Add(this.label3);
			this.TCDDados.Controls.Add(this.label2);
			this.TCDDados.Controls.Add(this.label1);
			this.TCDDados.Location = new System.Drawing.Point(4, 22);
			this.TCDDados.Name = "TCDDados";
			this.TCDDados.Padding = new System.Windows.Forms.Padding(3);
			this.TCDDados.Size = new System.Drawing.Size(834, 426);
			this.TCDDados.TabIndex = 0;
			this.TCDDados.Text = "Dados";
			// 
			// DVGDados
			// 
			this.DVGDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DVGDados.Location = new System.Drawing.Point(7, 269);
			this.DVGDados.Name = "DVGDados";
			this.DVGDados.Size = new System.Drawing.Size(821, 150);
			this.DVGDados.TabIndex = 16;
			// 
			// BTNPesquisar
			// 
			this.BTNPesquisar.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.BTNPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.BTNPesquisar.FlatAppearance.BorderSize = 2;
			this.BTNPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BTNPesquisar.Location = new System.Drawing.Point(738, 237);
			this.BTNPesquisar.Name = "BTNPesquisar";
			this.BTNPesquisar.Size = new System.Drawing.Size(90, 23);
			this.BTNPesquisar.TabIndex = 15;
			this.BTNPesquisar.Text = "Pesquisar";
			this.BTNPesquisar.UseVisualStyleBackColor = false;
			// 
			// TXTValor
			// 
			this.TXTValor.Location = new System.Drawing.Point(262, 241);
			this.TXTValor.Name = "TXTValor";
			this.TXTValor.Size = new System.Drawing.Size(469, 20);
			this.TXTValor.TabIndex = 14;
			// 
			// MSKTelefone
			// 
			this.MSKTelefone.Location = new System.Drawing.Point(7, 189);
			this.MSKTelefone.Mask = "(00)0000-0000";
			this.MSKTelefone.Name = "MSKTelefone";
			this.MSKTelefone.Size = new System.Drawing.Size(100, 20);
			this.MSKTelefone.TabIndex = 13;
			// 
			// TXTEmail
			// 
			this.TXTEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.TXTEmail.Location = new System.Drawing.Point(7, 140);
			this.TXTEmail.MaxLength = 150;
			this.TXTEmail.Name = "TXTEmail";
			this.TXTEmail.Size = new System.Drawing.Size(397, 20);
			this.TXTEmail.TabIndex = 12;
			// 
			// TXTNome
			// 
			this.TXTNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.TXTNome.Location = new System.Drawing.Point(7, 90);
			this.TXTNome.MaxLength = 50;
			this.TXTNome.Name = "TXTNome";
			this.TXTNome.Size = new System.Drawing.Size(397, 20);
			this.TXTNome.TabIndex = 11;
			// 
			// TXTCodigo
			// 
			this.TXTCodigo.Enabled = false;
			this.TXTCodigo.Location = new System.Drawing.Point(7, 31);
			this.TXTCodigo.Name = "TXTCodigo";
			this.TXTCodigo.Size = new System.Drawing.Size(100, 20);
			this.TXTCodigo.TabIndex = 10;
			// 
			// CMBOperador
			// 
			this.CMBOperador.FormattingEnabled = true;
			this.CMBOperador.Items.AddRange(new object[] {
									"=",
									"> ",
									"< ",
									">=",
									"<=",
									"<> "});
			this.CMBOperador.Location = new System.Drawing.Point(134, 241);
			this.CMBOperador.Name = "CMBOperador";
			this.CMBOperador.Size = new System.Drawing.Size(121, 21);
			this.CMBOperador.TabIndex = 9;
			// 
			// CMBCampo
			// 
			this.CMBCampo.FormattingEnabled = true;
			this.CMBCampo.Items.AddRange(new object[] {
									"id",
									"nome",
									"email",
									"telefone"});
			this.CMBCampo.Location = new System.Drawing.Point(7, 241);
			this.CMBCampo.Name = "CMBCampo";
			this.CMBCampo.Size = new System.Drawing.Size(121, 21);
			this.CMBCampo.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label4.Location = new System.Drawing.Point(7, 162);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Telefone";
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new System.Drawing.Point(7, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Email";
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(7, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nome";
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(7, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Codigo";
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(834, 426);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// FrmContatos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(866, 551);
			this.Controls.Add(this.TabControl1);
			this.Controls.Add(this.BTNExcluir);
			this.Controls.Add(this.BTNCancelar);
			this.Controls.Add(this.BTNSalvar);
			this.Controls.Add(this.BTNNovo);
			this.Name = "FrmContatos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Contatos";
			this.TabControl1.ResumeLayout(false);
			this.TCDDados.ResumeLayout(false);
			this.TCDDados.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DVGDados)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox CMBCampo;
		private System.Windows.Forms.ComboBox CMBOperador;
		private System.Windows.Forms.TextBox TXTCodigo;
		private System.Windows.Forms.TextBox TXTNome;
		private System.Windows.Forms.TextBox TXTEmail;
		private System.Windows.Forms.MaskedTextBox MSKTelefone;
		private System.Windows.Forms.TextBox TXTValor;
		private System.Windows.Forms.Button BTNPesquisar;
		private System.Windows.Forms.DataGridView DVGDados;
		private System.Windows.Forms.TabPage TCDDados;
		private System.Windows.Forms.TabControl TabControl1;
		private System.Windows.Forms.Button BTNExcluir;
		private System.Windows.Forms.Button BTNCancelar;
		private System.Windows.Forms.Button BTNSalvar;
		private System.Windows.Forms.Button BTNNovo;
		

	}
}
