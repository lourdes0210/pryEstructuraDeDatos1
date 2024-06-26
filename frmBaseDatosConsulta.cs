using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDeDatos1
{
    public partial class frmBaseDatosConsulta : Form
    {
        public frmBaseDatosConsulta()
        {
            InitializeComponent();
        }

        private void frmBaseDatosConsulta_Load(object sender, EventArgs e)
        {

        }

        

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsBaseDeDatos objBaseDatos = new clsBaseDeDatos();
            objBaseDatos.Listar(dgvDatos, txtSql.Text);
        }
    }
}
