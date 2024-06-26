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
    public partial class frmBaseDatosOperaciones : Form
    {
        public frmBaseDatosOperaciones()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmBaseDatosOperaciones_Load(object sender, EventArgs e)
        {

        }

        clsBaseDeDatos objBaseDatos = new clsBaseDeDatos();

        private void btnProyecciónSimple_Click(object sender, EventArgs e)
        {

            string varSQL = "SELECT Titulo " +
                "FROM Libro " +
                "ORDER BY 1 DESC";
            objBaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnProyecciónMultiatributo_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT IdLibro, Titulo " +
                "FROM Libro " +
                "ORDER BY 1 DESC"; ;
            objBaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT * " +
                "FROM Libro, Idioma " +
                "WHERE Libro.IdIdioma = Idioma.IdIdioma";
            objBaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnSelecciónSimple_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT * " +
                "FROM Libro " +
                "WHERE IdAutor = 3";
            objBaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnSelecciónMultiatributo_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT * FROM Libro " +
                "WHERE IdAutor=3 " +
                "AND IdPais=3";
            objBaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnSelecciónConvulción_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT * " +
                "FROM (SELECT * FROM Libro as T1 WHERE T1.IdIdioma > 5) " +
                "as T2 WHERE T2.IdAutor > 10";
            objBaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnUnión_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT * FROM Libro WHERE IdAutor = 2 " +
               "UNION " +
               "SELECT* FROM Libro WHERE IdAutor = 5 " +
               "UNION " +
               "SELECT* FROM Libro WHERE IdAutor = 3";
            objBaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnIntersección_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT * FROM Libro WHERE IdIdioma " +
                "IN " +
                "(SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5)";
            objBaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT * FROM Libro WHERE IdIdioma " +
                "NOT IN " +
                "(SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma< 5)";
            objBaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        
    }
}
