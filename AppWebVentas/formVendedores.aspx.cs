using Datos.Admin;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppWebVentas
{
    public partial class formVendedores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            gridVendedores.DataSource = AdmVendedor.Listar();
            gridVendedores.DataBind();
        }

        protected void btnTraerPorComision_Click(object sender, EventArgs e)
        {
            decimal comision = Convert.ToDecimal(txtComision.Text);

            gridVendedores.DataSource = AdmVendedor.TraerVendedores(comision);
            gridVendedores.DataBind();
        }

        protected void btnTraerPorId_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            gridVendedores.DataSource = AdmVendedor.TraerPorId(id);
            gridVendedores.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor(txtNombre.Text, txtApellido.Text,txtDni.Text, Convert.ToDecimal(txtComision.Text));

            int filasAfectadas = AdmVendedor.Insertar(vendedor);

            Actualizar(filasAfectadas);
        }
        private void Actualizar(int filasAfectadas)
        {
            if (filasAfectadas > 0)
            {
                MostrarDatos();
            }

            if (!Page.IsPostBack)
            {
                MostrarDatos();
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor(txtNombre.Text, txtApellido.Text,txtDni.Text, Convert.ToDecimal(txtComision.Text), Convert.ToInt32(txtId.Text));

            int filasAfectadas = AdmVendedor.Modificar(vendedor);
            Actualizar(filasAfectadas);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int filasAfectadas = AdmVendedor.Eliminar(Convert.ToInt32(txtId.Text));
            Actualizar(filasAfectadas);
        }
    }
}