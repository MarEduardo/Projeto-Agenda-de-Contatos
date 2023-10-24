using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace PrjAgenda2023
{
	/// <summary>
	/// Description of MainForm.
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
		
		void SobreToolStripMenuItemClick(object sender, EventArgs e)
		{
			FrmSobre fs = new FrmSobre();
			fs.Show();
		}
		
		void ToolStripButton2Click(object sender, EventArgs e)
		{
			FrmRelogio fr = new FrmRelogio();
			fr.Show();
		}
		
		void FRMPRINCIPALLoad(object sender, EventArgs e)
		{
			
		}
		
		void ToolStripButton3Click(object sender, EventArgs e)
		{
			Process.Start("C:/Windows/System32/Calc.exe");
		}
		
		void ContatosToolStripMenuItemClick(object sender, EventArgs e)
		{
			FrmContatos fc = new FrmContatos();
			fc.Show();
		}
	}
}
