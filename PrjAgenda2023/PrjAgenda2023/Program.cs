/*
 * Criado por SharpDevelop.
 * Usuário: POLIMIG
 * Data: 05/09/2023
 * Hora: 09:12
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Windows.Forms;

namespace PrjAgenda2023
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FRMPRINCIPAL());
		}
		
	}
}
