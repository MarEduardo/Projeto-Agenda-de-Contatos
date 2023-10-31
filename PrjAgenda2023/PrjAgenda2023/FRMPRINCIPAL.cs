/*
 * Criado por SharpDevelop.
 * Usuário: POLIMIG
 * Data: 31/10/2023
 * Hora: 09:16
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PrjAgenda2023
{
	/// <summary>
	/// Description of FRMPRINCIPAL.
	/// </summary>
	public partial class FRMPRINCIPAL : Form
	{
		public FRMPRINCIPAL()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ContatosToolStripMenuItemClick(object sender, EventArgs e)
		{
			FrmContatos f = new FrmContatos();
			f.Show();
		}
		
		void SobreToolStripMenuItemClick(object sender, EventArgs e)
		{
			FrmAbout a = new FrmAbout();
			a.Show();
		}
		
		void RelogioToolStripMenuItemClick(object sender, EventArgs e)
		{
			FrmRelogio r = new FrmRelogio();
			r.Show();
		}
		
		void CalculadoraToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
	}
}
