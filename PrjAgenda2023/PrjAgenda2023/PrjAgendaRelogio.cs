/*
 * Criado por SharpDevelop.
 * Usuário: POLIMIG
 * Data: 12/09/2023
 * Hora: 09:05
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PrjAgenda2023
{
	/// <summary>
	/// Description of PrjAgendaRelogio.
	/// </summary>
	public partial class FrmRelogio : Form
	{
		public FrmRelogio()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			LblHora.Text = DateTime.Now.ToLongTimeString();			
		}
		
	}
}
