using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using Libreria;

namespace InventarioProclean
{
    public partial class Ventana_Proveedores : Form
    {
        public Ventana_Proveedores()
        {
            InitializeComponent();
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            if (this.txtRutProveedor.Text.Trim().Length == 0)
            {
                toolTip1.Show("Rut no puede quedar en blanco.", txtRutProveedor);
                Libreria.Utilidades.LimpiarForm(this);
            }
            else if (this.txtNombreIngreso.Text.Trim().Length == 0)
            {
                toolTip1.Show("Rut no puede quedar en blanco.", txtNombreIngreso);
                Libreria.Utilidades.LimpiarForm(this);
            }
            else
            {
                MongoHandler MH = new MongoHandler(
                "mongodb://" + ConfigurationManager.AppSettings["ServidorMongo"],
                ConfigurationManager.AppSettings["BDMongo"]);
                if (MH.mensaje.Length != 0)
                {
                    MessageBox.Show(MH.mensaje.ToString());
                }
                else
                {
                    Proveedor P = new Proveedor
                    {
                        Rut = this.txtRutProveedor.Text,
                        Nombre = this.txtNombreIngreso.Text,
                        NombreFantasia = this.txtNombreFantaIngreso.Text,
                        Mail = this.txtMailIngreso.Text,
                        Telefonos = this.txtFonosIngreso.Text.Split(',').ToList(),
                        Direccion = this.txtDireccionIngreso.Text
                    };
                    if (MH.GuardarProveedor(P))
                    {
                        MessageBox.Show(MH.mensaje.ToString(), "Estado Ingreso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txtRutProveedor.Focus();
                        Libreria.Utilidades.LimpiarForm(this);
                    }
                    else
                    {
                        MessageBox.Show(MH.mensaje.ToString(), "Estado Ingreso",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }

        private void Ventana_Proveedores_Load(object sender, EventArgs e)
        {
            MongoHandler MH = new MongoHandler(
                "mongodb://" + ConfigurationManager.AppSettings["ServidorMongo"],
                ConfigurationManager.AppSettings["BDMongo"]);
            if (MH.mensaje.Length != 0)
            {
                MessageBox.Show(MH.mensaje.ToString());
            }
            else
            {
                List<Proveedor> proveedores = MH.getProveedores();
                Dictionary<String, String> data = new Dictionary<string, string>();
                foreach (Proveedor p in proveedores)
                {                    
                    data.Add(p.Rut, p.Nombre);
                }
                this.cmbProveedores.DataSource = new BindingSource(data, null);
                this.cmbProveedores.DisplayMember = "Value";
                this.cmbProveedores.ValueMember = "Key";
            }
        }

        private void cmbProveedores_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MessageBox.Show(this.cmbProveedores.SelectedValue.ToString());
        }
    }
}
