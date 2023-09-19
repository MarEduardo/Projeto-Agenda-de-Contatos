/*
 * Criado por SharpDevelop.
 * Usuário: POLIMIG
 * Data: 19/09/2023
 * Hora: 08:46
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace PrjAgenda2023
{
	/// <summary>
	/// Description of PrjAgendaContatos.
	/// </summary>
	public partial class FrmContatos : Form
	{
			private string Estado;
			public FrmContatos(){
				Estado="Ler";
				InitializeComponent();
			}
			private void limparCampos(){
				TXTCodigo.Clear();
				TXTNome.Clear();
				TXTEmail.Clear();
				MSKTelefone.Clear();
			}
		}
			
		}
		
		

	

