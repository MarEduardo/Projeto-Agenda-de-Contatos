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
		public MySqlConnection AbrirConexao()
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
		
		public void Inserir(string nomeaux, string emailaux, string foneaux){
			MySqlConnection conexao;
			MySqlCommand cmd;
			string Sql;
			
			conexao=AbrirConexao();
			try
			{
				if (conexao!+null){
					Sql="insert into pessoas values (null,'"+nomeaux+"','"+emailaux+"','"+foneaux+"')";
					cmd=new MySqlCommand(Sql,conexao);
					cmd.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro na gravação:"+ex.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{
				conexao.close();
			}
		}
		
		public void Excluir(int idaux){
			MySqlConnection conexao;
			MySqlCommand cmd;
			string Sql;
			
			conexao=AbrirConexao();
			try
			{
				if (conexao!+null){
					Sql="delete from pessoas where id="=idaux;
					cmd=new MySqlCommand(Sql,conexao);
					cmd.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro na exclusão:"+ex.ToString(), "Aviso",
				                MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{
				conexao.close();
			}
		}
		
		public void Alterar(int idaux, string nomeaux, string emailaux, string telefoneaux)
		{
			MySqlConnection conexao;
			MySqlCommand cmd;
			string sql;
			conexao=AbrirConexao();
			try 
			{
				if (conexao!=null) {
					Sql="update pessoas set nome='"+nomeaux+"',"+"email='"+emailaux+"', telefone='"+telefoneaux+"' where id="+idaux;
					cmd=new MySqlCommand(Sql,conexao)
						cmd.ExecuteNonQuery();
				}
	
}
			catch (Exception ex)
			{
				MessageBox.Show("Erro na alteração"+ex.ToString(),"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
			
			finally {
				conexao.Close();
			}
		}
			
		public DataTable Consultar(string filtro) {
			MySqlConnection conexao;
			MySqlCommand cmd;
			string sql;
			conexao=AbrirConexao();
			try 
			{
				if (conexao!=null) {
					sql="select * from pessoas where"+filtro;
					cmd=new MySqlCommand(sql,conexao);
					cmd.CommandType=CommandType.Text;
					MySqlDataAdapter da = new MySqlDataAdaptar(cmd);
					DataTable registros = new DataTable();
					da.Fill(registros);
					conexao.Close();
					return registros;
				}
		}
			catch (Exception ex)
			{
				MessageBox.Show("Erro na alteração"+ex.ToString(),"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
			
			finally {
				conexao.Close();
			}
			
			return null;	
	}
