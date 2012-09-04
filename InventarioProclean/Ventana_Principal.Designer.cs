namespace InventarioProclean
{
    partial class Ventana_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.códigosYProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.órdenesDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centrosDeCostosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.generalesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(708, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoFacturasToolStripMenuItem,
            this.egresosToolStripMenuItem,
            this.códigosYProductosToolStripMenuItem,
            this.órdenesDeComprasToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // ingresoFacturasToolStripMenuItem
            // 
            this.ingresoFacturasToolStripMenuItem.Name = "ingresoFacturasToolStripMenuItem";
            this.ingresoFacturasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.ingresoFacturasToolStripMenuItem.Text = "Ingreso Facturas";
            this.ingresoFacturasToolStripMenuItem.Click += new System.EventHandler(this.ingresoFacturasToolStripMenuItem_Click);
            // 
            // egresosToolStripMenuItem
            // 
            this.egresosToolStripMenuItem.Name = "egresosToolStripMenuItem";
            this.egresosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.egresosToolStripMenuItem.Text = "Egresos";
            this.egresosToolStripMenuItem.Click += new System.EventHandler(this.egresosToolStripMenuItem_Click);
            // 
            // códigosYProductosToolStripMenuItem
            // 
            this.códigosYProductosToolStripMenuItem.Name = "códigosYProductosToolStripMenuItem";
            this.códigosYProductosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.códigosYProductosToolStripMenuItem.Text = "Códigos y Productos";
            this.códigosYProductosToolStripMenuItem.Click += new System.EventHandler(this.códigosYProductosToolStripMenuItem_Click);
            // 
            // órdenesDeComprasToolStripMenuItem
            // 
            this.órdenesDeComprasToolStripMenuItem.Name = "órdenesDeComprasToolStripMenuItem";
            this.órdenesDeComprasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.órdenesDeComprasToolStripMenuItem.Text = "Órdenes de Compras";
            this.órdenesDeComprasToolStripMenuItem.Click += new System.EventHandler(this.órdenesDeComprasToolStripMenuItem_Click);
            // 
            // generalesToolStripMenuItem
            // 
            this.generalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centrosDeCostosToolStripMenuItem});
            this.generalesToolStripMenuItem.Name = "generalesToolStripMenuItem";
            this.generalesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.generalesToolStripMenuItem.Text = "Generales";
            // 
            // centrosDeCostosToolStripMenuItem
            // 
            this.centrosDeCostosToolStripMenuItem.Name = "centrosDeCostosToolStripMenuItem";
            this.centrosDeCostosToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.centrosDeCostosToolStripMenuItem.Text = "Centros de Costos";
            this.centrosDeCostosToolStripMenuItem.Click += new System.EventHandler(this.centrosDeCostosToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(708, 363);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(357, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(348, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(357, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(348, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(702, 302);
            this.dataGridView1.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha Movimiento";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "$ Unidad";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio Medio";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Orden de Compra";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Ventana_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 387);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Ventana_Principal";
            this.Text = "Ventana Principal";
            this.Load += new System.EventHandler(this.Ventana_Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem egresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem códigosYProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem órdenesDeComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centrosDeCostosToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

