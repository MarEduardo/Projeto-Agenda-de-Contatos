/*
 * Criado por SharpDevelop.
 * Usuário: POLIMIG
 * Data: 31/10/2023
 * Hora: 09:11
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PrjAgenda2023
{
	/// <summary>
	/// Description of FrmAbout.
	/// </summary>
	public partial class FrmAbout : Form
	{
		public FrmAbout()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
