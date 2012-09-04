using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventarioProclean
{
    public partial class Ventana_Principal : Form
    {        
        public Ventana_Principal()
        {
            InitializeComponent();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventana_Proveedores venProv = new Ventana_Proveedores();
            venProv.ShowDialog();
        }

        private void ingresoFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventana_Facturas venFac = new Ventana_Facturas();
            venFac.ShowDialog();
        }

        private void egresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventana_Egresos venEgr = new Ventana_Egresos();
            venEgr.ShowDialog();
        }

        private void códigosYProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventana_Codigos venCod = new Ventana_Codigos();
            venCod.ShowDialog();
        }

        private void órdenesDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventana_Orden venOrd = new Ventana_Orden();
            venOrd.ShowDialog();
        }

        private void centrosDeCostosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventana_Centros venCen = new Ventana_Centros();
            venCen.ShowDialog();
        }

        private void Ventana_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
