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
	public partial class Productos : UserControl
	{
		
		public Productos()
		{
			InitializeComponent();
		}

		private void Productos_Load(object sender, EventArgs e)
		{
			Form1.ESTADO_VENTANA_PRODUCTOS = true;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
