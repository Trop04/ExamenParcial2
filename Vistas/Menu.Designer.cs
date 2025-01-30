namespace ExamenParcial2
{
    partial class Menu
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_ReporteStock = new System.Windows.Forms.Button();
            this.button_Entradas = new System.Windows.Forms.Button();
            this.button_Proveedores = new System.Windows.Forms.Button();
            this.button_Productos = new System.Windows.Forms.Button();
            this.panelPrincipal.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.labelTitulo);
            this.panelPrincipal.Location = new System.Drawing.Point(12, 12);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(963, 474);
            this.panelPrincipal.TabIndex = 0;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelTitulo.Location = new System.Drawing.Point(112, 204);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(767, 58);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Bienvenido al Control del Almacén";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_ReporteStock);
            this.panel2.Controls.Add(this.button_Entradas);
            this.panel2.Controls.Add(this.button_Proveedores);
            this.panel2.Controls.Add(this.button_Productos);
            this.panel2.Location = new System.Drawing.Point(12, 492);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(963, 58);
            this.panel2.TabIndex = 1;
            // 
            // button_ReporteStock
            // 
            this.button_ReporteStock.BackColor = System.Drawing.Color.DarkMagenta;
            this.button_ReporteStock.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ReporteStock.ForeColor = System.Drawing.Color.White;
            this.button_ReporteStock.Location = new System.Drawing.Point(420, 3);
            this.button_ReporteStock.Name = "button_ReporteStock";
            this.button_ReporteStock.Size = new System.Drawing.Size(133, 52);
            this.button_ReporteStock.TabIndex = 3;
            this.button_ReporteStock.Text = "Reporte de Stock";
            this.button_ReporteStock.UseVisualStyleBackColor = false;
            this.button_ReporteStock.Click += new System.EventHandler(this.button_ReporteStock_Click);
            // 
            // button_Entradas
            // 
            this.button_Entradas.BackColor = System.Drawing.Color.DarkMagenta;
            this.button_Entradas.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Entradas.ForeColor = System.Drawing.Color.White;
            this.button_Entradas.Location = new System.Drawing.Point(281, 3);
            this.button_Entradas.Name = "button_Entradas";
            this.button_Entradas.Size = new System.Drawing.Size(133, 52);
            this.button_Entradas.TabIndex = 2;
            this.button_Entradas.Text = "Entradas";
            this.button_Entradas.UseVisualStyleBackColor = false;
            this.button_Entradas.Click += new System.EventHandler(this.button_Entradas_Click);
            // 
            // button_Proveedores
            // 
            this.button_Proveedores.BackColor = System.Drawing.Color.DarkMagenta;
            this.button_Proveedores.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Proveedores.ForeColor = System.Drawing.Color.White;
            this.button_Proveedores.Location = new System.Drawing.Point(142, 3);
            this.button_Proveedores.Name = "button_Proveedores";
            this.button_Proveedores.Size = new System.Drawing.Size(133, 52);
            this.button_Proveedores.TabIndex = 1;
            this.button_Proveedores.Text = "Proveedores";
            this.button_Proveedores.UseVisualStyleBackColor = false;
            this.button_Proveedores.Click += new System.EventHandler(this.button_Proveedores_Click);
            // 
            // button_Productos
            // 
            this.button_Productos.BackColor = System.Drawing.Color.DarkMagenta;
            this.button_Productos.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Productos.ForeColor = System.Drawing.Color.White;
            this.button_Productos.Location = new System.Drawing.Point(3, 3);
            this.button_Productos.Name = "button_Productos";
            this.button_Productos.Size = new System.Drawing.Size(133, 52);
            this.button_Productos.TabIndex = 0;
            this.button_Productos.Text = "Productos";
            this.button_Productos.UseVisualStyleBackColor = false;
            this.button_Productos.Click += new System.EventHandler(this.button_Productos_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu";
            this.Text = "Control de Almacen";
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_ReporteStock;
        private System.Windows.Forms.Button button_Entradas;
        private System.Windows.Forms.Button button_Proveedores;
        private System.Windows.Forms.Button button_Productos;
    }
}

