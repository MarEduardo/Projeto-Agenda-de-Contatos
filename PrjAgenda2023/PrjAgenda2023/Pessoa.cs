using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;


namespace PrjAgenda2023
{
	/// <summary>
	/// Description of Pessoa: uma classe responsavel por verificar e validar dados.
	/// </summary>
	public class Pessoa
	{
		private int codigo;
		private string nome, email,fone;
		
		public int Pcodigo
		{
			get{return codigo;}
			set{codigo=value;}
		}
		
		public string Pnome
		{
			get{return nome;}
			set{nome=value;}
		}
		
		public string Pemail
		{
			get{return email;}
			set{email=value;}
		}
		
		public string Ptelefone
		{
			get{return fone;}
			set{fone=value;}
		}
		
		public void InserirPessoa()
		{
			AcessoDados db = new AcessoDados();
			db.Inserir(Pnome,Pemail,Ptelefone);
			db=null;
		}
		
		public void AlterarPessoa()
		{
			AcessoDados db = new AcessoDados();
			db.Alterar(Pcodigo,Pnome,Pemail,Ptelefone);
			db=null;
		}
		
		public void ExcluirPessoa()
		{
			AcessoDados bd = new AcessoDados();
			bd.Excluir(Pcodigo);
			bd=null;
		}
		
		public void CarregarPessoa(int p)
		{
			DataTable dt = new DataTable();
			AcessoDados db = new AcessoDados();
			string parametro;
			parametro = "id=" + p;
			dt = db.Consultar(parametro);
			
			foreach(DataRow row in dt.Rows)
			{
				codigo = Convert.ToInt32(row[0].ToString());
				nome = row[1].ToString();
				email = row[2].ToString();
				fone = row[3].ToString();
			}
			db=null;
		}
		
		public Pessoa()
		{
		}
	}
}
