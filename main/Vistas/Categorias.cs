using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main.Vistas
{
	public partial class Categorias : UserControl
	{

		public Categorias()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Categorias_Load_1(object sender, EventArgs e)
		{
			Form1.ESTADO_VENTANA_CATEGORIAS = true;
		}
	}
}
