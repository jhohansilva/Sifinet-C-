using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
	public partial class Form1 : Form
	{
		public static Boolean ESTADO_VENTANA_PRODUCTOS = false;
		public static Boolean ESTADO_VENTANA_CATEGORIAS = false;

		public Form1()
		{
			InitializeComponent();
		}

		private void arhicovToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void gestiónDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var objProductos = new Vistas.Productos();
			//MessageBox.Show(ESTADO_VENTANA + "", "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			if (ESTADO_VENTANA_PRODUCTOS == false)
			{
				inicializarVentanas();
				dashboard.Controls.Clear();
				dashboard.Controls.Add(objProductos);
			}

		}

		private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var objCategorias = new Vistas.Categorias();
			if (ESTADO_VENTANA_CATEGORIAS == false)
			{
				inicializarVentanas();
				dashboard.Controls.Clear();
				dashboard.Controls.Add(objCategorias);
			}
		}

		private void inicializarVentanas()
		{
			ESTADO_VENTANA_CATEGORIAS = false;
			ESTADO_VENTANA_PRODUCTOS = false;
		}
	}
}
