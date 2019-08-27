namespace GestionDeClientes
{
    partial class formGestionDeC
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstCustomer = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTotalCustomers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCustomer
            // 
            this.lstCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colLastName,
            this.colAddress});
            this.lstCustomer.FullRowSelect = true;
            this.lstCustomer.HideSelection = false;
            this.lstCustomer.Location = new System.Drawing.Point(12, 122);
            this.lstCustomer.Name = "lstCustomer";
            this.lstCustomer.Size = new System.Drawing.Size(788, 473);
            this.lstCustomer.TabIndex = 0;
            this.lstCustomer.UseCompatibleStateImageBehavior = false;
            this.lstCustomer.View = System.Windows.Forms.View.Details;
            this.lstCustomer.DoubleClick += new System.EventHandler(this.lstCustomer_DoubleClick);
            // 
            // colName
            // 
            this.colName.Text = "Nombre";
            this.colName.Width = 182;
            // 
            // colLastName
            // 
            this.colLastName.Text = "Apellido";
            this.colLastName.Width = 179;
            // 
            // colAddress
            // 
            this.colAddress.Text = "Direccion";
            this.colAddress.Width = 422;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(13, 93);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(94, 93);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Nuevo Cliente";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(175, 93);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Editar Cliente";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(256, 93);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Eliminar Cliente";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTotalCustomers
            // 
            this.lblTotalCustomers.AutoSize = true;
            this.lblTotalCustomers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalCustomers.Location = new System.Drawing.Point(12, 601);
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            this.lblTotalCustomers.Size = new System.Drawing.Size(0, 13);
            this.lblTotalCustomers.TabIndex = 5;
            // 
            // formGestionDeC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 626);
            this.Controls.Add(this.lblTotalCustomers);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lstCustomer);
            this.Name = "formGestionDeC";
            this.Text = "Gestion  de Clientes";
            this.Activated += new System.EventHandler(this.formGestionDeC_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstCustomer;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colLastName;
        private System.Windows.Forms.ColumnHeader colAddress;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTotalCustomers;
    }
}

