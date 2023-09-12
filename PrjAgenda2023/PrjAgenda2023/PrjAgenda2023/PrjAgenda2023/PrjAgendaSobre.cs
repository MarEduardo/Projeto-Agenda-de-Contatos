/*
 * Criado por SharpDevelop.
 * Usuário: POLIMIG
 * Data: 12/09/2023
 * Hora: 08:10
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PrjAgenda2023
{
	/// <summary>
	/// Description of PrjAgendaSobre.
	/// </summary>
	public partial class FrmSobre : Form
	{
		public FrmSobre()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BTNOKClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
