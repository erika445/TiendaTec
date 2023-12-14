namespace TiendaTec
{
    partial class dgvCategoriaProductos
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
            this.dataCategoriaProductos = new System.Windows.Forms.DataGridView();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblNombreCategoria = new System.Windows.Forms.Label();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.txtDescripcionCategoria = new System.Windows.Forms.TextBox();
            this.lblDescripcionCategoria = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbCategoriaProductos = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataCategoriaProductos)).BeginInit();
            this.gbCategoriaProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataCategoriaProductos
            // 
            this.dataCategoriaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dataCategoriaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCategoriaProductos.Location = new System.Drawing.Point(304, 19);
            this.dataCategoriaProductos.Name = "dataCategoriaProductos";
            this.dataCategoriaProductos.Size = new System.Drawing.Size(357, 221);
            this.dataCategoriaProductos.TabIndex = 0;
            this.dataCategoriaProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCategoriaProductos_CellClick);
            this.dataCategoriaProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCategoriaProductos_CellDoubleClick);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.btnInsertar.Location = new System.Drawing.Point(9, 258);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(84, 40);
            this.btnInsertar.TabIndex = 1;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.btnMostrar.Location = new System.Drawing.Point(98, 258);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(84, 40);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(107)))), ((int)(((byte)(57)))));
            this.btnBorrar.Enabled = false;
            this.btnBorrar.Location = new System.Drawing.Point(188, 258);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(84, 40);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(141)))), ((int)(((byte)(88)))));
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Location = new System.Drawing.Point(278, 258);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(84, 40);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblNombreCategoria
            // 
            this.lblNombreCategoria.AutoSize = true;
            this.lblNombreCategoria.Location = new System.Drawing.Point(6, 16);
            this.lblNombreCategoria.Name = "lblNombreCategoria";
            this.lblNombreCategoria.Size = new System.Drawing.Size(91, 13);
            this.lblNombreCategoria.TabIndex = 5;
            this.lblNombreCategoria.Text = "Nombre categoria";
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Location = new System.Drawing.Point(6, 32);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(274, 20);
            this.txtNombreCategoria.TabIndex = 6;
            // 
            // txtDescripcionCategoria
            // 
            this.txtDescripcionCategoria.Location = new System.Drawing.Point(8, 71);
            this.txtDescripcionCategoria.Name = "txtDescripcionCategoria";
            this.txtDescripcionCategoria.Size = new System.Drawing.Size(274, 20);
            this.txtDescripcionCategoria.TabIndex = 8;
            // 
            // lblDescripcionCategoria
            // 
            this.lblDescripcionCategoria.AutoSize = true;
            this.lblDescripcionCategoria.Location = new System.Drawing.Point(6, 55);
            this.lblDescripcionCategoria.Name = "lblDescripcionCategoria";
            this.lblDescripcionCategoria.Size = new System.Drawing.Size(110, 13);
            this.lblDescripcionCategoria.TabIndex = 7;
            this.lblDescripcionCategoria.Text = "Descripcion categoria";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(141)))), ((int)(((byte)(88)))));
            this.btnSalir.Location = new System.Drawing.Point(368, 258);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 40);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // gbCategoriaProductos
            // 
            this.gbCategoriaProductos.Controls.Add(this.lblDescripcionCategoria);
            this.gbCategoriaProductos.Controls.Add(this.btnSalir);
            this.gbCategoriaProductos.Controls.Add(this.lblNombreCategoria);
            this.gbCategoriaProductos.Controls.Add(this.txtNombreCategoria);
            this.gbCategoriaProductos.Controls.Add(this.btnActualizar);
            this.gbCategoriaProductos.Controls.Add(this.txtDescripcionCategoria);
            this.gbCategoriaProductos.Controls.Add(this.btnBorrar);
            this.gbCategoriaProductos.Controls.Add(this.dataCategoriaProductos);
            this.gbCategoriaProductos.Controls.Add(this.btnMostrar);
            this.gbCategoriaProductos.Controls.Add(this.btnInsertar);
            this.gbCategoriaProductos.Location = new System.Drawing.Point(2, 12);
            this.gbCategoriaProductos.Name = "gbCategoriaProductos";
            this.gbCategoriaProductos.Size = new System.Drawing.Size(676, 304);
            this.gbCategoriaProductos.TabIndex = 19;
            this.gbCategoriaProductos.TabStop = false;
            this.gbCategoriaProductos.Text = "Categoria productos";
            // 
            // dgvCategoriaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 328);
            this.Controls.Add(this.gbCategoriaProductos);
            this.Name = "dgvCategoriaProductos";
            this.Text = "CategoriaProductos";
            this.Load += new System.EventHandler(this.dgvCategoriaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCategoriaProductos)).EndInit();
            this.gbCategoriaProductos.ResumeLayout(false);
            this.gbCategoriaProductos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCategoriaProductos;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblNombreCategoria;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.TextBox txtDescripcionCategoria;
        private System.Windows.Forms.Label lblDescripcionCategoria;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbCategoriaProductos;
    }
}