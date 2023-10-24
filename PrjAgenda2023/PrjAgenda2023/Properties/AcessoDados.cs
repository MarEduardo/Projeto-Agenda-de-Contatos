/*
 * Criado por SharpDevelop.
 * Usuário: POLIMIG
 * Data: 26/09/2023
 * Hora: 08:47
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace PrjAgenda2023
{
	/// <summary>
	/// Description of AcessoDados.
	/// </summary>
	public class AcessoDados
	{
		public MySqlConnection AbrirConexão()
		{
			string strconexao = "server=localhost;uid=root;password=polimigmysql;database=bdcontatos";
			MySqlConnection BancoDados;
			try
			{
				BancoDados = new MySqlConnection(strconexao);
				BancoDados.Open();
				return BancoDados;
			}
			catch(Exception ex)
			{
				MessageBox.Show("Erro na conexão como banco de dados!"+ex.ToString(),"Aviso!",
				                MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			return null;	
			
		}
	}
}
